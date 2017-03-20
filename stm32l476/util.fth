\ Copyright Jean Jonethal 2015, 2016
\
\ This program is free software: you can redistribute it and/or modify
\ it under the terms of the GNU General Public License as published by
\ the Free Software Foundation, either version 3 of the License, or
\ (at your option) any later version.
\
\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program.  If not, see <http://www.gnu.org/licenses/>.

\ file        : util.fth
\ author      : jean jonethal
\ description : provides some general useful utilities
\
\ ********** history *********************
\ 2016-12-14jjo add ftab and enum, some reformating
\ 2016-02-09jjo add history to this file

: cnt0   ( m -- b )                       \ count trailing zeros with hw support
   dup negate and 1-
   clz negate #32 + 1-foldable ;
: bits@  ( m adr -- b )                   \ get bitfield at masked position e.g $1234 v ! $f0 v bits@ $3 = . (-1)
   @ over and swap cnt0 rshift ;          \ and shift it down 
: bits!  ( n m adr -- )                   \ set bitfield value n to value at masked position
   >R dup >R cnt0 lshift                  \ shift value n to proper position
   R@ and                                 \ mask out unrelated bits
   R> not R@ @ and                        \ invert bitmask and maskout new bits in current value
   or r> ! ;                              \ apply value and store back
                                          \ example : set RCC_PLLCFGR.PLLN to #400
                                          \   $1FF #6 lshift constant PLLN
                                          \   $40023804      constant RCC_PLLCFGR
                                          \   #400 PLLN RCC_PLLCFGR bits!
: bits2!  ( n m adr -- )                  \ set bitfield value n to value at masked position
   >R dup >R cnt0 lshift                  \ shift value n to proper position
   R@ and                                 \ mask out unrelated bits
   R> R@ @ swap bic                       \ invert bitmask and maskout new bits in current value
   or r> ! ;                              \ apply value and store back
                                          \ example : set RCC_PLLCFGR.PLLN to #400
                                          \   $1FF #6 lshift constant PLLN
                                          \   $40023804      constant RCC_PLLCFGR
                                          \   #400 PLLN RCC_PLLCFGR bits!

 
: u.8 ( n -- )                            \ unsigned output 8 digits
   0 <# # # # # # # # # #> type ;
: x.8 ( n -- )                            \ hex output 8 digits
   base @ hex swap u.8 base ! ;
: x.2 ( n -- )                            \ hex output 2 digits
   base @ hex swap 0 <# # # #> type base ! ;
: cfill ( c n a -- )                      \ fill memory block at address a length n with char c
   tuck + swap do dup i c! loop drop ;
: d2**  ( n -- d )                        \ return 2^n 
   dup #31 > if
     #32 - 1 swap lshift 0 swap
   else
     1 swap lshift 0
   then 1-foldable ;
: dxor ( d d -- d )                       \ double xor
   rot xor -rot xor swap 4-foldable ;
: $. ( -- )                               \ print a dollar sign 
   [char] $ emit ;
: rbit,  ( rm rd -- )                     \ compile reverse bits instruction rm:operand reg rd:destination reg
   over $f and                            \ from ARMv7 achitecture A7.7.110 RBIT
   %1111101010010000 or h,                \ opcode low word
   $f and 8 lshift swap $f and or
   %1111000010100000 or h, ;              \ opcode high word
: reverse ( w -- w )                      \ reverse bits 31..0:b31..b0 > b0..b31
   [ 6 6 rbit, ] 1-foldable inline ;      \ reverse tos in R6
: bit-reverse-5..0 ( w -- w )             \ reverse bits 5..0
   reverse #26 rshift 1-foldable inline ;
: set-mask! ( v m a -- )                  \ set new value at masked position eg $A0 $f0 @a:$1234 setmask -- @a:12A4   
   tuck @ swap bic rot or swap ! ;        \ v must be clean
: 2^ ( n -- n )                           \ 2^n
   1 swap lshift 1-foldable ;
: ftab: ( -- )  ( name )                  \ create a function table
   <builds does> swap 2 lshift + @ execute ;
: enum ( n -- n + 1 ) ( "name" )          \ enumeration constant
   dup constant 1+ ;
: enum; ( n -- ) drop ;                   \ finish enumeration

\ Cornerstone for 2 kb Flash pages

: cornerstone ( Name ) ( -- )
  <builds begin here $7FF and while 0 h, repeat
  does>   begin dup  $7FF and while 2+   repeat 
          eraseflashfrom
;
