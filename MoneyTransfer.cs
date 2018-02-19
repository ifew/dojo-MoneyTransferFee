using System;

namespace MoneyTransfer
{
    public class MoneyTransfer
    {
        private string originBank;
        private string destinationBank;

        public MoneyTransfer(string originBank, string destinationBank)
        {
            this.originBank = originBank;
            this.destinationBank = destinationBank;
        }

        internal bool IsSameBank()
        {
            if(originBank == destinationBank) {
                return true;
            } else {
                return false;
            }
        }

        internal double? getFee(double amount)
        {
            if(amount <= 0 || amount > 20000) {
                return null;
            } else {
                if(IsSameBank()) {
                    return 0;
                } else {
                    if(amount > 5000 && amount <= 10000) {
                        return 1;
                    } else {
                        return 0;
                    }
                }
            }
        }

        internal bool IsTransfer(double amount)
        {
            if(amount <= 0 || amount > 20000) {
                return false;
            } else {
                return true;
            }
        }
    }
}
