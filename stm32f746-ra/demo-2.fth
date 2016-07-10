: hsi-on ;
: clock-system-hsi  ( -- )               \ set system clock to hsi
   hsi-on hsi-wait-stable 
: clock-192-mhz ( -- )
   clock-system-hsi  pll-off pll-source-hse pll-192-mhz pll-on
   flash-ws-192-mhz cache-activate clock-system-pll uart-baud-update ;
: clock-init clock-192-mhz ;         \ let the system run on 200 MHz

0 variable cursor-y
0 variable cursor-x
: edit-key-up ( -- )
   cursor-y 0= if scroll-up 
   else -1 cursor-y +! ;
: edit-key-left ( -- )
   cursor-x 0= if scroll-left 
   else -1 cursor-x +! ;
: edit ( -- )                            \ window editor
   edit-key-up
   edit-key-down
   edit-key-left
   edit-key-right
   edit-key-enter
   ; 
: demo ( -- )
   clock-init sdram-init qspi-init
   display-init sd-card-init demo-start ;