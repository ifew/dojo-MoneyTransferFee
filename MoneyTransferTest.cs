using System;
using Xunit;

namespace MoneyTransfer
{
    public class MoneyTransferTest
    {
        [Theory]
        [InlineData(0,null)]
        [InlineData(20001,null)]
        public void When_Transfer_Same_Bank_Should_Be_Return_False(double inputAmount, double? expectedFee)
        {
            var originBank = "SCB";
            var destinationBank = "SCB";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.getFee(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.False(actualStatus);
        }
        
        [Theory]
        [InlineData(4999,0)]
        [InlineData(5000,0)]
        [InlineData(5001,0)]
        [InlineData(9999,0)]
        [InlineData(10000,0)]
        [InlineData(10001,0)]
        [InlineData(14999,0)]
        [InlineData(15000,0)]
        [InlineData(15001,0)]
        [InlineData(19999,0)]
        [InlineData(20000,0)]
        public void When_Transfer_Same_Bank_Amount_Should_Be_Return_True_And_Fee_0THB(double inputAmount, double expectedFee)
        {
            var originBank = "SCB";
            var destinationBank = "SCB";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.getFee(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.True(actualStatus);
        }

        
    }
}
