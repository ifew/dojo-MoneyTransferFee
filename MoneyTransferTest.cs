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

            MoneyTransfer moneyTransfer = new MoneyTransfer();
            var actual = moneyTransfer.Transfer(originBank, destinationBank, 0);

            Assert.False(actual);
        }
    }
}
