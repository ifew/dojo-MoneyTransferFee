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

        internal double? Transfer(double amount)
        {
            if(amount == 0) {
                return null;
            } else {
                return 0;
            }
        }

        internal bool IsTransfer(double amount)
        {
            if(amount == 0) {
                return false;
            } else {
                return true;
            }
        }
    }
}
