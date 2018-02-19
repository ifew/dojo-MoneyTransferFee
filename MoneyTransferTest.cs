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
            double inputAmount = 0;
            double? expectedFee = null;

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.Transfer(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.False(actualStatus);
        }
        
        [Fact]
        public void When_Transfer_Same_Bank_Amount_4999THB_Should_Be_Return_True()
        {
            var originBank = "SCB";
            var destinationBank = "SCB";
            double inputAmount = 4999;
            double expectedFee = 0;

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.Transfer(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.True(actualStatus);
        }

        [Fact]
        public void When_Transfer_Same_Bank_Amount_5000THB_Should_Be_Return_True()
        {
            var originBank = "SCB";
            var destinationBank = "SCB";
            double inputAmount = 5000;
            double expectedFee = 0;

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.Transfer(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.True(actualStatus);
        }
    }
}
