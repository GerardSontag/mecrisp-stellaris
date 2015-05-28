\  STM32F072x ARM CMSIS-SVD register file for Mecrisp-Stellaris Forth by Matthias Koch
	\  x = 0 or 1 below in the Register Field bit positions 
	 

    $40023000 constant CRC  
	 CRC $0 + constant CRC_DR	\ read-write		\  : RESET_CRC_DR $FFFFFFFF 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift CRC_DR        \ CRC_DR	Bit Offset:0	Bit Width:32
        
        CRC $4 + constant CRC_IDR	\ read-write		\  : RESET_CRC_IDR $00000000 
        \ %xxxxxxxx  0 lshift CRC_IDR        \ CRC_IDR	Bit Offset:0	Bit Width:8
        
        CRC $8 + constant CRC_CR	\ read-write		\  : RESET_CRC_CR $00000000 
        \ %x  0 lshift CRC_CR        \ CRC_RESET	Bit Offset:0	Bit Width:1
        \ %xx  5 lshift CRC_CR        \ CRC_REV_IN	Bit Offset:5	Bit Width:2
        \ %x  7 lshift CRC_CR        \ CRC_REV_OUT	Bit Offset:7	Bit Width:1
        
        CRC $C + constant CRC_INIT	\ read-write		\  : RESET_CRC_INIT $FFFFFFFF 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift CRC_INIT        \ CRC_INIT	Bit Offset:0	Bit Width:32
        
         
	
     $48001400 constant GPIOF  
	 GPIOF $0 + constant GPIOF_MODER	\ read-write		\  : RESET_GPIOF_MODER $00000000 
        \ %xx  30 lshift GPIOF_MODER        \ GPIOF_MODER15	Bit Offset:30	Bit Width:2
        \ %xx  28 lshift GPIOF_MODER        \ GPIOF_MODER14	Bit Offset:28	Bit Width:2
        \ %xx  26 lshift GPIOF_MODER        \ GPIOF_MODER13	Bit Offset:26	Bit Width:2
        \ %xx  24 lshift GPIOF_MODER        \ GPIOF_MODER12	Bit Offset:24	Bit Width:2
        \ %xx  22 lshift GPIOF_MODER        \ GPIOF_MODER11	Bit Offset:22	Bit Width:2
        \ %xx  20 lshift GPIOF_MODER        \ GPIOF_MODER10	Bit Offset:20	Bit Width:2
        \ %xx  18 lshift GPIOF_MODER        \ GPIOF_MODER9	Bit Offset:18	Bit Width:2
        \ %xx  16 lshift GPIOF_MODER        \ GPIOF_MODER8	Bit Offset:16	Bit Width:2
        \ %xx  14 lshift GPIOF_MODER        \ GPIOF_MODER7	Bit Offset:14	Bit Width:2
        \ %xx  12 lshift GPIOF_MODER        \ GPIOF_MODER6	Bit Offset:12	Bit Width:2
        \ %xx  10 lshift GPIOF_MODER        \ GPIOF_MODER5	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift GPIOF_MODER        \ GPIOF_MODER4	Bit Offset:8	Bit Width:2
        \ %xx  6 lshift GPIOF_MODER        \ GPIOF_MODER3	Bit Offset:6	Bit Width:2
        \ %xx  4 lshift GPIOF_MODER        \ GPIOF_MODER2	Bit Offset:4	Bit Width:2
        \ %xx  2 lshift GPIOF_MODER        \ GPIOF_MODER1	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift GPIOF_MODER        \ GPIOF_MODER0	Bit Offset:0	Bit Width:2
        
        GPIOF $4 + constant GPIOF_OTYPER	\ read-write		\  : RESET_GPIOF_OTYPER $00000000 
        \ %x  15 lshift GPIOF_OTYPER        \ GPIOF_OT15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOF_OTYPER        \ GPIOF_OT14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOF_OTYPER        \ GPIOF_OT13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOF_OTYPER        \ GPIOF_OT12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOF_OTYPER        \ GPIOF_OT11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOF_OTYPER        \ GPIOF_OT10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOF_OTYPER        \ GPIOF_OT9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOF_OTYPER        \ GPIOF_OT8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOF_OTYPER        \ GPIOF_OT7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOF_OTYPER        \ GPIOF_OT6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOF_OTYPER        \ GPIOF_OT5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOF_OTYPER        \ GPIOF_OT4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOF_OTYPER        \ GPIOF_OT3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOF_OTYPER        \ GPIOF_OT2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOF_OTYPER        \ GPIOF_OT1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOF_OTYPER        \ GPIOF_OT0	Bit Offset:0	Bit Width:1
        
        GPIOF $8 + constant GPIOF_OSPEEDR	\ read-write		\  : RESET_GPIOF_OSPEEDR $00000000 
        \ %xx  30 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR15	Bit Offset:30	Bit Width:2
        \ %xx  28 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR14	Bit Offset:28	Bit Width:2
        \ %xx  26 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR13	Bit Offset:26	Bit Width:2
        \ %xx  24 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR12	Bit Offset:24	Bit Width:2
        \ %xx  22 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR11	Bit Offset:22	Bit Width:2
        \ %xx  20 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR10	Bit Offset:20	Bit Width:2
        \ %xx  18 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR9	Bit Offset:18	Bit Width:2
        \ %xx  16 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR8	Bit Offset:16	Bit Width:2
        \ %xx  14 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR7	Bit Offset:14	Bit Width:2
        \ %xx  12 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR6	Bit Offset:12	Bit Width:2
        \ %xx  10 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR5	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR4	Bit Offset:8	Bit Width:2
        \ %xx  6 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR3	Bit Offset:6	Bit Width:2
        \ %xx  4 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR2	Bit Offset:4	Bit Width:2
        \ %xx  2 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR1	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift GPIOF_OSPEEDR        \ GPIOF_OSPEEDR0	Bit Offset:0	Bit Width:2
        
        GPIOF $C + constant GPIOF_PUPDR	\ read-write		\  : RESET_GPIOF_PUPDR $00000000 
        \ %xx  30 lshift GPIOF_PUPDR        \ GPIOF_PUPDR15	Bit Offset:30	Bit Width:2
        \ %xx  28 lshift GPIOF_PUPDR        \ GPIOF_PUPDR14	Bit Offset:28	Bit Width:2
        \ %xx  26 lshift GPIOF_PUPDR        \ GPIOF_PUPDR13	Bit Offset:26	Bit Width:2
        \ %xx  24 lshift GPIOF_PUPDR        \ GPIOF_PUPDR12	Bit Offset:24	Bit Width:2
        \ %xx  22 lshift GPIOF_PUPDR        \ GPIOF_PUPDR11	Bit Offset:22	Bit Width:2
        \ %xx  20 lshift GPIOF_PUPDR        \ GPIOF_PUPDR10	Bit Offset:20	Bit Width:2
        \ %xx  18 lshift GPIOF_PUPDR        \ GPIOF_PUPDR9	Bit Offset:18	Bit Width:2
        \ %xx  16 lshift GPIOF_PUPDR        \ GPIOF_PUPDR8	Bit Offset:16	Bit Width:2
        \ %xx  14 lshift GPIOF_PUPDR        \ GPIOF_PUPDR7	Bit Offset:14	Bit Width:2
        \ %xx  12 lshift GPIOF_PUPDR        \ GPIOF_PUPDR6	Bit Offset:12	Bit Width:2
        \ %xx  10 lshift GPIOF_PUPDR        \ GPIOF_PUPDR5	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift GPIOF_PUPDR        \ GPIOF_PUPDR4	Bit Offset:8	Bit Width:2
        \ %xx  6 lshift GPIOF_PUPDR        \ GPIOF_PUPDR3	Bit Offset:6	Bit Width:2
        \ %xx  4 lshift GPIOF_PUPDR        \ GPIOF_PUPDR2	Bit Offset:4	Bit Width:2
        \ %xx  2 lshift GPIOF_PUPDR        \ GPIOF_PUPDR1	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift GPIOF_PUPDR        \ GPIOF_PUPDR0	Bit Offset:0	Bit Width:2
        
        GPIOF $10 + constant GPIOF_IDR	\ read-only		\  : RESET_GPIOF_IDR $00000000 
        \ %x  15 lshift GPIOF_IDR        \ GPIOF_IDR15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOF_IDR        \ GPIOF_IDR14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOF_IDR        \ GPIOF_IDR13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOF_IDR        \ GPIOF_IDR12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOF_IDR        \ GPIOF_IDR11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOF_IDR        \ GPIOF_IDR10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOF_IDR        \ GPIOF_IDR9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOF_IDR        \ GPIOF_IDR8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOF_IDR        \ GPIOF_IDR7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOF_IDR        \ GPIOF_IDR6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOF_IDR        \ GPIOF_IDR5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOF_IDR        \ GPIOF_IDR4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOF_IDR        \ GPIOF_IDR3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOF_IDR        \ GPIOF_IDR2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOF_IDR        \ GPIOF_IDR1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOF_IDR        \ GPIOF_IDR0	Bit Offset:0	Bit Width:1
        
        GPIOF $14 + constant GPIOF_ODR	\ read-write		\  : RESET_GPIOF_ODR $00000000 
        \ %x  15 lshift GPIOF_ODR        \ GPIOF_ODR15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOF_ODR        \ GPIOF_ODR14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOF_ODR        \ GPIOF_ODR13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOF_ODR        \ GPIOF_ODR12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOF_ODR        \ GPIOF_ODR11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOF_ODR        \ GPIOF_ODR10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOF_ODR        \ GPIOF_ODR9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOF_ODR        \ GPIOF_ODR8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOF_ODR        \ GPIOF_ODR7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOF_ODR        \ GPIOF_ODR6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOF_ODR        \ GPIOF_ODR5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOF_ODR        \ GPIOF_ODR4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOF_ODR        \ GPIOF_ODR3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOF_ODR        \ GPIOF_ODR2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOF_ODR        \ GPIOF_ODR1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOF_ODR        \ GPIOF_ODR0	Bit Offset:0	Bit Width:1
        
        GPIOF $18 + constant GPIOF_BSRR	\ write-only		\  : RESET_GPIOF_BSRR $00000000 
        \ %x  31 lshift GPIOF_BSRR        \ GPIOF_BR15	Bit Offset:31	Bit Width:1
        \ %x  30 lshift GPIOF_BSRR        \ GPIOF_BR14	Bit Offset:30	Bit Width:1
        \ %x  29 lshift GPIOF_BSRR        \ GPIOF_BR13	Bit Offset:29	Bit Width:1
        \ %x  28 lshift GPIOF_BSRR        \ GPIOF_BR12	Bit Offset:28	Bit Width:1
        \ %x  27 lshift GPIOF_BSRR        \ GPIOF_BR11	Bit Offset:27	Bit Width:1
        \ %x  26 lshift GPIOF_BSRR        \ GPIOF_BR10	Bit Offset:26	Bit Width:1
        \ %x  25 lshift GPIOF_BSRR        \ GPIOF_BR9	Bit Offset:25	Bit Width:1
        \ %x  24 lshift GPIOF_BSRR        \ GPIOF_BR8	Bit Offset:24	Bit Width:1
        \ %x  23 lshift GPIOF_BSRR        \ GPIOF_BR7	Bit Offset:23	Bit Width:1
        \ %x  22 lshift GPIOF_BSRR        \ GPIOF_BR6	Bit Offset:22	Bit Width:1
        \ %x  21 lshift GPIOF_BSRR        \ GPIOF_BR5	Bit Offset:21	Bit Width:1
        \ %x  20 lshift GPIOF_BSRR        \ GPIOF_BR4	Bit Offset:20	Bit Width:1
        \ %x  19 lshift GPIOF_BSRR        \ GPIOF_BR3	Bit Offset:19	Bit Width:1
        \ %x  18 lshift GPIOF_BSRR        \ GPIOF_BR2	Bit Offset:18	Bit Width:1
        \ %x  17 lshift GPIOF_BSRR        \ GPIOF_BR1	Bit Offset:17	Bit Width:1
        \ %x  16 lshift GPIOF_BSRR        \ GPIOF_BR0	Bit Offset:16	Bit Width:1
        \ %x  15 lshift GPIOF_BSRR        \ GPIOF_BS15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOF_BSRR        \ GPIOF_BS14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOF_BSRR        \ GPIOF_BS13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOF_BSRR        \ GPIOF_BS12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOF_BSRR        \ GPIOF_BS11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOF_BSRR        \ GPIOF_BS10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOF_BSRR        \ GPIOF_BS9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOF_BSRR        \ GPIOF_BS8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOF_BSRR        \ GPIOF_BS7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOF_BSRR        \ GPIOF_BS6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOF_BSRR        \ GPIOF_BS5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOF_BSRR        \ GPIOF_BS4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOF_BSRR        \ GPIOF_BS3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOF_BSRR        \ GPIOF_BS2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOF_BSRR        \ GPIOF_BS1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOF_BSRR        \ GPIOF_BS0	Bit Offset:0	Bit Width:1
        
        GPIOF $1C + constant GPIOF_LCKR	\ read-write		\  : RESET_GPIOF_LCKR $00000000 
        \ %x  16 lshift GPIOF_LCKR        \ GPIOF_LCKK	Bit Offset:16	Bit Width:1
        \ %x  15 lshift GPIOF_LCKR        \ GPIOF_LCK15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOF_LCKR        \ GPIOF_LCK14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOF_LCKR        \ GPIOF_LCK13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOF_LCKR        \ GPIOF_LCK12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOF_LCKR        \ GPIOF_LCK11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOF_LCKR        \ GPIOF_LCK10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOF_LCKR        \ GPIOF_LCK9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOF_LCKR        \ GPIOF_LCK8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOF_LCKR        \ GPIOF_LCK7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOF_LCKR        \ GPIOF_LCK6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOF_LCKR        \ GPIOF_LCK5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOF_LCKR        \ GPIOF_LCK4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOF_LCKR        \ GPIOF_LCK3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOF_LCKR        \ GPIOF_LCK2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOF_LCKR        \ GPIOF_LCK1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOF_LCKR        \ GPIOF_LCK0	Bit Offset:0	Bit Width:1
        
        GPIOF $20 + constant GPIOF_AFRL	\ read-write		\  : RESET_GPIOF_AFRL $00000000 
        \ %xxxx  28 lshift GPIOF_AFRL        \ GPIOF_AFRL7	Bit Offset:28	Bit Width:4
        \ %xxxx  24 lshift GPIOF_AFRL        \ GPIOF_AFRL6	Bit Offset:24	Bit Width:4
        \ %xxxx  20 lshift GPIOF_AFRL        \ GPIOF_AFRL5	Bit Offset:20	Bit Width:4
        \ %xxxx  16 lshift GPIOF_AFRL        \ GPIOF_AFRL4	Bit Offset:16	Bit Width:4
        \ %xxxx  12 lshift GPIOF_AFRL        \ GPIOF_AFRL3	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift GPIOF_AFRL        \ GPIOF_AFRL2	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift GPIOF_AFRL        \ GPIOF_AFRL1	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift GPIOF_AFRL        \ GPIOF_AFRL0	Bit Offset:0	Bit Width:4
        
        GPIOF $24 + constant GPIOF_AFRH	\ read-write		\  : RESET_GPIOF_AFRH $00000000 
        \ %xxxx  28 lshift GPIOF_AFRH        \ GPIOF_AFRH15	Bit Offset:28	Bit Width:4
        \ %xxxx  24 lshift GPIOF_AFRH        \ GPIOF_AFRH14	Bit Offset:24	Bit Width:4
        \ %xxxx  20 lshift GPIOF_AFRH        \ GPIOF_AFRH13	Bit Offset:20	Bit Width:4
        \ %xxxx  16 lshift GPIOF_AFRH        \ GPIOF_AFRH12	Bit Offset:16	Bit Width:4
        \ %xxxx  12 lshift GPIOF_AFRH        \ GPIOF_AFRH11	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift GPIOF_AFRH        \ GPIOF_AFRH10	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift GPIOF_AFRH        \ GPIOF_AFRH9	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift GPIOF_AFRH        \ GPIOF_AFRH8	Bit Offset:0	Bit Width:4
        
        GPIOF $28 + constant GPIOF_BRR	\ write-only		\  : RESET_GPIOF_BRR $00000000 
        \ %x  0 lshift GPIOF_BRR        \ GPIOF_BR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift GPIOF_BRR        \ GPIOF_BR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift GPIOF_BRR        \ GPIOF_BR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift GPIOF_BRR        \ GPIOF_BR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift GPIOF_BRR        \ GPIOF_BR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift GPIOF_BRR        \ GPIOF_BR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift GPIOF_BRR        \ GPIOF_BR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift GPIOF_BRR        \ GPIOF_BR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift GPIOF_BRR        \ GPIOF_BR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift GPIOF_BRR        \ GPIOF_BR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift GPIOF_BRR        \ GPIOF_BR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift GPIOF_BRR        \ GPIOF_BR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift GPIOF_BRR        \ GPIOF_BR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift GPIOF_BRR        \ GPIOF_BR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift GPIOF_BRR        \ GPIOF_BR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift GPIOF_BRR        \ GPIOF_BR15	Bit Offset:15	Bit Width:1
        
         
	
     $48000C00 constant GPIOD  
	  
	
     $48000800 constant GPIOC  
	  
	
     $48000400 constant GPIOB  
	  
	
     $48001000 constant GPIOE  
	  
	
     $48000000 constant GPIOA  
	 GPIOA $0 + constant GPIOA_MODER	\ read-write		\  : RESET_GPIOA_MODER $28000000 
        \ %xx  30 lshift GPIOA_MODER        \ GPIOA_MODER15	Bit Offset:30	Bit Width:2
        \ %xx  28 lshift GPIOA_MODER        \ GPIOA_MODER14	Bit Offset:28	Bit Width:2
        \ %xx  26 lshift GPIOA_MODER        \ GPIOA_MODER13	Bit Offset:26	Bit Width:2
        \ %xx  24 lshift GPIOA_MODER        \ GPIOA_MODER12	Bit Offset:24	Bit Width:2
        \ %xx  22 lshift GPIOA_MODER        \ GPIOA_MODER11	Bit Offset:22	Bit Width:2
        \ %xx  20 lshift GPIOA_MODER        \ GPIOA_MODER10	Bit Offset:20	Bit Width:2
        \ %xx  18 lshift GPIOA_MODER        \ GPIOA_MODER9	Bit Offset:18	Bit Width:2
        \ %xx  16 lshift GPIOA_MODER        \ GPIOA_MODER8	Bit Offset:16	Bit Width:2
        \ %xx  14 lshift GPIOA_MODER        \ GPIOA_MODER7	Bit Offset:14	Bit Width:2
        \ %xx  12 lshift GPIOA_MODER        \ GPIOA_MODER6	Bit Offset:12	Bit Width:2
        \ %xx  10 lshift GPIOA_MODER        \ GPIOA_MODER5	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift GPIOA_MODER        \ GPIOA_MODER4	Bit Offset:8	Bit Width:2
        \ %xx  6 lshift GPIOA_MODER        \ GPIOA_MODER3	Bit Offset:6	Bit Width:2
        \ %xx  4 lshift GPIOA_MODER        \ GPIOA_MODER2	Bit Offset:4	Bit Width:2
        \ %xx  2 lshift GPIOA_MODER        \ GPIOA_MODER1	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift GPIOA_MODER        \ GPIOA_MODER0	Bit Offset:0	Bit Width:2
        
        GPIOA $4 + constant GPIOA_OTYPER	\ read-write		\  : RESET_GPIOA_OTYPER $00000000 
        \ %x  15 lshift GPIOA_OTYPER        \ GPIOA_OT15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOA_OTYPER        \ GPIOA_OT14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOA_OTYPER        \ GPIOA_OT13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOA_OTYPER        \ GPIOA_OT12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOA_OTYPER        \ GPIOA_OT11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOA_OTYPER        \ GPIOA_OT10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOA_OTYPER        \ GPIOA_OT9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOA_OTYPER        \ GPIOA_OT8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOA_OTYPER        \ GPIOA_OT7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOA_OTYPER        \ GPIOA_OT6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOA_OTYPER        \ GPIOA_OT5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOA_OTYPER        \ GPIOA_OT4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOA_OTYPER        \ GPIOA_OT3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOA_OTYPER        \ GPIOA_OT2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOA_OTYPER        \ GPIOA_OT1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOA_OTYPER        \ GPIOA_OT0	Bit Offset:0	Bit Width:1
        
        GPIOA $8 + constant GPIOA_OSPEEDR	\ read-write		\  : RESET_GPIOA_OSPEEDR $00000000 
        \ %xx  30 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR15	Bit Offset:30	Bit Width:2
        \ %xx  28 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR14	Bit Offset:28	Bit Width:2
        \ %xx  26 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR13	Bit Offset:26	Bit Width:2
        \ %xx  24 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR12	Bit Offset:24	Bit Width:2
        \ %xx  22 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR11	Bit Offset:22	Bit Width:2
        \ %xx  20 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR10	Bit Offset:20	Bit Width:2
        \ %xx  18 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR9	Bit Offset:18	Bit Width:2
        \ %xx  16 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR8	Bit Offset:16	Bit Width:2
        \ %xx  14 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR7	Bit Offset:14	Bit Width:2
        \ %xx  12 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR6	Bit Offset:12	Bit Width:2
        \ %xx  10 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR5	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR4	Bit Offset:8	Bit Width:2
        \ %xx  6 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR3	Bit Offset:6	Bit Width:2
        \ %xx  4 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR2	Bit Offset:4	Bit Width:2
        \ %xx  2 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR1	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift GPIOA_OSPEEDR        \ GPIOA_OSPEEDR0	Bit Offset:0	Bit Width:2
        
        GPIOA $C + constant GPIOA_PUPDR	\ read-write		\  : RESET_GPIOA_PUPDR $24000000 
        \ %xx  30 lshift GPIOA_PUPDR        \ GPIOA_PUPDR15	Bit Offset:30	Bit Width:2
        \ %xx  28 lshift GPIOA_PUPDR        \ GPIOA_PUPDR14	Bit Offset:28	Bit Width:2
        \ %xx  26 lshift GPIOA_PUPDR        \ GPIOA_PUPDR13	Bit Offset:26	Bit Width:2
        \ %xx  24 lshift GPIOA_PUPDR        \ GPIOA_PUPDR12	Bit Offset:24	Bit Width:2
        \ %xx  22 lshift GPIOA_PUPDR        \ GPIOA_PUPDR11	Bit Offset:22	Bit Width:2
        \ %xx  20 lshift GPIOA_PUPDR        \ GPIOA_PUPDR10	Bit Offset:20	Bit Width:2
        \ %xx  18 lshift GPIOA_PUPDR        \ GPIOA_PUPDR9	Bit Offset:18	Bit Width:2
        \ %xx  16 lshift GPIOA_PUPDR        \ GPIOA_PUPDR8	Bit Offset:16	Bit Width:2
        \ %xx  14 lshift GPIOA_PUPDR        \ GPIOA_PUPDR7	Bit Offset:14	Bit Width:2
        \ %xx  12 lshift GPIOA_PUPDR        \ GPIOA_PUPDR6	Bit Offset:12	Bit Width:2
        \ %xx  10 lshift GPIOA_PUPDR        \ GPIOA_PUPDR5	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift GPIOA_PUPDR        \ GPIOA_PUPDR4	Bit Offset:8	Bit Width:2
        \ %xx  6 lshift GPIOA_PUPDR        \ GPIOA_PUPDR3	Bit Offset:6	Bit Width:2
        \ %xx  4 lshift GPIOA_PUPDR        \ GPIOA_PUPDR2	Bit Offset:4	Bit Width:2
        \ %xx  2 lshift GPIOA_PUPDR        \ GPIOA_PUPDR1	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift GPIOA_PUPDR        \ GPIOA_PUPDR0	Bit Offset:0	Bit Width:2
        
        GPIOA $10 + constant GPIOA_IDR	\ read-only		\  : RESET_GPIOA_IDR $00000000 
        \ %x  15 lshift GPIOA_IDR        \ GPIOA_IDR15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOA_IDR        \ GPIOA_IDR14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOA_IDR        \ GPIOA_IDR13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOA_IDR        \ GPIOA_IDR12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOA_IDR        \ GPIOA_IDR11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOA_IDR        \ GPIOA_IDR10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOA_IDR        \ GPIOA_IDR9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOA_IDR        \ GPIOA_IDR8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOA_IDR        \ GPIOA_IDR7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOA_IDR        \ GPIOA_IDR6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOA_IDR        \ GPIOA_IDR5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOA_IDR        \ GPIOA_IDR4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOA_IDR        \ GPIOA_IDR3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOA_IDR        \ GPIOA_IDR2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOA_IDR        \ GPIOA_IDR1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOA_IDR        \ GPIOA_IDR0	Bit Offset:0	Bit Width:1
        
        GPIOA $14 + constant GPIOA_ODR	\ read-write		\  : RESET_GPIOA_ODR $00000000 
        \ %x  15 lshift GPIOA_ODR        \ GPIOA_ODR15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOA_ODR        \ GPIOA_ODR14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOA_ODR        \ GPIOA_ODR13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOA_ODR        \ GPIOA_ODR12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOA_ODR        \ GPIOA_ODR11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOA_ODR        \ GPIOA_ODR10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOA_ODR        \ GPIOA_ODR9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOA_ODR        \ GPIOA_ODR8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOA_ODR        \ GPIOA_ODR7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOA_ODR        \ GPIOA_ODR6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOA_ODR        \ GPIOA_ODR5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOA_ODR        \ GPIOA_ODR4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOA_ODR        \ GPIOA_ODR3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOA_ODR        \ GPIOA_ODR2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOA_ODR        \ GPIOA_ODR1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOA_ODR        \ GPIOA_ODR0	Bit Offset:0	Bit Width:1
        
        GPIOA $18 + constant GPIOA_BSRR	\ write-only		\  : RESET_GPIOA_BSRR $00000000 
        \ %x  31 lshift GPIOA_BSRR        \ GPIOA_BR15	Bit Offset:31	Bit Width:1
        \ %x  30 lshift GPIOA_BSRR        \ GPIOA_BR14	Bit Offset:30	Bit Width:1
        \ %x  29 lshift GPIOA_BSRR        \ GPIOA_BR13	Bit Offset:29	Bit Width:1
        \ %x  28 lshift GPIOA_BSRR        \ GPIOA_BR12	Bit Offset:28	Bit Width:1
        \ %x  27 lshift GPIOA_BSRR        \ GPIOA_BR11	Bit Offset:27	Bit Width:1
        \ %x  26 lshift GPIOA_BSRR        \ GPIOA_BR10	Bit Offset:26	Bit Width:1
        \ %x  25 lshift GPIOA_BSRR        \ GPIOA_BR9	Bit Offset:25	Bit Width:1
        \ %x  24 lshift GPIOA_BSRR        \ GPIOA_BR8	Bit Offset:24	Bit Width:1
        \ %x  23 lshift GPIOA_BSRR        \ GPIOA_BR7	Bit Offset:23	Bit Width:1
        \ %x  22 lshift GPIOA_BSRR        \ GPIOA_BR6	Bit Offset:22	Bit Width:1
        \ %x  21 lshift GPIOA_BSRR        \ GPIOA_BR5	Bit Offset:21	Bit Width:1
        \ %x  20 lshift GPIOA_BSRR        \ GPIOA_BR4	Bit Offset:20	Bit Width:1
        \ %x  19 lshift GPIOA_BSRR        \ GPIOA_BR3	Bit Offset:19	Bit Width:1
        \ %x  18 lshift GPIOA_BSRR        \ GPIOA_BR2	Bit Offset:18	Bit Width:1
        \ %x  17 lshift GPIOA_BSRR        \ GPIOA_BR1	Bit Offset:17	Bit Width:1
        \ %x  16 lshift GPIOA_BSRR        \ GPIOA_BR0	Bit Offset:16	Bit Width:1
        \ %x  15 lshift GPIOA_BSRR        \ GPIOA_BS15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOA_BSRR        \ GPIOA_BS14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOA_BSRR        \ GPIOA_BS13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOA_BSRR        \ GPIOA_BS12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOA_BSRR        \ GPIOA_BS11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOA_BSRR        \ GPIOA_BS10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOA_BSRR        \ GPIOA_BS9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOA_BSRR        \ GPIOA_BS8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOA_BSRR        \ GPIOA_BS7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOA_BSRR        \ GPIOA_BS6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOA_BSRR        \ GPIOA_BS5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOA_BSRR        \ GPIOA_BS4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOA_BSRR        \ GPIOA_BS3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOA_BSRR        \ GPIOA_BS2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOA_BSRR        \ GPIOA_BS1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOA_BSRR        \ GPIOA_BS0	Bit Offset:0	Bit Width:1
        
        GPIOA $1C + constant GPIOA_LCKR	\ read-write		\  : RESET_GPIOA_LCKR $00000000 
        \ %x  16 lshift GPIOA_LCKR        \ GPIOA_LCKK	Bit Offset:16	Bit Width:1
        \ %x  15 lshift GPIOA_LCKR        \ GPIOA_LCK15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift GPIOA_LCKR        \ GPIOA_LCK14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift GPIOA_LCKR        \ GPIOA_LCK13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift GPIOA_LCKR        \ GPIOA_LCK12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift GPIOA_LCKR        \ GPIOA_LCK11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift GPIOA_LCKR        \ GPIOA_LCK10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift GPIOA_LCKR        \ GPIOA_LCK9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift GPIOA_LCKR        \ GPIOA_LCK8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift GPIOA_LCKR        \ GPIOA_LCK7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift GPIOA_LCKR        \ GPIOA_LCK6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift GPIOA_LCKR        \ GPIOA_LCK5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift GPIOA_LCKR        \ GPIOA_LCK4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift GPIOA_LCKR        \ GPIOA_LCK3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift GPIOA_LCKR        \ GPIOA_LCK2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift GPIOA_LCKR        \ GPIOA_LCK1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift GPIOA_LCKR        \ GPIOA_LCK0	Bit Offset:0	Bit Width:1
        
        GPIOA $20 + constant GPIOA_AFRL	\ read-write		\  : RESET_GPIOA_AFRL $00000000 
        \ %xxxx  28 lshift GPIOA_AFRL        \ GPIOA_AFRL7	Bit Offset:28	Bit Width:4
        \ %xxxx  24 lshift GPIOA_AFRL        \ GPIOA_AFRL6	Bit Offset:24	Bit Width:4
        \ %xxxx  20 lshift GPIOA_AFRL        \ GPIOA_AFRL5	Bit Offset:20	Bit Width:4
        \ %xxxx  16 lshift GPIOA_AFRL        \ GPIOA_AFRL4	Bit Offset:16	Bit Width:4
        \ %xxxx  12 lshift GPIOA_AFRL        \ GPIOA_AFRL3	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift GPIOA_AFRL        \ GPIOA_AFRL2	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift GPIOA_AFRL        \ GPIOA_AFRL1	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift GPIOA_AFRL        \ GPIOA_AFRL0	Bit Offset:0	Bit Width:4
        
        GPIOA $24 + constant GPIOA_AFRH	\ read-write		\  : RESET_GPIOA_AFRH $00000000 
        \ %xxxx  28 lshift GPIOA_AFRH        \ GPIOA_AFRH15	Bit Offset:28	Bit Width:4
        \ %xxxx  24 lshift GPIOA_AFRH        \ GPIOA_AFRH14	Bit Offset:24	Bit Width:4
        \ %xxxx  20 lshift GPIOA_AFRH        \ GPIOA_AFRH13	Bit Offset:20	Bit Width:4
        \ %xxxx  16 lshift GPIOA_AFRH        \ GPIOA_AFRH12	Bit Offset:16	Bit Width:4
        \ %xxxx  12 lshift GPIOA_AFRH        \ GPIOA_AFRH11	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift GPIOA_AFRH        \ GPIOA_AFRH10	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift GPIOA_AFRH        \ GPIOA_AFRH9	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift GPIOA_AFRH        \ GPIOA_AFRH8	Bit Offset:0	Bit Width:4
        
        GPIOA $28 + constant GPIOA_BRR	\ write-only		\  : RESET_GPIOA_BRR $00000000 
        \ %x  0 lshift GPIOA_BRR        \ GPIOA_BR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift GPIOA_BRR        \ GPIOA_BR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift GPIOA_BRR        \ GPIOA_BR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift GPIOA_BRR        \ GPIOA_BR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift GPIOA_BRR        \ GPIOA_BR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift GPIOA_BRR        \ GPIOA_BR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift GPIOA_BRR        \ GPIOA_BR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift GPIOA_BRR        \ GPIOA_BR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift GPIOA_BRR        \ GPIOA_BR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift GPIOA_BRR        \ GPIOA_BR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift GPIOA_BRR        \ GPIOA_BR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift GPIOA_BRR        \ GPIOA_BR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift GPIOA_BRR        \ GPIOA_BR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift GPIOA_BRR        \ GPIOA_BR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift GPIOA_BRR        \ GPIOA_BR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift GPIOA_BRR        \ GPIOA_BR15	Bit Offset:15	Bit Width:1
        
         
	
     $40013000 constant SPI1  
	 SPI1 $0 + constant SPI1_CR1	\ read-write		\  : RESET_SPI1_CR1 $0000 
        \ %x  15 lshift SPI1_CR1        \ SPI1_BIDIMODE	Bit Offset:15	Bit Width:1
        \ %x  14 lshift SPI1_CR1        \ SPI1_BIDIOE	Bit Offset:14	Bit Width:1
        \ %x  13 lshift SPI1_CR1        \ SPI1_CRCEN	Bit Offset:13	Bit Width:1
        \ %x  12 lshift SPI1_CR1        \ SPI1_CRCNEXT	Bit Offset:12	Bit Width:1
        \ %x  11 lshift SPI1_CR1        \ SPI1_DFF	Bit Offset:11	Bit Width:1
        \ %x  10 lshift SPI1_CR1        \ SPI1_RXONLY	Bit Offset:10	Bit Width:1
        \ %x  9 lshift SPI1_CR1        \ SPI1_SSM	Bit Offset:9	Bit Width:1
        \ %x  8 lshift SPI1_CR1        \ SPI1_SSI	Bit Offset:8	Bit Width:1
        \ %x  7 lshift SPI1_CR1        \ SPI1_LSBFIRST	Bit Offset:7	Bit Width:1
        \ %x  6 lshift SPI1_CR1        \ SPI1_SPE	Bit Offset:6	Bit Width:1
        \ %xxx  3 lshift SPI1_CR1        \ SPI1_BR	Bit Offset:3	Bit Width:3
        \ %x  2 lshift SPI1_CR1        \ SPI1_MSTR	Bit Offset:2	Bit Width:1
        \ %x  1 lshift SPI1_CR1        \ SPI1_CPOL	Bit Offset:1	Bit Width:1
        \ %x  0 lshift SPI1_CR1        \ SPI1_CPHA	Bit Offset:0	Bit Width:1
        
        SPI1 $4 + constant SPI1_CR2	\ read-write		\  : RESET_SPI1_CR2 $0000 
        \ %x  0 lshift SPI1_CR2        \ SPI1_RXDMAEN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift SPI1_CR2        \ SPI1_TXDMAEN	Bit Offset:1	Bit Width:1
        \ %x  2 lshift SPI1_CR2        \ SPI1_SSOE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift SPI1_CR2        \ SPI1_NSSP	Bit Offset:3	Bit Width:1
        \ %x  4 lshift SPI1_CR2        \ SPI1_FRF	Bit Offset:4	Bit Width:1
        \ %x  5 lshift SPI1_CR2        \ SPI1_ERRIE	Bit Offset:5	Bit Width:1
        \ %x  6 lshift SPI1_CR2        \ SPI1_RXNEIE	Bit Offset:6	Bit Width:1
        \ %x  7 lshift SPI1_CR2        \ SPI1_TXEIE	Bit Offset:7	Bit Width:1
        \ %xxxx  8 lshift SPI1_CR2        \ SPI1_DS	Bit Offset:8	Bit Width:4
        \ %x  12 lshift SPI1_CR2        \ SPI1_FRXTH	Bit Offset:12	Bit Width:1
        \ %x  13 lshift SPI1_CR2        \ SPI1_LDMA_RX	Bit Offset:13	Bit Width:1
        \ %x  14 lshift SPI1_CR2        \ SPI1_LDMA_TX	Bit Offset:14	Bit Width:1
        
        SPI1 $8 + constant SPI1_SR	\ 		\  : RESET_SPI1_SR $0002 
        \ %x  0 lshift SPI1_SR        \ SPI1_RXNE	Bit Offset:0	Bit Width:1
        \ %x  1 lshift SPI1_SR        \ SPI1_TXE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift SPI1_SR        \ SPI1_CHSIDE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift SPI1_SR        \ SPI1_UDR	Bit Offset:3	Bit Width:1
        \ %x  4 lshift SPI1_SR        \ SPI1_CRCERR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift SPI1_SR        \ SPI1_MODF	Bit Offset:5	Bit Width:1
        \ %x  6 lshift SPI1_SR        \ SPI1_OVR	Bit Offset:6	Bit Width:1
        \ %x  7 lshift SPI1_SR        \ SPI1_BSY	Bit Offset:7	Bit Width:1
        \ %x  8 lshift SPI1_SR        \ SPI1_TIFRFE	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift SPI1_SR        \ SPI1_FRLVL	Bit Offset:9	Bit Width:2
        \ %xx  11 lshift SPI1_SR        \ SPI1_FTLVL	Bit Offset:11	Bit Width:2
        
        SPI1 $C + constant SPI1_DR	\ read-write		\  : RESET_SPI1_DR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift SPI1_DR        \ SPI1_DR	Bit Offset:0	Bit Width:16
        
        SPI1 $10 + constant SPI1_CRCPR	\ read-write		\  : RESET_SPI1_CRCPR $0007 
        \ %xxxxxxxxxxxxxxxx  0 lshift SPI1_CRCPR        \ SPI1_CRCPOLY	Bit Offset:0	Bit Width:16
        
        SPI1 $14 + constant SPI1_RXCRCR	\ read-only		\  : RESET_SPI1_RXCRCR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift SPI1_RXCRCR        \ SPI1_RxCRC	Bit Offset:0	Bit Width:16
        
        SPI1 $18 + constant SPI1_TXCRCR	\ read-only		\  : RESET_SPI1_TXCRCR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift SPI1_TXCRCR        \ SPI1_TxCRC	Bit Offset:0	Bit Width:16
        
        SPI1 $1C + constant SPI1_I2SCFGR	\ read-write		\  : RESET_SPI1_I2SCFGR $0000 
        \ %x  11 lshift SPI1_I2SCFGR        \ SPI1_I2SMOD	Bit Offset:11	Bit Width:1
        \ %x  10 lshift SPI1_I2SCFGR        \ SPI1_I2SE	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift SPI1_I2SCFGR        \ SPI1_I2SCFG	Bit Offset:8	Bit Width:2
        \ %x  7 lshift SPI1_I2SCFGR        \ SPI1_PCMSYNC	Bit Offset:7	Bit Width:1
        \ %xx  4 lshift SPI1_I2SCFGR        \ SPI1_I2SSTD	Bit Offset:4	Bit Width:2
        \ %x  3 lshift SPI1_I2SCFGR        \ SPI1_CKPOL	Bit Offset:3	Bit Width:1
        \ %xx  1 lshift SPI1_I2SCFGR        \ SPI1_DATLEN	Bit Offset:1	Bit Width:2
        \ %x  0 lshift SPI1_I2SCFGR        \ SPI1_CHLEN	Bit Offset:0	Bit Width:1
        
        SPI1 $20 + constant SPI1_I2SPR	\ read-write		\  : RESET_SPI1_I2SPR $00000010 
        \ %x  9 lshift SPI1_I2SPR        \ SPI1_MCKOE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift SPI1_I2SPR        \ SPI1_ODD	Bit Offset:8	Bit Width:1
        \ %xxxxxxxx  0 lshift SPI1_I2SPR        \ SPI1_I2SDIV	Bit Offset:0	Bit Width:8
        
         
	
     $40003800 constant SPI2  
	  
	
     $40007400 constant DAC  
	 DAC $0 + constant DAC_CR	\ read-write		\  : RESET_DAC_CR $00000000 
        \ %x  0 lshift DAC_CR        \ DAC_EN1	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DAC_CR        \ DAC_BOFF1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DAC_CR        \ DAC_TEN1	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DAC_CR        \ DAC_TSEL10	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DAC_CR        \ DAC_TSEL11	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DAC_CR        \ DAC_TSEL12	Bit Offset:5	Bit Width:1
        \ %x  12 lshift DAC_CR        \ DAC_DMAEN1	Bit Offset:12	Bit Width:1
        \ %x  13 lshift DAC_CR        \ DAC_DMAUDRIE1	Bit Offset:13	Bit Width:1
        
        DAC $4 + constant DAC_SWTRIGR	\ write-only		\  : RESET_DAC_SWTRIGR $00000000 
        \ %x  0 lshift DAC_SWTRIGR        \ DAC_SWTRIG1	Bit Offset:0	Bit Width:1
        
        DAC $8 + constant DAC_DHR12R1	\ read-write		\  : RESET_DAC_DHR12R1 $00000000 
        \ %xxxxxxxxxxxx  0 lshift DAC_DHR12R1        \ DAC_DACC1DHR	Bit Offset:0	Bit Width:12
        
        DAC $C + constant DAC_DHR12L1	\ read-write		\  : RESET_DAC_DHR12L1 $00000000 
        \ %xxxxxxxxxxxx  4 lshift DAC_DHR12L1        \ DAC_DACC1DHR	Bit Offset:4	Bit Width:12
        
        DAC $10 + constant DAC_DHR8R1	\ read-write		\  : RESET_DAC_DHR8R1 $00000000 
        \ %xxxxxxxx  0 lshift DAC_DHR8R1        \ DAC_DACC1DHR	Bit Offset:0	Bit Width:8
        
        DAC $2C + constant DAC_DOR1	\ read-only		\  : RESET_DAC_DOR1 $00000000 
        \ %xxxxxxxxxxxx  0 lshift DAC_DOR1        \ DAC_DACC1DOR	Bit Offset:0	Bit Width:12
        
        DAC $34 + constant DAC_SR	\ read-write		\  : RESET_DAC_SR $00000000 
        \ %x  29 lshift DAC_SR        \ DAC_DMAUDR2	Bit Offset:29	Bit Width:1
        \ %x  13 lshift DAC_SR        \ DAC_DMAUDR1	Bit Offset:13	Bit Width:1
        
         
	
     $40007000 constant PWR  
	 PWR $0 + constant PWR_CR	\ read-write		\  : RESET_PWR_CR $00000000 
        \ %x  9 lshift PWR_CR        \ PWR_FPDS	Bit Offset:9	Bit Width:1
        \ %x  8 lshift PWR_CR        \ PWR_DBP	Bit Offset:8	Bit Width:1
        \ %xxx  5 lshift PWR_CR        \ PWR_PLS	Bit Offset:5	Bit Width:3
        \ %x  4 lshift PWR_CR        \ PWR_PVDE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift PWR_CR        \ PWR_CSBF	Bit Offset:3	Bit Width:1
        \ %x  2 lshift PWR_CR        \ PWR_CWUF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift PWR_CR        \ PWR_PDDS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift PWR_CR        \ PWR_LPDS	Bit Offset:0	Bit Width:1
        
        PWR $4 + constant PWR_CSR	\ 		\  : RESET_PWR_CSR $00000000 
        \ %x  9 lshift PWR_CSR        \ PWR_BRE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift PWR_CSR        \ PWR_EWUP	Bit Offset:8	Bit Width:1
        \ %x  3 lshift PWR_CSR        \ PWR_BRR	Bit Offset:3	Bit Width:1
        \ %x  2 lshift PWR_CSR        \ PWR_PVDO	Bit Offset:2	Bit Width:1
        \ %x  1 lshift PWR_CSR        \ PWR_SBF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift PWR_CSR        \ PWR_WUF	Bit Offset:0	Bit Width:1
        
         
	
     $40005400 constant I2C1  
	 I2C1 $0 + constant I2C1_CR1	\ 		\  : RESET_I2C1_CR1 $00000000 
        \ %x  0 lshift I2C1_CR1        \ I2C1_PE	Bit Offset:0	Bit Width:1
        \ %x  1 lshift I2C1_CR1        \ I2C1_TXIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift I2C1_CR1        \ I2C1_RXIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift I2C1_CR1        \ I2C1_ADDRIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift I2C1_CR1        \ I2C1_NACKIE	Bit Offset:4	Bit Width:1
        \ %x  5 lshift I2C1_CR1        \ I2C1_STOPIE	Bit Offset:5	Bit Width:1
        \ %x  6 lshift I2C1_CR1        \ I2C1_TCIE	Bit Offset:6	Bit Width:1
        \ %x  7 lshift I2C1_CR1        \ I2C1_ERRIE	Bit Offset:7	Bit Width:1
        \ %xxxx  8 lshift I2C1_CR1        \ I2C1_DNF	Bit Offset:8	Bit Width:4
        \ %x  12 lshift I2C1_CR1        \ I2C1_ANFOFF	Bit Offset:12	Bit Width:1
        \ %x  13 lshift I2C1_CR1        \ I2C1_SWRST	Bit Offset:13	Bit Width:1
        \ %x  14 lshift I2C1_CR1        \ I2C1_TXDMAEN	Bit Offset:14	Bit Width:1
        \ %x  15 lshift I2C1_CR1        \ I2C1_RXDMAEN	Bit Offset:15	Bit Width:1
        \ %x  16 lshift I2C1_CR1        \ I2C1_SBC	Bit Offset:16	Bit Width:1
        \ %x  17 lshift I2C1_CR1        \ I2C1_NOSTRETCH	Bit Offset:17	Bit Width:1
        \ %x  18 lshift I2C1_CR1        \ I2C1_WUPEN	Bit Offset:18	Bit Width:1
        \ %x  19 lshift I2C1_CR1        \ I2C1_GCEN	Bit Offset:19	Bit Width:1
        \ %x  20 lshift I2C1_CR1        \ I2C1_SMBHEN	Bit Offset:20	Bit Width:1
        \ %x  21 lshift I2C1_CR1        \ I2C1_SMBDEN	Bit Offset:21	Bit Width:1
        \ %x  22 lshift I2C1_CR1        \ I2C1_ALERTEN	Bit Offset:22	Bit Width:1
        \ %x  23 lshift I2C1_CR1        \ I2C1_PECEN	Bit Offset:23	Bit Width:1
        
        I2C1 $4 + constant I2C1_CR2	\ read-write		\  : RESET_I2C1_CR2 $00000000 
        \ %x  26 lshift I2C1_CR2        \ I2C1_PECBYTE	Bit Offset:26	Bit Width:1
        \ %x  25 lshift I2C1_CR2        \ I2C1_AUTOEND	Bit Offset:25	Bit Width:1
        \ %x  24 lshift I2C1_CR2        \ I2C1_RELOAD	Bit Offset:24	Bit Width:1
        \ %xxxxxxxx  16 lshift I2C1_CR2        \ I2C1_NBYTES	Bit Offset:16	Bit Width:8
        \ %x  15 lshift I2C1_CR2        \ I2C1_NACK	Bit Offset:15	Bit Width:1
        \ %x  14 lshift I2C1_CR2        \ I2C1_STOP	Bit Offset:14	Bit Width:1
        \ %x  13 lshift I2C1_CR2        \ I2C1_START	Bit Offset:13	Bit Width:1
        \ %x  12 lshift I2C1_CR2        \ I2C1_HEAD10R	Bit Offset:12	Bit Width:1
        \ %x  11 lshift I2C1_CR2        \ I2C1_ADD10	Bit Offset:11	Bit Width:1
        \ %x  10 lshift I2C1_CR2        \ I2C1_RD_WRN	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift I2C1_CR2        \ I2C1_SADD8	Bit Offset:8	Bit Width:2
        \ %xxxxxxx  1 lshift I2C1_CR2        \ I2C1_SADD1	Bit Offset:1	Bit Width:7
        \ %x  0 lshift I2C1_CR2        \ I2C1_SADD0	Bit Offset:0	Bit Width:1
        
        I2C1 $8 + constant I2C1_OAR1	\ read-write		\  : RESET_I2C1_OAR1 $00000000 
        \ %x  0 lshift I2C1_OAR1        \ I2C1_OA1_0	Bit Offset:0	Bit Width:1
        \ %xxxxxxx  1 lshift I2C1_OAR1        \ I2C1_OA1_1	Bit Offset:1	Bit Width:7
        \ %xx  8 lshift I2C1_OAR1        \ I2C1_OA1_8	Bit Offset:8	Bit Width:2
        \ %x  10 lshift I2C1_OAR1        \ I2C1_OA1MODE	Bit Offset:10	Bit Width:1
        \ %x  15 lshift I2C1_OAR1        \ I2C1_OA1EN	Bit Offset:15	Bit Width:1
        
        I2C1 $C + constant I2C1_OAR2	\ read-write		\  : RESET_I2C1_OAR2 $00000000 
        \ %xxxxxxx  1 lshift I2C1_OAR2        \ I2C1_OA2	Bit Offset:1	Bit Width:7
        \ %xxx  8 lshift I2C1_OAR2        \ I2C1_OA2MSK	Bit Offset:8	Bit Width:3
        \ %x  15 lshift I2C1_OAR2        \ I2C1_OA2EN	Bit Offset:15	Bit Width:1
        
        I2C1 $10 + constant I2C1_TIMINGR	\ read-write		\  : RESET_I2C1_TIMINGR $00000000 
        \ %xxxxxxxx  0 lshift I2C1_TIMINGR        \ I2C1_SCLL	Bit Offset:0	Bit Width:8
        \ %xxxxxxxx  8 lshift I2C1_TIMINGR        \ I2C1_SCLH	Bit Offset:8	Bit Width:8
        \ %xxxx  16 lshift I2C1_TIMINGR        \ I2C1_SDADEL	Bit Offset:16	Bit Width:4
        \ %xxxx  20 lshift I2C1_TIMINGR        \ I2C1_SCLDEL	Bit Offset:20	Bit Width:4
        \ %xxxx  28 lshift I2C1_TIMINGR        \ I2C1_PRESC	Bit Offset:28	Bit Width:4
        
        I2C1 $14 + constant I2C1_TIMEOUTR	\ read-write		\  : RESET_I2C1_TIMEOUTR $00000000 
        \ %xxxxxxxxxxxx  0 lshift I2C1_TIMEOUTR        \ I2C1_TIMEOUTA	Bit Offset:0	Bit Width:12
        \ %x  12 lshift I2C1_TIMEOUTR        \ I2C1_TIDLE	Bit Offset:12	Bit Width:1
        \ %x  15 lshift I2C1_TIMEOUTR        \ I2C1_TIMOUTEN	Bit Offset:15	Bit Width:1
        \ %xxxxxxxxxxxx  16 lshift I2C1_TIMEOUTR        \ I2C1_TIMEOUTB	Bit Offset:16	Bit Width:12
        \ %x  31 lshift I2C1_TIMEOUTR        \ I2C1_TEXTEN	Bit Offset:31	Bit Width:1
        
        I2C1 $18 + constant I2C1_ISR	\ 		\  : RESET_I2C1_ISR $00000001 
        \ %xxxxxxx  17 lshift I2C1_ISR        \ I2C1_ADDCODE	Bit Offset:17	Bit Width:7
        \ %x  16 lshift I2C1_ISR        \ I2C1_DIR	Bit Offset:16	Bit Width:1
        \ %x  15 lshift I2C1_ISR        \ I2C1_BUSY	Bit Offset:15	Bit Width:1
        \ %x  13 lshift I2C1_ISR        \ I2C1_ALERT	Bit Offset:13	Bit Width:1
        \ %x  12 lshift I2C1_ISR        \ I2C1_TIMEOUT	Bit Offset:12	Bit Width:1
        \ %x  11 lshift I2C1_ISR        \ I2C1_PECERR	Bit Offset:11	Bit Width:1
        \ %x  10 lshift I2C1_ISR        \ I2C1_OVR	Bit Offset:10	Bit Width:1
        \ %x  9 lshift I2C1_ISR        \ I2C1_ARLO	Bit Offset:9	Bit Width:1
        \ %x  8 lshift I2C1_ISR        \ I2C1_BERR	Bit Offset:8	Bit Width:1
        \ %x  7 lshift I2C1_ISR        \ I2C1_TCR	Bit Offset:7	Bit Width:1
        \ %x  6 lshift I2C1_ISR        \ I2C1_TC	Bit Offset:6	Bit Width:1
        \ %x  5 lshift I2C1_ISR        \ I2C1_STOPF	Bit Offset:5	Bit Width:1
        \ %x  4 lshift I2C1_ISR        \ I2C1_NACKF	Bit Offset:4	Bit Width:1
        \ %x  3 lshift I2C1_ISR        \ I2C1_ADDR	Bit Offset:3	Bit Width:1
        \ %x  2 lshift I2C1_ISR        \ I2C1_RXNE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift I2C1_ISR        \ I2C1_TXIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift I2C1_ISR        \ I2C1_TXE	Bit Offset:0	Bit Width:1
        
        I2C1 $1C + constant I2C1_ICR	\ write-only		\  : RESET_I2C1_ICR $00000000 
        \ %x  13 lshift I2C1_ICR        \ I2C1_ALERTCF	Bit Offset:13	Bit Width:1
        \ %x  12 lshift I2C1_ICR        \ I2C1_TIMOUTCF	Bit Offset:12	Bit Width:1
        \ %x  11 lshift I2C1_ICR        \ I2C1_PECCF	Bit Offset:11	Bit Width:1
        \ %x  10 lshift I2C1_ICR        \ I2C1_OVRCF	Bit Offset:10	Bit Width:1
        \ %x  9 lshift I2C1_ICR        \ I2C1_ARLOCF	Bit Offset:9	Bit Width:1
        \ %x  8 lshift I2C1_ICR        \ I2C1_BERRCF	Bit Offset:8	Bit Width:1
        \ %x  5 lshift I2C1_ICR        \ I2C1_STOPCF	Bit Offset:5	Bit Width:1
        \ %x  4 lshift I2C1_ICR        \ I2C1_NACKCF	Bit Offset:4	Bit Width:1
        \ %x  3 lshift I2C1_ICR        \ I2C1_ADDRCF	Bit Offset:3	Bit Width:1
        
        I2C1 $20 + constant I2C1_PECR	\ read-only		\  : RESET_I2C1_PECR $00000000 
        \ %xxxxxxxx  0 lshift I2C1_PECR        \ I2C1_PEC	Bit Offset:0	Bit Width:8
        
        I2C1 $24 + constant I2C1_RXDR	\ read-only		\  : RESET_I2C1_RXDR $00000000 
        \ %xxxxxxxx  0 lshift I2C1_RXDR        \ I2C1_RXDATA	Bit Offset:0	Bit Width:8
        
        I2C1 $28 + constant I2C1_TXDR	\ read-write		\  : RESET_I2C1_TXDR $00000000 
        \ %xxxxxxxx  0 lshift I2C1_TXDR        \ I2C1_TXDATA	Bit Offset:0	Bit Width:8
        
         
	
     $40005800 constant I2C2  
	  
	
     $40003000 constant IWDG  
	 IWDG $0 + constant IWDG_KR	\ write-only		\  : RESET_IWDG_KR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift IWDG_KR        \ IWDG_KEY	Bit Offset:0	Bit Width:16
        
        IWDG $4 + constant IWDG_PR	\ read-write		\  : RESET_IWDG_PR $00000000 
        \ %xxx  0 lshift IWDG_PR        \ IWDG_PR	Bit Offset:0	Bit Width:3
        
        IWDG $8 + constant IWDG_RLR	\ read-write		\  : RESET_IWDG_RLR $00000FFF 
        \ %xxxxxxxxxxxx  0 lshift IWDG_RLR        \ IWDG_RL	Bit Offset:0	Bit Width:12
        
        IWDG $C + constant IWDG_SR	\ read-only		\  : RESET_IWDG_SR $00000000 
        \ %x  0 lshift IWDG_SR        \ IWDG_PVU	Bit Offset:0	Bit Width:1
        \ %x  1 lshift IWDG_SR        \ IWDG_RVU	Bit Offset:1	Bit Width:1
        \ %x  2 lshift IWDG_SR        \ IWDG_WVU	Bit Offset:2	Bit Width:1
        
        IWDG $10 + constant IWDG_WINR	\ read-write		\  : RESET_IWDG_WINR $00000FFF 
        \ %xxxxxxxxxxxx  0 lshift IWDG_WINR        \ IWDG_WIN	Bit Offset:0	Bit Width:12
        
         
	
     $40002C00 constant WWDG  
	 WWDG $0 + constant WWDG_CR	\ read-write		\  : RESET_WWDG_CR $0000007F 
        \ %x  7 lshift WWDG_CR        \ WWDG_WDGA	Bit Offset:7	Bit Width:1
        \ %xxxxxxx  0 lshift WWDG_CR        \ WWDG_T	Bit Offset:0	Bit Width:7
        
        WWDG $4 + constant WWDG_CFR	\ read-write		\  : RESET_WWDG_CFR $0000007F 
        \ %x  9 lshift WWDG_CFR        \ WWDG_EWI	Bit Offset:9	Bit Width:1
        \ %xx  7 lshift WWDG_CFR        \ WWDG_WDGTB	Bit Offset:7	Bit Width:2
        \ %xxxxxxx  0 lshift WWDG_CFR        \ WWDG_W	Bit Offset:0	Bit Width:7
        
        WWDG $8 + constant WWDG_SR	\ read-write		\  : RESET_WWDG_SR $00000000 
        \ %x  0 lshift WWDG_SR        \ WWDG_EWIF	Bit Offset:0	Bit Width:1
        
         
	
     $40012C00 constant TIM1  
	 TIM1 $0 + constant TIM1_CR1	\ read-write		\  : RESET_TIM1_CR1 $0000 
        \ %xx  8 lshift TIM1_CR1        \ TIM1_CKD	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM1_CR1        \ TIM1_ARPE	Bit Offset:7	Bit Width:1
        \ %xx  5 lshift TIM1_CR1        \ TIM1_CMS	Bit Offset:5	Bit Width:2
        \ %x  4 lshift TIM1_CR1        \ TIM1_DIR	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM1_CR1        \ TIM1_OPM	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_CR1        \ TIM1_URS	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM1_CR1        \ TIM1_UDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM1_CR1        \ TIM1_CEN	Bit Offset:0	Bit Width:1
        
        TIM1 $4 + constant TIM1_CR2	\ read-write		\  : RESET_TIM1_CR2 $0000 
        \ %x  14 lshift TIM1_CR2        \ TIM1_OIS4	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TIM1_CR2        \ TIM1_OIS3N	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM1_CR2        \ TIM1_OIS3	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM1_CR2        \ TIM1_OIS2N	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_CR2        \ TIM1_OIS2	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM1_CR2        \ TIM1_OIS1N	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM1_CR2        \ TIM1_OIS1	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TIM1_CR2        \ TIM1_TI1S	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM1_CR2        \ TIM1_MMS	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM1_CR2        \ TIM1_CCDS	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_CR2        \ TIM1_CCUS	Bit Offset:2	Bit Width:1
        \ %x  0 lshift TIM1_CR2        \ TIM1_CCPC	Bit Offset:0	Bit Width:1
        
        TIM1 $8 + constant TIM1_SMCR	\ read-write		\  : RESET_TIM1_SMCR $0000 
        \ %x  15 lshift TIM1_SMCR        \ TIM1_ETP	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TIM1_SMCR        \ TIM1_ECE	Bit Offset:14	Bit Width:1
        \ %xx  12 lshift TIM1_SMCR        \ TIM1_ETPS	Bit Offset:12	Bit Width:2
        \ %xxxx  8 lshift TIM1_SMCR        \ TIM1_ETF	Bit Offset:8	Bit Width:4
        \ %x  7 lshift TIM1_SMCR        \ TIM1_MSM	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM1_SMCR        \ TIM1_TS	Bit Offset:4	Bit Width:3
        \ %xxx  0 lshift TIM1_SMCR        \ TIM1_SMS	Bit Offset:0	Bit Width:3
        
        TIM1 $C + constant TIM1_DIER	\ read-write		\  : RESET_TIM1_DIER $0000 
        \ %x  14 lshift TIM1_DIER        \ TIM1_TDE	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TIM1_DIER        \ TIM1_COMDE	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM1_DIER        \ TIM1_CC4DE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM1_DIER        \ TIM1_CC3DE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_DIER        \ TIM1_CC2DE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM1_DIER        \ TIM1_CC1DE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM1_DIER        \ TIM1_UDE	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TIM1_DIER        \ TIM1_BIE	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM1_DIER        \ TIM1_TIE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM1_DIER        \ TIM1_COMIE	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TIM1_DIER        \ TIM1_CC4IE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM1_DIER        \ TIM1_CC3IE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_DIER        \ TIM1_CC2IE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM1_DIER        \ TIM1_CC1IE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM1_DIER        \ TIM1_UIE	Bit Offset:0	Bit Width:1
        
        TIM1 $10 + constant TIM1_SR	\ read-write		\  : RESET_TIM1_SR $0000 
        \ %x  12 lshift TIM1_SR        \ TIM1_CC4OF	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM1_SR        \ TIM1_CC3OF	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_SR        \ TIM1_CC2OF	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM1_SR        \ TIM1_CC1OF	Bit Offset:9	Bit Width:1
        \ %x  7 lshift TIM1_SR        \ TIM1_BIF	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM1_SR        \ TIM1_TIF	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM1_SR        \ TIM1_COMIF	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TIM1_SR        \ TIM1_CC4IF	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM1_SR        \ TIM1_CC3IF	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_SR        \ TIM1_CC2IF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM1_SR        \ TIM1_CC1IF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM1_SR        \ TIM1_UIF	Bit Offset:0	Bit Width:1
        
        TIM1 $14 + constant TIM1_EGR	\ write-only		\  : RESET_TIM1_EGR $0000 
        \ %x  7 lshift TIM1_EGR        \ TIM1_BG	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM1_EGR        \ TIM1_TG	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM1_EGR        \ TIM1_COMG	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TIM1_EGR        \ TIM1_CC4G	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM1_EGR        \ TIM1_CC3G	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_EGR        \ TIM1_CC2G	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM1_EGR        \ TIM1_CC1G	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM1_EGR        \ TIM1_UG	Bit Offset:0	Bit Width:1
        
        TIM1 $18 + constant TIM1_CCMR1_Output	\ read-write		\  : RESET_TIM1_CCMR1_Output $00000000 
        \ %x  15 lshift TIM1_CCMR1_Output        \ TIM1_OC2CE	Bit Offset:15	Bit Width:1
        \ %xxx  12 lshift TIM1_CCMR1_Output        \ TIM1_OC2M	Bit Offset:12	Bit Width:3
        \ %x  11 lshift TIM1_CCMR1_Output        \ TIM1_OC2PE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_CCMR1_Output        \ TIM1_OC2FE	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM1_CCMR1_Output        \ TIM1_CC2S	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM1_CCMR1_Output        \ TIM1_OC1CE	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM1_CCMR1_Output        \ TIM1_OC1M	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM1_CCMR1_Output        \ TIM1_OC1PE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_CCMR1_Output        \ TIM1_OC1FE	Bit Offset:2	Bit Width:1
        \ %xx  0 lshift TIM1_CCMR1_Output        \ TIM1_CC1S	Bit Offset:0	Bit Width:2
        
        TIM1 $18 + constant TIM1_CCMR1_Input	\ read-write		\  : RESET_TIM1_CCMR1_Input $00000000 
        \ %xxxx  12 lshift TIM1_CCMR1_Input        \ TIM1_IC2F	Bit Offset:12	Bit Width:4
        \ %xx  10 lshift TIM1_CCMR1_Input        \ TIM1_IC2PCS	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift TIM1_CCMR1_Input        \ TIM1_CC2S	Bit Offset:8	Bit Width:2
        \ %xxxx  4 lshift TIM1_CCMR1_Input        \ TIM1_IC1F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM1_CCMR1_Input        \ TIM1_IC1PCS	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM1_CCMR1_Input        \ TIM1_CC1S	Bit Offset:0	Bit Width:2
        
        TIM1 $1C + constant TIM1_CCMR2_Output	\ read-write		\  : RESET_TIM1_CCMR2_Output $00000000 
        \ %x  15 lshift TIM1_CCMR2_Output        \ TIM1_OC4CE	Bit Offset:15	Bit Width:1
        \ %xxx  12 lshift TIM1_CCMR2_Output        \ TIM1_OC4M	Bit Offset:12	Bit Width:3
        \ %x  11 lshift TIM1_CCMR2_Output        \ TIM1_OC4PE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_CCMR2_Output        \ TIM1_OC4FE	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM1_CCMR2_Output        \ TIM1_CC4S	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM1_CCMR2_Output        \ TIM1_OC3CE	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM1_CCMR2_Output        \ TIM1_OC3M	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM1_CCMR2_Output        \ TIM1_OC3PE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_CCMR2_Output        \ TIM1_OC3FE	Bit Offset:2	Bit Width:1
        \ %xx  0 lshift TIM1_CCMR2_Output        \ TIM1_CC3S	Bit Offset:0	Bit Width:2
        
        TIM1 $1C + constant TIM1_CCMR2_Input	\ read-write		\  : RESET_TIM1_CCMR2_Input $00000000 
        \ %xxxx  12 lshift TIM1_CCMR2_Input        \ TIM1_IC4F	Bit Offset:12	Bit Width:4
        \ %xx  10 lshift TIM1_CCMR2_Input        \ TIM1_IC4PSC	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift TIM1_CCMR2_Input        \ TIM1_CC4S	Bit Offset:8	Bit Width:2
        \ %xxxx  4 lshift TIM1_CCMR2_Input        \ TIM1_IC3F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM1_CCMR2_Input        \ TIM1_IC3PSC	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM1_CCMR2_Input        \ TIM1_CC3S	Bit Offset:0	Bit Width:2
        
        TIM1 $20 + constant TIM1_CCER	\ read-write		\  : RESET_TIM1_CCER $0000 
        \ %x  13 lshift TIM1_CCER        \ TIM1_CC4P	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM1_CCER        \ TIM1_CC4E	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM1_CCER        \ TIM1_CC3NP	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_CCER        \ TIM1_CC3NE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM1_CCER        \ TIM1_CC3P	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM1_CCER        \ TIM1_CC3E	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TIM1_CCER        \ TIM1_CC2NP	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM1_CCER        \ TIM1_CC2NE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM1_CCER        \ TIM1_CC2P	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TIM1_CCER        \ TIM1_CC2E	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM1_CCER        \ TIM1_CC1NP	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM1_CCER        \ TIM1_CC1NE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM1_CCER        \ TIM1_CC1P	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM1_CCER        \ TIM1_CC1E	Bit Offset:0	Bit Width:1
        
        TIM1 $24 + constant TIM1_CNT	\ read-write		\  : RESET_TIM1_CNT $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CNT        \ TIM1_CNT	Bit Offset:0	Bit Width:16
        
        TIM1 $28 + constant TIM1_PSC	\ read-write		\  : RESET_TIM1_PSC $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_PSC        \ TIM1_PSC	Bit Offset:0	Bit Width:16
        
        TIM1 $2C + constant TIM1_ARR	\ read-write		\  : RESET_TIM1_ARR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_ARR        \ TIM1_ARR	Bit Offset:0	Bit Width:16
        
        TIM1 $30 + constant TIM1_RCR	\ read-write		\  : RESET_TIM1_RCR $0000 
        \ %xxxxxxxx  0 lshift TIM1_RCR        \ TIM1_REP	Bit Offset:0	Bit Width:8
        
        TIM1 $34 + constant TIM1_CCR1	\ read-write		\  : RESET_TIM1_CCR1 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR1        \ TIM1_CCR1	Bit Offset:0	Bit Width:16
        
        TIM1 $38 + constant TIM1_CCR2	\ read-write		\  : RESET_TIM1_CCR2 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR2        \ TIM1_CCR2	Bit Offset:0	Bit Width:16
        
        TIM1 $3C + constant TIM1_CCR3	\ read-write		\  : RESET_TIM1_CCR3 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR3        \ TIM1_CCR3	Bit Offset:0	Bit Width:16
        
        TIM1 $40 + constant TIM1_CCR4	\ read-write		\  : RESET_TIM1_CCR4 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR4        \ TIM1_CCR4	Bit Offset:0	Bit Width:16
        
        TIM1 $44 + constant TIM1_BDTR	\ read-write		\  : RESET_TIM1_BDTR $0000 
        \ %x  15 lshift TIM1_BDTR        \ TIM1_MOE	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TIM1_BDTR        \ TIM1_AOE	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TIM1_BDTR        \ TIM1_BKP	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM1_BDTR        \ TIM1_BKE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM1_BDTR        \ TIM1_OSSR	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM1_BDTR        \ TIM1_OSSI	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM1_BDTR        \ TIM1_LOCK	Bit Offset:8	Bit Width:2
        \ %xxxxxxxx  0 lshift TIM1_BDTR        \ TIM1_DTG	Bit Offset:0	Bit Width:8
        
        TIM1 $48 + constant TIM1_DCR	\ read-write		\  : RESET_TIM1_DCR $0000 
        \ %xxxxx  8 lshift TIM1_DCR        \ TIM1_DBL	Bit Offset:8	Bit Width:5
        \ %xxxxx  0 lshift TIM1_DCR        \ TIM1_DBA	Bit Offset:0	Bit Width:5
        
        TIM1 $4C + constant TIM1_DMAR	\ read-write		\  : RESET_TIM1_DMAR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM1_DMAR        \ TIM1_DMAB	Bit Offset:0	Bit Width:16
        
         
	
     $40000000 constant TIM2  
	 TIM2 $0 + constant TIM2_CR1	\ read-write		\  : RESET_TIM2_CR1 $0000 
        \ %xx  8 lshift TIM2_CR1        \ TIM2_CKD	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM2_CR1        \ TIM2_ARPE	Bit Offset:7	Bit Width:1
        \ %xx  5 lshift TIM2_CR1        \ TIM2_CMS	Bit Offset:5	Bit Width:2
        \ %x  4 lshift TIM2_CR1        \ TIM2_DIR	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM2_CR1        \ TIM2_OPM	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM2_CR1        \ TIM2_URS	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM2_CR1        \ TIM2_UDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM2_CR1        \ TIM2_CEN	Bit Offset:0	Bit Width:1
        
        TIM2 $4 + constant TIM2_CR2	\ read-write		\  : RESET_TIM2_CR2 $0000 
        \ %x  7 lshift TIM2_CR2        \ TIM2_TI1S	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM2_CR2        \ TIM2_MMS	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM2_CR2        \ TIM2_CCDS	Bit Offset:3	Bit Width:1
        
        TIM2 $8 + constant TIM2_SMCR	\ read-write		\  : RESET_TIM2_SMCR $0000 
        \ %x  15 lshift TIM2_SMCR        \ TIM2_ETP	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TIM2_SMCR        \ TIM2_ECE	Bit Offset:14	Bit Width:1
        \ %xx  12 lshift TIM2_SMCR        \ TIM2_ETPS	Bit Offset:12	Bit Width:2
        \ %xxxx  8 lshift TIM2_SMCR        \ TIM2_ETF	Bit Offset:8	Bit Width:4
        \ %x  7 lshift TIM2_SMCR        \ TIM2_MSM	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM2_SMCR        \ TIM2_TS	Bit Offset:4	Bit Width:3
        \ %xxx  0 lshift TIM2_SMCR        \ TIM2_SMS	Bit Offset:0	Bit Width:3
        
        TIM2 $C + constant TIM2_DIER	\ read-write		\  : RESET_TIM2_DIER $0000 
        \ %x  14 lshift TIM2_DIER        \ TIM2_TDE	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TIM2_DIER        \ TIM2_COMDE	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM2_DIER        \ TIM2_CC4DE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM2_DIER        \ TIM2_CC3DE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM2_DIER        \ TIM2_CC2DE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM2_DIER        \ TIM2_CC1DE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM2_DIER        \ TIM2_UDE	Bit Offset:8	Bit Width:1
        \ %x  6 lshift TIM2_DIER        \ TIM2_TIE	Bit Offset:6	Bit Width:1
        \ %x  4 lshift TIM2_DIER        \ TIM2_CC4IE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM2_DIER        \ TIM2_CC3IE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM2_DIER        \ TIM2_CC2IE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM2_DIER        \ TIM2_CC1IE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM2_DIER        \ TIM2_UIE	Bit Offset:0	Bit Width:1
        
        TIM2 $10 + constant TIM2_SR	\ read-write		\  : RESET_TIM2_SR $0000 
        \ %x  12 lshift TIM2_SR        \ TIM2_CC4OF	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM2_SR        \ TIM2_CC3OF	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM2_SR        \ TIM2_CC2OF	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM2_SR        \ TIM2_CC1OF	Bit Offset:9	Bit Width:1
        \ %x  6 lshift TIM2_SR        \ TIM2_TIF	Bit Offset:6	Bit Width:1
        \ %x  4 lshift TIM2_SR        \ TIM2_CC4IF	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM2_SR        \ TIM2_CC3IF	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM2_SR        \ TIM2_CC2IF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM2_SR        \ TIM2_CC1IF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM2_SR        \ TIM2_UIF	Bit Offset:0	Bit Width:1
        
        TIM2 $14 + constant TIM2_EGR	\ write-only		\  : RESET_TIM2_EGR $0000 
        \ %x  6 lshift TIM2_EGR        \ TIM2_TG	Bit Offset:6	Bit Width:1
        \ %x  4 lshift TIM2_EGR        \ TIM2_CC4G	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM2_EGR        \ TIM2_CC3G	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM2_EGR        \ TIM2_CC2G	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM2_EGR        \ TIM2_CC1G	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM2_EGR        \ TIM2_UG	Bit Offset:0	Bit Width:1
        
        TIM2 $18 + constant TIM2_CCMR1_Output	\ read-write		\  : RESET_TIM2_CCMR1_Output $00000000 
        \ %x  15 lshift TIM2_CCMR1_Output        \ TIM2_OC2CE	Bit Offset:15	Bit Width:1
        \ %xxx  12 lshift TIM2_CCMR1_Output        \ TIM2_OC2M	Bit Offset:12	Bit Width:3
        \ %x  11 lshift TIM2_CCMR1_Output        \ TIM2_OC2PE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM2_CCMR1_Output        \ TIM2_OC2FE	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM2_CCMR1_Output        \ TIM2_CC2S	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM2_CCMR1_Output        \ TIM2_OC1CE	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM2_CCMR1_Output        \ TIM2_OC1M	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM2_CCMR1_Output        \ TIM2_OC1PE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM2_CCMR1_Output        \ TIM2_OC1FE	Bit Offset:2	Bit Width:1
        \ %xx  0 lshift TIM2_CCMR1_Output        \ TIM2_CC1S	Bit Offset:0	Bit Width:2
        
        TIM2 $18 + constant TIM2_CCMR1_Input	\ read-write		\  : RESET_TIM2_CCMR1_Input $00000000 
        \ %xxxx  12 lshift TIM2_CCMR1_Input        \ TIM2_IC2F	Bit Offset:12	Bit Width:4
        \ %xx  10 lshift TIM2_CCMR1_Input        \ TIM2_IC2PSC	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift TIM2_CCMR1_Input        \ TIM2_CC2S	Bit Offset:8	Bit Width:2
        \ %xxxx  4 lshift TIM2_CCMR1_Input        \ TIM2_IC1F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM2_CCMR1_Input        \ TIM2_IC1PSC	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM2_CCMR1_Input        \ TIM2_CC1S	Bit Offset:0	Bit Width:2
        
        TIM2 $1C + constant TIM2_CCMR2_Output	\ read-write		\  : RESET_TIM2_CCMR2_Output $00000000 
        \ %x  15 lshift TIM2_CCMR2_Output        \ TIM2_OC4CE	Bit Offset:15	Bit Width:1
        \ %xxx  12 lshift TIM2_CCMR2_Output        \ TIM2_OC4M	Bit Offset:12	Bit Width:3
        \ %x  11 lshift TIM2_CCMR2_Output        \ TIM2_OC4PE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM2_CCMR2_Output        \ TIM2_OC4FE	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM2_CCMR2_Output        \ TIM2_CC4S	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM2_CCMR2_Output        \ TIM2_OC3CE	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM2_CCMR2_Output        \ TIM2_OC3M	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM2_CCMR2_Output        \ TIM2_OC3PE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM2_CCMR2_Output        \ TIM2_OC3FE	Bit Offset:2	Bit Width:1
        \ %xx  0 lshift TIM2_CCMR2_Output        \ TIM2_CC3S	Bit Offset:0	Bit Width:2
        
        TIM2 $1C + constant TIM2_CCMR2_Input	\ read-write		\  : RESET_TIM2_CCMR2_Input $00000000 
        \ %xxxx  12 lshift TIM2_CCMR2_Input        \ TIM2_IC4F	Bit Offset:12	Bit Width:4
        \ %xx  10 lshift TIM2_CCMR2_Input        \ TIM2_IC4PSC	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift TIM2_CCMR2_Input        \ TIM2_CC4S	Bit Offset:8	Bit Width:2
        \ %xxxx  4 lshift TIM2_CCMR2_Input        \ TIM2_IC3F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM2_CCMR2_Input        \ TIM2_IC3PSC	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM2_CCMR2_Input        \ TIM2_CC3S	Bit Offset:0	Bit Width:2
        
        TIM2 $20 + constant TIM2_CCER	\ read-write		\  : RESET_TIM2_CCER $0000 
        \ %x  15 lshift TIM2_CCER        \ TIM2_CC4NP	Bit Offset:15	Bit Width:1
        \ %x  13 lshift TIM2_CCER        \ TIM2_CC4P	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM2_CCER        \ TIM2_CC4E	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM2_CCER        \ TIM2_CC3NP	Bit Offset:11	Bit Width:1
        \ %x  9 lshift TIM2_CCER        \ TIM2_CC3P	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM2_CCER        \ TIM2_CC3E	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TIM2_CCER        \ TIM2_CC2NP	Bit Offset:7	Bit Width:1
        \ %x  5 lshift TIM2_CCER        \ TIM2_CC2P	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TIM2_CCER        \ TIM2_CC2E	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM2_CCER        \ TIM2_CC1NP	Bit Offset:3	Bit Width:1
        \ %x  1 lshift TIM2_CCER        \ TIM2_CC1P	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM2_CCER        \ TIM2_CC1E	Bit Offset:0	Bit Width:1
        
        TIM2 $24 + constant TIM2_CNT	\ read-write		\  : RESET_TIM2_CNT $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift TIM2_CNT        \ TIM2_CNT_H	Bit Offset:16	Bit Width:16
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CNT        \ TIM2_CNT_L	Bit Offset:0	Bit Width:16
        
        TIM2 $28 + constant TIM2_PSC	\ read-write		\  : RESET_TIM2_PSC $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_PSC        \ TIM2_PSC	Bit Offset:0	Bit Width:16
        
        TIM2 $2C + constant TIM2_ARR	\ read-write		\  : RESET_TIM2_ARR $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift TIM2_ARR        \ TIM2_ARR_H	Bit Offset:16	Bit Width:16
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_ARR        \ TIM2_ARR_L	Bit Offset:0	Bit Width:16
        
        TIM2 $34 + constant TIM2_CCR1	\ read-write		\  : RESET_TIM2_CCR1 $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift TIM2_CCR1        \ TIM2_CCR1_H	Bit Offset:16	Bit Width:16
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR1        \ TIM2_CCR1_L	Bit Offset:0	Bit Width:16
        
        TIM2 $38 + constant TIM2_CCR2	\ read-write		\  : RESET_TIM2_CCR2 $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift TIM2_CCR2        \ TIM2_CCR2_H	Bit Offset:16	Bit Width:16
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR2        \ TIM2_CCR2_L	Bit Offset:0	Bit Width:16
        
        TIM2 $3C + constant TIM2_CCR3	\ read-write		\  : RESET_TIM2_CCR3 $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift TIM2_CCR3        \ TIM2_CCR3_H	Bit Offset:16	Bit Width:16
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR3        \ TIM2_CCR3_L	Bit Offset:0	Bit Width:16
        
        TIM2 $40 + constant TIM2_CCR4	\ read-write		\  : RESET_TIM2_CCR4 $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift TIM2_CCR4        \ TIM2_CCR4_H	Bit Offset:16	Bit Width:16
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR4        \ TIM2_CCR4_L	Bit Offset:0	Bit Width:16
        
        TIM2 $48 + constant TIM2_DCR	\ read-write		\  : RESET_TIM2_DCR $0000 
        \ %xxxxx  8 lshift TIM2_DCR        \ TIM2_DBL	Bit Offset:8	Bit Width:5
        \ %xxxxx  0 lshift TIM2_DCR        \ TIM2_DBA	Bit Offset:0	Bit Width:5
        
        TIM2 $4C + constant TIM2_DMAR	\ read-write		\  : RESET_TIM2_DMAR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM2_DMAR        \ TIM2_DMAR	Bit Offset:0	Bit Width:16
        
         
	
     $40000400 constant TIM3  
	  
	
     $40002000 constant TIM14  
	 TIM14 $0 + constant TIM14_CR1	\ read-write		\  : RESET_TIM14_CR1 $0000 
        \ %xx  8 lshift TIM14_CR1        \ TIM14_CKD	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM14_CR1        \ TIM14_ARPE	Bit Offset:7	Bit Width:1
        \ %x  2 lshift TIM14_CR1        \ TIM14_URS	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM14_CR1        \ TIM14_UDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM14_CR1        \ TIM14_CEN	Bit Offset:0	Bit Width:1
        
        TIM14 $C + constant TIM14_DIER	\ read-write		\  : RESET_TIM14_DIER $0000 
        \ %x  1 lshift TIM14_DIER        \ TIM14_CC1IE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM14_DIER        \ TIM14_UIE	Bit Offset:0	Bit Width:1
        
        TIM14 $10 + constant TIM14_SR	\ read-write		\  : RESET_TIM14_SR $0000 
        \ %x  9 lshift TIM14_SR        \ TIM14_CC1OF	Bit Offset:9	Bit Width:1
        \ %x  1 lshift TIM14_SR        \ TIM14_CC1IF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM14_SR        \ TIM14_UIF	Bit Offset:0	Bit Width:1
        
        TIM14 $14 + constant TIM14_EGR	\ write-only		\  : RESET_TIM14_EGR $0000 
        \ %x  1 lshift TIM14_EGR        \ TIM14_CC1G	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM14_EGR        \ TIM14_UG	Bit Offset:0	Bit Width:1
        
        TIM14 $18 + constant TIM14_CCMR1_Output	\ read-write		\  : RESET_TIM14_CCMR1_Output $00000000 
        \ %xx  0 lshift TIM14_CCMR1_Output        \ TIM14_CC1S	Bit Offset:0	Bit Width:2
        \ %x  2 lshift TIM14_CCMR1_Output        \ TIM14_OC1FE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift TIM14_CCMR1_Output        \ TIM14_OC1PE	Bit Offset:3	Bit Width:1
        \ %xxx  4 lshift TIM14_CCMR1_Output        \ TIM14_OC1M	Bit Offset:4	Bit Width:3
        
        TIM14 $18 + constant TIM14_CCMR1_Input	\ read-write		\  : RESET_TIM14_CCMR1_Input $00000000 
        \ %xxxx  4 lshift TIM14_CCMR1_Input        \ TIM14_IC1F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM14_CCMR1_Input        \ TIM14_IC1PSC	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM14_CCMR1_Input        \ TIM14_CC1S	Bit Offset:0	Bit Width:2
        
        TIM14 $20 + constant TIM14_CCER	\ read-write		\  : RESET_TIM14_CCER $0000 
        \ %x  3 lshift TIM14_CCER        \ TIM14_CC1NP	Bit Offset:3	Bit Width:1
        \ %x  1 lshift TIM14_CCER        \ TIM14_CC1P	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM14_CCER        \ TIM14_CC1E	Bit Offset:0	Bit Width:1
        
        TIM14 $24 + constant TIM14_CNT	\ read-write		\  : RESET_TIM14_CNT $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM14_CNT        \ TIM14_CNT	Bit Offset:0	Bit Width:16
        
        TIM14 $28 + constant TIM14_PSC	\ read-write		\  : RESET_TIM14_PSC $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM14_PSC        \ TIM14_PSC	Bit Offset:0	Bit Width:16
        
        TIM14 $2C + constant TIM14_ARR	\ read-write		\  : RESET_TIM14_ARR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM14_ARR        \ TIM14_ARR	Bit Offset:0	Bit Width:16
        
        TIM14 $34 + constant TIM14_CCR1	\ read-write		\  : RESET_TIM14_CCR1 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM14_CCR1        \ TIM14_CCR1	Bit Offset:0	Bit Width:16
        
        TIM14 $50 + constant TIM14_OR	\ read-write		\  : RESET_TIM14_OR $00000000 
        \ %xx  0 lshift TIM14_OR        \ TIM14_RMP	Bit Offset:0	Bit Width:2
        
         
	
     $40001000 constant TIM6  
	 TIM6 $0 + constant TIM6_CR1	\ read-write		\  : RESET_TIM6_CR1 $0000 
        \ %x  7 lshift TIM6_CR1        \ TIM6_ARPE	Bit Offset:7	Bit Width:1
        \ %x  3 lshift TIM6_CR1        \ TIM6_OPM	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM6_CR1        \ TIM6_URS	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM6_CR1        \ TIM6_UDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM6_CR1        \ TIM6_CEN	Bit Offset:0	Bit Width:1
        
        TIM6 $4 + constant TIM6_CR2	\ read-write		\  : RESET_TIM6_CR2 $0000 
        \ %xxx  4 lshift TIM6_CR2        \ TIM6_MMS	Bit Offset:4	Bit Width:3
        
        TIM6 $C + constant TIM6_DIER	\ read-write		\  : RESET_TIM6_DIER $0000 
        \ %x  8 lshift TIM6_DIER        \ TIM6_UDE	Bit Offset:8	Bit Width:1
        \ %x  0 lshift TIM6_DIER        \ TIM6_UIE	Bit Offset:0	Bit Width:1
        
        TIM6 $10 + constant TIM6_SR	\ read-write		\  : RESET_TIM6_SR $0000 
        \ %x  0 lshift TIM6_SR        \ TIM6_UIF	Bit Offset:0	Bit Width:1
        
        TIM6 $14 + constant TIM6_EGR	\ write-only		\  : RESET_TIM6_EGR $0000 
        \ %x  0 lshift TIM6_EGR        \ TIM6_UG	Bit Offset:0	Bit Width:1
        
        TIM6 $24 + constant TIM6_CNT	\ read-write		\  : RESET_TIM6_CNT $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM6_CNT        \ TIM6_CNT	Bit Offset:0	Bit Width:16
        
        TIM6 $28 + constant TIM6_PSC	\ read-write		\  : RESET_TIM6_PSC $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM6_PSC        \ TIM6_PSC	Bit Offset:0	Bit Width:16
        
        TIM6 $2C + constant TIM6_ARR	\ read-write		\  : RESET_TIM6_ARR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM6_ARR        \ TIM6_ARR	Bit Offset:0	Bit Width:16
        
         
	
     $40001400 constant TIM7  
	  
	
     $40010400 constant EXTI  
	 EXTI $0 + constant EXTI_IMR	\ read-write		\  : RESET_EXTI_IMR $0F940000 
        \ %x  0 lshift EXTI_IMR        \ EXTI_MR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift EXTI_IMR        \ EXTI_MR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift EXTI_IMR        \ EXTI_MR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift EXTI_IMR        \ EXTI_MR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift EXTI_IMR        \ EXTI_MR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift EXTI_IMR        \ EXTI_MR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift EXTI_IMR        \ EXTI_MR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift EXTI_IMR        \ EXTI_MR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift EXTI_IMR        \ EXTI_MR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift EXTI_IMR        \ EXTI_MR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift EXTI_IMR        \ EXTI_MR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift EXTI_IMR        \ EXTI_MR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift EXTI_IMR        \ EXTI_MR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift EXTI_IMR        \ EXTI_MR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift EXTI_IMR        \ EXTI_MR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift EXTI_IMR        \ EXTI_MR15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift EXTI_IMR        \ EXTI_MR16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift EXTI_IMR        \ EXTI_MR17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift EXTI_IMR        \ EXTI_MR18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift EXTI_IMR        \ EXTI_MR19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift EXTI_IMR        \ EXTI_MR20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift EXTI_IMR        \ EXTI_MR21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift EXTI_IMR        \ EXTI_MR22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift EXTI_IMR        \ EXTI_MR23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift EXTI_IMR        \ EXTI_MR24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift EXTI_IMR        \ EXTI_MR25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift EXTI_IMR        \ EXTI_MR26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift EXTI_IMR        \ EXTI_MR27	Bit Offset:27	Bit Width:1
        
        EXTI $4 + constant EXTI_EMR	\ read-write		\  : RESET_EXTI_EMR $00000000 
        \ %x  0 lshift EXTI_EMR        \ EXTI_MR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift EXTI_EMR        \ EXTI_MR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift EXTI_EMR        \ EXTI_MR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift EXTI_EMR        \ EXTI_MR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift EXTI_EMR        \ EXTI_MR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift EXTI_EMR        \ EXTI_MR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift EXTI_EMR        \ EXTI_MR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift EXTI_EMR        \ EXTI_MR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift EXTI_EMR        \ EXTI_MR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift EXTI_EMR        \ EXTI_MR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift EXTI_EMR        \ EXTI_MR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift EXTI_EMR        \ EXTI_MR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift EXTI_EMR        \ EXTI_MR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift EXTI_EMR        \ EXTI_MR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift EXTI_EMR        \ EXTI_MR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift EXTI_EMR        \ EXTI_MR15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift EXTI_EMR        \ EXTI_MR16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift EXTI_EMR        \ EXTI_MR17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift EXTI_EMR        \ EXTI_MR18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift EXTI_EMR        \ EXTI_MR19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift EXTI_EMR        \ EXTI_MR20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift EXTI_EMR        \ EXTI_MR21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift EXTI_EMR        \ EXTI_MR22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift EXTI_EMR        \ EXTI_MR23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift EXTI_EMR        \ EXTI_MR24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift EXTI_EMR        \ EXTI_MR25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift EXTI_EMR        \ EXTI_MR26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift EXTI_EMR        \ EXTI_MR27	Bit Offset:27	Bit Width:1
        
        EXTI $8 + constant EXTI_RTSR	\ read-write		\  : RESET_EXTI_RTSR $00000000 
        \ %x  0 lshift EXTI_RTSR        \ EXTI_TR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift EXTI_RTSR        \ EXTI_TR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift EXTI_RTSR        \ EXTI_TR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift EXTI_RTSR        \ EXTI_TR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift EXTI_RTSR        \ EXTI_TR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift EXTI_RTSR        \ EXTI_TR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift EXTI_RTSR        \ EXTI_TR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift EXTI_RTSR        \ EXTI_TR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift EXTI_RTSR        \ EXTI_TR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift EXTI_RTSR        \ EXTI_TR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift EXTI_RTSR        \ EXTI_TR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift EXTI_RTSR        \ EXTI_TR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift EXTI_RTSR        \ EXTI_TR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift EXTI_RTSR        \ EXTI_TR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift EXTI_RTSR        \ EXTI_TR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift EXTI_RTSR        \ EXTI_TR15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift EXTI_RTSR        \ EXTI_TR16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift EXTI_RTSR        \ EXTI_TR17	Bit Offset:17	Bit Width:1
        \ %x  19 lshift EXTI_RTSR        \ EXTI_TR19	Bit Offset:19	Bit Width:1
        
        EXTI $C + constant EXTI_FTSR	\ read-write		\  : RESET_EXTI_FTSR $00000000 
        \ %x  0 lshift EXTI_FTSR        \ EXTI_TR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift EXTI_FTSR        \ EXTI_TR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift EXTI_FTSR        \ EXTI_TR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift EXTI_FTSR        \ EXTI_TR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift EXTI_FTSR        \ EXTI_TR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift EXTI_FTSR        \ EXTI_TR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift EXTI_FTSR        \ EXTI_TR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift EXTI_FTSR        \ EXTI_TR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift EXTI_FTSR        \ EXTI_TR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift EXTI_FTSR        \ EXTI_TR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift EXTI_FTSR        \ EXTI_TR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift EXTI_FTSR        \ EXTI_TR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift EXTI_FTSR        \ EXTI_TR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift EXTI_FTSR        \ EXTI_TR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift EXTI_FTSR        \ EXTI_TR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift EXTI_FTSR        \ EXTI_TR15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift EXTI_FTSR        \ EXTI_TR16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift EXTI_FTSR        \ EXTI_TR17	Bit Offset:17	Bit Width:1
        \ %x  19 lshift EXTI_FTSR        \ EXTI_TR19	Bit Offset:19	Bit Width:1
        
        EXTI $10 + constant EXTI_SWIER	\ read-write		\  : RESET_EXTI_SWIER $00000000 
        \ %x  0 lshift EXTI_SWIER        \ EXTI_SWIER0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift EXTI_SWIER        \ EXTI_SWIER1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift EXTI_SWIER        \ EXTI_SWIER2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift EXTI_SWIER        \ EXTI_SWIER3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift EXTI_SWIER        \ EXTI_SWIER4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift EXTI_SWIER        \ EXTI_SWIER5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift EXTI_SWIER        \ EXTI_SWIER6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift EXTI_SWIER        \ EXTI_SWIER7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift EXTI_SWIER        \ EXTI_SWIER8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift EXTI_SWIER        \ EXTI_SWIER9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift EXTI_SWIER        \ EXTI_SWIER10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift EXTI_SWIER        \ EXTI_SWIER11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift EXTI_SWIER        \ EXTI_SWIER12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift EXTI_SWIER        \ EXTI_SWIER13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift EXTI_SWIER        \ EXTI_SWIER14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift EXTI_SWIER        \ EXTI_SWIER15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift EXTI_SWIER        \ EXTI_SWIER16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift EXTI_SWIER        \ EXTI_SWIER17	Bit Offset:17	Bit Width:1
        \ %x  19 lshift EXTI_SWIER        \ EXTI_SWIER19	Bit Offset:19	Bit Width:1
        
        EXTI $14 + constant EXTI_PR	\ read-write		\  : RESET_EXTI_PR $00000000 
        \ %x  0 lshift EXTI_PR        \ EXTI_PR0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift EXTI_PR        \ EXTI_PR1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift EXTI_PR        \ EXTI_PR2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift EXTI_PR        \ EXTI_PR3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift EXTI_PR        \ EXTI_PR4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift EXTI_PR        \ EXTI_PR5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift EXTI_PR        \ EXTI_PR6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift EXTI_PR        \ EXTI_PR7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift EXTI_PR        \ EXTI_PR8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift EXTI_PR        \ EXTI_PR9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift EXTI_PR        \ EXTI_PR10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift EXTI_PR        \ EXTI_PR11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift EXTI_PR        \ EXTI_PR12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift EXTI_PR        \ EXTI_PR13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift EXTI_PR        \ EXTI_PR14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift EXTI_PR        \ EXTI_PR15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift EXTI_PR        \ EXTI_PR16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift EXTI_PR        \ EXTI_PR17	Bit Offset:17	Bit Width:1
        \ %x  19 lshift EXTI_PR        \ EXTI_PR19	Bit Offset:19	Bit Width:1
        
         
	
     $E000E100 constant NVIC  
	 NVIC $0 + constant NVIC_ISER	\ read-write		\  : RESET_NVIC_ISER $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ISER        \ NVIC_SETENA	Bit Offset:0	Bit Width:32
        
        NVIC $80 + constant NVIC_ICER	\ read-write		\  : RESET_NVIC_ICER $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ICER        \ NVIC_CLRENA	Bit Offset:0	Bit Width:32
        
        NVIC $100 + constant NVIC_ISPR	\ read-write		\  : RESET_NVIC_ISPR $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ISPR        \ NVIC_SETPEND	Bit Offset:0	Bit Width:32
        
        NVIC $180 + constant NVIC_ICPR	\ read-write		\  : RESET_NVIC_ICPR $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ICPR        \ NVIC_CLRPEND	Bit Offset:0	Bit Width:32
        
        NVIC $300 + constant NVIC_IPR0	\ read-write		\  : RESET_NVIC_IPR0 $00000000 
        \ %xx  6 lshift NVIC_IPR0        \ NVIC_PRI_00	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR0        \ NVIC_PRI_01	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR0        \ NVIC_PRI_02	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR0        \ NVIC_PRI_03	Bit Offset:30	Bit Width:2
        
        NVIC $304 + constant NVIC_IPR1	\ read-write		\  : RESET_NVIC_IPR1 $00000000 
        \ %xx  6 lshift NVIC_IPR1        \ NVIC_PRI_40	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR1        \ NVIC_PRI_41	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR1        \ NVIC_PRI_42	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR1        \ NVIC_PRI_43	Bit Offset:30	Bit Width:2
        
        NVIC $308 + constant NVIC_IPR2	\ read-write		\  : RESET_NVIC_IPR2 $00000000 
        \ %xx  6 lshift NVIC_IPR2        \ NVIC_PRI_80	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR2        \ NVIC_PRI_81	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR2        \ NVIC_PRI_82	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR2        \ NVIC_PRI_83	Bit Offset:30	Bit Width:2
        
        NVIC $30C + constant NVIC_IPR3	\ read-write		\  : RESET_NVIC_IPR3 $00000000 
        \ %xx  6 lshift NVIC_IPR3        \ NVIC_PRI_120	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR3        \ NVIC_PRI_121	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR3        \ NVIC_PRI_122	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR3        \ NVIC_PRI_123	Bit Offset:30	Bit Width:2
        
        NVIC $310 + constant NVIC_IPR4	\ read-write		\  : RESET_NVIC_IPR4 $00000000 
        \ %xx  6 lshift NVIC_IPR4        \ NVIC_PRI_160	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR4        \ NVIC_PRI_161	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR4        \ NVIC_PRI_162	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR4        \ NVIC_PRI_163	Bit Offset:30	Bit Width:2
        
        NVIC $314 + constant NVIC_IPR5	\ read-write		\  : RESET_NVIC_IPR5 $00000000 
        \ %xx  6 lshift NVIC_IPR5        \ NVIC_PRI_200	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR5        \ NVIC_PRI_201	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR5        \ NVIC_PRI_202	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR5        \ NVIC_PRI_203	Bit Offset:30	Bit Width:2
        
        NVIC $318 + constant NVIC_IPR6	\ read-write		\  : RESET_NVIC_IPR6 $00000000 
        \ %xx  6 lshift NVIC_IPR6        \ NVIC_PRI_240	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR6        \ NVIC_PRI_241	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR6        \ NVIC_PRI_242	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR6        \ NVIC_PRI_243	Bit Offset:30	Bit Width:2
        
        NVIC $31C + constant NVIC_IPR7	\ read-write		\  : RESET_NVIC_IPR7 $00000000 
        \ %xx  6 lshift NVIC_IPR7        \ NVIC_PRI_280	Bit Offset:6	Bit Width:2
        \ %xx  14 lshift NVIC_IPR7        \ NVIC_PRI_281	Bit Offset:14	Bit Width:2
        \ %xx  22 lshift NVIC_IPR7        \ NVIC_PRI_282	Bit Offset:22	Bit Width:2
        \ %xx  30 lshift NVIC_IPR7        \ NVIC_PRI_283	Bit Offset:30	Bit Width:2
        
         
	
     $40020000 constant DMA  
	 DMA $0 + constant DMA_ISR	\ read-only		\  : RESET_DMA_ISR $00000000 
        \ %x  0 lshift DMA_ISR        \ DMA_GIF1	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_ISR        \ DMA_TCIF1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_ISR        \ DMA_HTIF1	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_ISR        \ DMA_TEIF1	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_ISR        \ DMA_GIF2	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_ISR        \ DMA_TCIF2	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_ISR        \ DMA_HTIF2	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_ISR        \ DMA_TEIF2	Bit Offset:7	Bit Width:1
        \ %x  8 lshift DMA_ISR        \ DMA_GIF3	Bit Offset:8	Bit Width:1
        \ %x  9 lshift DMA_ISR        \ DMA_TCIF3	Bit Offset:9	Bit Width:1
        \ %x  10 lshift DMA_ISR        \ DMA_HTIF3	Bit Offset:10	Bit Width:1
        \ %x  11 lshift DMA_ISR        \ DMA_TEIF3	Bit Offset:11	Bit Width:1
        \ %x  12 lshift DMA_ISR        \ DMA_GIF4	Bit Offset:12	Bit Width:1
        \ %x  13 lshift DMA_ISR        \ DMA_TCIF4	Bit Offset:13	Bit Width:1
        \ %x  14 lshift DMA_ISR        \ DMA_HTIF4	Bit Offset:14	Bit Width:1
        \ %x  15 lshift DMA_ISR        \ DMA_TEIF4	Bit Offset:15	Bit Width:1
        \ %x  16 lshift DMA_ISR        \ DMA_GIF5	Bit Offset:16	Bit Width:1
        \ %x  17 lshift DMA_ISR        \ DMA_TCIF5	Bit Offset:17	Bit Width:1
        \ %x  18 lshift DMA_ISR        \ DMA_HTIF5	Bit Offset:18	Bit Width:1
        \ %x  19 lshift DMA_ISR        \ DMA_TEIF5	Bit Offset:19	Bit Width:1
        \ %x  20 lshift DMA_ISR        \ DMA_GIF6	Bit Offset:20	Bit Width:1
        \ %x  21 lshift DMA_ISR        \ DMA_TCIF6	Bit Offset:21	Bit Width:1
        \ %x  22 lshift DMA_ISR        \ DMA_HTIF6	Bit Offset:22	Bit Width:1
        \ %x  23 lshift DMA_ISR        \ DMA_TEIF6	Bit Offset:23	Bit Width:1
        \ %x  24 lshift DMA_ISR        \ DMA_GIF7	Bit Offset:24	Bit Width:1
        \ %x  25 lshift DMA_ISR        \ DMA_TCIF7	Bit Offset:25	Bit Width:1
        \ %x  26 lshift DMA_ISR        \ DMA_HTIF7	Bit Offset:26	Bit Width:1
        \ %x  27 lshift DMA_ISR        \ DMA_TEIF7	Bit Offset:27	Bit Width:1
        
        DMA $4 + constant DMA_IFCR	\ write-only		\  : RESET_DMA_IFCR $00000000 
        \ %x  0 lshift DMA_IFCR        \ DMA_CGIF1	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_IFCR        \ DMA_CTCIF1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_IFCR        \ DMA_CHTIF1	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_IFCR        \ DMA_CTEIF1	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_IFCR        \ DMA_CGIF2	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_IFCR        \ DMA_CTCIF2	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_IFCR        \ DMA_CHTIF2	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_IFCR        \ DMA_CTEIF2	Bit Offset:7	Bit Width:1
        \ %x  8 lshift DMA_IFCR        \ DMA_CGIF3	Bit Offset:8	Bit Width:1
        \ %x  9 lshift DMA_IFCR        \ DMA_CTCIF3	Bit Offset:9	Bit Width:1
        \ %x  10 lshift DMA_IFCR        \ DMA_CHTIF3	Bit Offset:10	Bit Width:1
        \ %x  11 lshift DMA_IFCR        \ DMA_CTEIF3	Bit Offset:11	Bit Width:1
        \ %x  12 lshift DMA_IFCR        \ DMA_CGIF4	Bit Offset:12	Bit Width:1
        \ %x  13 lshift DMA_IFCR        \ DMA_CTCIF4	Bit Offset:13	Bit Width:1
        \ %x  14 lshift DMA_IFCR        \ DMA_CHTIF4	Bit Offset:14	Bit Width:1
        \ %x  15 lshift DMA_IFCR        \ DMA_CTEIF4	Bit Offset:15	Bit Width:1
        \ %x  16 lshift DMA_IFCR        \ DMA_CGIF5	Bit Offset:16	Bit Width:1
        \ %x  17 lshift DMA_IFCR        \ DMA_CTCIF5	Bit Offset:17	Bit Width:1
        \ %x  18 lshift DMA_IFCR        \ DMA_CHTIF5	Bit Offset:18	Bit Width:1
        \ %x  19 lshift DMA_IFCR        \ DMA_CTEIF5	Bit Offset:19	Bit Width:1
        \ %x  20 lshift DMA_IFCR        \ DMA_CGIF6	Bit Offset:20	Bit Width:1
        \ %x  21 lshift DMA_IFCR        \ DMA_CTCIF6	Bit Offset:21	Bit Width:1
        \ %x  22 lshift DMA_IFCR        \ DMA_CHTIF6	Bit Offset:22	Bit Width:1
        \ %x  23 lshift DMA_IFCR        \ DMA_CTEIF6	Bit Offset:23	Bit Width:1
        \ %x  24 lshift DMA_IFCR        \ DMA_CGIF7	Bit Offset:24	Bit Width:1
        \ %x  25 lshift DMA_IFCR        \ DMA_CTCIF7	Bit Offset:25	Bit Width:1
        \ %x  26 lshift DMA_IFCR        \ DMA_CHTIF7	Bit Offset:26	Bit Width:1
        \ %x  27 lshift DMA_IFCR        \ DMA_CTEIF7	Bit Offset:27	Bit Width:1
        
        DMA $8 + constant DMA_CCR1	\ read-write		\  : RESET_DMA_CCR1 $00000000 
        \ %x  0 lshift DMA_CCR1        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR1        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR1        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR1        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR1        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR1        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR1        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR1        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR1        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR1        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR1        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR1        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $C + constant DMA_CNDTR1	\ read-write		\  : RESET_DMA_CNDTR1 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR1        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $10 + constant DMA_CPAR1	\ read-write		\  : RESET_DMA_CPAR1 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR1        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $14 + constant DMA_CMAR1	\ read-write		\  : RESET_DMA_CMAR1 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR1        \ DMA_MA	Bit Offset:0	Bit Width:32
        
        DMA $1C + constant DMA_CCR2	\ read-write		\  : RESET_DMA_CCR2 $00000000 
        \ %x  0 lshift DMA_CCR2        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR2        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR2        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR2        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR2        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR2        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR2        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR2        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR2        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR2        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR2        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR2        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $20 + constant DMA_CNDTR2	\ read-write		\  : RESET_DMA_CNDTR2 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR2        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $24 + constant DMA_CPAR2	\ read-write		\  : RESET_DMA_CPAR2 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR2        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $28 + constant DMA_CMAR2	\ read-write		\  : RESET_DMA_CMAR2 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR2        \ DMA_MA	Bit Offset:0	Bit Width:32
        
        DMA $30 + constant DMA_CCR3	\ read-write		\  : RESET_DMA_CCR3 $00000000 
        \ %x  0 lshift DMA_CCR3        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR3        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR3        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR3        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR3        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR3        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR3        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR3        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR3        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR3        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR3        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR3        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $34 + constant DMA_CNDTR3	\ read-write		\  : RESET_DMA_CNDTR3 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR3        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $38 + constant DMA_CPAR3	\ read-write		\  : RESET_DMA_CPAR3 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR3        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $3C + constant DMA_CMAR3	\ read-write		\  : RESET_DMA_CMAR3 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR3        \ DMA_MA	Bit Offset:0	Bit Width:32
        
        DMA $44 + constant DMA_CCR4	\ read-write		\  : RESET_DMA_CCR4 $00000000 
        \ %x  0 lshift DMA_CCR4        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR4        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR4        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR4        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR4        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR4        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR4        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR4        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR4        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR4        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR4        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR4        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $48 + constant DMA_CNDTR4	\ read-write		\  : RESET_DMA_CNDTR4 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR4        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $4C + constant DMA_CPAR4	\ read-write		\  : RESET_DMA_CPAR4 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR4        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $50 + constant DMA_CMAR4	\ read-write		\  : RESET_DMA_CMAR4 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR4        \ DMA_MA	Bit Offset:0	Bit Width:32
        
        DMA $58 + constant DMA_CCR5	\ read-write		\  : RESET_DMA_CCR5 $00000000 
        \ %x  0 lshift DMA_CCR5        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR5        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR5        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR5        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR5        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR5        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR5        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR5        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR5        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR5        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR5        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR5        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $5C + constant DMA_CNDTR5	\ read-write		\  : RESET_DMA_CNDTR5 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR5        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $60 + constant DMA_CPAR5	\ read-write		\  : RESET_DMA_CPAR5 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR5        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $64 + constant DMA_CMAR5	\ read-write		\  : RESET_DMA_CMAR5 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR5        \ DMA_MA	Bit Offset:0	Bit Width:32
        
        DMA $6C + constant DMA_CCR6	\ read-write		\  : RESET_DMA_CCR6 $00000000 
        \ %x  0 lshift DMA_CCR6        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR6        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR6        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR6        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR6        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR6        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR6        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR6        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR6        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR6        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR6        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR6        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $70 + constant DMA_CNDTR6	\ read-write		\  : RESET_DMA_CNDTR6 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR6        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $74 + constant DMA_CPAR6	\ read-write		\  : RESET_DMA_CPAR6 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR6        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $78 + constant DMA_CMAR6	\ read-write		\  : RESET_DMA_CMAR6 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR6        \ DMA_MA	Bit Offset:0	Bit Width:32
        
        DMA $80 + constant DMA_CCR7	\ read-write		\  : RESET_DMA_CCR7 $00000000 
        \ %x  0 lshift DMA_CCR7        \ DMA_EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DMA_CCR7        \ DMA_TCIE	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DMA_CCR7        \ DMA_HTIE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift DMA_CCR7        \ DMA_TEIE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift DMA_CCR7        \ DMA_DIR	Bit Offset:4	Bit Width:1
        \ %x  5 lshift DMA_CCR7        \ DMA_CIRC	Bit Offset:5	Bit Width:1
        \ %x  6 lshift DMA_CCR7        \ DMA_PINC	Bit Offset:6	Bit Width:1
        \ %x  7 lshift DMA_CCR7        \ DMA_MINC	Bit Offset:7	Bit Width:1
        \ %xx  8 lshift DMA_CCR7        \ DMA_PSIZE	Bit Offset:8	Bit Width:2
        \ %xx  10 lshift DMA_CCR7        \ DMA_MSIZE	Bit Offset:10	Bit Width:2
        \ %xx  12 lshift DMA_CCR7        \ DMA_PL	Bit Offset:12	Bit Width:2
        \ %x  14 lshift DMA_CCR7        \ DMA_MEM2MEM	Bit Offset:14	Bit Width:1
        
        DMA $84 + constant DMA_CNDTR7	\ read-write		\  : RESET_DMA_CNDTR7 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift DMA_CNDTR7        \ DMA_NDT	Bit Offset:0	Bit Width:16
        
        DMA $88 + constant DMA_CPAR7	\ read-write		\  : RESET_DMA_CPAR7 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CPAR7        \ DMA_PA	Bit Offset:0	Bit Width:32
        
        DMA $8C + constant DMA_CMAR7	\ read-write		\  : RESET_DMA_CMAR7 $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA_CMAR7        \ DMA_MA	Bit Offset:0	Bit Width:32
        
         
	
     $40021000 constant RCC  
	 RCC $0 + constant RCC_CR	\ 		\  : RESET_RCC_CR $00000083 
        \ %x  0 lshift RCC_CR        \ RCC_HSION	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_CR        \ RCC_HSIRDY	Bit Offset:1	Bit Width:1
        \ %xxxxx  3 lshift RCC_CR        \ RCC_HSITRIM	Bit Offset:3	Bit Width:5
        \ %xxxxxxxx  8 lshift RCC_CR        \ RCC_HSICAL	Bit Offset:8	Bit Width:8
        \ %x  16 lshift RCC_CR        \ RCC_HSEON	Bit Offset:16	Bit Width:1
        \ %x  17 lshift RCC_CR        \ RCC_HSERDY	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_CR        \ RCC_HSEBYP	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RCC_CR        \ RCC_CSSON	Bit Offset:19	Bit Width:1
        \ %x  24 lshift RCC_CR        \ RCC_PLLON	Bit Offset:24	Bit Width:1
        \ %x  25 lshift RCC_CR        \ RCC_PLLRDY	Bit Offset:25	Bit Width:1
        
        RCC $4 + constant RCC_CFGR	\ 		\  : RESET_RCC_CFGR $00000000 
        \ %xx  0 lshift RCC_CFGR        \ RCC_SW	Bit Offset:0	Bit Width:2
        \ %xx  2 lshift RCC_CFGR        \ RCC_SWS	Bit Offset:2	Bit Width:2
        \ %xxxx  4 lshift RCC_CFGR        \ RCC_HPRE	Bit Offset:4	Bit Width:4
        \ %xxx  8 lshift RCC_CFGR        \ RCC_PPRE	Bit Offset:8	Bit Width:3
        \ %x  14 lshift RCC_CFGR        \ RCC_ADCPRE	Bit Offset:14	Bit Width:1
        \ %xx  15 lshift RCC_CFGR        \ RCC_PLLSRC	Bit Offset:15	Bit Width:2
        \ %x  17 lshift RCC_CFGR        \ RCC_PLLXTPRE	Bit Offset:17	Bit Width:1
        \ %xxxx  18 lshift RCC_CFGR        \ RCC_PLLMUL	Bit Offset:18	Bit Width:4
        \ %xxx  24 lshift RCC_CFGR        \ RCC_MCO	Bit Offset:24	Bit Width:3
        \ %xxx  28 lshift RCC_CFGR        \ RCC_MCOPRE	Bit Offset:28	Bit Width:3
        \ %x  31 lshift RCC_CFGR        \ RCC_PLLNODIV	Bit Offset:31	Bit Width:1
        
        RCC $8 + constant RCC_CIR	\ 		\  : RESET_RCC_CIR $00000000 
        \ %x  0 lshift RCC_CIR        \ RCC_LSIRDYF	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_CIR        \ RCC_LSERDYF	Bit Offset:1	Bit Width:1
        \ %x  2 lshift RCC_CIR        \ RCC_HSIRDYF	Bit Offset:2	Bit Width:1
        \ %x  3 lshift RCC_CIR        \ RCC_HSERDYF	Bit Offset:3	Bit Width:1
        \ %x  4 lshift RCC_CIR        \ RCC_PLLRDYF	Bit Offset:4	Bit Width:1
        \ %x  5 lshift RCC_CIR        \ RCC_HSI14RDYF	Bit Offset:5	Bit Width:1
        \ %x  6 lshift RCC_CIR        \ RCC_HSI48RDYF	Bit Offset:6	Bit Width:1
        \ %x  7 lshift RCC_CIR        \ RCC_CSSF	Bit Offset:7	Bit Width:1
        \ %x  8 lshift RCC_CIR        \ RCC_LSIRDYIE	Bit Offset:8	Bit Width:1
        \ %x  9 lshift RCC_CIR        \ RCC_LSERDYIE	Bit Offset:9	Bit Width:1
        \ %x  10 lshift RCC_CIR        \ RCC_HSIRDYIE	Bit Offset:10	Bit Width:1
        \ %x  11 lshift RCC_CIR        \ RCC_HSERDYIE	Bit Offset:11	Bit Width:1
        \ %x  12 lshift RCC_CIR        \ RCC_PLLRDYIE	Bit Offset:12	Bit Width:1
        \ %x  13 lshift RCC_CIR        \ RCC_HSI14RDYE	Bit Offset:13	Bit Width:1
        \ %x  14 lshift RCC_CIR        \ RCC_HSI48RDYIE	Bit Offset:14	Bit Width:1
        \ %x  16 lshift RCC_CIR        \ RCC_LSIRDYC	Bit Offset:16	Bit Width:1
        \ %x  17 lshift RCC_CIR        \ RCC_LSERDYC	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_CIR        \ RCC_HSIRDYC	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RCC_CIR        \ RCC_HSERDYC	Bit Offset:19	Bit Width:1
        \ %x  20 lshift RCC_CIR        \ RCC_PLLRDYC	Bit Offset:20	Bit Width:1
        \ %x  21 lshift RCC_CIR        \ RCC_HSI14RDYC	Bit Offset:21	Bit Width:1
        \ %x  22 lshift RCC_CIR        \ RCC_HSI48RDYC	Bit Offset:22	Bit Width:1
        \ %x  23 lshift RCC_CIR        \ RCC_CSSC	Bit Offset:23	Bit Width:1
        
        RCC $C + constant RCC_APB2RSTR	\ read-write		\  : RESET_RCC_APB2RSTR $00000000 
        \ %x  0 lshift RCC_APB2RSTR        \ RCC_SYSCFGRST	Bit Offset:0	Bit Width:1
        \ %x  9 lshift RCC_APB2RSTR        \ RCC_ADCRST	Bit Offset:9	Bit Width:1
        \ %x  11 lshift RCC_APB2RSTR        \ RCC_TIM1RST	Bit Offset:11	Bit Width:1
        \ %x  12 lshift RCC_APB2RSTR        \ RCC_SPI1RST	Bit Offset:12	Bit Width:1
        \ %x  14 lshift RCC_APB2RSTR        \ RCC_USART1RST	Bit Offset:14	Bit Width:1
        \ %x  16 lshift RCC_APB2RSTR        \ RCC_TIM15RST	Bit Offset:16	Bit Width:1
        \ %x  17 lshift RCC_APB2RSTR        \ RCC_TIM16RST	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_APB2RSTR        \ RCC_TIM17RST	Bit Offset:18	Bit Width:1
        \ %x  22 lshift RCC_APB2RSTR        \ RCC_DBGMCURST	Bit Offset:22	Bit Width:1
        
        RCC $10 + constant RCC_APB1RSTR	\ read-write		\  : RESET_RCC_APB1RSTR $00000000 
        \ %x  0 lshift RCC_APB1RSTR        \ RCC_TIM2RST	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_APB1RSTR        \ RCC_TIM3RST	Bit Offset:1	Bit Width:1
        \ %x  4 lshift RCC_APB1RSTR        \ RCC_TIM6RST	Bit Offset:4	Bit Width:1
        \ %x  5 lshift RCC_APB1RSTR        \ RCC_TIM7RST	Bit Offset:5	Bit Width:1
        \ %x  8 lshift RCC_APB1RSTR        \ RCC_TIM14RST	Bit Offset:8	Bit Width:1
        \ %x  11 lshift RCC_APB1RSTR        \ RCC_WWDGRST	Bit Offset:11	Bit Width:1
        \ %x  14 lshift RCC_APB1RSTR        \ RCC_SPI2RST	Bit Offset:14	Bit Width:1
        \ %x  17 lshift RCC_APB1RSTR        \ RCC_USART2RST	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_APB1RSTR        \ RCC_USART3RST	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RCC_APB1RSTR        \ RCC_USART4RST	Bit Offset:19	Bit Width:1
        \ %x  21 lshift RCC_APB1RSTR        \ RCC_I2C1RST	Bit Offset:21	Bit Width:1
        \ %x  22 lshift RCC_APB1RSTR        \ RCC_I2C2RST	Bit Offset:22	Bit Width:1
        \ %x  23 lshift RCC_APB1RSTR        \ RCC_USBRST	Bit Offset:23	Bit Width:1
        \ %x  25 lshift RCC_APB1RSTR        \ RCC_CANRST	Bit Offset:25	Bit Width:1
        \ %x  27 lshift RCC_APB1RSTR        \ RCC_CRSRST	Bit Offset:27	Bit Width:1
        \ %x  28 lshift RCC_APB1RSTR        \ RCC_PWRRST	Bit Offset:28	Bit Width:1
        \ %x  29 lshift RCC_APB1RSTR        \ RCC_DACRST	Bit Offset:29	Bit Width:1
        \ %x  30 lshift RCC_APB1RSTR        \ RCC_CECRST	Bit Offset:30	Bit Width:1
        
        RCC $14 + constant RCC_AHBENR	\ read-write		\  : RESET_RCC_AHBENR $00000014 
        \ %x  0 lshift RCC_AHBENR        \ RCC_DMAEN	Bit Offset:0	Bit Width:1
        \ %x  2 lshift RCC_AHBENR        \ RCC_SRAMEN	Bit Offset:2	Bit Width:1
        \ %x  4 lshift RCC_AHBENR        \ RCC_FLITFEN	Bit Offset:4	Bit Width:1
        \ %x  6 lshift RCC_AHBENR        \ RCC_CRCEN	Bit Offset:6	Bit Width:1
        \ %x  17 lshift RCC_AHBENR        \ RCC_IOPAEN	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_AHBENR        \ RCC_IOPBEN	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RCC_AHBENR        \ RCC_IOPCEN	Bit Offset:19	Bit Width:1
        \ %x  20 lshift RCC_AHBENR        \ RCC_IOPDEN	Bit Offset:20	Bit Width:1
        \ %x  22 lshift RCC_AHBENR        \ RCC_IOPFEN	Bit Offset:22	Bit Width:1
        \ %x  24 lshift RCC_AHBENR        \ RCC_TSCEN	Bit Offset:24	Bit Width:1
        
        RCC $18 + constant RCC_APB2ENR	\ read-write		\  : RESET_RCC_APB2ENR $00000000 
        \ %x  0 lshift RCC_APB2ENR        \ RCC_SYSCFGEN	Bit Offset:0	Bit Width:1
        \ %x  9 lshift RCC_APB2ENR        \ RCC_ADCEN	Bit Offset:9	Bit Width:1
        \ %x  11 lshift RCC_APB2ENR        \ RCC_TIM1EN	Bit Offset:11	Bit Width:1
        \ %x  12 lshift RCC_APB2ENR        \ RCC_SPI1EN	Bit Offset:12	Bit Width:1
        \ %x  14 lshift RCC_APB2ENR        \ RCC_USART1EN	Bit Offset:14	Bit Width:1
        \ %x  16 lshift RCC_APB2ENR        \ RCC_TIM15EN	Bit Offset:16	Bit Width:1
        \ %x  17 lshift RCC_APB2ENR        \ RCC_TIM16EN	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_APB2ENR        \ RCC_TIM17EN	Bit Offset:18	Bit Width:1
        \ %x  22 lshift RCC_APB2ENR        \ RCC_DBGMCUEN	Bit Offset:22	Bit Width:1
        
        RCC $1C + constant RCC_APB1ENR	\ read-write		\  : RESET_RCC_APB1ENR $00000000 
        \ %x  0 lshift RCC_APB1ENR        \ RCC_TIM2EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_APB1ENR        \ RCC_TIM3EN	Bit Offset:1	Bit Width:1
        \ %x  4 lshift RCC_APB1ENR        \ RCC_TIM6EN	Bit Offset:4	Bit Width:1
        \ %x  5 lshift RCC_APB1ENR        \ RCC_TIM7EN	Bit Offset:5	Bit Width:1
        \ %x  8 lshift RCC_APB1ENR        \ RCC_TIM14EN	Bit Offset:8	Bit Width:1
        \ %x  11 lshift RCC_APB1ENR        \ RCC_WWDGEN	Bit Offset:11	Bit Width:1
        \ %x  14 lshift RCC_APB1ENR        \ RCC_SPI2EN	Bit Offset:14	Bit Width:1
        \ %x  17 lshift RCC_APB1ENR        \ RCC_USART2EN	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_APB1ENR        \ RCC_USART3EN	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RCC_APB1ENR        \ RCC_USART4EN	Bit Offset:19	Bit Width:1
        \ %x  21 lshift RCC_APB1ENR        \ RCC_I2C1EN	Bit Offset:21	Bit Width:1
        \ %x  22 lshift RCC_APB1ENR        \ RCC_I2C2EN	Bit Offset:22	Bit Width:1
        \ %x  23 lshift RCC_APB1ENR        \ RCC_USBRST	Bit Offset:23	Bit Width:1
        \ %x  25 lshift RCC_APB1ENR        \ RCC_CANEN	Bit Offset:25	Bit Width:1
        \ %x  27 lshift RCC_APB1ENR        \ RCC_CRSEN	Bit Offset:27	Bit Width:1
        \ %x  28 lshift RCC_APB1ENR        \ RCC_PWREN	Bit Offset:28	Bit Width:1
        \ %x  29 lshift RCC_APB1ENR        \ RCC_DACEN	Bit Offset:29	Bit Width:1
        \ %x  30 lshift RCC_APB1ENR        \ RCC_CECEN	Bit Offset:30	Bit Width:1
        
        RCC $20 + constant RCC_BDCR	\ 		\  : RESET_RCC_BDCR $00000000 
        \ %x  0 lshift RCC_BDCR        \ RCC_LSEON	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_BDCR        \ RCC_LSERDY	Bit Offset:1	Bit Width:1
        \ %x  2 lshift RCC_BDCR        \ RCC_LSEBYP	Bit Offset:2	Bit Width:1
        \ %xx  3 lshift RCC_BDCR        \ RCC_LSEDRV	Bit Offset:3	Bit Width:2
        \ %xx  8 lshift RCC_BDCR        \ RCC_RTCSEL	Bit Offset:8	Bit Width:2
        \ %x  15 lshift RCC_BDCR        \ RCC_RTCEN	Bit Offset:15	Bit Width:1
        \ %x  16 lshift RCC_BDCR        \ RCC_BDRST	Bit Offset:16	Bit Width:1
        
        RCC $24 + constant RCC_CSR	\ 		\  : RESET_RCC_CSR $0C000000 
        \ %x  0 lshift RCC_CSR        \ RCC_LSION	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_CSR        \ RCC_LSIRDY	Bit Offset:1	Bit Width:1
        \ %x  24 lshift RCC_CSR        \ RCC_RMVF	Bit Offset:24	Bit Width:1
        \ %x  25 lshift RCC_CSR        \ RCC_OBLRSTF	Bit Offset:25	Bit Width:1
        \ %x  26 lshift RCC_CSR        \ RCC_PINRSTF	Bit Offset:26	Bit Width:1
        \ %x  27 lshift RCC_CSR        \ RCC_PORRSTF	Bit Offset:27	Bit Width:1
        \ %x  28 lshift RCC_CSR        \ RCC_SFTRSTF	Bit Offset:28	Bit Width:1
        \ %x  29 lshift RCC_CSR        \ RCC_IWDGRSTF	Bit Offset:29	Bit Width:1
        \ %x  30 lshift RCC_CSR        \ RCC_WWDGRSTF	Bit Offset:30	Bit Width:1
        \ %x  31 lshift RCC_CSR        \ RCC_LPWRRSTF	Bit Offset:31	Bit Width:1
        
        RCC $28 + constant RCC_AHBRSTR	\ read-write		\  : RESET_RCC_AHBRSTR $00000000 
        \ %x  17 lshift RCC_AHBRSTR        \ RCC_IOPARST	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RCC_AHBRSTR        \ RCC_IOPBRST	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RCC_AHBRSTR        \ RCC_IOPCRST	Bit Offset:19	Bit Width:1
        \ %x  20 lshift RCC_AHBRSTR        \ RCC_IOPDRST	Bit Offset:20	Bit Width:1
        \ %x  22 lshift RCC_AHBRSTR        \ RCC_IOPFRST	Bit Offset:22	Bit Width:1
        \ %x  24 lshift RCC_AHBRSTR        \ RCC_TSCRST	Bit Offset:24	Bit Width:1
        
        RCC $2C + constant RCC_CFGR2	\ read-write		\  : RESET_RCC_CFGR2 $00000000 
        \ %xxxx  0 lshift RCC_CFGR2        \ RCC_PREDIV	Bit Offset:0	Bit Width:4
        
        RCC $30 + constant RCC_CFGR3	\ read-write		\  : RESET_RCC_CFGR3 $00000000 
        \ %xx  0 lshift RCC_CFGR3        \ RCC_USART1SW	Bit Offset:0	Bit Width:2
        \ %x  4 lshift RCC_CFGR3        \ RCC_I2C1SW	Bit Offset:4	Bit Width:1
        \ %x  6 lshift RCC_CFGR3        \ RCC_CECSW	Bit Offset:6	Bit Width:1
        \ %x  7 lshift RCC_CFGR3        \ RCC_USBSW	Bit Offset:7	Bit Width:1
        \ %x  8 lshift RCC_CFGR3        \ RCC_ADCSW	Bit Offset:8	Bit Width:1
        \ %xx  16 lshift RCC_CFGR3        \ RCC_USART2SW	Bit Offset:16	Bit Width:2
        
        RCC $34 + constant RCC_CR2	\ 		\  : RESET_RCC_CR2 $00000080 
        \ %x  0 lshift RCC_CR2        \ RCC_HSI14ON	Bit Offset:0	Bit Width:1
        \ %x  1 lshift RCC_CR2        \ RCC_HSI14RDY	Bit Offset:1	Bit Width:1
        \ %x  2 lshift RCC_CR2        \ RCC_HSI14DIS	Bit Offset:2	Bit Width:1
        \ %xxxxx  3 lshift RCC_CR2        \ RCC_HSI14TRIM	Bit Offset:3	Bit Width:5
        \ %xxxxxxxx  8 lshift RCC_CR2        \ RCC_HSI14CAL	Bit Offset:8	Bit Width:8
        \ %x  16 lshift RCC_CR2        \ RCC_HSI48ON	Bit Offset:16	Bit Width:1
        \ %x  17 lshift RCC_CR2        \ RCC_HSI48RDY	Bit Offset:17	Bit Width:1
        \ %x  24 lshift RCC_CR2        \ RCC_HSI48CAL	Bit Offset:24	Bit Width:1
        
         
	
     $40010000 constant SYSCFG  
	 SYSCFG $0 + constant SYSCFG_CFGR1	\ read-write		\  : RESET_SYSCFG_CFGR1 $00000000 
        \ %xx  0 lshift SYSCFG_CFGR1        \ SYSCFG_MEM_MODE	Bit Offset:0	Bit Width:2
        \ %x  8 lshift SYSCFG_CFGR1        \ SYSCFG_ADC_DMA_RMP	Bit Offset:8	Bit Width:1
        \ %x  9 lshift SYSCFG_CFGR1        \ SYSCFG_USART1_TX_DMA_RMP	Bit Offset:9	Bit Width:1
        \ %x  10 lshift SYSCFG_CFGR1        \ SYSCFG_USART1_RX_DMA_RMP	Bit Offset:10	Bit Width:1
        \ %x  11 lshift SYSCFG_CFGR1        \ SYSCFG_TIM16_DMA_RMP	Bit Offset:11	Bit Width:1
        \ %x  12 lshift SYSCFG_CFGR1        \ SYSCFG_TIM17_DMA_RMP	Bit Offset:12	Bit Width:1
        \ %x  16 lshift SYSCFG_CFGR1        \ SYSCFG_I2C_PB6_FM	Bit Offset:16	Bit Width:1
        \ %x  17 lshift SYSCFG_CFGR1        \ SYSCFG_I2C_PB7_FM	Bit Offset:17	Bit Width:1
        \ %x  18 lshift SYSCFG_CFGR1        \ SYSCFG_I2C_PB8_FM	Bit Offset:18	Bit Width:1
        \ %x  19 lshift SYSCFG_CFGR1        \ SYSCFG_I2C_PB9_FM	Bit Offset:19	Bit Width:1
        \ %x  20 lshift SYSCFG_CFGR1        \ SYSCFG_I2C1_FM_plus	Bit Offset:20	Bit Width:1
        \ %x  21 lshift SYSCFG_CFGR1        \ SYSCFG_I2C2_FM_plus	Bit Offset:21	Bit Width:1
        \ %x  24 lshift SYSCFG_CFGR1        \ SYSCFG_SPI2_DMA_RMP	Bit Offset:24	Bit Width:1
        \ %x  25 lshift SYSCFG_CFGR1        \ SYSCFG_USART2_DMA_RMP	Bit Offset:25	Bit Width:1
        \ %x  26 lshift SYSCFG_CFGR1        \ SYSCFG_USART3_DMA_RMP	Bit Offset:26	Bit Width:1
        \ %x  27 lshift SYSCFG_CFGR1        \ SYSCFG_I2C1_DMA_RMP	Bit Offset:27	Bit Width:1
        \ %x  28 lshift SYSCFG_CFGR1        \ SYSCFG_TIM1_DMA_RMP	Bit Offset:28	Bit Width:1
        \ %x  29 lshift SYSCFG_CFGR1        \ SYSCFG_TIM2_DMA_RMP	Bit Offset:29	Bit Width:1
        \ %x  30 lshift SYSCFG_CFGR1        \ SYSCFG_TIM3_DMA_RMP	Bit Offset:30	Bit Width:1
        
        SYSCFG $8 + constant SYSCFG_EXTICR1	\ read-write		\  : RESET_SYSCFG_EXTICR1 $0000 
        \ %xxxx  12 lshift SYSCFG_EXTICR1        \ SYSCFG_EXTI3	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift SYSCFG_EXTICR1        \ SYSCFG_EXTI2	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift SYSCFG_EXTICR1        \ SYSCFG_EXTI1	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift SYSCFG_EXTICR1        \ SYSCFG_EXTI0	Bit Offset:0	Bit Width:4
        
        SYSCFG $C + constant SYSCFG_EXTICR2	\ read-write		\  : RESET_SYSCFG_EXTICR2 $0000 
        \ %xxxx  12 lshift SYSCFG_EXTICR2        \ SYSCFG_EXTI7	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift SYSCFG_EXTICR2        \ SYSCFG_EXTI6	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift SYSCFG_EXTICR2        \ SYSCFG_EXTI5	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift SYSCFG_EXTICR2        \ SYSCFG_EXTI4	Bit Offset:0	Bit Width:4
        
        SYSCFG $10 + constant SYSCFG_EXTICR3	\ read-write		\  : RESET_SYSCFG_EXTICR3 $0000 
        \ %xxxx  12 lshift SYSCFG_EXTICR3        \ SYSCFG_EXTI11	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift SYSCFG_EXTICR3        \ SYSCFG_EXTI10	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift SYSCFG_EXTICR3        \ SYSCFG_EXTI9	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift SYSCFG_EXTICR3        \ SYSCFG_EXTI8	Bit Offset:0	Bit Width:4
        
        SYSCFG $14 + constant SYSCFG_EXTICR4	\ read-write		\  : RESET_SYSCFG_EXTICR4 $0000 
        \ %xxxx  12 lshift SYSCFG_EXTICR4        \ SYSCFG_EXTI15	Bit Offset:12	Bit Width:4
        \ %xxxx  8 lshift SYSCFG_EXTICR4        \ SYSCFG_EXTI14	Bit Offset:8	Bit Width:4
        \ %xxxx  4 lshift SYSCFG_EXTICR4        \ SYSCFG_EXTI13	Bit Offset:4	Bit Width:4
        \ %xxxx  0 lshift SYSCFG_EXTICR4        \ SYSCFG_EXTI12	Bit Offset:0	Bit Width:4
        
        SYSCFG $18 + constant SYSCFG_CFGR2	\ read-write		\  : RESET_SYSCFG_CFGR2 $0000 
        \ %x  8 lshift SYSCFG_CFGR2        \ SYSCFG_SRAM_PEF	Bit Offset:8	Bit Width:1
        \ %x  2 lshift SYSCFG_CFGR2        \ SYSCFG_PVD_LOCK	Bit Offset:2	Bit Width:1
        \ %x  1 lshift SYSCFG_CFGR2        \ SYSCFG_SRAM_PARITY_LOCK	Bit Offset:1	Bit Width:1
        \ %x  0 lshift SYSCFG_CFGR2        \ SYSCFG_LOCUP_LOCK	Bit Offset:0	Bit Width:1
        
         
	
     $40012400 constant ADC  
	 ADC $0 + constant ADC_ISR	\ read-write		\  : RESET_ADC_ISR $00000000 
        \ %x  7 lshift ADC_ISR        \ ADC_AWD	Bit Offset:7	Bit Width:1
        \ %x  4 lshift ADC_ISR        \ ADC_OVR	Bit Offset:4	Bit Width:1
        \ %x  3 lshift ADC_ISR        \ ADC_EOS	Bit Offset:3	Bit Width:1
        \ %x  2 lshift ADC_ISR        \ ADC_EOC	Bit Offset:2	Bit Width:1
        \ %x  1 lshift ADC_ISR        \ ADC_EOSMP	Bit Offset:1	Bit Width:1
        \ %x  0 lshift ADC_ISR        \ ADC_ADRDY	Bit Offset:0	Bit Width:1
        
        ADC $4 + constant ADC_IER	\ read-write		\  : RESET_ADC_IER $00000000 
        \ %x  7 lshift ADC_IER        \ ADC_AWDIE	Bit Offset:7	Bit Width:1
        \ %x  4 lshift ADC_IER        \ ADC_OVRIE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift ADC_IER        \ ADC_EOSIE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift ADC_IER        \ ADC_EOCIE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift ADC_IER        \ ADC_EOSMPIE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift ADC_IER        \ ADC_ADRDYIE	Bit Offset:0	Bit Width:1
        
        ADC $8 + constant ADC_CR	\ read-write		\  : RESET_ADC_CR $00000000 
        \ %x  31 lshift ADC_CR        \ ADC_ADCAL	Bit Offset:31	Bit Width:1
        \ %x  4 lshift ADC_CR        \ ADC_ADSTP	Bit Offset:4	Bit Width:1
        \ %x  2 lshift ADC_CR        \ ADC_ADSTART	Bit Offset:2	Bit Width:1
        \ %x  1 lshift ADC_CR        \ ADC_ADDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift ADC_CR        \ ADC_ADEN	Bit Offset:0	Bit Width:1
        
        ADC $C + constant ADC_CFGR1	\ read-write		\  : RESET_ADC_CFGR1 $00000000 
        \ %xxxxx  26 lshift ADC_CFGR1        \ ADC_AWDCH	Bit Offset:26	Bit Width:5
        \ %x  23 lshift ADC_CFGR1        \ ADC_AWDEN	Bit Offset:23	Bit Width:1
        \ %x  22 lshift ADC_CFGR1        \ ADC_AWDSGL	Bit Offset:22	Bit Width:1
        \ %x  16 lshift ADC_CFGR1        \ ADC_DISCEN	Bit Offset:16	Bit Width:1
        \ %x  15 lshift ADC_CFGR1        \ ADC_AUTOFF	Bit Offset:15	Bit Width:1
        \ %x  14 lshift ADC_CFGR1        \ ADC_AUTDLY	Bit Offset:14	Bit Width:1
        \ %x  13 lshift ADC_CFGR1        \ ADC_CONT	Bit Offset:13	Bit Width:1
        \ %x  12 lshift ADC_CFGR1        \ ADC_OVRMOD	Bit Offset:12	Bit Width:1
        \ %xx  10 lshift ADC_CFGR1        \ ADC_EXTEN	Bit Offset:10	Bit Width:2
        \ %xxx  6 lshift ADC_CFGR1        \ ADC_EXTSEL	Bit Offset:6	Bit Width:3
        \ %x  5 lshift ADC_CFGR1        \ ADC_ALIGN	Bit Offset:5	Bit Width:1
        \ %xx  3 lshift ADC_CFGR1        \ ADC_RES	Bit Offset:3	Bit Width:2
        \ %x  2 lshift ADC_CFGR1        \ ADC_SCANDIR	Bit Offset:2	Bit Width:1
        \ %x  1 lshift ADC_CFGR1        \ ADC_DMACFG	Bit Offset:1	Bit Width:1
        \ %x  0 lshift ADC_CFGR1        \ ADC_DMAEN	Bit Offset:0	Bit Width:1
        
        ADC $10 + constant ADC_CFGR2	\ read-write		\  : RESET_ADC_CFGR2 $00008000 
        \ %x  31 lshift ADC_CFGR2        \ ADC_JITOFF_D4	Bit Offset:31	Bit Width:1
        \ %x  30 lshift ADC_CFGR2        \ ADC_JITOFF_D2	Bit Offset:30	Bit Width:1
        
        ADC $14 + constant ADC_SMPR	\ read-write		\  : RESET_ADC_SMPR $00000000 
        \ %xxx  0 lshift ADC_SMPR        \ ADC_SMPR	Bit Offset:0	Bit Width:3
        
        ADC $20 + constant ADC_TR	\ read-write		\  : RESET_ADC_TR $00000FFF 
        \ %xxxxxxxxxxxx  16 lshift ADC_TR        \ ADC_HT	Bit Offset:16	Bit Width:12
        \ %xxxxxxxxxxxx  0 lshift ADC_TR        \ ADC_LT	Bit Offset:0	Bit Width:12
        
        ADC $28 + constant ADC_CHSELR	\ read-write		\  : RESET_ADC_CHSELR $00000000 
        \ %x  18 lshift ADC_CHSELR        \ ADC_CHSEL18	Bit Offset:18	Bit Width:1
        \ %x  17 lshift ADC_CHSELR        \ ADC_CHSEL17	Bit Offset:17	Bit Width:1
        \ %x  16 lshift ADC_CHSELR        \ ADC_CHSEL16	Bit Offset:16	Bit Width:1
        \ %x  15 lshift ADC_CHSELR        \ ADC_CHSEL15	Bit Offset:15	Bit Width:1
        \ %x  14 lshift ADC_CHSELR        \ ADC_CHSEL14	Bit Offset:14	Bit Width:1
        \ %x  13 lshift ADC_CHSELR        \ ADC_CHSEL13	Bit Offset:13	Bit Width:1
        \ %x  12 lshift ADC_CHSELR        \ ADC_CHSEL12	Bit Offset:12	Bit Width:1
        \ %x  11 lshift ADC_CHSELR        \ ADC_CHSEL11	Bit Offset:11	Bit Width:1
        \ %x  10 lshift ADC_CHSELR        \ ADC_CHSEL10	Bit Offset:10	Bit Width:1
        \ %x  9 lshift ADC_CHSELR        \ ADC_CHSEL9	Bit Offset:9	Bit Width:1
        \ %x  8 lshift ADC_CHSELR        \ ADC_CHSEL8	Bit Offset:8	Bit Width:1
        \ %x  7 lshift ADC_CHSELR        \ ADC_CHSEL7	Bit Offset:7	Bit Width:1
        \ %x  6 lshift ADC_CHSELR        \ ADC_CHSEL6	Bit Offset:6	Bit Width:1
        \ %x  5 lshift ADC_CHSELR        \ ADC_CHSEL5	Bit Offset:5	Bit Width:1
        \ %x  4 lshift ADC_CHSELR        \ ADC_CHSEL4	Bit Offset:4	Bit Width:1
        \ %x  3 lshift ADC_CHSELR        \ ADC_CHSEL3	Bit Offset:3	Bit Width:1
        \ %x  2 lshift ADC_CHSELR        \ ADC_CHSEL2	Bit Offset:2	Bit Width:1
        \ %x  1 lshift ADC_CHSELR        \ ADC_CHSEL1	Bit Offset:1	Bit Width:1
        \ %x  0 lshift ADC_CHSELR        \ ADC_CHSEL0	Bit Offset:0	Bit Width:1
        
        ADC $40 + constant ADC_DR	\ read-only		\  : RESET_ADC_DR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift ADC_DR        \ ADC_DATA	Bit Offset:0	Bit Width:16
        
        ADC $308 + constant ADC_CCR	\ read-write		\  : RESET_ADC_CCR $00000000 
        \ %x  24 lshift ADC_CCR        \ ADC_VBATEN	Bit Offset:24	Bit Width:1
        \ %x  23 lshift ADC_CCR        \ ADC_TSEN	Bit Offset:23	Bit Width:1
        \ %x  22 lshift ADC_CCR        \ ADC_VREFEN	Bit Offset:22	Bit Width:1
        
         
	
     $40013800 constant USART1  
	 USART1 $0 + constant USART1_CR1	\ read-write		\  : RESET_USART1_CR1 $0000 
        \ %x  0 lshift USART1_CR1        \ USART1_UE	Bit Offset:0	Bit Width:1
        \ %x  1 lshift USART1_CR1        \ USART1_UESM	Bit Offset:1	Bit Width:1
        \ %x  2 lshift USART1_CR1        \ USART1_RE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift USART1_CR1        \ USART1_TE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift USART1_CR1        \ USART1_IDLEIE	Bit Offset:4	Bit Width:1
        \ %x  5 lshift USART1_CR1        \ USART1_RXNEIE	Bit Offset:5	Bit Width:1
        \ %x  6 lshift USART1_CR1        \ USART1_TCIE	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USART1_CR1        \ USART1_TXEIE	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USART1_CR1        \ USART1_PEIE	Bit Offset:8	Bit Width:1
        \ %x  9 lshift USART1_CR1        \ USART1_PS	Bit Offset:9	Bit Width:1
        \ %x  10 lshift USART1_CR1        \ USART1_PCE	Bit Offset:10	Bit Width:1
        \ %x  11 lshift USART1_CR1        \ USART1_WAKE	Bit Offset:11	Bit Width:1
        \ %x  12 lshift USART1_CR1        \ USART1_M	Bit Offset:12	Bit Width:1
        \ %x  13 lshift USART1_CR1        \ USART1_MME	Bit Offset:13	Bit Width:1
        \ %x  14 lshift USART1_CR1        \ USART1_CMIE	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USART1_CR1        \ USART1_OVER8	Bit Offset:15	Bit Width:1
        \ %xxxxx  16 lshift USART1_CR1        \ USART1_DEDT	Bit Offset:16	Bit Width:5
        \ %xxxxx  21 lshift USART1_CR1        \ USART1_DEAT	Bit Offset:21	Bit Width:5
        \ %x  26 lshift USART1_CR1        \ USART1_RTOIE	Bit Offset:26	Bit Width:1
        \ %x  27 lshift USART1_CR1        \ USART1_EOBIE	Bit Offset:27	Bit Width:1
        \ %x  28 lshift USART1_CR1        \ USART1_M1	Bit Offset:28	Bit Width:1
        
        USART1 $4 + constant USART1_CR2	\ read-write		\  : RESET_USART1_CR2 $0000 
        \ %xxxx  28 lshift USART1_CR2        \ USART1_ADD4	Bit Offset:28	Bit Width:4
        \ %xxxx  24 lshift USART1_CR2        \ USART1_ADD0	Bit Offset:24	Bit Width:4
        \ %x  23 lshift USART1_CR2        \ USART1_RTOEN	Bit Offset:23	Bit Width:1
        \ %xx  21 lshift USART1_CR2        \ USART1_ABRMOD	Bit Offset:21	Bit Width:2
        \ %x  20 lshift USART1_CR2        \ USART1_ABREN	Bit Offset:20	Bit Width:1
        \ %x  19 lshift USART1_CR2        \ USART1_MSBFIRST	Bit Offset:19	Bit Width:1
        \ %x  18 lshift USART1_CR2        \ USART1_DATAINV	Bit Offset:18	Bit Width:1
        \ %x  17 lshift USART1_CR2        \ USART1_TXINV	Bit Offset:17	Bit Width:1
        \ %x  16 lshift USART1_CR2        \ USART1_RXINV	Bit Offset:16	Bit Width:1
        \ %x  15 lshift USART1_CR2        \ USART1_SWAP	Bit Offset:15	Bit Width:1
        \ %x  14 lshift USART1_CR2        \ USART1_LINEN	Bit Offset:14	Bit Width:1
        \ %xx  12 lshift USART1_CR2        \ USART1_STOP	Bit Offset:12	Bit Width:2
        \ %x  11 lshift USART1_CR2        \ USART1_CLKEN	Bit Offset:11	Bit Width:1
        \ %x  10 lshift USART1_CR2        \ USART1_CPOL	Bit Offset:10	Bit Width:1
        \ %x  9 lshift USART1_CR2        \ USART1_CPHA	Bit Offset:9	Bit Width:1
        \ %x  8 lshift USART1_CR2        \ USART1_LBCL	Bit Offset:8	Bit Width:1
        \ %x  6 lshift USART1_CR2        \ USART1_LBDIE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift USART1_CR2        \ USART1_LBDL	Bit Offset:5	Bit Width:1
        \ %x  4 lshift USART1_CR2        \ USART1_ADDM7	Bit Offset:4	Bit Width:1
        
        USART1 $8 + constant USART1_CR3	\ read-write		\  : RESET_USART1_CR3 $0000 
        \ %x  22 lshift USART1_CR3        \ USART1_WUFIE	Bit Offset:22	Bit Width:1
        \ %xx  20 lshift USART1_CR3        \ USART1_WUS	Bit Offset:20	Bit Width:2
        \ %xxx  17 lshift USART1_CR3        \ USART1_SCARCNT	Bit Offset:17	Bit Width:3
        \ %x  15 lshift USART1_CR3        \ USART1_DEP	Bit Offset:15	Bit Width:1
        \ %x  14 lshift USART1_CR3        \ USART1_DEM	Bit Offset:14	Bit Width:1
        \ %x  13 lshift USART1_CR3        \ USART1_DDRE	Bit Offset:13	Bit Width:1
        \ %x  12 lshift USART1_CR3        \ USART1_OVRDIS	Bit Offset:12	Bit Width:1
        \ %x  11 lshift USART1_CR3        \ USART1_ONEBIT	Bit Offset:11	Bit Width:1
        \ %x  10 lshift USART1_CR3        \ USART1_CTSIE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift USART1_CR3        \ USART1_CTSE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift USART1_CR3        \ USART1_RTSE	Bit Offset:8	Bit Width:1
        \ %x  7 lshift USART1_CR3        \ USART1_DMAT	Bit Offset:7	Bit Width:1
        \ %x  6 lshift USART1_CR3        \ USART1_DMAR	Bit Offset:6	Bit Width:1
        \ %x  5 lshift USART1_CR3        \ USART1_SCEN	Bit Offset:5	Bit Width:1
        \ %x  4 lshift USART1_CR3        \ USART1_NACK	Bit Offset:4	Bit Width:1
        \ %x  3 lshift USART1_CR3        \ USART1_HDSEL	Bit Offset:3	Bit Width:1
        \ %x  2 lshift USART1_CR3        \ USART1_IRLP	Bit Offset:2	Bit Width:1
        \ %x  1 lshift USART1_CR3        \ USART1_IREN	Bit Offset:1	Bit Width:1
        \ %x  0 lshift USART1_CR3        \ USART1_EIE	Bit Offset:0	Bit Width:1
        
        USART1 $C + constant USART1_BRR	\ read-write		\  : RESET_USART1_BRR $0000 
        \ %xxxxxxxxxxxx  4 lshift USART1_BRR        \ USART1_DIV_Mantissa	Bit Offset:4	Bit Width:12
        \ %xxxx  0 lshift USART1_BRR        \ USART1_DIV_Fraction	Bit Offset:0	Bit Width:4
        
        USART1 $10 + constant USART1_GTPR	\ read-write		\  : RESET_USART1_GTPR $0000 
        \ %xxxxxxxx  8 lshift USART1_GTPR        \ USART1_GT	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift USART1_GTPR        \ USART1_PSC	Bit Offset:0	Bit Width:8
        
        USART1 $14 + constant USART1_RTOR	\ read-write		\  : RESET_USART1_RTOR $0000 
        \ %xxxxxxxx  24 lshift USART1_RTOR        \ USART1_BLEN	Bit Offset:24	Bit Width:8
        \ %xxxxxxxxxxxxxxxxxxxxxxxx  0 lshift USART1_RTOR        \ USART1_RTO	Bit Offset:0	Bit Width:24
        
        USART1 $18 + constant USART1_RQR	\ read-write		\  : RESET_USART1_RQR $0000 
        \ %x  4 lshift USART1_RQR        \ USART1_TXFRQ	Bit Offset:4	Bit Width:1
        \ %x  3 lshift USART1_RQR        \ USART1_RXFRQ	Bit Offset:3	Bit Width:1
        \ %x  2 lshift USART1_RQR        \ USART1_MMRQ	Bit Offset:2	Bit Width:1
        \ %x  1 lshift USART1_RQR        \ USART1_SBKRQ	Bit Offset:1	Bit Width:1
        \ %x  0 lshift USART1_RQR        \ USART1_ABRRQ	Bit Offset:0	Bit Width:1
        
        USART1 $1C + constant USART1_ISR	\ read-only		\  : RESET_USART1_ISR $00C0 
        \ %x  22 lshift USART1_ISR        \ USART1_REACK	Bit Offset:22	Bit Width:1
        \ %x  21 lshift USART1_ISR        \ USART1_TEACK	Bit Offset:21	Bit Width:1
        \ %x  20 lshift USART1_ISR        \ USART1_WUF	Bit Offset:20	Bit Width:1
        \ %x  19 lshift USART1_ISR        \ USART1_RWU	Bit Offset:19	Bit Width:1
        \ %x  18 lshift USART1_ISR        \ USART1_SBKF	Bit Offset:18	Bit Width:1
        \ %x  17 lshift USART1_ISR        \ USART1_CMF	Bit Offset:17	Bit Width:1
        \ %x  16 lshift USART1_ISR        \ USART1_BUSY	Bit Offset:16	Bit Width:1
        \ %x  15 lshift USART1_ISR        \ USART1_ABRF	Bit Offset:15	Bit Width:1
        \ %x  14 lshift USART1_ISR        \ USART1_ABRE	Bit Offset:14	Bit Width:1
        \ %x  12 lshift USART1_ISR        \ USART1_EOBF	Bit Offset:12	Bit Width:1
        \ %x  11 lshift USART1_ISR        \ USART1_RTOF	Bit Offset:11	Bit Width:1
        \ %x  10 lshift USART1_ISR        \ USART1_CTS	Bit Offset:10	Bit Width:1
        \ %x  9 lshift USART1_ISR        \ USART1_CTSIF	Bit Offset:9	Bit Width:1
        \ %x  8 lshift USART1_ISR        \ USART1_LBDF	Bit Offset:8	Bit Width:1
        \ %x  7 lshift USART1_ISR        \ USART1_TXE	Bit Offset:7	Bit Width:1
        \ %x  6 lshift USART1_ISR        \ USART1_TC	Bit Offset:6	Bit Width:1
        \ %x  5 lshift USART1_ISR        \ USART1_RXNE	Bit Offset:5	Bit Width:1
        \ %x  4 lshift USART1_ISR        \ USART1_IDLE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift USART1_ISR        \ USART1_ORE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift USART1_ISR        \ USART1_NF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift USART1_ISR        \ USART1_FE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift USART1_ISR        \ USART1_PE	Bit Offset:0	Bit Width:1
        
        USART1 $20 + constant USART1_ICR	\ read-write		\  : RESET_USART1_ICR $0000 
        \ %x  20 lshift USART1_ICR        \ USART1_WUCF	Bit Offset:20	Bit Width:1
        \ %x  17 lshift USART1_ICR        \ USART1_CMCF	Bit Offset:17	Bit Width:1
        \ %x  12 lshift USART1_ICR        \ USART1_EOBCF	Bit Offset:12	Bit Width:1
        \ %x  11 lshift USART1_ICR        \ USART1_RTOCF	Bit Offset:11	Bit Width:1
        \ %x  9 lshift USART1_ICR        \ USART1_CTSCF	Bit Offset:9	Bit Width:1
        \ %x  8 lshift USART1_ICR        \ USART1_LBDCF	Bit Offset:8	Bit Width:1
        \ %x  6 lshift USART1_ICR        \ USART1_TCCF	Bit Offset:6	Bit Width:1
        \ %x  4 lshift USART1_ICR        \ USART1_IDLECF	Bit Offset:4	Bit Width:1
        \ %x  3 lshift USART1_ICR        \ USART1_ORECF	Bit Offset:3	Bit Width:1
        \ %x  2 lshift USART1_ICR        \ USART1_NCF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift USART1_ICR        \ USART1_FECF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift USART1_ICR        \ USART1_PECF	Bit Offset:0	Bit Width:1
        
        USART1 $24 + constant USART1_RDR	\ read-only		\  : RESET_USART1_RDR $0000 
        \ %xxxxxxxxx  0 lshift USART1_RDR        \ USART1_RDR	Bit Offset:0	Bit Width:9
        
        USART1 $28 + constant USART1_TDR	\ read-write		\  : RESET_USART1_TDR $0000 
        \ %xxxxxxxxx  0 lshift USART1_TDR        \ USART1_TDR	Bit Offset:0	Bit Width:9
        
         
	
     $40004400 constant USART2  
	  
	
     $40004800 constant USART3  
	  
	
     $40004C00 constant USART4  
	  
	
     $4001001C constant COMP  
	 COMP $0 + constant COMP_CSR	\ 		\  : RESET_COMP_CSR $00000000 
        \ %x  0 lshift COMP_CSR        \ COMP_COMP1EN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift COMP_CSR        \ COMP_COMP1_INP_DAC	Bit Offset:1	Bit Width:1
        \ %xx  2 lshift COMP_CSR        \ COMP_COMP1MODE	Bit Offset:2	Bit Width:2
        \ %xxx  4 lshift COMP_CSR        \ COMP_COMP1INSEL	Bit Offset:4	Bit Width:3
        \ %xxx  8 lshift COMP_CSR        \ COMP_COMP1OUTSEL	Bit Offset:8	Bit Width:3
        \ %x  11 lshift COMP_CSR        \ COMP_COMP1POL	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift COMP_CSR        \ COMP_COMP1HYST	Bit Offset:12	Bit Width:2
        \ %x  14 lshift COMP_CSR        \ COMP_COMP1OUT	Bit Offset:14	Bit Width:1
        \ %x  15 lshift COMP_CSR        \ COMP_COMP1LOCK	Bit Offset:15	Bit Width:1
        \ %x  16 lshift COMP_CSR        \ COMP_COMP2EN	Bit Offset:16	Bit Width:1
        \ %xx  18 lshift COMP_CSR        \ COMP_COMP2MODE	Bit Offset:18	Bit Width:2
        \ %xxx  20 lshift COMP_CSR        \ COMP_COMP2INSEL	Bit Offset:20	Bit Width:3
        \ %x  23 lshift COMP_CSR        \ COMP_WNDWEN	Bit Offset:23	Bit Width:1
        \ %xxx  24 lshift COMP_CSR        \ COMP_COMP2OUTSEL	Bit Offset:24	Bit Width:3
        \ %x  27 lshift COMP_CSR        \ COMP_COMP2POL	Bit Offset:27	Bit Width:1
        \ %xx  28 lshift COMP_CSR        \ COMP_COMP2HYST	Bit Offset:28	Bit Width:2
        \ %x  30 lshift COMP_CSR        \ COMP_COMP2OUT	Bit Offset:30	Bit Width:1
        \ %x  31 lshift COMP_CSR        \ COMP_COMP2LOCK	Bit Offset:31	Bit Width:1
        
         
	
     $40002800 constant RTC  
	 RTC $0 + constant RTC_TR	\ read-write		\  : RESET_RTC_TR $00000000 
        \ %x  22 lshift RTC_TR        \ RTC_PM	Bit Offset:22	Bit Width:1
        \ %xx  20 lshift RTC_TR        \ RTC_HT	Bit Offset:20	Bit Width:2
        \ %xxxx  16 lshift RTC_TR        \ RTC_HU	Bit Offset:16	Bit Width:4
        \ %xxx  12 lshift RTC_TR        \ RTC_MNT	Bit Offset:12	Bit Width:3
        \ %xxxx  8 lshift RTC_TR        \ RTC_MNU	Bit Offset:8	Bit Width:4
        \ %xxx  4 lshift RTC_TR        \ RTC_ST	Bit Offset:4	Bit Width:3
        \ %xxxx  0 lshift RTC_TR        \ RTC_SU	Bit Offset:0	Bit Width:4
        
        RTC $4 + constant RTC_DR	\ read-write		\  : RESET_RTC_DR $00002101 
        \ %xxxx  20 lshift RTC_DR        \ RTC_YT	Bit Offset:20	Bit Width:4
        \ %xxxx  16 lshift RTC_DR        \ RTC_YU	Bit Offset:16	Bit Width:4
        \ %xxx  13 lshift RTC_DR        \ RTC_WDU	Bit Offset:13	Bit Width:3
        \ %x  12 lshift RTC_DR        \ RTC_MT	Bit Offset:12	Bit Width:1
        \ %xxxx  8 lshift RTC_DR        \ RTC_MU	Bit Offset:8	Bit Width:4
        \ %xx  4 lshift RTC_DR        \ RTC_DT	Bit Offset:4	Bit Width:2
        \ %xxxx  0 lshift RTC_DR        \ RTC_DU	Bit Offset:0	Bit Width:4
        
        RTC $8 + constant RTC_CR	\ 		\  : RESET_RTC_CR $00000000 
        \ %x  3 lshift RTC_CR        \ RTC_TSEDGE	Bit Offset:3	Bit Width:1
        \ %x  4 lshift RTC_CR        \ RTC_REFCKON	Bit Offset:4	Bit Width:1
        \ %x  5 lshift RTC_CR        \ RTC_BYPSHAD	Bit Offset:5	Bit Width:1
        \ %x  6 lshift RTC_CR        \ RTC_FMT	Bit Offset:6	Bit Width:1
        \ %x  8 lshift RTC_CR        \ RTC_ALRAE	Bit Offset:8	Bit Width:1
        \ %x  11 lshift RTC_CR        \ RTC_TSE	Bit Offset:11	Bit Width:1
        \ %x  12 lshift RTC_CR        \ RTC_ALRAIE	Bit Offset:12	Bit Width:1
        \ %x  15 lshift RTC_CR        \ RTC_TSIE	Bit Offset:15	Bit Width:1
        \ %x  16 lshift RTC_CR        \ RTC_ADD1H	Bit Offset:16	Bit Width:1
        \ %x  17 lshift RTC_CR        \ RTC_SUB1H	Bit Offset:17	Bit Width:1
        \ %x  18 lshift RTC_CR        \ RTC_BKP	Bit Offset:18	Bit Width:1
        \ %x  19 lshift RTC_CR        \ RTC_COSEL	Bit Offset:19	Bit Width:1
        \ %x  20 lshift RTC_CR        \ RTC_POL	Bit Offset:20	Bit Width:1
        \ %xx  21 lshift RTC_CR        \ RTC_OSEL	Bit Offset:21	Bit Width:2
        \ %x  23 lshift RTC_CR        \ RTC_COE	Bit Offset:23	Bit Width:1
        
        RTC $C + constant RTC_ISR	\ 		\  : RESET_RTC_ISR $00000007 
        \ %x  0 lshift RTC_ISR        \ RTC_ALRAWF	Bit Offset:0	Bit Width:1
        \ %x  3 lshift RTC_ISR        \ RTC_SHPF	Bit Offset:3	Bit Width:1
        \ %x  4 lshift RTC_ISR        \ RTC_INITS	Bit Offset:4	Bit Width:1
        \ %x  5 lshift RTC_ISR        \ RTC_RSF	Bit Offset:5	Bit Width:1
        \ %x  6 lshift RTC_ISR        \ RTC_INITF	Bit Offset:6	Bit Width:1
        \ %x  7 lshift RTC_ISR        \ RTC_INIT	Bit Offset:7	Bit Width:1
        \ %x  8 lshift RTC_ISR        \ RTC_ALRAF	Bit Offset:8	Bit Width:1
        \ %x  11 lshift RTC_ISR        \ RTC_TSF	Bit Offset:11	Bit Width:1
        \ %x  12 lshift RTC_ISR        \ RTC_TSOVF	Bit Offset:12	Bit Width:1
        \ %x  13 lshift RTC_ISR        \ RTC_TAMP1F	Bit Offset:13	Bit Width:1
        \ %x  14 lshift RTC_ISR        \ RTC_TAMP2F	Bit Offset:14	Bit Width:1
        \ %x  16 lshift RTC_ISR        \ RTC_RECALPF	Bit Offset:16	Bit Width:1
        
        RTC $10 + constant RTC_PRER	\ read-write		\  : RESET_RTC_PRER $007F00FF 
        \ %xxxxxxx  16 lshift RTC_PRER        \ RTC_PREDIV_A	Bit Offset:16	Bit Width:7
        \ %xxxxxxxxxxxxxxx  0 lshift RTC_PRER        \ RTC_PREDIV_S	Bit Offset:0	Bit Width:15
        
        RTC $1C + constant RTC_ALRMAR	\ read-write		\  : RESET_RTC_ALRMAR $00000000 
        \ %x  31 lshift RTC_ALRMAR        \ RTC_MSK4	Bit Offset:31	Bit Width:1
        \ %x  30 lshift RTC_ALRMAR        \ RTC_WDSEL	Bit Offset:30	Bit Width:1
        \ %xx  28 lshift RTC_ALRMAR        \ RTC_DT	Bit Offset:28	Bit Width:2
        \ %xxxx  24 lshift RTC_ALRMAR        \ RTC_DU	Bit Offset:24	Bit Width:4
        \ %x  23 lshift RTC_ALRMAR        \ RTC_MSK3	Bit Offset:23	Bit Width:1
        \ %x  22 lshift RTC_ALRMAR        \ RTC_PM	Bit Offset:22	Bit Width:1
        \ %xx  20 lshift RTC_ALRMAR        \ RTC_HT	Bit Offset:20	Bit Width:2
        \ %xxxx  16 lshift RTC_ALRMAR        \ RTC_HU	Bit Offset:16	Bit Width:4
        \ %x  15 lshift RTC_ALRMAR        \ RTC_MSK2	Bit Offset:15	Bit Width:1
        \ %xxx  12 lshift RTC_ALRMAR        \ RTC_MNT	Bit Offset:12	Bit Width:3
        \ %xxxx  8 lshift RTC_ALRMAR        \ RTC_MNU	Bit Offset:8	Bit Width:4
        \ %x  7 lshift RTC_ALRMAR        \ RTC_MSK1	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift RTC_ALRMAR        \ RTC_ST	Bit Offset:4	Bit Width:3
        \ %xxxx  0 lshift RTC_ALRMAR        \ RTC_SU	Bit Offset:0	Bit Width:4
        
        RTC $24 + constant RTC_WPR	\ write-only		\  : RESET_RTC_WPR $00000000 
        \ %xxxxxxxx  0 lshift RTC_WPR        \ RTC_KEY	Bit Offset:0	Bit Width:8
        
        RTC $28 + constant RTC_SSR	\ read-only		\  : RESET_RTC_SSR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift RTC_SSR        \ RTC_SS	Bit Offset:0	Bit Width:16
        
        RTC $2C + constant RTC_SHIFTR	\ write-only		\  : RESET_RTC_SHIFTR $00000000 
        \ %x  31 lshift RTC_SHIFTR        \ RTC_ADD1S	Bit Offset:31	Bit Width:1
        \ %xxxxxxxxxxxxxxx  0 lshift RTC_SHIFTR        \ RTC_SUBFS	Bit Offset:0	Bit Width:15
        
        RTC $30 + constant RTC_TSTR	\ read-only		\  : RESET_RTC_TSTR $00000000 
        \ %x  22 lshift RTC_TSTR        \ RTC_PM	Bit Offset:22	Bit Width:1
        \ %xx  20 lshift RTC_TSTR        \ RTC_HT	Bit Offset:20	Bit Width:2
        \ %xxxx  16 lshift RTC_TSTR        \ RTC_HU	Bit Offset:16	Bit Width:4
        \ %xxx  12 lshift RTC_TSTR        \ RTC_MNT	Bit Offset:12	Bit Width:3
        \ %xxxx  8 lshift RTC_TSTR        \ RTC_MNU	Bit Offset:8	Bit Width:4
        \ %xxx  4 lshift RTC_TSTR        \ RTC_ST	Bit Offset:4	Bit Width:3
        \ %xxxx  0 lshift RTC_TSTR        \ RTC_SU	Bit Offset:0	Bit Width:4
        
        RTC $34 + constant RTC_TSDR	\ read-only		\  : RESET_RTC_TSDR $00000000 
        \ %xxx  13 lshift RTC_TSDR        \ RTC_WDU	Bit Offset:13	Bit Width:3
        \ %x  12 lshift RTC_TSDR        \ RTC_MT	Bit Offset:12	Bit Width:1
        \ %xxxx  8 lshift RTC_TSDR        \ RTC_MU	Bit Offset:8	Bit Width:4
        \ %xx  4 lshift RTC_TSDR        \ RTC_DT	Bit Offset:4	Bit Width:2
        \ %xxxx  0 lshift RTC_TSDR        \ RTC_DU	Bit Offset:0	Bit Width:4
        
        RTC $38 + constant RTC_TSSSR	\ read-only		\  : RESET_RTC_TSSSR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift RTC_TSSSR        \ RTC_SS	Bit Offset:0	Bit Width:16
        
        RTC $3C + constant RTC_CALR	\ read-write		\  : RESET_RTC_CALR $00000000 
        \ %x  15 lshift RTC_CALR        \ RTC_CALP	Bit Offset:15	Bit Width:1
        \ %x  14 lshift RTC_CALR        \ RTC_CALW8	Bit Offset:14	Bit Width:1
        \ %x  13 lshift RTC_CALR        \ RTC_CALW16	Bit Offset:13	Bit Width:1
        \ %xxxxxxxxx  0 lshift RTC_CALR        \ RTC_CALM	Bit Offset:0	Bit Width:9
        
        RTC $40 + constant RTC_TAFCR	\ read-write		\  : RESET_RTC_TAFCR $00000000 
        \ %x  23 lshift RTC_TAFCR        \ RTC_PC15MODE	Bit Offset:23	Bit Width:1
        \ %x  22 lshift RTC_TAFCR        \ RTC_PC15VALUE	Bit Offset:22	Bit Width:1
        \ %x  21 lshift RTC_TAFCR        \ RTC_PC14MODE	Bit Offset:21	Bit Width:1
        \ %x  20 lshift RTC_TAFCR        \ RTC_PC14VALUE	Bit Offset:20	Bit Width:1
        \ %x  19 lshift RTC_TAFCR        \ RTC_PC13MODE	Bit Offset:19	Bit Width:1
        \ %x  18 lshift RTC_TAFCR        \ RTC_PC13VALUE	Bit Offset:18	Bit Width:1
        \ %x  15 lshift RTC_TAFCR        \ RTC_TAMP_PUDIS	Bit Offset:15	Bit Width:1
        \ %xx  13 lshift RTC_TAFCR        \ RTC_TAMP_PRCH	Bit Offset:13	Bit Width:2
        \ %xx  11 lshift RTC_TAFCR        \ RTC_TAMPFLT	Bit Offset:11	Bit Width:2
        \ %xxx  8 lshift RTC_TAFCR        \ RTC_TAMPFREQ	Bit Offset:8	Bit Width:3
        \ %x  7 lshift RTC_TAFCR        \ RTC_TAMPTS	Bit Offset:7	Bit Width:1
        \ %x  4 lshift RTC_TAFCR        \ RTC_TAMP2_TRG	Bit Offset:4	Bit Width:1
        \ %x  3 lshift RTC_TAFCR        \ RTC_TAMP2E	Bit Offset:3	Bit Width:1
        \ %x  2 lshift RTC_TAFCR        \ RTC_TAMPIE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift RTC_TAFCR        \ RTC_TAMP1TRG	Bit Offset:1	Bit Width:1
        \ %x  0 lshift RTC_TAFCR        \ RTC_TAMP1E	Bit Offset:0	Bit Width:1
        
        RTC $44 + constant RTC_ALRMASSR	\ read-write		\  : RESET_RTC_ALRMASSR $00000000 
        \ %xxxx  24 lshift RTC_ALRMASSR        \ RTC_MASKSS	Bit Offset:24	Bit Width:4
        \ %xxxxxxxxxxxxxxx  0 lshift RTC_ALRMASSR        \ RTC_SS	Bit Offset:0	Bit Width:15
        
        RTC $50 + constant RTC_BKP0R	\ read-write		\  : RESET_RTC_BKP0R $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift RTC_BKP0R        \ RTC_BKP	Bit Offset:0	Bit Width:32
        
        RTC $54 + constant RTC_BKP1R	\ read-write		\  : RESET_RTC_BKP1R $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift RTC_BKP1R        \ RTC_BKP	Bit Offset:0	Bit Width:32
        
        RTC $58 + constant RTC_BKP2R	\ read-write		\  : RESET_RTC_BKP2R $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift RTC_BKP2R        \ RTC_BKP	Bit Offset:0	Bit Width:32
        
        RTC $5C + constant RTC_BKP3R	\ read-write		\  : RESET_RTC_BKP3R $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift RTC_BKP3R        \ RTC_BKP	Bit Offset:0	Bit Width:32
        
        RTC $60 + constant RTC_BKP4R	\ read-write		\  : RESET_RTC_BKP4R $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift RTC_BKP4R        \ RTC_BKP	Bit Offset:0	Bit Width:32
        
         
	
     $40014000 constant TIM15  
	 TIM15 $0 + constant TIM15_CR1	\ read-write		\  : RESET_TIM15_CR1 $0000 
        \ %xx  8 lshift TIM15_CR1        \ TIM15_CKD	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM15_CR1        \ TIM15_ARPE	Bit Offset:7	Bit Width:1
        \ %x  3 lshift TIM15_CR1        \ TIM15_OPM	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM15_CR1        \ TIM15_URS	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM15_CR1        \ TIM15_UDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM15_CR1        \ TIM15_CEN	Bit Offset:0	Bit Width:1
        
        TIM15 $4 + constant TIM15_CR2	\ read-write		\  : RESET_TIM15_CR2 $0000 
        \ %x  10 lshift TIM15_CR2        \ TIM15_OIS2	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM15_CR2        \ TIM15_OIS1N	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM15_CR2        \ TIM15_OIS1	Bit Offset:8	Bit Width:1
        \ %xxx  4 lshift TIM15_CR2        \ TIM15_MMS	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM15_CR2        \ TIM15_CCDS	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM15_CR2        \ TIM15_CCUS	Bit Offset:2	Bit Width:1
        \ %x  0 lshift TIM15_CR2        \ TIM15_CCPC	Bit Offset:0	Bit Width:1
        
        TIM15 $8 + constant TIM15_SMCR	\ read-write		\  : RESET_TIM15_SMCR $0000 
        \ %x  7 lshift TIM15_SMCR        \ TIM15_MSM	Bit Offset:7	Bit Width:1
        \ %xxx  4 lshift TIM15_SMCR        \ TIM15_TS	Bit Offset:4	Bit Width:3
        \ %xxx  0 lshift TIM15_SMCR        \ TIM15_SMS	Bit Offset:0	Bit Width:3
        
        TIM15 $C + constant TIM15_DIER	\ read-write		\  : RESET_TIM15_DIER $0000 
        \ %x  14 lshift TIM15_DIER        \ TIM15_TDE	Bit Offset:14	Bit Width:1
        \ %x  10 lshift TIM15_DIER        \ TIM15_CC2DE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM15_DIER        \ TIM15_CC1DE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM15_DIER        \ TIM15_UDE	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TIM15_DIER        \ TIM15_BIE	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM15_DIER        \ TIM15_TIE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM15_DIER        \ TIM15_COMIE	Bit Offset:5	Bit Width:1
        \ %x  2 lshift TIM15_DIER        \ TIM15_CC2IE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM15_DIER        \ TIM15_CC1IE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM15_DIER        \ TIM15_UIE	Bit Offset:0	Bit Width:1
        
        TIM15 $10 + constant TIM15_SR	\ read-write		\  : RESET_TIM15_SR $0000 
        \ %x  10 lshift TIM15_SR        \ TIM15_CC2OF	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TIM15_SR        \ TIM15_CC1OF	Bit Offset:9	Bit Width:1
        \ %x  7 lshift TIM15_SR        \ TIM15_BIF	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM15_SR        \ TIM15_TIF	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM15_SR        \ TIM15_COMIF	Bit Offset:5	Bit Width:1
        \ %x  2 lshift TIM15_SR        \ TIM15_CC2IF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM15_SR        \ TIM15_CC1IF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM15_SR        \ TIM15_UIF	Bit Offset:0	Bit Width:1
        
        TIM15 $14 + constant TIM15_EGR	\ write-only		\  : RESET_TIM15_EGR $0000 
        \ %x  7 lshift TIM15_EGR        \ TIM15_BG	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM15_EGR        \ TIM15_TG	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM15_EGR        \ TIM15_COMG	Bit Offset:5	Bit Width:1
        \ %x  2 lshift TIM15_EGR        \ TIM15_CC2G	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM15_EGR        \ TIM15_CC1G	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM15_EGR        \ TIM15_UG	Bit Offset:0	Bit Width:1
        
        TIM15 $18 + constant TIM15_CCMR1_Output	\ read-write		\  : RESET_TIM15_CCMR1_Output $00000000 
        \ %xxx  12 lshift TIM15_CCMR1_Output        \ TIM15_OC2M	Bit Offset:12	Bit Width:3
        \ %x  11 lshift TIM15_CCMR1_Output        \ TIM15_OC2PE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM15_CCMR1_Output        \ TIM15_OC2FE	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM15_CCMR1_Output        \ TIM15_CC2S	Bit Offset:8	Bit Width:2
        \ %xxx  4 lshift TIM15_CCMR1_Output        \ TIM15_OC1M	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM15_CCMR1_Output        \ TIM15_OC1PE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM15_CCMR1_Output        \ TIM15_OC1FE	Bit Offset:2	Bit Width:1
        \ %xx  0 lshift TIM15_CCMR1_Output        \ TIM15_CC1S	Bit Offset:0	Bit Width:2
        
        TIM15 $18 + constant TIM15_CCMR1_Input	\ read-write		\  : RESET_TIM15_CCMR1_Input $00000000 
        \ %xxxx  12 lshift TIM15_CCMR1_Input        \ TIM15_IC2F	Bit Offset:12	Bit Width:4
        \ %xx  10 lshift TIM15_CCMR1_Input        \ TIM15_IC2PSC	Bit Offset:10	Bit Width:2
        \ %xx  8 lshift TIM15_CCMR1_Input        \ TIM15_CC2S	Bit Offset:8	Bit Width:2
        \ %xxxx  4 lshift TIM15_CCMR1_Input        \ TIM15_IC1F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM15_CCMR1_Input        \ TIM15_IC1PSC	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM15_CCMR1_Input        \ TIM15_CC1S	Bit Offset:0	Bit Width:2
        
        TIM15 $20 + constant TIM15_CCER	\ read-write		\  : RESET_TIM15_CCER $0000 
        \ %x  7 lshift TIM15_CCER        \ TIM15_CC2NP	Bit Offset:7	Bit Width:1
        \ %x  5 lshift TIM15_CCER        \ TIM15_CC2P	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TIM15_CCER        \ TIM15_CC2E	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TIM15_CCER        \ TIM15_CC1NP	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM15_CCER        \ TIM15_CC1NE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM15_CCER        \ TIM15_CC1P	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM15_CCER        \ TIM15_CC1E	Bit Offset:0	Bit Width:1
        
        TIM15 $24 + constant TIM15_CNT	\ read-write		\  : RESET_TIM15_CNT $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM15_CNT        \ TIM15_CNT	Bit Offset:0	Bit Width:16
        
        TIM15 $28 + constant TIM15_PSC	\ read-write		\  : RESET_TIM15_PSC $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM15_PSC        \ TIM15_PSC	Bit Offset:0	Bit Width:16
        
        TIM15 $2C + constant TIM15_ARR	\ read-write		\  : RESET_TIM15_ARR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM15_ARR        \ TIM15_ARR	Bit Offset:0	Bit Width:16
        
        TIM15 $30 + constant TIM15_RCR	\ read-write		\  : RESET_TIM15_RCR $0000 
        \ %xxxxxxxx  0 lshift TIM15_RCR        \ TIM15_REP	Bit Offset:0	Bit Width:8
        
        TIM15 $34 + constant TIM15_CCR1	\ read-write		\  : RESET_TIM15_CCR1 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM15_CCR1        \ TIM15_CCR1	Bit Offset:0	Bit Width:16
        
        TIM15 $38 + constant TIM15_CCR2	\ read-write		\  : RESET_TIM15_CCR2 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM15_CCR2        \ TIM15_CCR2	Bit Offset:0	Bit Width:16
        
        TIM15 $44 + constant TIM15_BDTR	\ read-write		\  : RESET_TIM15_BDTR $0000 
        \ %x  15 lshift TIM15_BDTR        \ TIM15_MOE	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TIM15_BDTR        \ TIM15_AOE	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TIM15_BDTR        \ TIM15_BKP	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM15_BDTR        \ TIM15_BKE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM15_BDTR        \ TIM15_OSSR	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM15_BDTR        \ TIM15_OSSI	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM15_BDTR        \ TIM15_LOCK	Bit Offset:8	Bit Width:2
        \ %xxxxxxxx  0 lshift TIM15_BDTR        \ TIM15_DTG	Bit Offset:0	Bit Width:8
        
        TIM15 $48 + constant TIM15_DCR	\ read-write		\  : RESET_TIM15_DCR $0000 
        \ %xxxxx  8 lshift TIM15_DCR        \ TIM15_DBL	Bit Offset:8	Bit Width:5
        \ %xxxxx  0 lshift TIM15_DCR        \ TIM15_DBA	Bit Offset:0	Bit Width:5
        
        TIM15 $4C + constant TIM15_DMAR	\ read-write		\  : RESET_TIM15_DMAR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM15_DMAR        \ TIM15_DMAB	Bit Offset:0	Bit Width:16
        
         
	
     $40014400 constant TIM16  
	 TIM16 $0 + constant TIM16_CR1	\ read-write		\  : RESET_TIM16_CR1 $0000 
        \ %xx  8 lshift TIM16_CR1        \ TIM16_CKD	Bit Offset:8	Bit Width:2
        \ %x  7 lshift TIM16_CR1        \ TIM16_ARPE	Bit Offset:7	Bit Width:1
        \ %x  3 lshift TIM16_CR1        \ TIM16_OPM	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM16_CR1        \ TIM16_URS	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM16_CR1        \ TIM16_UDIS	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM16_CR1        \ TIM16_CEN	Bit Offset:0	Bit Width:1
        
        TIM16 $4 + constant TIM16_CR2	\ read-write		\  : RESET_TIM16_CR2 $0000 
        \ %x  9 lshift TIM16_CR2        \ TIM16_OIS1N	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM16_CR2        \ TIM16_OIS1	Bit Offset:8	Bit Width:1
        \ %x  3 lshift TIM16_CR2        \ TIM16_CCDS	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM16_CR2        \ TIM16_CCUS	Bit Offset:2	Bit Width:1
        \ %x  0 lshift TIM16_CR2        \ TIM16_CCPC	Bit Offset:0	Bit Width:1
        
        TIM16 $C + constant TIM16_DIER	\ read-write		\  : RESET_TIM16_DIER $0000 
        \ %x  14 lshift TIM16_DIER        \ TIM16_TDE	Bit Offset:14	Bit Width:1
        \ %x  9 lshift TIM16_DIER        \ TIM16_CC1DE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TIM16_DIER        \ TIM16_UDE	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TIM16_DIER        \ TIM16_BIE	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM16_DIER        \ TIM16_TIE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM16_DIER        \ TIM16_COMIE	Bit Offset:5	Bit Width:1
        \ %x  1 lshift TIM16_DIER        \ TIM16_CC1IE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM16_DIER        \ TIM16_UIE	Bit Offset:0	Bit Width:1
        
        TIM16 $10 + constant TIM16_SR	\ read-write		\  : RESET_TIM16_SR $0000 
        \ %x  9 lshift TIM16_SR        \ TIM16_CC1OF	Bit Offset:9	Bit Width:1
        \ %x  7 lshift TIM16_SR        \ TIM16_BIF	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM16_SR        \ TIM16_TIF	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM16_SR        \ TIM16_COMIF	Bit Offset:5	Bit Width:1
        \ %x  1 lshift TIM16_SR        \ TIM16_CC1IF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM16_SR        \ TIM16_UIF	Bit Offset:0	Bit Width:1
        
        TIM16 $14 + constant TIM16_EGR	\ write-only		\  : RESET_TIM16_EGR $0000 
        \ %x  7 lshift TIM16_EGR        \ TIM16_BG	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TIM16_EGR        \ TIM16_TG	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TIM16_EGR        \ TIM16_COMG	Bit Offset:5	Bit Width:1
        \ %x  1 lshift TIM16_EGR        \ TIM16_CC1G	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM16_EGR        \ TIM16_UG	Bit Offset:0	Bit Width:1
        
        TIM16 $18 + constant TIM16_CCMR1_Output	\ read-write		\  : RESET_TIM16_CCMR1_Output $00000000 
        \ %xxx  4 lshift TIM16_CCMR1_Output        \ TIM16_OC1M	Bit Offset:4	Bit Width:3
        \ %x  3 lshift TIM16_CCMR1_Output        \ TIM16_OC1PE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM16_CCMR1_Output        \ TIM16_OC1FE	Bit Offset:2	Bit Width:1
        \ %xx  0 lshift TIM16_CCMR1_Output        \ TIM16_CC1S	Bit Offset:0	Bit Width:2
        
        TIM16 $18 + constant TIM16_CCMR1_Input	\ read-write		\  : RESET_TIM16_CCMR1_Input $00000000 
        \ %xxxx  4 lshift TIM16_CCMR1_Input        \ TIM16_IC1F	Bit Offset:4	Bit Width:4
        \ %xx  2 lshift TIM16_CCMR1_Input        \ TIM16_IC1PSC	Bit Offset:2	Bit Width:2
        \ %xx  0 lshift TIM16_CCMR1_Input        \ TIM16_CC1S	Bit Offset:0	Bit Width:2
        
        TIM16 $20 + constant TIM16_CCER	\ read-write		\  : RESET_TIM16_CCER $0000 
        \ %x  3 lshift TIM16_CCER        \ TIM16_CC1NP	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TIM16_CCER        \ TIM16_CC1NE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TIM16_CCER        \ TIM16_CC1P	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TIM16_CCER        \ TIM16_CC1E	Bit Offset:0	Bit Width:1
        
        TIM16 $24 + constant TIM16_CNT	\ read-write		\  : RESET_TIM16_CNT $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM16_CNT        \ TIM16_CNT	Bit Offset:0	Bit Width:16
        
        TIM16 $28 + constant TIM16_PSC	\ read-write		\  : RESET_TIM16_PSC $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM16_PSC        \ TIM16_PSC	Bit Offset:0	Bit Width:16
        
        TIM16 $2C + constant TIM16_ARR	\ read-write		\  : RESET_TIM16_ARR $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM16_ARR        \ TIM16_ARR	Bit Offset:0	Bit Width:16
        
        TIM16 $30 + constant TIM16_RCR	\ read-write		\  : RESET_TIM16_RCR $0000 
        \ %xxxxxxxx  0 lshift TIM16_RCR        \ TIM16_REP	Bit Offset:0	Bit Width:8
        
        TIM16 $34 + constant TIM16_CCR1	\ read-write		\  : RESET_TIM16_CCR1 $00000000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM16_CCR1        \ TIM16_CCR1	Bit Offset:0	Bit Width:16
        
        TIM16 $44 + constant TIM16_BDTR	\ read-write		\  : RESET_TIM16_BDTR $0000 
        \ %x  15 lshift TIM16_BDTR        \ TIM16_MOE	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TIM16_BDTR        \ TIM16_AOE	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TIM16_BDTR        \ TIM16_BKP	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TIM16_BDTR        \ TIM16_BKE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TIM16_BDTR        \ TIM16_OSSR	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TIM16_BDTR        \ TIM16_OSSI	Bit Offset:10	Bit Width:1
        \ %xx  8 lshift TIM16_BDTR        \ TIM16_LOCK	Bit Offset:8	Bit Width:2
        \ %xxxxxxxx  0 lshift TIM16_BDTR        \ TIM16_DTG	Bit Offset:0	Bit Width:8
        
        TIM16 $48 + constant TIM16_DCR	\ read-write		\  : RESET_TIM16_DCR $0000 
        \ %xxxxx  8 lshift TIM16_DCR        \ TIM16_DBL	Bit Offset:8	Bit Width:5
        \ %xxxxx  0 lshift TIM16_DCR        \ TIM16_DBA	Bit Offset:0	Bit Width:5
        
        TIM16 $4C + constant TIM16_DMAR	\ read-write		\  : RESET_TIM16_DMAR $0000 
        \ %xxxxxxxxxxxxxxxx  0 lshift TIM16_DMAR        \ TIM16_DMAB	Bit Offset:0	Bit Width:16
        
         
	
     $40014800 constant TIM17  
	  
	
     $40024000 constant TSC  
	 TSC $0 + constant TSC_CR	\ read-write		\  : RESET_TSC_CR $00000000 
        \ %xxxx  28 lshift TSC_CR        \ TSC_CTPH	Bit Offset:28	Bit Width:4
        \ %xxxx  24 lshift TSC_CR        \ TSC_CTPL	Bit Offset:24	Bit Width:4
        \ %xxxxxxx  17 lshift TSC_CR        \ TSC_SSD	Bit Offset:17	Bit Width:7
        \ %x  16 lshift TSC_CR        \ TSC_SSE	Bit Offset:16	Bit Width:1
        \ %x  15 lshift TSC_CR        \ TSC_SSPSC	Bit Offset:15	Bit Width:1
        \ %xxx  12 lshift TSC_CR        \ TSC_PGPSC	Bit Offset:12	Bit Width:3
        \ %xxx  5 lshift TSC_CR        \ TSC_MCV	Bit Offset:5	Bit Width:3
        \ %x  4 lshift TSC_CR        \ TSC_IODEF	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TSC_CR        \ TSC_SYNCPOL	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TSC_CR        \ TSC_AM	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TSC_CR        \ TSC_START	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_CR        \ TSC_TSCE	Bit Offset:0	Bit Width:1
        
        TSC $4 + constant TSC_IER	\ read-write		\  : RESET_TSC_IER $00000000 
        \ %x  1 lshift TSC_IER        \ TSC_MCEIE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_IER        \ TSC_EOAIE	Bit Offset:0	Bit Width:1
        
        TSC $8 + constant TSC_ICR	\ read-write		\  : RESET_TSC_ICR $00000000 
        \ %x  1 lshift TSC_ICR        \ TSC_MCEIC	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_ICR        \ TSC_EOAIC	Bit Offset:0	Bit Width:1
        
        TSC $C + constant TSC_ISR	\ read-write		\  : RESET_TSC_ISR $00000000 
        \ %x  1 lshift TSC_ISR        \ TSC_MCEF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_ISR        \ TSC_EOAF	Bit Offset:0	Bit Width:1
        
        TSC $10 + constant TSC_IOHCR	\ read-write		\  : RESET_TSC_IOHCR $FFFFFFFF 
        \ %x  23 lshift TSC_IOHCR        \ TSC_G6_IO4	Bit Offset:23	Bit Width:1
        \ %x  22 lshift TSC_IOHCR        \ TSC_G6_IO3	Bit Offset:22	Bit Width:1
        \ %x  21 lshift TSC_IOHCR        \ TSC_G6_IO2	Bit Offset:21	Bit Width:1
        \ %x  20 lshift TSC_IOHCR        \ TSC_G6_IO1	Bit Offset:20	Bit Width:1
        \ %x  19 lshift TSC_IOHCR        \ TSC_G5_IO4	Bit Offset:19	Bit Width:1
        \ %x  18 lshift TSC_IOHCR        \ TSC_G5_IO3	Bit Offset:18	Bit Width:1
        \ %x  17 lshift TSC_IOHCR        \ TSC_G5_IO2	Bit Offset:17	Bit Width:1
        \ %x  16 lshift TSC_IOHCR        \ TSC_G5_IO1	Bit Offset:16	Bit Width:1
        \ %x  15 lshift TSC_IOHCR        \ TSC_G4_IO4	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TSC_IOHCR        \ TSC_G4_IO3	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TSC_IOHCR        \ TSC_G4_IO2	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TSC_IOHCR        \ TSC_G4_IO1	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TSC_IOHCR        \ TSC_G3_IO4	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TSC_IOHCR        \ TSC_G3_IO3	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TSC_IOHCR        \ TSC_G3_IO2	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TSC_IOHCR        \ TSC_G3_IO1	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TSC_IOHCR        \ TSC_G2_IO4	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TSC_IOHCR        \ TSC_G2_IO3	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TSC_IOHCR        \ TSC_G2_IO2	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TSC_IOHCR        \ TSC_G2_IO1	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TSC_IOHCR        \ TSC_G1_IO4	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TSC_IOHCR        \ TSC_G1_IO3	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TSC_IOHCR        \ TSC_G1_IO2	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_IOHCR        \ TSC_G1_IO1	Bit Offset:0	Bit Width:1
        
        TSC $18 + constant TSC_IOASCR	\ read-write		\  : RESET_TSC_IOASCR $00000000 
        \ %x  23 lshift TSC_IOASCR        \ TSC_G6_IO4	Bit Offset:23	Bit Width:1
        \ %x  22 lshift TSC_IOASCR        \ TSC_G6_IO3	Bit Offset:22	Bit Width:1
        \ %x  21 lshift TSC_IOASCR        \ TSC_G6_IO2	Bit Offset:21	Bit Width:1
        \ %x  20 lshift TSC_IOASCR        \ TSC_G6_IO1	Bit Offset:20	Bit Width:1
        \ %x  19 lshift TSC_IOASCR        \ TSC_G5_IO4	Bit Offset:19	Bit Width:1
        \ %x  18 lshift TSC_IOASCR        \ TSC_G5_IO3	Bit Offset:18	Bit Width:1
        \ %x  17 lshift TSC_IOASCR        \ TSC_G5_IO2	Bit Offset:17	Bit Width:1
        \ %x  16 lshift TSC_IOASCR        \ TSC_G5_IO1	Bit Offset:16	Bit Width:1
        \ %x  15 lshift TSC_IOASCR        \ TSC_G4_IO4	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TSC_IOASCR        \ TSC_G4_IO3	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TSC_IOASCR        \ TSC_G4_IO2	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TSC_IOASCR        \ TSC_G4_IO1	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TSC_IOASCR        \ TSC_G3_IO4	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TSC_IOASCR        \ TSC_G3_IO3	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TSC_IOASCR        \ TSC_G3_IO2	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TSC_IOASCR        \ TSC_G3_IO1	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TSC_IOASCR        \ TSC_G2_IO4	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TSC_IOASCR        \ TSC_G2_IO3	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TSC_IOASCR        \ TSC_G2_IO2	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TSC_IOASCR        \ TSC_G2_IO1	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TSC_IOASCR        \ TSC_G1_IO4	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TSC_IOASCR        \ TSC_G1_IO3	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TSC_IOASCR        \ TSC_G1_IO2	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_IOASCR        \ TSC_G1_IO1	Bit Offset:0	Bit Width:1
        
        TSC $20 + constant TSC_IOSCR	\ read-write		\  : RESET_TSC_IOSCR $00000000 
        \ %x  23 lshift TSC_IOSCR        \ TSC_G6_IO4	Bit Offset:23	Bit Width:1
        \ %x  22 lshift TSC_IOSCR        \ TSC_G6_IO3	Bit Offset:22	Bit Width:1
        \ %x  21 lshift TSC_IOSCR        \ TSC_G6_IO2	Bit Offset:21	Bit Width:1
        \ %x  20 lshift TSC_IOSCR        \ TSC_G6_IO1	Bit Offset:20	Bit Width:1
        \ %x  19 lshift TSC_IOSCR        \ TSC_G5_IO4	Bit Offset:19	Bit Width:1
        \ %x  18 lshift TSC_IOSCR        \ TSC_G5_IO3	Bit Offset:18	Bit Width:1
        \ %x  17 lshift TSC_IOSCR        \ TSC_G5_IO2	Bit Offset:17	Bit Width:1
        \ %x  16 lshift TSC_IOSCR        \ TSC_G5_IO1	Bit Offset:16	Bit Width:1
        \ %x  15 lshift TSC_IOSCR        \ TSC_G4_IO4	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TSC_IOSCR        \ TSC_G4_IO3	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TSC_IOSCR        \ TSC_G4_IO2	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TSC_IOSCR        \ TSC_G4_IO1	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TSC_IOSCR        \ TSC_G3_IO4	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TSC_IOSCR        \ TSC_G3_IO3	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TSC_IOSCR        \ TSC_G3_IO2	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TSC_IOSCR        \ TSC_G3_IO1	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TSC_IOSCR        \ TSC_G2_IO4	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TSC_IOSCR        \ TSC_G2_IO3	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TSC_IOSCR        \ TSC_G2_IO2	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TSC_IOSCR        \ TSC_G2_IO1	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TSC_IOSCR        \ TSC_G1_IO4	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TSC_IOSCR        \ TSC_G1_IO3	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TSC_IOSCR        \ TSC_G1_IO2	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_IOSCR        \ TSC_G1_IO1	Bit Offset:0	Bit Width:1
        
        TSC $28 + constant TSC_IOCCR	\ read-write		\  : RESET_TSC_IOCCR $00000000 
        \ %x  23 lshift TSC_IOCCR        \ TSC_G6_IO4	Bit Offset:23	Bit Width:1
        \ %x  22 lshift TSC_IOCCR        \ TSC_G6_IO3	Bit Offset:22	Bit Width:1
        \ %x  21 lshift TSC_IOCCR        \ TSC_G6_IO2	Bit Offset:21	Bit Width:1
        \ %x  20 lshift TSC_IOCCR        \ TSC_G6_IO1	Bit Offset:20	Bit Width:1
        \ %x  19 lshift TSC_IOCCR        \ TSC_G5_IO4	Bit Offset:19	Bit Width:1
        \ %x  18 lshift TSC_IOCCR        \ TSC_G5_IO3	Bit Offset:18	Bit Width:1
        \ %x  17 lshift TSC_IOCCR        \ TSC_G5_IO2	Bit Offset:17	Bit Width:1
        \ %x  16 lshift TSC_IOCCR        \ TSC_G5_IO1	Bit Offset:16	Bit Width:1
        \ %x  15 lshift TSC_IOCCR        \ TSC_G4_IO4	Bit Offset:15	Bit Width:1
        \ %x  14 lshift TSC_IOCCR        \ TSC_G4_IO3	Bit Offset:14	Bit Width:1
        \ %x  13 lshift TSC_IOCCR        \ TSC_G4_IO2	Bit Offset:13	Bit Width:1
        \ %x  12 lshift TSC_IOCCR        \ TSC_G4_IO1	Bit Offset:12	Bit Width:1
        \ %x  11 lshift TSC_IOCCR        \ TSC_G3_IO4	Bit Offset:11	Bit Width:1
        \ %x  10 lshift TSC_IOCCR        \ TSC_G3_IO3	Bit Offset:10	Bit Width:1
        \ %x  9 lshift TSC_IOCCR        \ TSC_G3_IO2	Bit Offset:9	Bit Width:1
        \ %x  8 lshift TSC_IOCCR        \ TSC_G3_IO1	Bit Offset:8	Bit Width:1
        \ %x  7 lshift TSC_IOCCR        \ TSC_G2_IO4	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TSC_IOCCR        \ TSC_G2_IO3	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TSC_IOCCR        \ TSC_G2_IO2	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TSC_IOCCR        \ TSC_G2_IO1	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TSC_IOCCR        \ TSC_G1_IO4	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TSC_IOCCR        \ TSC_G1_IO3	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TSC_IOCCR        \ TSC_G1_IO2	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_IOCCR        \ TSC_G1_IO1	Bit Offset:0	Bit Width:1
        
        TSC $30 + constant TSC_IOGCSR	\ 		\  : RESET_TSC_IOGCSR $00000000 
        \ %x  23 lshift TSC_IOGCSR        \ TSC_G8S	Bit Offset:23	Bit Width:1
        \ %x  22 lshift TSC_IOGCSR        \ TSC_G7S	Bit Offset:22	Bit Width:1
        \ %x  21 lshift TSC_IOGCSR        \ TSC_G6S	Bit Offset:21	Bit Width:1
        \ %x  20 lshift TSC_IOGCSR        \ TSC_G5S	Bit Offset:20	Bit Width:1
        \ %x  19 lshift TSC_IOGCSR        \ TSC_G4S	Bit Offset:19	Bit Width:1
        \ %x  18 lshift TSC_IOGCSR        \ TSC_G3S	Bit Offset:18	Bit Width:1
        \ %x  17 lshift TSC_IOGCSR        \ TSC_G2S	Bit Offset:17	Bit Width:1
        \ %x  16 lshift TSC_IOGCSR        \ TSC_G1S	Bit Offset:16	Bit Width:1
        \ %x  7 lshift TSC_IOGCSR        \ TSC_G8E	Bit Offset:7	Bit Width:1
        \ %x  6 lshift TSC_IOGCSR        \ TSC_G7E	Bit Offset:6	Bit Width:1
        \ %x  5 lshift TSC_IOGCSR        \ TSC_G6E	Bit Offset:5	Bit Width:1
        \ %x  4 lshift TSC_IOGCSR        \ TSC_G5E	Bit Offset:4	Bit Width:1
        \ %x  3 lshift TSC_IOGCSR        \ TSC_G4E	Bit Offset:3	Bit Width:1
        \ %x  2 lshift TSC_IOGCSR        \ TSC_G3E	Bit Offset:2	Bit Width:1
        \ %x  1 lshift TSC_IOGCSR        \ TSC_G2E	Bit Offset:1	Bit Width:1
        \ %x  0 lshift TSC_IOGCSR        \ TSC_G1E	Bit Offset:0	Bit Width:1
        
        TSC $34 + constant TSC_IOG1CR	\ read-only		\  : RESET_TSC_IOG1CR $00000000 
        \ %xxxxxxxxxxxxxx  0 lshift TSC_IOG1CR        \ TSC_CNT	Bit Offset:0	Bit Width:14
        
        TSC $38 + constant TSC_IOG2CR	\ read-only		\  : RESET_TSC_IOG2CR $00000000 
        \ %xxxxxxxxxxxxxx  0 lshift TSC_IOG2CR        \ TSC_CNT	Bit Offset:0	Bit Width:14
        
        TSC $3C + constant TSC_IOG3CR	\ read-only		\  : RESET_TSC_IOG3CR $00000000 
        \ %xxxxxxxxxxxxxx  0 lshift TSC_IOG3CR        \ TSC_CNT	Bit Offset:0	Bit Width:14
        
        TSC $40 + constant TSC_IOG4CR	\ read-only		\  : RESET_TSC_IOG4CR $00000000 
        \ %xxxxxxxxxxxxxx  0 lshift TSC_IOG4CR        \ TSC_CNT	Bit Offset:0	Bit Width:14
        
        TSC $44 + constant TSC_IOG5CR	\ read-only		\  : RESET_TSC_IOG5CR $00000000 
        \ %xxxxxxxxxxxxxx  0 lshift TSC_IOG5CR        \ TSC_CNT	Bit Offset:0	Bit Width:14
        
        TSC $48 + constant TSC_IOG6CR	\ read-only		\  : RESET_TSC_IOG6CR $00000000 
        \ %xxxxxxxxxxxxxx  0 lshift TSC_IOG6CR        \ TSC_CNT	Bit Offset:0	Bit Width:14
        
         
	
     $40007800 constant CEC  
	 CEC $0 + constant CEC_CR	\ read-write		\  : RESET_CEC_CR $00000000 
        \ %x  2 lshift CEC_CR        \ CEC_TXEOM	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CEC_CR        \ CEC_TXSOM	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CEC_CR        \ CEC_CECEN	Bit Offset:0	Bit Width:1
        
        CEC $4 + constant CEC_CFGR	\ read-write		\  : RESET_CEC_CFGR $00000000 
        \ %x  11 lshift CEC_CFGR        \ CEC_LBPEGEN	Bit Offset:11	Bit Width:1
        \ %x  10 lshift CEC_CFGR        \ CEC_BREGEN	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CEC_CFGR        \ CEC_BRESTP	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CEC_CFGR        \ CEC_RXTOL	Bit Offset:8	Bit Width:1
        \ %xxx  5 lshift CEC_CFGR        \ CEC_SFT	Bit Offset:5	Bit Width:3
        \ %x  4 lshift CEC_CFGR        \ CEC_LSTN	Bit Offset:4	Bit Width:1
        \ %xxxx  0 lshift CEC_CFGR        \ CEC_OAR	Bit Offset:0	Bit Width:4
        
        CEC $8 + constant CEC_TXDR	\ write-only		\  : RESET_CEC_TXDR $00000000 
        \ %xxxxxxxx  0 lshift CEC_TXDR        \ CEC_TXD	Bit Offset:0	Bit Width:8
        
        CEC $C + constant CEC_RXDR	\ read-only		\  : RESET_CEC_RXDR $00000000 
        \ %xxxxxxxx  0 lshift CEC_RXDR        \ CEC_RXDR	Bit Offset:0	Bit Width:8
        
        CEC $10 + constant CEC_ISR	\ read-write		\  : RESET_CEC_ISR $00000000 
        \ %x  12 lshift CEC_ISR        \ CEC_TXACKE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift CEC_ISR        \ CEC_TXERR	Bit Offset:11	Bit Width:1
        \ %x  10 lshift CEC_ISR        \ CEC_TXUDR	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CEC_ISR        \ CEC_TXEND	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CEC_ISR        \ CEC_TXBR	Bit Offset:8	Bit Width:1
        \ %x  7 lshift CEC_ISR        \ CEC_ARBLST	Bit Offset:7	Bit Width:1
        \ %x  6 lshift CEC_ISR        \ CEC_RXACKE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift CEC_ISR        \ CEC_LBPE	Bit Offset:5	Bit Width:1
        \ %x  4 lshift CEC_ISR        \ CEC_SBPE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CEC_ISR        \ CEC_BRE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CEC_ISR        \ CEC_RXOVR	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CEC_ISR        \ CEC_RXEND	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CEC_ISR        \ CEC_RXBR	Bit Offset:0	Bit Width:1
        
        CEC $14 + constant CEC_IER	\ read-write		\  : RESET_CEC_IER $00000000 
        \ %x  12 lshift CEC_IER        \ CEC_TXACKIE	Bit Offset:12	Bit Width:1
        \ %x  11 lshift CEC_IER        \ CEC_TXERRIE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift CEC_IER        \ CEC_TXUDRIE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CEC_IER        \ CEC_TXENDIE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CEC_IER        \ CEC_TXBRIE	Bit Offset:8	Bit Width:1
        \ %x  7 lshift CEC_IER        \ CEC_ARBLSTIE	Bit Offset:7	Bit Width:1
        \ %x  6 lshift CEC_IER        \ CEC_RXACKIE	Bit Offset:6	Bit Width:1
        \ %x  5 lshift CEC_IER        \ CEC_LBPEIE	Bit Offset:5	Bit Width:1
        \ %x  4 lshift CEC_IER        \ CEC_SBPEIE	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CEC_IER        \ CEC_BREIE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CEC_IER        \ CEC_RXOVRIE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CEC_IER        \ CEC_RXENDIE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CEC_IER        \ CEC_RXBRIE	Bit Offset:0	Bit Width:1
        
         
	
     $40022000 constant Flash  
	 Flash $0 + constant Flash_ACR	\ 		\  : RESET_Flash_ACR $00000030 
        \ %xxx  0 lshift Flash_ACR        \ Flash_LATENCY	Bit Offset:0	Bit Width:3
        \ %x  4 lshift Flash_ACR        \ Flash_PRFTBE	Bit Offset:4	Bit Width:1
        \ %x  5 lshift Flash_ACR        \ Flash_PRFTBS	Bit Offset:5	Bit Width:1
        
        Flash $4 + constant Flash_KEYR	\ write-only		\  : RESET_Flash_KEYR $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift Flash_KEYR        \ Flash_FKEYR	Bit Offset:0	Bit Width:32
        
        Flash $8 + constant Flash_OPTKEYR	\ write-only		\  : RESET_Flash_OPTKEYR $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift Flash_OPTKEYR        \ Flash_OPTKEYR	Bit Offset:0	Bit Width:32
        
        Flash $C + constant Flash_SR	\ 		\  : RESET_Flash_SR $00000000 
        \ %x  5 lshift Flash_SR        \ Flash_EOP	Bit Offset:5	Bit Width:1
        \ %x  4 lshift Flash_SR        \ Flash_WRPRT	Bit Offset:4	Bit Width:1
        \ %x  2 lshift Flash_SR        \ Flash_PGERR	Bit Offset:2	Bit Width:1
        \ %x  0 lshift Flash_SR        \ Flash_BSY	Bit Offset:0	Bit Width:1
        
        Flash $10 + constant Flash_CR	\ read-write		\  : RESET_Flash_CR $00000080 
        \ %x  13 lshift Flash_CR        \ Flash_FORCE_OPTLOAD	Bit Offset:13	Bit Width:1
        \ %x  12 lshift Flash_CR        \ Flash_EOPIE	Bit Offset:12	Bit Width:1
        \ %x  10 lshift Flash_CR        \ Flash_ERRIE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift Flash_CR        \ Flash_OPTWRE	Bit Offset:9	Bit Width:1
        \ %x  7 lshift Flash_CR        \ Flash_LOCK	Bit Offset:7	Bit Width:1
        \ %x  6 lshift Flash_CR        \ Flash_STRT	Bit Offset:6	Bit Width:1
        \ %x  5 lshift Flash_CR        \ Flash_OPTER	Bit Offset:5	Bit Width:1
        \ %x  4 lshift Flash_CR        \ Flash_OPTPG	Bit Offset:4	Bit Width:1
        \ %x  2 lshift Flash_CR        \ Flash_MER	Bit Offset:2	Bit Width:1
        \ %x  1 lshift Flash_CR        \ Flash_PER	Bit Offset:1	Bit Width:1
        \ %x  0 lshift Flash_CR        \ Flash_PG	Bit Offset:0	Bit Width:1
        
        Flash $14 + constant Flash_AR	\ write-only		\  : RESET_Flash_AR $00000000 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift Flash_AR        \ Flash_FAR	Bit Offset:0	Bit Width:32
        
        Flash $1C + constant Flash_OBR	\ read-only		\  : RESET_Flash_OBR $03FFFFF2 
        \ %xxxxxxxx  24 lshift Flash_OBR        \ Flash_Data1	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift Flash_OBR        \ Flash_Data0	Bit Offset:16	Bit Width:8
        \ %x  13 lshift Flash_OBR        \ Flash_VDDA_MONITOR	Bit Offset:13	Bit Width:1
        \ %x  12 lshift Flash_OBR        \ Flash_BOOT1	Bit Offset:12	Bit Width:1
        \ %x  10 lshift Flash_OBR        \ Flash_nRST_STDBY	Bit Offset:10	Bit Width:1
        \ %x  9 lshift Flash_OBR        \ Flash_nRST_STOP	Bit Offset:9	Bit Width:1
        \ %x  8 lshift Flash_OBR        \ Flash_WDG_SW	Bit Offset:8	Bit Width:1
        \ %x  2 lshift Flash_OBR        \ Flash_LEVEL2_PROT	Bit Offset:2	Bit Width:1
        \ %x  1 lshift Flash_OBR        \ Flash_LEVEL1_PROT	Bit Offset:1	Bit Width:1
        \ %x  0 lshift Flash_OBR        \ Flash_OPTERR	Bit Offset:0	Bit Width:1
        
        Flash $20 + constant Flash_WRPR	\ read-only		\  : RESET_Flash_WRPR $FFFFFFFF 
        \ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift Flash_WRPR        \ Flash_WRP	Bit Offset:0	Bit Width:32
        
         
	
     $40015800 constant DBGMCU  
	 DBGMCU $0 + constant DBGMCU_IDCODE	\ read-only		\  : RESET_DBGMCU_IDCODE $0 
        \ %xxxxxxxxxxxx  0 lshift DBGMCU_IDCODE        \ DBGMCU_DEV_ID	Bit Offset:0	Bit Width:12
        \ %xxxx  12 lshift DBGMCU_IDCODE        \ DBGMCU_DIV_ID	Bit Offset:12	Bit Width:4
        \ %xxxxxxxxxxxxxxxx  16 lshift DBGMCU_IDCODE        \ DBGMCU_REV_ID	Bit Offset:16	Bit Width:16
        
        DBGMCU $4 + constant DBGMCU_CR	\ read-write		\  : RESET_DBGMCU_CR $0 
        \ %x  1 lshift DBGMCU_CR        \ DBGMCU_DBG_STOP	Bit Offset:1	Bit Width:1
        \ %x  2 lshift DBGMCU_CR        \ DBGMCU_DBG_STANDBY	Bit Offset:2	Bit Width:1
        
        DBGMCU $8 + constant DBGMCU_APBLFZ	\ read-write		\  : RESET_DBGMCU_APBLFZ $0 
        \ %x  0 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_TIMER2_STOP	Bit Offset:0	Bit Width:1
        \ %x  1 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_TIMER3_STOP	Bit Offset:1	Bit Width:1
        \ %x  4 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_TIMER6_STOP	Bit Offset:4	Bit Width:1
        \ %x  8 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_TIMER14_STOP	Bit Offset:8	Bit Width:1
        \ %x  10 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_RTC_STOP	Bit Offset:10	Bit Width:1
        \ %x  11 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_WWDG_STOP	Bit Offset:11	Bit Width:1
        \ %x  12 lshift DBGMCU_APBLFZ        \ DBGMCU_DBG_IWDG_STOP	Bit Offset:12	Bit Width:1
        \ %x  21 lshift DBGMCU_APBLFZ        \ DBGMCU_I2C1_SMBUS_TIMEOUT	Bit Offset:21	Bit Width:1
        
        DBGMCU $C + constant DBGMCU_APBHFZ	\ read-write		\  : RESET_DBGMCU_APBHFZ $0 
        \ %x  11 lshift DBGMCU_APBHFZ        \ DBGMCU_DBG_TIMER1_STOP	Bit Offset:11	Bit Width:1
        \ %x  16 lshift DBGMCU_APBHFZ        \ DBGMCU_DBG_TIMER15_STO	Bit Offset:16	Bit Width:1
        \ %x  17 lshift DBGMCU_APBHFZ        \ DBGMCU_DBG_TIMER16_STO	Bit Offset:17	Bit Width:1
        \ %x  18 lshift DBGMCU_APBHFZ        \ DBGMCU_DBG_TIMER17_STO	Bit Offset:18	Bit Width:1
        
         
	
     $40005C00 constant USB  
	 USB $0 + constant USB_EP0R	\ read-write		\  : RESET_USB_EP0R $00000000 
        \ %xxxx  0 lshift USB_EP0R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP0R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP0R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP0R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP0R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP0R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP0R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP0R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP0R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP0R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $4 + constant USB_EP1R	\ read-write		\  : RESET_USB_EP1R $00000000 
        \ %xxxx  0 lshift USB_EP1R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP1R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP1R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP1R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP1R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP1R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP1R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP1R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP1R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP1R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $8 + constant USB_EP2R	\ read-write		\  : RESET_USB_EP2R $00000000 
        \ %xxxx  0 lshift USB_EP2R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP2R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP2R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP2R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP2R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP2R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP2R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP2R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP2R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP2R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $C + constant USB_EP3R	\ read-write		\  : RESET_USB_EP3R $00000000 
        \ %xxxx  0 lshift USB_EP3R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP3R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP3R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP3R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP3R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP3R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP3R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP3R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP3R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP3R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $10 + constant USB_EP4R	\ read-write		\  : RESET_USB_EP4R $00000000 
        \ %xxxx  0 lshift USB_EP4R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP4R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP4R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP4R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP4R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP4R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP4R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP4R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP4R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP4R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $14 + constant USB_EP5R	\ read-write		\  : RESET_USB_EP5R $00000000 
        \ %xxxx  0 lshift USB_EP5R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP5R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP5R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP5R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP5R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP5R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP5R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP5R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP5R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP5R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $18 + constant USB_EP6R	\ read-write		\  : RESET_USB_EP6R $00000000 
        \ %xxxx  0 lshift USB_EP6R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP6R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP6R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP6R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP6R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP6R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP6R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP6R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP6R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP6R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $1C + constant USB_EP7R	\ read-write		\  : RESET_USB_EP7R $00000000 
        \ %xxxx  0 lshift USB_EP7R        \ USB_EA	Bit Offset:0	Bit Width:4
        \ %xx  4 lshift USB_EP7R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
        \ %x  6 lshift USB_EP7R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_EP7R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_EP7R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
        \ %xx  9 lshift USB_EP7R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
        \ %x  11 lshift USB_EP7R        \ USB_SETUP	Bit Offset:11	Bit Width:1
        \ %xx  12 lshift USB_EP7R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
        \ %x  14 lshift USB_EP7R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_EP7R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1
        
        USB $40 + constant USB_CNTR	\ read-write		\  : RESET_USB_CNTR $00000003 
        \ %x  0 lshift USB_CNTR        \ USB_FRES	Bit Offset:0	Bit Width:1
        \ %x  1 lshift USB_CNTR        \ USB_PDWN	Bit Offset:1	Bit Width:1
        \ %x  2 lshift USB_CNTR        \ USB_LPMODE	Bit Offset:2	Bit Width:1
        \ %x  3 lshift USB_CNTR        \ USB_FSUSP	Bit Offset:3	Bit Width:1
        \ %x  4 lshift USB_CNTR        \ USB_RESUME	Bit Offset:4	Bit Width:1
        \ %x  5 lshift USB_CNTR        \ USB_L1RESUME	Bit Offset:5	Bit Width:1
        \ %x  7 lshift USB_CNTR        \ USB_L1REQM	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_CNTR        \ USB_ESOFM	Bit Offset:8	Bit Width:1
        \ %x  9 lshift USB_CNTR        \ USB_SOFM	Bit Offset:9	Bit Width:1
        \ %x  10 lshift USB_CNTR        \ USB_RESETM	Bit Offset:10	Bit Width:1
        \ %x  11 lshift USB_CNTR        \ USB_SUSPM	Bit Offset:11	Bit Width:1
        \ %x  12 lshift USB_CNTR        \ USB_WKUPM	Bit Offset:12	Bit Width:1
        \ %x  13 lshift USB_CNTR        \ USB_ERRM	Bit Offset:13	Bit Width:1
        \ %x  14 lshift USB_CNTR        \ USB_PMAOVRM	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_CNTR        \ USB_CTRM	Bit Offset:15	Bit Width:1
        
        USB $44 + constant USB_ISTR	\ 		\  : RESET_USB_ISTR $00000000 
        \ %xxxx  0 lshift USB_ISTR        \ USB_EP_ID	Bit Offset:0	Bit Width:4
        \ %x  4 lshift USB_ISTR        \ USB_DIR	Bit Offset:4	Bit Width:1
        \ %x  7 lshift USB_ISTR        \ USB_L1REQ	Bit Offset:7	Bit Width:1
        \ %x  8 lshift USB_ISTR        \ USB_ESOF	Bit Offset:8	Bit Width:1
        \ %x  9 lshift USB_ISTR        \ USB_SOF	Bit Offset:9	Bit Width:1
        \ %x  10 lshift USB_ISTR        \ USB_RESET	Bit Offset:10	Bit Width:1
        \ %x  11 lshift USB_ISTR        \ USB_SUSP	Bit Offset:11	Bit Width:1
        \ %x  12 lshift USB_ISTR        \ USB_WKUP	Bit Offset:12	Bit Width:1
        \ %x  13 lshift USB_ISTR        \ USB_ERR	Bit Offset:13	Bit Width:1
        \ %x  14 lshift USB_ISTR        \ USB_PMAOVR	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_ISTR        \ USB_CTR	Bit Offset:15	Bit Width:1
        
        USB $48 + constant USB_FNR	\ read-only		\  : RESET_USB_FNR $0000 
        \ % 0 lshift USB_FNR        \ USB_FN	Bit Offset:0	Bit Width:11
        \ %xx  11 lshift USB_FNR        \ USB_LSOF	Bit Offset:11	Bit Width:2
        \ %x  13 lshift USB_FNR        \ USB_LCK	Bit Offset:13	Bit Width:1
        \ %x  14 lshift USB_FNR        \ USB_RXDM	Bit Offset:14	Bit Width:1
        \ %x  15 lshift USB_FNR        \ USB_RXDP	Bit Offset:15	Bit Width:1
        
        USB $4C + constant USB_DADDR	\ read-write		\  : RESET_USB_DADDR $0000 
        \ %xxxxxxx  0 lshift USB_DADDR        \ USB_ADD	Bit Offset:0	Bit Width:7
        \ %x  7 lshift USB_DADDR        \ USB_EF	Bit Offset:7	Bit Width:1
        
        USB $50 + constant USB_BTABLE	\ read-write		\  : RESET_USB_BTABLE $0000 
        \ % 3 lshift USB_BTABLE        \ USB_BTABLE	Bit Offset:3	Bit Width:13
        
        USB $54 + constant USB_LPMCSR	\ 		\  : RESET_USB_LPMCSR $0000 
        \ %x  0 lshift USB_LPMCSR        \ USB_LPMEN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift USB_LPMCSR        \ USB_LPMACK	Bit Offset:1	Bit Width:1
        \ %x  3 lshift USB_LPMCSR        \ USB_REMWAKE	Bit Offset:3	Bit Width:1
        \ %xxxx  4 lshift USB_LPMCSR        \ USB_BESL	Bit Offset:4	Bit Width:4
        
        USB $58 + constant USB_BCDR	\ 		\  : RESET_USB_BCDR $0000 
        \ %x  0 lshift USB_BCDR        \ USB_BCDEN	Bit Offset:0	Bit Width:1
        \ %x  1 lshift USB_BCDR        \ USB_DCDEN	Bit Offset:1	Bit Width:1
        \ %x  2 lshift USB_BCDR        \ USB_PDEN	Bit Offset:2	Bit Width:1
        \ %x  3 lshift USB_BCDR        \ USB_SDEN	Bit Offset:3	Bit Width:1
        \ %x  4 lshift USB_BCDR        \ USB_DCDET	Bit Offset:4	Bit Width:1
        \ %x  5 lshift USB_BCDR        \ USB_PDET	Bit Offset:5	Bit Width:1
        \ %x  6 lshift USB_BCDR        \ USB_SDET	Bit Offset:6	Bit Width:1
        \ %x  7 lshift USB_BCDR        \ USB_PS2DET	Bit Offset:7	Bit Width:1
        \ %x  15 lshift USB_BCDR        \ USB_DPPU	Bit Offset:15	Bit Width:1
        
         
	
     $40006C00 constant CRS  
	 CRS $0 + constant CRS_CR	\ read-write		\  : RESET_CRS_CR $00002000 
        \ %xxxxxx  8 lshift CRS_CR        \ CRS_TRIM	Bit Offset:8	Bit Width:6
        \ %x  7 lshift CRS_CR        \ CRS_SWSYNC	Bit Offset:7	Bit Width:1
        \ %x  6 lshift CRS_CR        \ CRS_AUTOTRIMEN	Bit Offset:6	Bit Width:1
        \ %x  5 lshift CRS_CR        \ CRS_CEN	Bit Offset:5	Bit Width:1
        \ %x  3 lshift CRS_CR        \ CRS_ESYNCIE	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CRS_CR        \ CRS_ERRIE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CRS_CR        \ CRS_SYNCWARNIE	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CRS_CR        \ CRS_SYNCOKIE	Bit Offset:0	Bit Width:1
        
        CRS $4 + constant CRS_CFGR	\ read-write		\  : RESET_CRS_CFGR $2022BB7F 
        \ %x  31 lshift CRS_CFGR        \ CRS_SYNCPOL	Bit Offset:31	Bit Width:1
        \ %xx  28 lshift CRS_CFGR        \ CRS_SYNCSRC	Bit Offset:28	Bit Width:2
        \ %xxx  24 lshift CRS_CFGR        \ CRS_SYNCDIV	Bit Offset:24	Bit Width:3
        \ %xxxxxxxx  16 lshift CRS_CFGR        \ CRS_FELIM	Bit Offset:16	Bit Width:8
        \ %xxxxxxxxxxxxxxxx  0 lshift CRS_CFGR        \ CRS_RELOAD	Bit Offset:0	Bit Width:16
        
        CRS $8 + constant CRS_ISR	\ read-only		\  : RESET_CRS_ISR $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift CRS_ISR        \ CRS_FECAP	Bit Offset:16	Bit Width:16
        \ %x  15 lshift CRS_ISR        \ CRS_FEDIR	Bit Offset:15	Bit Width:1
        \ %x  10 lshift CRS_ISR        \ CRS_TRIMOVF	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CRS_ISR        \ CRS_SYNCMISS	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CRS_ISR        \ CRS_SYNCERR	Bit Offset:8	Bit Width:1
        \ %x  3 lshift CRS_ISR        \ CRS_ESYNCF	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CRS_ISR        \ CRS_ERRF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CRS_ISR        \ CRS_SYNCWARNF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CRS_ISR        \ CRS_SYNCOKF	Bit Offset:0	Bit Width:1
        
        CRS $C + constant CRS_ICR	\ read-write		\  : RESET_CRS_ICR $00000000 
        \ %x  3 lshift CRS_ICR        \ CRS_ESYNCC	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CRS_ICR        \ CRS_ERRC	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CRS_ICR        \ CRS_SYNCWARNC	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CRS_ICR        \ CRS_SYNCOKC	Bit Offset:0	Bit Width:1
        
         
	
     $40006400 constant CAN  
	 CAN $0 + constant CAN_CAN_MCR	\ read-write		\  : RESET_CAN_CAN_MCR $00000000 
        \ %x  16 lshift CAN_CAN_MCR        \ CAN_DBF	Bit Offset:16	Bit Width:1
        \ %x  15 lshift CAN_CAN_MCR        \ CAN_RESET	Bit Offset:15	Bit Width:1
        \ %x  7 lshift CAN_CAN_MCR        \ CAN_TTCM	Bit Offset:7	Bit Width:1
        \ %x  6 lshift CAN_CAN_MCR        \ CAN_ABOM	Bit Offset:6	Bit Width:1
        \ %x  5 lshift CAN_CAN_MCR        \ CAN_AWUM	Bit Offset:5	Bit Width:1
        \ %x  4 lshift CAN_CAN_MCR        \ CAN_NART	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CAN_CAN_MCR        \ CAN_RFLM	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CAN_CAN_MCR        \ CAN_TXFP	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_MCR        \ CAN_SLEEP	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_MCR        \ CAN_INRQ	Bit Offset:0	Bit Width:1
        
        CAN $4 + constant CAN_CAN_MSR	\ 		\  : RESET_CAN_CAN_MSR $00000000 
        \ %x  11 lshift CAN_CAN_MSR        \ CAN_RX	Bit Offset:11	Bit Width:1
        \ %x  10 lshift CAN_CAN_MSR        \ CAN_SAMP	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CAN_CAN_MSR        \ CAN_RXM	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CAN_CAN_MSR        \ CAN_TXM	Bit Offset:8	Bit Width:1
        \ %x  4 lshift CAN_CAN_MSR        \ CAN_SLAKI	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CAN_CAN_MSR        \ CAN_WKUI	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CAN_CAN_MSR        \ CAN_ERRI	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_MSR        \ CAN_SLAK	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_MSR        \ CAN_INAK	Bit Offset:0	Bit Width:1
        
        CAN $8 + constant CAN_CAN_TSR	\ 		\  : RESET_CAN_CAN_TSR $00000000 
        \ %x  31 lshift CAN_CAN_TSR        \ CAN_LOW2	Bit Offset:31	Bit Width:1
        \ %x  30 lshift CAN_CAN_TSR        \ CAN_LOW1	Bit Offset:30	Bit Width:1
        \ %x  29 lshift CAN_CAN_TSR        \ CAN_LOW0	Bit Offset:29	Bit Width:1
        \ %x  28 lshift CAN_CAN_TSR        \ CAN_TME2	Bit Offset:28	Bit Width:1
        \ %x  27 lshift CAN_CAN_TSR        \ CAN_TME1	Bit Offset:27	Bit Width:1
        \ %x  26 lshift CAN_CAN_TSR        \ CAN_TME0	Bit Offset:26	Bit Width:1
        \ %xx  24 lshift CAN_CAN_TSR        \ CAN_CODE	Bit Offset:24	Bit Width:2
        \ %x  23 lshift CAN_CAN_TSR        \ CAN_ABRQ2	Bit Offset:23	Bit Width:1
        \ %x  19 lshift CAN_CAN_TSR        \ CAN_TERR2	Bit Offset:19	Bit Width:1
        \ %x  18 lshift CAN_CAN_TSR        \ CAN_ALST2	Bit Offset:18	Bit Width:1
        \ %x  17 lshift CAN_CAN_TSR        \ CAN_TXOK2	Bit Offset:17	Bit Width:1
        \ %x  16 lshift CAN_CAN_TSR        \ CAN_RQCP2	Bit Offset:16	Bit Width:1
        \ %x  15 lshift CAN_CAN_TSR        \ CAN_ABRQ1	Bit Offset:15	Bit Width:1
        \ %x  11 lshift CAN_CAN_TSR        \ CAN_TERR1	Bit Offset:11	Bit Width:1
        \ %x  10 lshift CAN_CAN_TSR        \ CAN_ALST1	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CAN_CAN_TSR        \ CAN_TXOK1	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CAN_CAN_TSR        \ CAN_RQCP1	Bit Offset:8	Bit Width:1
        \ %x  7 lshift CAN_CAN_TSR        \ CAN_ABRQ0	Bit Offset:7	Bit Width:1
        \ %x  3 lshift CAN_CAN_TSR        \ CAN_TERR0	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CAN_CAN_TSR        \ CAN_ALST0	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_TSR        \ CAN_TXOK0	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_TSR        \ CAN_RQCP0	Bit Offset:0	Bit Width:1
        
        CAN $C + constant CAN_CAN_RF0R	\ 		\  : RESET_CAN_CAN_RF0R $00000000 
        \ %x  5 lshift CAN_CAN_RF0R        \ CAN_RFOM0	Bit Offset:5	Bit Width:1
        \ %x  4 lshift CAN_CAN_RF0R        \ CAN_FOVR0	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CAN_CAN_RF0R        \ CAN_FULL0	Bit Offset:3	Bit Width:1
        \ %xx  0 lshift CAN_CAN_RF0R        \ CAN_FMP0	Bit Offset:0	Bit Width:2
        
        CAN $10 + constant CAN_CAN_RF1R	\ 		\  : RESET_CAN_CAN_RF1R $00000000 
        \ %x  5 lshift CAN_CAN_RF1R        \ CAN_RFOM1	Bit Offset:5	Bit Width:1
        \ %x  4 lshift CAN_CAN_RF1R        \ CAN_FOVR1	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CAN_CAN_RF1R        \ CAN_FULL1	Bit Offset:3	Bit Width:1
        \ %xx  0 lshift CAN_CAN_RF1R        \ CAN_FMP1	Bit Offset:0	Bit Width:2
        
        CAN $14 + constant CAN_CAN_IER	\ read-write		\  : RESET_CAN_CAN_IER $00000000 
        \ %x  17 lshift CAN_CAN_IER        \ CAN_SLKIE	Bit Offset:17	Bit Width:1
        \ %x  16 lshift CAN_CAN_IER        \ CAN_WKUIE	Bit Offset:16	Bit Width:1
        \ %x  15 lshift CAN_CAN_IER        \ CAN_ERRIE	Bit Offset:15	Bit Width:1
        \ %x  11 lshift CAN_CAN_IER        \ CAN_LECIE	Bit Offset:11	Bit Width:1
        \ %x  10 lshift CAN_CAN_IER        \ CAN_BOFIE	Bit Offset:10	Bit Width:1
        \ %x  9 lshift CAN_CAN_IER        \ CAN_EPVIE	Bit Offset:9	Bit Width:1
        \ %x  8 lshift CAN_CAN_IER        \ CAN_EWGIE	Bit Offset:8	Bit Width:1
        \ %x  6 lshift CAN_CAN_IER        \ CAN_FOVIE1	Bit Offset:6	Bit Width:1
        \ %x  5 lshift CAN_CAN_IER        \ CAN_FFIE1	Bit Offset:5	Bit Width:1
        \ %x  4 lshift CAN_CAN_IER        \ CAN_FMPIE1	Bit Offset:4	Bit Width:1
        \ %x  3 lshift CAN_CAN_IER        \ CAN_FOVIE0	Bit Offset:3	Bit Width:1
        \ %x  2 lshift CAN_CAN_IER        \ CAN_FFIE0	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_IER        \ CAN_FMPIE0	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_IER        \ CAN_TMEIE	Bit Offset:0	Bit Width:1
        
        CAN $18 + constant CAN_CAN_ESR	\ 		\  : RESET_CAN_CAN_ESR $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_ESR        \ CAN_REC	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_ESR        \ CAN_TEC	Bit Offset:16	Bit Width:8
        \ %xxx  4 lshift CAN_CAN_ESR        \ CAN_LEC	Bit Offset:4	Bit Width:3
        \ %x  2 lshift CAN_CAN_ESR        \ CAN_BOFF	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_ESR        \ CAN_EPVF	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_ESR        \ CAN_EWGF	Bit Offset:0	Bit Width:1
        
        CAN $1C + constant CAN_CAN_BTR	\ read-write		\  : RESET_CAN_CAN_BTR $00000000 
        \ %x  31 lshift CAN_CAN_BTR        \ CAN_SILM	Bit Offset:31	Bit Width:1
        \ %x  30 lshift CAN_CAN_BTR        \ CAN_LBKM	Bit Offset:30	Bit Width:1
        \ %xx  24 lshift CAN_CAN_BTR        \ CAN_SJW	Bit Offset:24	Bit Width:2
        \ %xxx  20 lshift CAN_CAN_BTR        \ CAN_TS2	Bit Offset:20	Bit Width:3
        \ %xxxx  16 lshift CAN_CAN_BTR        \ CAN_TS1	Bit Offset:16	Bit Width:4
        \ % 0 lshift CAN_CAN_BTR        \ CAN_BRP	Bit Offset:0	Bit Width:10
        
        CAN $180 + constant CAN_CAN_TI0R	\ read-write		\  : RESET_CAN_CAN_TI0R $00000000 
        \ % 21 lshift CAN_CAN_TI0R        \ CAN_STID	Bit Offset:21	Bit Width:11
        \ % 3 lshift CAN_CAN_TI0R        \ CAN_EXID	Bit Offset:3	Bit Width:18
        \ %x  2 lshift CAN_CAN_TI0R        \ CAN_IDE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_TI0R        \ CAN_RTR	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_TI0R        \ CAN_TXRQ	Bit Offset:0	Bit Width:1
        
        CAN $184 + constant CAN_CAN_TDT0R	\ read-write		\  : RESET_CAN_CAN_TDT0R $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_TDT0R        \ CAN_TIME	Bit Offset:16	Bit Width:16
        \ %x  8 lshift CAN_CAN_TDT0R        \ CAN_TGT	Bit Offset:8	Bit Width:1
        \ %xxxx  0 lshift CAN_CAN_TDT0R        \ CAN_DLC	Bit Offset:0	Bit Width:4
        
        CAN $188 + constant CAN_CAN_TDL0R	\ read-write		\  : RESET_CAN_CAN_TDL0R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_TDL0R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_TDL0R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_TDL0R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_TDL0R        \ CAN_DATA0	Bit Offset:0	Bit Width:8
        
        CAN $18C + constant CAN_CAN_TDH0R	\ read-write		\  : RESET_CAN_CAN_TDH0R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_TDH0R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_TDH0R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_TDH0R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_TDH0R        \ CAN_DATA4	Bit Offset:0	Bit Width:8
        
        CAN $190 + constant CAN_CAN_TI1R	\ read-write		\  : RESET_CAN_CAN_TI1R $00000000 
        \ % 21 lshift CAN_CAN_TI1R        \ CAN_STID	Bit Offset:21	Bit Width:11
        \ % 3 lshift CAN_CAN_TI1R        \ CAN_EXID	Bit Offset:3	Bit Width:18
        \ %x  2 lshift CAN_CAN_TI1R        \ CAN_IDE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_TI1R        \ CAN_RTR	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_TI1R        \ CAN_TXRQ	Bit Offset:0	Bit Width:1
        
        CAN $194 + constant CAN_CAN_TDT1R	\ read-write		\  : RESET_CAN_CAN_TDT1R $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_TDT1R        \ CAN_TIME	Bit Offset:16	Bit Width:16
        \ %x  8 lshift CAN_CAN_TDT1R        \ CAN_TGT	Bit Offset:8	Bit Width:1
        \ %xxxx  0 lshift CAN_CAN_TDT1R        \ CAN_DLC	Bit Offset:0	Bit Width:4
        
        CAN $198 + constant CAN_CAN_TDL1R	\ read-write		\  : RESET_CAN_CAN_TDL1R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_TDL1R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_TDL1R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_TDL1R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_TDL1R        \ CAN_DATA0	Bit Offset:0	Bit Width:8
        
        CAN $19C + constant CAN_CAN_TDH1R	\ read-write		\  : RESET_CAN_CAN_TDH1R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_TDH1R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_TDH1R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_TDH1R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_TDH1R        \ CAN_DATA4	Bit Offset:0	Bit Width:8
        
        CAN $1A0 + constant CAN_CAN_TI2R	\ read-write		\  : RESET_CAN_CAN_TI2R $00000000 
        \ % 21 lshift CAN_CAN_TI2R        \ CAN_STID	Bit Offset:21	Bit Width:11
        \ % 3 lshift CAN_CAN_TI2R        \ CAN_EXID	Bit Offset:3	Bit Width:18
        \ %x  2 lshift CAN_CAN_TI2R        \ CAN_IDE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_TI2R        \ CAN_RTR	Bit Offset:1	Bit Width:1
        \ %x  0 lshift CAN_CAN_TI2R        \ CAN_TXRQ	Bit Offset:0	Bit Width:1
        
        CAN $1A4 + constant CAN_CAN_TDT2R	\ read-write		\  : RESET_CAN_CAN_TDT2R $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_TDT2R        \ CAN_TIME	Bit Offset:16	Bit Width:16
        \ %x  8 lshift CAN_CAN_TDT2R        \ CAN_TGT	Bit Offset:8	Bit Width:1
        \ %xxxx  0 lshift CAN_CAN_TDT2R        \ CAN_DLC	Bit Offset:0	Bit Width:4
        
        CAN $1A8 + constant CAN_CAN_TDL2R	\ read-write		\  : RESET_CAN_CAN_TDL2R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_TDL2R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_TDL2R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_TDL2R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_TDL2R        \ CAN_DATA0	Bit Offset:0	Bit Width:8
        
        CAN $1AC + constant CAN_CAN_TDH2R	\ read-write		\  : RESET_CAN_CAN_TDH2R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_TDH2R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_TDH2R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_TDH2R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_TDH2R        \ CAN_DATA4	Bit Offset:0	Bit Width:8
        
        CAN $1B0 + constant CAN_CAN_RI0R	\ read-only		\  : RESET_CAN_CAN_RI0R $00000000 
        \ % 21 lshift CAN_CAN_RI0R        \ CAN_STID	Bit Offset:21	Bit Width:11
        \ % 3 lshift CAN_CAN_RI0R        \ CAN_EXID	Bit Offset:3	Bit Width:18
        \ %x  2 lshift CAN_CAN_RI0R        \ CAN_IDE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_RI0R        \ CAN_RTR	Bit Offset:1	Bit Width:1
        
        CAN $1B4 + constant CAN_CAN_RDT0R	\ read-only		\  : RESET_CAN_CAN_RDT0R $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_RDT0R        \ CAN_TIME	Bit Offset:16	Bit Width:16
        \ %xxxxxxxx  8 lshift CAN_CAN_RDT0R        \ CAN_FMI	Bit Offset:8	Bit Width:8
        \ %xxxx  0 lshift CAN_CAN_RDT0R        \ CAN_DLC	Bit Offset:0	Bit Width:4
        
        CAN $1B8 + constant CAN_CAN_RDL0R	\ read-only		\  : RESET_CAN_CAN_RDL0R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_RDL0R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_RDL0R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_RDL0R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_RDL0R        \ CAN_DATA0	Bit Offset:0	Bit Width:8
        
        CAN $1BC + constant CAN_CAN_RDH0R	\ read-only		\  : RESET_CAN_CAN_RDH0R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_RDH0R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_RDH0R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_RDH0R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_RDH0R        \ CAN_DATA4	Bit Offset:0	Bit Width:8
        
        CAN $1C0 + constant CAN_CAN_RI1R	\ read-only		\  : RESET_CAN_CAN_RI1R $00000000 
        \ % 21 lshift CAN_CAN_RI1R        \ CAN_STID	Bit Offset:21	Bit Width:11
        \ % 3 lshift CAN_CAN_RI1R        \ CAN_EXID	Bit Offset:3	Bit Width:18
        \ %x  2 lshift CAN_CAN_RI1R        \ CAN_IDE	Bit Offset:2	Bit Width:1
        \ %x  1 lshift CAN_CAN_RI1R        \ CAN_RTR	Bit Offset:1	Bit Width:1
        
        CAN $1C4 + constant CAN_CAN_RDT1R	\ read-only		\  : RESET_CAN_CAN_RDT1R $00000000 
        \ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_RDT1R        \ CAN_TIME	Bit Offset:16	Bit Width:16
        \ %xxxxxxxx  8 lshift CAN_CAN_RDT1R        \ CAN_FMI	Bit Offset:8	Bit Width:8
        \ %xxxx  0 lshift CAN_CAN_RDT1R        \ CAN_DLC	Bit Offset:0	Bit Width:4
        
        CAN $1C8 + constant CAN_CAN_RDL1R	\ read-only		\  : RESET_CAN_CAN_RDL1R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_RDL1R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_RDL1R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_RDL1R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_RDL1R        \ CAN_DATA0	Bit Offset:0	Bit Width:8
        
        CAN $1CC + constant CAN_CAN_RDH1R	\ read-only		\  : RESET_CAN_CAN_RDH1R $00000000 
        \ %xxxxxxxx  24 lshift CAN_CAN_RDH1R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
        \ %xxxxxxxx  16 lshift CAN_CAN_RDH1R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
        \ %xxxxxxxx  8 lshift CAN_CAN_RDH1R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
        \ %xxxxxxxx  0 lshift CAN_CAN_RDH1R        \ CAN_DATA4	Bit Offset:0	Bit Width:8
        
        CAN $200 + constant CAN_CAN_FMR	\ read-write		\  : RESET_CAN_CAN_FMR $00000000 
        \ %xxxxxx  8 lshift CAN_CAN_FMR        \ CAN_CAN2SB	Bit Offset:8	Bit Width:6
        \ %x  0 lshift CAN_CAN_FMR        \ CAN_FINIT	Bit Offset:0	Bit Width:1
        
        CAN $204 + constant CAN_CAN_FM1R	\ read-write		\  : RESET_CAN_CAN_FM1R $00000000 
        \ %x  0 lshift CAN_CAN_FM1R        \ CAN_FBM0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_CAN_FM1R        \ CAN_FBM1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_CAN_FM1R        \ CAN_FBM2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_CAN_FM1R        \ CAN_FBM3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_CAN_FM1R        \ CAN_FBM4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_CAN_FM1R        \ CAN_FBM5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_CAN_FM1R        \ CAN_FBM6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_CAN_FM1R        \ CAN_FBM7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_CAN_FM1R        \ CAN_FBM8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_CAN_FM1R        \ CAN_FBM9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_CAN_FM1R        \ CAN_FBM10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_CAN_FM1R        \ CAN_FBM11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_CAN_FM1R        \ CAN_FBM12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_CAN_FM1R        \ CAN_FBM13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_CAN_FM1R        \ CAN_FBM14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_CAN_FM1R        \ CAN_FBM15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_CAN_FM1R        \ CAN_FBM16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_CAN_FM1R        \ CAN_FBM17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_CAN_FM1R        \ CAN_FBM18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_CAN_FM1R        \ CAN_FBM19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_CAN_FM1R        \ CAN_FBM20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_CAN_FM1R        \ CAN_FBM21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_CAN_FM1R        \ CAN_FBM22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_CAN_FM1R        \ CAN_FBM23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_CAN_FM1R        \ CAN_FBM24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_CAN_FM1R        \ CAN_FBM25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_CAN_FM1R        \ CAN_FBM26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_CAN_FM1R        \ CAN_FBM27	Bit Offset:27	Bit Width:1
        
        CAN $20C + constant CAN_CAN_FS1R	\ read-write		\  : RESET_CAN_CAN_FS1R $00000000 
        \ %x  0 lshift CAN_CAN_FS1R        \ CAN_FSC0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_CAN_FS1R        \ CAN_FSC1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_CAN_FS1R        \ CAN_FSC2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_CAN_FS1R        \ CAN_FSC3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_CAN_FS1R        \ CAN_FSC4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_CAN_FS1R        \ CAN_FSC5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_CAN_FS1R        \ CAN_FSC6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_CAN_FS1R        \ CAN_FSC7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_CAN_FS1R        \ CAN_FSC8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_CAN_FS1R        \ CAN_FSC9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_CAN_FS1R        \ CAN_FSC10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_CAN_FS1R        \ CAN_FSC11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_CAN_FS1R        \ CAN_FSC12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_CAN_FS1R        \ CAN_FSC13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_CAN_FS1R        \ CAN_FSC14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_CAN_FS1R        \ CAN_FSC15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_CAN_FS1R        \ CAN_FSC16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_CAN_FS1R        \ CAN_FSC17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_CAN_FS1R        \ CAN_FSC18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_CAN_FS1R        \ CAN_FSC19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_CAN_FS1R        \ CAN_FSC20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_CAN_FS1R        \ CAN_FSC21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_CAN_FS1R        \ CAN_FSC22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_CAN_FS1R        \ CAN_FSC23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_CAN_FS1R        \ CAN_FSC24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_CAN_FS1R        \ CAN_FSC25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_CAN_FS1R        \ CAN_FSC26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_CAN_FS1R        \ CAN_FSC27	Bit Offset:27	Bit Width:1
        
        CAN $214 + constant CAN_CAN_FFA1R	\ read-write		\  : RESET_CAN_CAN_FFA1R $00000000 
        \ %x  0 lshift CAN_CAN_FFA1R        \ CAN_FFA0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_CAN_FFA1R        \ CAN_FFA1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_CAN_FFA1R        \ CAN_FFA2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_CAN_FFA1R        \ CAN_FFA3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_CAN_FFA1R        \ CAN_FFA4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_CAN_FFA1R        \ CAN_FFA5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_CAN_FFA1R        \ CAN_FFA6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_CAN_FFA1R        \ CAN_FFA7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_CAN_FFA1R        \ CAN_FFA8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_CAN_FFA1R        \ CAN_FFA9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_CAN_FFA1R        \ CAN_FFA10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_CAN_FFA1R        \ CAN_FFA11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_CAN_FFA1R        \ CAN_FFA12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_CAN_FFA1R        \ CAN_FFA13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_CAN_FFA1R        \ CAN_FFA14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_CAN_FFA1R        \ CAN_FFA15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_CAN_FFA1R        \ CAN_FFA16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_CAN_FFA1R        \ CAN_FFA17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_CAN_FFA1R        \ CAN_FFA18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_CAN_FFA1R        \ CAN_FFA19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_CAN_FFA1R        \ CAN_FFA20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_CAN_FFA1R        \ CAN_FFA21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_CAN_FFA1R        \ CAN_FFA22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_CAN_FFA1R        \ CAN_FFA23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_CAN_FFA1R        \ CAN_FFA24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_CAN_FFA1R        \ CAN_FFA25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_CAN_FFA1R        \ CAN_FFA26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_CAN_FFA1R        \ CAN_FFA27	Bit Offset:27	Bit Width:1
        
        CAN $21C + constant CAN_CAN_FA1R	\ read-write		\  : RESET_CAN_CAN_FA1R $00000000 
        \ %x  0 lshift CAN_CAN_FA1R        \ CAN_FACT0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_CAN_FA1R        \ CAN_FACT1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_CAN_FA1R        \ CAN_FACT2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_CAN_FA1R        \ CAN_FACT3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_CAN_FA1R        \ CAN_FACT4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_CAN_FA1R        \ CAN_FACT5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_CAN_FA1R        \ CAN_FACT6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_CAN_FA1R        \ CAN_FACT7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_CAN_FA1R        \ CAN_FACT8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_CAN_FA1R        \ CAN_FACT9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_CAN_FA1R        \ CAN_FACT10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_CAN_FA1R        \ CAN_FACT11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_CAN_FA1R        \ CAN_FACT12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_CAN_FA1R        \ CAN_FACT13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_CAN_FA1R        \ CAN_FACT14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_CAN_FA1R        \ CAN_FACT15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_CAN_FA1R        \ CAN_FACT16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_CAN_FA1R        \ CAN_FACT17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_CAN_FA1R        \ CAN_FACT18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_CAN_FA1R        \ CAN_FACT19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_CAN_FA1R        \ CAN_FACT20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_CAN_FA1R        \ CAN_FACT21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_CAN_FA1R        \ CAN_FACT22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_CAN_FA1R        \ CAN_FACT23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_CAN_FA1R        \ CAN_FACT24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_CAN_FA1R        \ CAN_FACT25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_CAN_FA1R        \ CAN_FACT26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_CAN_FA1R        \ CAN_FACT27	Bit Offset:27	Bit Width:1
        
        CAN $240 + constant CAN_F0R1	\ read-write		\  : RESET_CAN_F0R1 $00000000 
        \ %x  0 lshift CAN_F0R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F0R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F0R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F0R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F0R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F0R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F0R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F0R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F0R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F0R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F0R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F0R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F0R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F0R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F0R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F0R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F0R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F0R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F0R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F0R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F0R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F0R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F0R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F0R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F0R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F0R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F0R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F0R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F0R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F0R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F0R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F0R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $244 + constant CAN_F0R2	\ read-write		\  : RESET_CAN_F0R2 $00000000 
        \ %x  0 lshift CAN_F0R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F0R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F0R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F0R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F0R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F0R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F0R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F0R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F0R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F0R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F0R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F0R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F0R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F0R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F0R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F0R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F0R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F0R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F0R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F0R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F0R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F0R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F0R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F0R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F0R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F0R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F0R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F0R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F0R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F0R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F0R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F0R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $248 + constant CAN_F1R1	\ read-write		\  : RESET_CAN_F1R1 $00000000 
        \ %x  0 lshift CAN_F1R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F1R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F1R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F1R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F1R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F1R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F1R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F1R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F1R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F1R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F1R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F1R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F1R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F1R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F1R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F1R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F1R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F1R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F1R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F1R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F1R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F1R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F1R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F1R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F1R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F1R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F1R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F1R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F1R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F1R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F1R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F1R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $24C + constant CAN_F1R2	\ read-write		\  : RESET_CAN_F1R2 $00000000 
        \ %x  0 lshift CAN_F1R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F1R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F1R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F1R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F1R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F1R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F1R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F1R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F1R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F1R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F1R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F1R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F1R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F1R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F1R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F1R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F1R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F1R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F1R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F1R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F1R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F1R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F1R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F1R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F1R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F1R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F1R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F1R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F1R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F1R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F1R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F1R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $250 + constant CAN_F2R1	\ read-write		\  : RESET_CAN_F2R1 $00000000 
        \ %x  0 lshift CAN_F2R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F2R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F2R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F2R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F2R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F2R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F2R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F2R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F2R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F2R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F2R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F2R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F2R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F2R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F2R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F2R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F2R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F2R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F2R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F2R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F2R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F2R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F2R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F2R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F2R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F2R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F2R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F2R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F2R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F2R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F2R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F2R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $254 + constant CAN_F2R2	\ read-write		\  : RESET_CAN_F2R2 $00000000 
        \ %x  0 lshift CAN_F2R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F2R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F2R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F2R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F2R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F2R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F2R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F2R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F2R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F2R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F2R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F2R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F2R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F2R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F2R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F2R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F2R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F2R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F2R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F2R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F2R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F2R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F2R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F2R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F2R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F2R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F2R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F2R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F2R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F2R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F2R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F2R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $258 + constant CAN_F3R1	\ read-write		\  : RESET_CAN_F3R1 $00000000 
        \ %x  0 lshift CAN_F3R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F3R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F3R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F3R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F3R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F3R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F3R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F3R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F3R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F3R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F3R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F3R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F3R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F3R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F3R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F3R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F3R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F3R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F3R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F3R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F3R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F3R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F3R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F3R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F3R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F3R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F3R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F3R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F3R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F3R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F3R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F3R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $25C + constant CAN_F3R2	\ read-write		\  : RESET_CAN_F3R2 $00000000 
        \ %x  0 lshift CAN_F3R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F3R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F3R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F3R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F3R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F3R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F3R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F3R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F3R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F3R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F3R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F3R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F3R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F3R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F3R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F3R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F3R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F3R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F3R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F3R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F3R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F3R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F3R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F3R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F3R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F3R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F3R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F3R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F3R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F3R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F3R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F3R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $260 + constant CAN_F4R1	\ read-write		\  : RESET_CAN_F4R1 $00000000 
        \ %x  0 lshift CAN_F4R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F4R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F4R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F4R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F4R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F4R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F4R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F4R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F4R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F4R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F4R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F4R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F4R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F4R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F4R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F4R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F4R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F4R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F4R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F4R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F4R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F4R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F4R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F4R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F4R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F4R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F4R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F4R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F4R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F4R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F4R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F4R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $264 + constant CAN_F4R2	\ read-write		\  : RESET_CAN_F4R2 $00000000 
        \ %x  0 lshift CAN_F4R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F4R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F4R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F4R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F4R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F4R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F4R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F4R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F4R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F4R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F4R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F4R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F4R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F4R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F4R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F4R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F4R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F4R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F4R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F4R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F4R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F4R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F4R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F4R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F4R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F4R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F4R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F4R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F4R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F4R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F4R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F4R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $268 + constant CAN_F5R1	\ read-write		\  : RESET_CAN_F5R1 $00000000 
        \ %x  0 lshift CAN_F5R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F5R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F5R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F5R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F5R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F5R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F5R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F5R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F5R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F5R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F5R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F5R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F5R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F5R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F5R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F5R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F5R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F5R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F5R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F5R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F5R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F5R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F5R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F5R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F5R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F5R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F5R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F5R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F5R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F5R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F5R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F5R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $26C + constant CAN_F5R2	\ read-write		\  : RESET_CAN_F5R2 $00000000 
        \ %x  0 lshift CAN_F5R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F5R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F5R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F5R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F5R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F5R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F5R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F5R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F5R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F5R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F5R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F5R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F5R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F5R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F5R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F5R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F5R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F5R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F5R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F5R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F5R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F5R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F5R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F5R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F5R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F5R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F5R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F5R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F5R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F5R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F5R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F5R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $270 + constant CAN_F6R1	\ read-write		\  : RESET_CAN_F6R1 $00000000 
        \ %x  0 lshift CAN_F6R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F6R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F6R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F6R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F6R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F6R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F6R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F6R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F6R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F6R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F6R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F6R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F6R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F6R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F6R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F6R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F6R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F6R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F6R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F6R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F6R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F6R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F6R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F6R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F6R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F6R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F6R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F6R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F6R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F6R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F6R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F6R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $274 + constant CAN_F6R2	\ read-write		\  : RESET_CAN_F6R2 $00000000 
        \ %x  0 lshift CAN_F6R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F6R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F6R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F6R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F6R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F6R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F6R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F6R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F6R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F6R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F6R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F6R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F6R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F6R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F6R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F6R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F6R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F6R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F6R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F6R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F6R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F6R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F6R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F6R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F6R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F6R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F6R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F6R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F6R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F6R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F6R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F6R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $278 + constant CAN_F7R1	\ read-write		\  : RESET_CAN_F7R1 $00000000 
        \ %x  0 lshift CAN_F7R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F7R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F7R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F7R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F7R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F7R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F7R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F7R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F7R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F7R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F7R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F7R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F7R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F7R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F7R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F7R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F7R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F7R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F7R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F7R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F7R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F7R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F7R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F7R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F7R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F7R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F7R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F7R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F7R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F7R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F7R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F7R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $27C + constant CAN_F7R2	\ read-write		\  : RESET_CAN_F7R2 $00000000 
        \ %x  0 lshift CAN_F7R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F7R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F7R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F7R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F7R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F7R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F7R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F7R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F7R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F7R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F7R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F7R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F7R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F7R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F7R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F7R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F7R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F7R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F7R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F7R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F7R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F7R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F7R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F7R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F7R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F7R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F7R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F7R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F7R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F7R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F7R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F7R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $280 + constant CAN_F8R1	\ read-write		\  : RESET_CAN_F8R1 $00000000 
        \ %x  0 lshift CAN_F8R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F8R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F8R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F8R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F8R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F8R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F8R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F8R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F8R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F8R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F8R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F8R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F8R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F8R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F8R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F8R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F8R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F8R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F8R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F8R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F8R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F8R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F8R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F8R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F8R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F8R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F8R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F8R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F8R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F8R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F8R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F8R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $284 + constant CAN_F8R2	\ read-write		\  : RESET_CAN_F8R2 $00000000 
        \ %x  0 lshift CAN_F8R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F8R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F8R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F8R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F8R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F8R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F8R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F8R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F8R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F8R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F8R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F8R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F8R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F8R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F8R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F8R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F8R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F8R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F8R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F8R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F8R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F8R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F8R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F8R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F8R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F8R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F8R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F8R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F8R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F8R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F8R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F8R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $288 + constant CAN_F9R1	\ read-write		\  : RESET_CAN_F9R1 $00000000 
        \ %x  0 lshift CAN_F9R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F9R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F9R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F9R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F9R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F9R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F9R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F9R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F9R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F9R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F9R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F9R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F9R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F9R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F9R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F9R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F9R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F9R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F9R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F9R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F9R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F9R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F9R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F9R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F9R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F9R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F9R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F9R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F9R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F9R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F9R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F9R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $28C + constant CAN_F9R2	\ read-write		\  : RESET_CAN_F9R2 $00000000 
        \ %x  0 lshift CAN_F9R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F9R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F9R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F9R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F9R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F9R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F9R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F9R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F9R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F9R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F9R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F9R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F9R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F9R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F9R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F9R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F9R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F9R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F9R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F9R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F9R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F9R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F9R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F9R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F9R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F9R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F9R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F9R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F9R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F9R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F9R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F9R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $290 + constant CAN_F10R1	\ read-write		\  : RESET_CAN_F10R1 $00000000 
        \ %x  0 lshift CAN_F10R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F10R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F10R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F10R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F10R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F10R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F10R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F10R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F10R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F10R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F10R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F10R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F10R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F10R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F10R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F10R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F10R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F10R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F10R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F10R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F10R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F10R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F10R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F10R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F10R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F10R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F10R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F10R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F10R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F10R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F10R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F10R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $294 + constant CAN_F10R2	\ read-write		\  : RESET_CAN_F10R2 $00000000 
        \ %x  0 lshift CAN_F10R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F10R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F10R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F10R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F10R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F10R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F10R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F10R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F10R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F10R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F10R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F10R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F10R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F10R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F10R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F10R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F10R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F10R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F10R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F10R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F10R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F10R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F10R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F10R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F10R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F10R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F10R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F10R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F10R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F10R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F10R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F10R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $298 + constant CAN_F11R1	\ read-write		\  : RESET_CAN_F11R1 $00000000 
        \ %x  0 lshift CAN_F11R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F11R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F11R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F11R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F11R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F11R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F11R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F11R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F11R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F11R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F11R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F11R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F11R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F11R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F11R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F11R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F11R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F11R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F11R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F11R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F11R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F11R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F11R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F11R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F11R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F11R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F11R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F11R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F11R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F11R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F11R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F11R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $29C + constant CAN_F11R2	\ read-write		\  : RESET_CAN_F11R2 $00000000 
        \ %x  0 lshift CAN_F11R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F11R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F11R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F11R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F11R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F11R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F11R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F11R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F11R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F11R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F11R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F11R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F11R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F11R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F11R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F11R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F11R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F11R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F11R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F11R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F11R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F11R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F11R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F11R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F11R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F11R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F11R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F11R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F11R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F11R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F11R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F11R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2A0 + constant CAN_F12R1	\ read-write		\  : RESET_CAN_F12R1 $00000000 
        \ %x  0 lshift CAN_F12R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F12R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F12R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F12R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F12R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F12R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F12R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F12R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F12R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F12R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F12R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F12R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F12R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F12R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F12R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F12R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F12R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F12R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F12R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F12R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F12R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F12R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F12R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F12R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F12R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F12R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F12R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F12R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F12R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F12R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F12R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F12R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2A4 + constant CAN_F12R2	\ read-write		\  : RESET_CAN_F12R2 $00000000 
        \ %x  0 lshift CAN_F12R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F12R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F12R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F12R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F12R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F12R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F12R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F12R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F12R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F12R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F12R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F12R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F12R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F12R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F12R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F12R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F12R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F12R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F12R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F12R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F12R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F12R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F12R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F12R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F12R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F12R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F12R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F12R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F12R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F12R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F12R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F12R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2A8 + constant CAN_F13R1	\ read-write		\  : RESET_CAN_F13R1 $00000000 
        \ %x  0 lshift CAN_F13R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F13R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F13R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F13R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F13R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F13R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F13R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F13R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F13R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F13R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F13R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F13R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F13R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F13R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F13R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F13R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F13R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F13R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F13R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F13R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F13R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F13R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F13R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F13R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F13R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F13R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F13R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F13R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F13R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F13R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F13R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F13R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2AC + constant CAN_F13R2	\ read-write		\  : RESET_CAN_F13R2 $00000000 
        \ %x  0 lshift CAN_F13R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F13R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F13R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F13R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F13R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F13R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F13R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F13R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F13R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F13R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F13R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F13R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F13R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F13R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F13R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F13R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F13R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F13R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F13R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F13R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F13R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F13R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F13R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F13R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F13R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F13R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F13R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F13R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F13R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F13R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F13R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F13R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2B0 + constant CAN_F14R1	\ read-write		\  : RESET_CAN_F14R1 $00000000 
        \ %x  0 lshift CAN_F14R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F14R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F14R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F14R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F14R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F14R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F14R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F14R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F14R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F14R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F14R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F14R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F14R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F14R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F14R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F14R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F14R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F14R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F14R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F14R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F14R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F14R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F14R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F14R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F14R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F14R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F14R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F14R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F14R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F14R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F14R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F14R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2B4 + constant CAN_F14R2	\ read-write		\  : RESET_CAN_F14R2 $00000000 
        \ %x  0 lshift CAN_F14R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F14R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F14R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F14R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F14R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F14R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F14R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F14R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F14R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F14R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F14R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F14R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F14R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F14R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F14R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F14R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F14R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F14R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F14R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F14R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F14R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F14R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F14R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F14R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F14R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F14R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F14R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F14R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F14R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F14R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F14R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F14R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2B8 + constant CAN_F15R1	\ read-write		\  : RESET_CAN_F15R1 $00000000 
        \ %x  0 lshift CAN_F15R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F15R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F15R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F15R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F15R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F15R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F15R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F15R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F15R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F15R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F15R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F15R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F15R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F15R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F15R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F15R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F15R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F15R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F15R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F15R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F15R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F15R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F15R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F15R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F15R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F15R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F15R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F15R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F15R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F15R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F15R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F15R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2BC + constant CAN_F15R2	\ read-write		\  : RESET_CAN_F15R2 $00000000 
        \ %x  0 lshift CAN_F15R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F15R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F15R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F15R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F15R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F15R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F15R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F15R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F15R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F15R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F15R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F15R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F15R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F15R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F15R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F15R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F15R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F15R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F15R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F15R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F15R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F15R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F15R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F15R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F15R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F15R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F15R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F15R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F15R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F15R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F15R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F15R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2C0 + constant CAN_F16R1	\ read-write		\  : RESET_CAN_F16R1 $00000000 
        \ %x  0 lshift CAN_F16R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F16R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F16R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F16R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F16R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F16R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F16R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F16R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F16R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F16R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F16R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F16R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F16R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F16R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F16R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F16R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F16R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F16R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F16R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F16R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F16R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F16R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F16R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F16R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F16R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F16R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F16R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F16R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F16R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F16R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F16R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F16R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2C4 + constant CAN_F16R2	\ read-write		\  : RESET_CAN_F16R2 $00000000 
        \ %x  0 lshift CAN_F16R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F16R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F16R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F16R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F16R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F16R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F16R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F16R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F16R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F16R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F16R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F16R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F16R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F16R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F16R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F16R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F16R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F16R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F16R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F16R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F16R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F16R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F16R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F16R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F16R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F16R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F16R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F16R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F16R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F16R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F16R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F16R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2C8 + constant CAN_F17R1	\ read-write		\  : RESET_CAN_F17R1 $00000000 
        \ %x  0 lshift CAN_F17R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F17R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F17R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F17R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F17R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F17R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F17R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F17R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F17R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F17R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F17R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F17R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F17R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F17R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F17R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F17R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F17R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F17R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F17R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F17R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F17R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F17R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F17R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F17R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F17R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F17R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F17R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F17R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F17R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F17R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F17R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F17R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2CC + constant CAN_F17R2	\ read-write		\  : RESET_CAN_F17R2 $00000000 
        \ %x  0 lshift CAN_F17R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F17R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F17R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F17R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F17R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F17R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F17R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F17R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F17R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F17R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F17R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F17R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F17R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F17R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F17R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F17R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F17R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F17R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F17R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F17R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F17R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F17R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F17R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F17R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F17R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F17R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F17R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F17R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F17R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F17R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F17R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F17R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2D0 + constant CAN_F18R1	\ read-write		\  : RESET_CAN_F18R1 $00000000 
        \ %x  0 lshift CAN_F18R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F18R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F18R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F18R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F18R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F18R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F18R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F18R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F18R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F18R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F18R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F18R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F18R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F18R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F18R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F18R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F18R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F18R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F18R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F18R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F18R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F18R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F18R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F18R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F18R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F18R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F18R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F18R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F18R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F18R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F18R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F18R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2D4 + constant CAN_F18R2	\ read-write		\  : RESET_CAN_F18R2 $00000000 
        \ %x  0 lshift CAN_F18R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F18R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F18R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F18R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F18R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F18R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F18R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F18R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F18R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F18R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F18R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F18R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F18R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F18R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F18R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F18R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F18R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F18R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F18R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F18R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F18R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F18R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F18R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F18R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F18R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F18R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F18R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F18R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F18R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F18R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F18R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F18R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2D8 + constant CAN_F19R1	\ read-write		\  : RESET_CAN_F19R1 $00000000 
        \ %x  0 lshift CAN_F19R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F19R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F19R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F19R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F19R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F19R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F19R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F19R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F19R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F19R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F19R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F19R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F19R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F19R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F19R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F19R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F19R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F19R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F19R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F19R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F19R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F19R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F19R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F19R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F19R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F19R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F19R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F19R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F19R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F19R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F19R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F19R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2DC + constant CAN_F19R2	\ read-write		\  : RESET_CAN_F19R2 $00000000 
        \ %x  0 lshift CAN_F19R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F19R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F19R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F19R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F19R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F19R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F19R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F19R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F19R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F19R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F19R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F19R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F19R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F19R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F19R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F19R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F19R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F19R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F19R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F19R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F19R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F19R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F19R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F19R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F19R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F19R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F19R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F19R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F19R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F19R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F19R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F19R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2E0 + constant CAN_F20R1	\ read-write		\  : RESET_CAN_F20R1 $00000000 
        \ %x  0 lshift CAN_F20R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F20R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F20R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F20R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F20R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F20R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F20R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F20R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F20R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F20R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F20R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F20R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F20R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F20R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F20R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F20R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F20R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F20R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F20R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F20R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F20R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F20R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F20R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F20R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F20R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F20R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F20R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F20R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F20R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F20R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F20R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F20R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2E4 + constant CAN_F20R2	\ read-write		\  : RESET_CAN_F20R2 $00000000 
        \ %x  0 lshift CAN_F20R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F20R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F20R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F20R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F20R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F20R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F20R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F20R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F20R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F20R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F20R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F20R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F20R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F20R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F20R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F20R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F20R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F20R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F20R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F20R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F20R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F20R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F20R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F20R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F20R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F20R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F20R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F20R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F20R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F20R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F20R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F20R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2E8 + constant CAN_F21R1	\ read-write		\  : RESET_CAN_F21R1 $00000000 
        \ %x  0 lshift CAN_F21R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F21R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F21R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F21R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F21R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F21R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F21R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F21R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F21R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F21R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F21R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F21R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F21R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F21R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F21R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F21R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F21R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F21R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F21R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F21R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F21R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F21R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F21R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F21R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F21R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F21R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F21R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F21R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F21R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F21R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F21R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F21R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2EC + constant CAN_F21R2	\ read-write		\  : RESET_CAN_F21R2 $00000000 
        \ %x  0 lshift CAN_F21R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F21R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F21R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F21R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F21R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F21R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F21R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F21R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F21R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F21R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F21R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F21R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F21R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F21R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F21R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F21R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F21R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F21R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F21R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F21R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F21R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F21R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F21R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F21R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F21R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F21R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F21R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F21R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F21R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F21R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F21R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F21R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2F0 + constant CAN_F22R1	\ read-write		\  : RESET_CAN_F22R1 $00000000 
        \ %x  0 lshift CAN_F22R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F22R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F22R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F22R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F22R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F22R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F22R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F22R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F22R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F22R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F22R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F22R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F22R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F22R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F22R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F22R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F22R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F22R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F22R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F22R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F22R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F22R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F22R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F22R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F22R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F22R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F22R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F22R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F22R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F22R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F22R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F22R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2F4 + constant CAN_F22R2	\ read-write		\  : RESET_CAN_F22R2 $00000000 
        \ %x  0 lshift CAN_F22R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F22R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F22R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F22R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F22R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F22R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F22R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F22R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F22R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F22R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F22R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F22R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F22R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F22R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F22R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F22R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F22R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F22R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F22R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F22R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F22R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F22R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F22R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F22R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F22R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F22R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F22R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F22R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F22R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F22R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F22R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F22R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2F8 + constant CAN_F23R1	\ read-write		\  : RESET_CAN_F23R1 $00000000 
        \ %x  0 lshift CAN_F23R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F23R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F23R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F23R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F23R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F23R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F23R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F23R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F23R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F23R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F23R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F23R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F23R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F23R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F23R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F23R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F23R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F23R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F23R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F23R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F23R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F23R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F23R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F23R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F23R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F23R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F23R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F23R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F23R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F23R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F23R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F23R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $2FC + constant CAN_F23R2	\ read-write		\  : RESET_CAN_F23R2 $00000000 
        \ %x  0 lshift CAN_F23R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F23R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F23R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F23R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F23R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F23R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F23R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F23R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F23R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F23R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F23R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F23R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F23R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F23R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F23R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F23R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F23R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F23R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F23R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F23R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F23R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F23R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F23R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F23R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F23R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F23R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F23R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F23R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F23R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F23R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F23R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F23R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $300 + constant CAN_F24R1	\ read-write		\  : RESET_CAN_F24R1 $00000000 
        \ %x  0 lshift CAN_F24R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F24R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F24R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F24R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F24R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F24R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F24R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F24R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F24R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F24R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F24R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F24R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F24R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F24R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F24R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F24R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F24R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F24R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F24R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F24R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F24R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F24R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F24R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F24R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F24R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F24R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F24R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F24R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F24R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F24R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F24R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F24R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $304 + constant CAN_F24R2	\ read-write		\  : RESET_CAN_F24R2 $00000000 
        \ %x  0 lshift CAN_F24R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F24R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F24R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F24R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F24R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F24R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F24R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F24R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F24R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F24R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F24R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F24R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F24R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F24R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F24R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F24R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F24R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F24R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F24R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F24R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F24R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F24R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F24R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F24R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F24R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F24R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F24R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F24R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F24R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F24R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F24R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F24R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $308 + constant CAN_F25R1	\ read-write		\  : RESET_CAN_F25R1 $00000000 
        \ %x  0 lshift CAN_F25R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F25R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F25R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F25R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F25R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F25R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F25R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F25R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F25R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F25R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F25R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F25R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F25R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F25R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F25R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F25R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F25R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F25R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F25R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F25R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F25R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F25R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F25R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F25R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F25R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F25R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F25R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F25R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F25R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F25R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F25R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F25R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $30C + constant CAN_F25R2	\ read-write		\  : RESET_CAN_F25R2 $00000000 
        \ %x  0 lshift CAN_F25R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F25R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F25R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F25R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F25R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F25R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F25R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F25R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F25R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F25R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F25R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F25R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F25R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F25R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F25R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F25R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F25R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F25R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F25R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F25R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F25R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F25R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F25R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F25R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F25R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F25R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F25R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F25R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F25R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F25R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F25R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F25R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $310 + constant CAN_F26R1	\ read-write		\  : RESET_CAN_F26R1 $00000000 
        \ %x  0 lshift CAN_F26R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F26R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F26R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F26R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F26R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F26R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F26R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F26R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F26R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F26R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F26R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F26R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F26R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F26R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F26R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F26R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F26R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F26R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F26R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F26R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F26R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F26R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F26R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F26R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F26R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F26R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F26R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F26R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F26R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F26R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F26R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F26R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $314 + constant CAN_F26R2	\ read-write		\  : RESET_CAN_F26R2 $00000000 
        \ %x  0 lshift CAN_F26R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F26R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F26R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F26R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F26R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F26R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F26R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F26R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F26R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F26R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F26R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F26R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F26R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F26R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F26R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F26R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F26R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F26R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F26R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F26R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F26R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F26R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F26R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F26R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F26R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F26R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F26R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F26R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F26R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F26R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F26R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F26R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $318 + constant CAN_F27R1	\ read-write		\  : RESET_CAN_F27R1 $00000000 
        \ %x  0 lshift CAN_F27R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F27R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F27R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F27R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F27R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F27R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F27R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F27R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F27R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F27R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F27R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F27R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F27R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F27R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F27R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F27R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F27R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F27R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F27R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F27R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F27R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F27R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F27R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F27R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F27R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F27R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F27R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F27R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F27R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F27R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F27R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F27R1        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
        CAN $31C + constant CAN_F27R2	\ read-write		\  : RESET_CAN_F27R2 $00000000 
        \ %x  0 lshift CAN_F27R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
        \ %x  1 lshift CAN_F27R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
        \ %x  2 lshift CAN_F27R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
        \ %x  3 lshift CAN_F27R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
        \ %x  4 lshift CAN_F27R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
        \ %x  5 lshift CAN_F27R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
        \ %x  6 lshift CAN_F27R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
        \ %x  7 lshift CAN_F27R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
        \ %x  8 lshift CAN_F27R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
        \ %x  9 lshift CAN_F27R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
        \ %x  10 lshift CAN_F27R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
        \ %x  11 lshift CAN_F27R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
        \ %x  12 lshift CAN_F27R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
        \ %x  13 lshift CAN_F27R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
        \ %x  14 lshift CAN_F27R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
        \ %x  15 lshift CAN_F27R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
        \ %x  16 lshift CAN_F27R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
        \ %x  17 lshift CAN_F27R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
        \ %x  18 lshift CAN_F27R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
        \ %x  19 lshift CAN_F27R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
        \ %x  20 lshift CAN_F27R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
        \ %x  21 lshift CAN_F27R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
        \ %x  22 lshift CAN_F27R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
        \ %x  23 lshift CAN_F27R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
        \ %x  24 lshift CAN_F27R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
        \ %x  25 lshift CAN_F27R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
        \ %x  26 lshift CAN_F27R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
        \ %x  27 lshift CAN_F27R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
        \ %x  28 lshift CAN_F27R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
        \ %x  29 lshift CAN_F27R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
        \ %x  30 lshift CAN_F27R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
        \ %x  31 lshift CAN_F27R2        \ CAN_FB31	Bit Offset:31	Bit Width:1
        
         
	
     