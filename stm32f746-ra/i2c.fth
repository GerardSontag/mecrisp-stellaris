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

\ i2c driver
\ file i2c.fth
\ ********** history ********************
\ 2016oct17jjo continue init, addresses
\ 2016sep5jjo initial version, add docs
\
\ C:\Users\jeanjo\Downloads\stm\DM00124865 RM0385 STM32F75xxx and STM32F74xxx advanced ARM®-based 32-bit MCUs.pdf
\ http://www.st.com/resource/en/reference_manual/dm00124865.pdf
\ C:\Users\jeanjo\Downloads\stm\DM00166116 STM32F746NG datasheet.pdf
\ http://www.st.com/resource/en/datasheet/stm32f745ie.pdf
\ require utils.fth
\ require gpio.fth
\ require rcc.fth

\ ********** i2c pin definitions ********
\ I2C_SDA (PB9)  package pin (D14) 
\ I2C_SCL (PB8)  package pin (D14) I2C1_SCL

\ PH7 - LCD_SCL / AUDIO_SCL / I2C3_SCL
\ PH8 - LCD_SDA / AUDIO_SDA / I2C3_SDA

\ ********** i2c address calc ***********
: i2c-n>a ( n -- a )                     \ calculate i2c base addres from number
   #7 and $14 + #10 lshift               \ nr 1..4
   $40000000 or 1-foldable ;
: i2c-a>n ( a -- n )                     \ i2c-addr -> i2c nr
   #10 rshift #5 - 7 and 1-foldable ;

\ ********** i2c DCKCFGR2 ***************
decimal
: i2c-clk-m ( n -- m )                   \ calculate i2c clock mask from i2c# 
   2 * #14 + 3 swap lshift 1-foldable ;  \ DCKCFGR2 register

\ ********** i2c driver interface var ***
3 i2c-n>a variable i2c_base              \ i2c base address of port

\ ********** i2c base address words *****
: i2c_base@ ( -- a ) i2c_base @ ;        \ fetch i2c base address
: i2c# ( -- n ) i2c_base@ i2c-a>n ;      \ get current i2c port number

\ ********** i2c timings ****************
   1   #28 lshift                        \ PRESC
   4   #20 lshift or                     \ SCLDEL
   $2  #16 lshift or                     \ SDADEL
   $F   #8 lshift or                     \ SCLH
   $13            or                     \ SCLL
   constant i2c-8MHz-100K                \ input clock 8 MHz - i2c clock 100 kHz

   $3  #28 lshift                        \ PRESC
   $4  #20 lshift or                     \ SCLDEL
   $2  #16 lshift or                     \ SDADEL
   $F   #8 lshift or                     \ SCLH
   $13            or                     \ SCLL
   constant i2c-16MHz-100K               \ input clock 16 MHz - i2c clock 100 kHz

\ ********** i2c global states **********
: i2c_cr1! ( n -- ) i2c_base@ ! ;        \ store value to i2c_cr1 
: i2c_cr2 ( -- a ) i2c_base@ 4 + ;       \ address of i2c_cr2 register

\ ********** i2c interface functions ****
: i2c-rcc-on ( -- )                     \ turn on i2c clock
   i2c# 20 + 1 swap lshift
   RCC_APB1ENR bis ! ;
: i2c-in-clk ( n -- )                   \ set timing clock source
    i2c# i2c-clk-m DCKCFGR2 bits! ;   
: i2c-init ( -- )                       \ initialize i2c interface
   0 over i2c_cr1! wait-3-clk           \ reset i2c instance wait 3 APB clk
   1 swap i2c_cr1! ;                    \ enable i2c
: i2c-stop ( p -- ) ;                   \ stop generation
   1 14 lshift i2c_base@ 4 + bis! ;
: i2c-gpio-ena ( p -- ) ;
: i2c-int-ena ( p -- ) ;
: i2c-int-dis ( p -- ) ;
: i2c-int-handler ( -- )                \ this is called from interrupt
   ipsr case #47 of I2C1_EV endof       \ "/"
             #48 of I2C1_ER endof       \ "0"
             #49 of I2C2_EV endof       \ "1"
             #50 of I2C2_ER endof       \ "2"
             #88 of I2C3_EV endof       \ "X"
             #89 of I2C3_ER endof       \ "Y"
            #111 of I2C4_EV endof       \ "o"
            #112 of I2C4_ER endof       \ "p"
            8    swap       endcase ;

: i>c2   case #47 of 0 endof
             #48 of 1 endof
             #49 of 2 endof 
             #50 of 3 endof
             #88 of 4 endof
             #89 of 5 endof
            #111 of 6 endof
            #112 of 7 endof
                    8 swap  endcase ;
            
: i>c #47 - dup #3 rshift dup 0<> -2 and + + 7 and ; 

: test-i>c ( a -- )
   47 over execute 0 = swap
   48 over execute 1 = swap
   49 over execute 2 = swap
   50 over execute 3 = swap
   88 over execute 4 = swap
   89 over execute 5 = swap
   111 over execute 6 = swap
   112 swap execute 7 =
   and and and and  and and and ;

 
: i2c-timing ( -- )                      \ 16MHz i2c clock 100 khz
   2 i2c-port @ i2c-clk-m                \ generate i2c clock selection mask
   RCC_DCKCFGR2 bits!                    \ set hsi cock source
   i2c-16MHz-100K i2c_base@ $10 + ! ;

: bis/bic! ( m a f -- )                  \ depending of flag set or reset bits 
   if bis! else bic ! then ;

: i2c-state-init ( -- ) ;
: i2c-start-read ( a -- ) ;
: i2c-adr-mode-10bit ( adrMode -- )
   0<> 1 #11 lshift i2c-cr2 bits! ;
: i2c-txis? ( -- f )
   #2 i2c_base@ $18 + bit@ ;
: i2c-start ( -- )                       \ start i2c master transfer
   1 #13 lshift i2c_cr2 bis! ;
: i2c-tx-adr ( a -- )                    \ set i2c target address
   $3ff i2c_cr2 bits! ;
: i2c-write ( numbytes slaveadr -- )     \ start tx 7 bit adr
   $FF and                               \ num bytes and slave address
   swap $FF and #16 lshift or            \
   1 #25 lshift or                       \ enable auto end
   i2c_cr2 !
   i2c-start ;                           \ start
: i2c-receive ( numbytes slaveadr -- )   \ start i2c receiving

