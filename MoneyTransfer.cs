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

        internal bool Transfer(double amount)
        {
            if(amount == 0) {
                return false;
            } else {
                return true;
            }
        }
    }
}
