# dojo-MoneyTransfer

##Business Condition
- วงเงินโอนไม่เกิน 5,000 บาท ฟรีทุกรายการ
- วงเงินโอน 5,001 - 10,000 บาท ค่าธรรมเนียม 1 บาท
- วงเงินโอน 10,001 - 15,000 บาท ค่าธรรมเนียม 2 บาท
- วงเงินโอน 15,001 - 20,000 บาท ค่าธรรมเนียม 3 บาท
- โอนเงินภายในธนาคารเดียวกัน ฟรีทุกรายการ
- โอนได้ไม่เกินครั้งละ 20,000 บาท

##Test Cases

| Bank A | Bank B | Money Transfer | Fee | Status |
|:-------:|:-------:|----------------:|----:|:-------:|
| SCB | SCB | 4999 | 0 | True |
| SCB | KBANK | 4999 | 0 | True |
| SCB | SCB | 5000 | 0 | True |
| SCB | KBANK | 5000 | 0 | True |
| SCB | SCB | 5001 | 0 | True |
| SCB | KBANK | 5001 | 1 | True |
| SCB | SCB | 9999 | 0 | True |
| SCB | KBANK | 9999 | 1 | True |
| SCB | SCB | 10000 | 0 | True |
| SCB | KBANK | 10000 | 1 | True |
| SCB | SCB | 10001 | 0 | True |
| SCB | KBANK | 10001 | 2 | True |
| SCB | SCB | 14999 | 0 | True |
| SCB | KBANK | 14999 | 2 | True |
| SCB | SCB | 15000 | 0 | True |
| SCB | KBANK | 15000 | 2 | True |
| SCB | SCB | 15001 | 0 | True |
| SCB | KBANK | 15001 | 3 | True |
| SCB | SCB | 19999 | 0 | True |
| SCB | KBANK | 19999 | 3 | True |
| SCB | SCB | 20000 | 0 | True |
| SCB | KBANK | 20000 | 3 | True |
| SCB | SCB | 20001 | null | False |
| SCB | KBANK | 20001 | null | False |
| SCB | SCB | 0 | null | False |
| SCB | KBANK | 0 | null | False |
