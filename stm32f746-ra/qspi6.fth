\ Copyright Jean Jonethal 2017
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

\ file qspi6.fth
\ author jean jonethal
\ qspi flash part N25Q128A13EF840E
\ qspi flash datasheet "C:\Users\jeanjo\Downloads\stm\n25q_128mb_3v_65nm.pdf"
\ https://www.micron.com/~/media/documents/products/data-sheet/nor-flash/serial-nor/n25q/n25q_128mb_3v_65nm.pdf
\ stm32f746 user manual "C:\Users\jeanjo\Downloads\stm\DM00124865 RM0385 STM32F75xxx and STM32F74xxx advanced ARM®-based 32-bit MCUs.pdf"

require util.fth
require gpio.fth

\ QSPI_NCS - PB6  - AF10                 \ chip select
\ QSPI_CLK - PB2  - AF9                  \ clock 
\ QSPI_D0  - PD11 - AF9                  \ data 0
\ QSPI_D1  - PD12 - AF9                  \ data 1
\ QSPI_D2  - PE2  - AF9                  \ data 2
\ QSPI_D3  - PD13 - AF9                  \ data 3


1 gpio   6 + constant QS  \ QSPI_NCS
1 gpio   2 + constant QC  \ QSPI_CLK
3 gpio #11 + constant qd0 \ QSPI_D0
3 gpio #12 + constant qd1 \ QSPI_D1
3 gpio #13 + constant qd3 \ QSPI_D3
4 gpio   2 + constant qd2 \ QSPI_D2

: q1<>  ( -- ) qd0  gpio-output qd1  gpio-input ;  \ single mode data io
: q2>   ( -- ) qd0  gpio-output qd1  gpio-output ; \ dual output
: q2<   ( -- ) qd0  gpio-input  qd1  gpio-input ;  \ dual input
: q4>   ( -- ) qd3  gpio-output qd2  gpio-output q2> ; \ quad out
: q4<   ( -- ) qd3  gpio-input  qd3  gpio-input q2< ;  \ quad in
: qs> qs gpio-output ;
: qc> qc gpio-output ;

: pin! ( f pin -- )                       \ output flag to pin
  tuck swap if bsrr-on else bsrr-off then swap gpio-bsrr ! ;
\   swap 0= #16 and over bsrr-on lshift swap gpio-bsrr ! ;
: pin!<< ( n pin -- n )                   \ output bit 31 to pin and << value
   over 0< swap pin! 2* ;
: qd0! ( n -- n ) qd0 pin!<< ;            \ set pin QD0
: qd1! ( n -- n ) qd1 pin!<< ;            \ set pin QD1
: qd2! ( n -- n ) qd2 pin!<< ;            \ set pin QD2
: qd3! ( n -- n ) qd3 pin!<< ;            \ set pin QD3
: qck! ( n -- n ) qc  pin! ;              \ set pin qc
: qen!  ( n -- n ) qs  pin! ;              \ set pin qs to b31
: qc0  ( -- ) qc bsrr-off qc gpio-bsrr ! ; \ set qc 0
: qc1  ( -- ) qc bsrr-on qc gpio-bsrr ! ;  \ set qc 1
: qs0  ( -- ) qs bsrr-off qs gpio-bsrr ! ; \ set qs 0
: qs1  ( -- ) qs bsrr-on qs gpio-bsrr ! ;  \ set qs 1

: pin@ ( pin -- b )                       \ get pin value
   dup  gpio-idr @ swap pin# rshift 1 and  ;
: pin@<< ( n pin -- n )                   \ shift in pin value
   pin@ swap 2* or ; 

: .pin ( pin -- ) pin@ . ;

: LA ( -- )
\  cr qs .pin space qc .pin space
\  qd0 .pin space qd1 .pin space qd2 .pin space qd3 .pin space
  ;
\ output bit shifting
: q1b1!  ( n -- n ) LA qc0 LA qd0! LA qc1 LA ;        \ single mode shifting out highest bit
: q1b2!  ( n -- n ) q1b1! q1b1! ;
: q1b4!  ( n -- n ) q1b2! q1b2! ;         \ single mode shifting out highest 4 bit s
: q1b8!  ( n -- n ) q1b4! q1b4! ;         \ single mode shifting out highest 8 bit s
: q2b2!  ( n -- n ) LA qc0 LA qd1! qd0! LA qc1 LA ;   \ dual mode shifting 2 highest bits
: q2b4!  ( n -- n ) q2b2! q2b2! ;         \ dual mode shifting 4 highest bits
: q2b8!  ( n -- n ) q2b4! q2b4! ;         \ dual mode shifting 8 highest bits
: q4b4!  ( n -- n )                       \ dual mode shifting 4 highest bits
   LA qc0 LA qd3! qd2! qd1! qd0! LA qc1 LA ;
: q4b8!  ( n -- n ) q4b4! q4b4! ;         \ quad mode shifting 8 highest bits
: qd0@ ( n -- n ) qd0 gpio-idr @ qd0 pin# rshift 1 and swap 2* or ;
: qd1@ ( n -- n ) qd1 gpio-idr @ qd1 pin# rshift 1 and swap 2* or ;
: qd2@ ( n -- n ) qd2 gpio-idr @ qd2 pin# rshift 1 and swap 2* or ;
: qd3@ ( n -- n ) qd3 gpio-idr @ qd3 pin# rshift 1 and swap 2* or ;
\ input bit shifting
: q1b1@ ( n -- n ) LA qc0 LA qc1 LA qd1@ LA ;         \ single shifting in 1 bit from spi
: q1b2@ ( n -- n ) q1b1@ q1b1@ ;          \ single shifting in 2 bit from spi
: q1b4@ ( n -- n ) q1b2@ q1b2@ ;          \ single shifting in 4 bit from spi
: q1b8@ ( n -- n ) q1b4@ q1b4@ ;          \ single shifting in 8 bit from spi
: q2b2@ ( n -- n ) LA qc0 LA qc1 LA qd1@ qd0@ LA ;    \ dual shifting in 2 bit from spi
: q2b4@ ( n -- n ) q2b2@ q2b2@ ;          \ dual shifting in 4 bit from spi
: q2b8@ ( n -- n ) q2b4@ q2b4@ ;          \ dual shifting in 8 bit from spi
: q4b4@ ( n -- n ) LA qc0 LA qc1 LA                \ quad shifting in 4 bit from spi
   qd3@ qd2@ qd1@ qd0@ LA ;
: q4b8@ ( n -- n ) q4b4@ q4b4@ ;          \ quad shifting in 8 bit from spi

' q1b8@ variable qb8@-hook
' q1b8! variable qb8!-hook
' q1<>  variable q>-hook
' q1<>  variable q<-hook

: q1 ['] q1b8@ qb8@-hook !
     ['] q1b8! qb8!-hook !
     ['] q1<>  q>-hook !
     ['] q1<>  q<-hook ! ;
: q2 ['] q2b8@ qb8@-hook !
     ['] q2b8! qb8!-hook !
     ['] q2>  q>-hook !
     ['] q2<  q<-hook ! ;
: q4 ['] q4b8@ qb8@-hook !
     ['] q4b8! qb8!-hook !
     ['] q4>  q>-hook !
     ['] q4<  q<-hook ! ;

: qb8! qb8!-hook @ execute ;
: qb8@ qb8@-hook @ execute ;
: q< q<-hook @ execute ;
: q> q>-hook @ execute ;
: qc! ( n -- )  #24 lshift qb8! drop ;
: qc@ ( -- n ) 0 qb8@ ;

: qspi-gpio-clk-on ( -- )                 \ turn on gpio clock
   1 qs gpio-clk! 1 qd0 gpio-clk! 1 qd2 gpio-clk! ;
: qspi-gpio-init-sw ( -- )                \ qspi bitbang
   qspi-gpio-clk-on qs  1 gpio-mode! qc  1 gpio-mode! 
   qs gpio-output qc gpio-output qd0 1 gpio-mode!
   qd1 1 gpio-mode! qd2 1 gpio-mode! qd3 1 gpio-mode! -1 qd2! qd3! drop ;
: q-init ( -- )                           \ initialize qspi 
   qspi-gpio-init-sw qs> qc>
   q4> -1 qd0! qd1! qd2! qd3! drop qc1 qs1 ;
: q-start ( -- ) q> qs0 ;                 \ start qspi transfer
: q-end   ( -- ) qc1 qs1 ;                \ end qspi transfer

\ ********** flash driver ****************
$50 constant Q_CLEAR_FLAG_REG
$70 constant Q_READ_FLAG_REG
$03 constant Q_READ
$0B constant Q_READ_FAST
$9E constant Q_READ_ID
$B5 constant Q_READ_NV_CFG_REG
$B1 constant Q_WRITE_NV_CFG_REG
$05 constant Q_READ_STAT_REG
$85 constant Q_READ_VOL_CFG_REG
$81 constant Q_WRITE_VOL_CFG_REG
$66 constant Q_RESET_ENABLE
$99 constant Q_RESET_MEM
$04 constant Q_WRITE_DIS
$06 constant Q_WRITE_ENA
$20 constant Q_ERASE_SUB_SEC
$D8 constant Q_ERASE_SEC
$C7 constant Q_ERASE_BULK
$7A constant Q_WRITE_RESUME
$75 constant Q_WRITE_SUSPEND
$02 constant Q_PAGE_PROG

: read-id ( a -- )                        \ read id to buffer 20 bytes
   qs0 q> Q_READ_ID qc! q<
   dup 20 + swap do 0 qb8@ i c! loop qc1 qs1 ;
: .id  ( -- )                             \ print id
   q> LA qs0 LA Q_READ_ID qc! q< .s
   20 0 do 0 qb8@ x.2 space loop LA qc1 LA qs1 LA cr ;

: q-read ( l ad qadr -- )
   q> qs0 Q_READ qc! 8 lshift qb8! qb8! qb8! drop q< 
   tuck + swap do qc@ i c! loop qc1 qs1 ;

: q-adr! ( n -- )                         \ write 24 bit address
   8 lshift qb8! qb8! qb8! drop ; 

: c. ( n -- )                             \ emit printable character or .
   dup #32 > and dup 127 < and dup 0= [CHAR] . and or emit ;
: q-dump-line ( l a -- )
   cr x.8 space
   dup >r 0 
   do qc@ dup x.2 space loop r@ #16 swap - 3 * spaces
   r@ 1- 0 swap 
   do i pick c. -1 +loop r> 0 do drop loop ;   

$80 constant Q_STAT_WRITE_DISABLE
$40 constant Q_STAT_BLOCK_PROT_B3
$20 constant Q_STAT_BLOCK_PROT_BOTTOM
$10 constant Q_STAT_BLOCK_PROT_B2
$08 constant Q_STAT_BLOCK_PROT_B1
$04 constant Q_STAT_BLOCK_PROT_B0
$02 constant Q_STAT_WRITE_ENABLE
$01 constant Q_STAT_WRITE_IN_PROGRESS

: q-read-stat ( -- n )
   q-start Q_READ_STAT_REG qc! q< qc@ q-end ; 
: q-dump ( l qadr -- )                    \ dump qspi contents
   dup
   q-start Q_READ qc! q-adr! q<
   tuck + swap do #16 i q-dump-line #16 +loop  
   q-end ;
: q-write-ena ( -- )
   q-start Q_WRITE_ENA qc! q-end ;
: q-write-dis ( -- )
   q-start Q_WRITE_DIS qc! q-end ;
: q-write ( l a qa -- )
   q-write-ena
   q-start Q_PAGE_PROG qc! q-adr!
   tuck + swap do i c@ qc! loop q-end ;
: q-verify  ( l a qa -- err )             \ verify qspi -- count errors
   q-start Q_READ qc! q-adr! q<
   tuck + swap 0 -rot do qc@ i @ = negate + loop q-end ; 
: q-erase-subsector ( qa -- )
   q-write-ena 
   q-start Q_ERASE_SUB_SEC qc! q-adr! q-end ;
: test.id ( -- ) q-init .id ;