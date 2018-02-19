using System;
using Xunit;

namespace MoneyTransfer
{
    public class MoneyTransferTest
    {
        [Fact]
        public void When_Transfer_Same_Bank_Amount_0THB_Should_Be_Return_False()
        {
            var originBank = "SCB";
            var destinationBank = "SCB";
            var amount = 0;

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actual = moneyTransfer.Transfer(amount);

            Assert.False(actual);
        }

        
        [Fact]
        public void When_Transfer_Same_Bank_Amount_4999THB_Should_Be_Return_True()
        {
            var originBank = "SCB";
            var destinationBank = "SCB";
            var amount = 4999;

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actual = moneyTransfer.Transfer(amount);

            Assert.True(actual);
        }

        
        
        [Fact]
        public void When_Transfer_Same_Bank_Amount_5000THB_Should_Be_Return_True()
        {
            var originBank = "SCB";
            var destinationBank = "SCB";
            var amount = 5000;

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actual = moneyTransfer.Transfer(amount);

            Assert.True(actual);
        }
    }
}
