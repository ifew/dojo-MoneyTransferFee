using System;
using Xunit;

namespace MoneyTransfer
{
    public class MoneyTransferTest
    {
        
        [Fact]
        public void When_Same_Bank_Should_Be_Return_True()
        {
            var originBank = "SCB";
            var destinationBank = "SCB";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actual = moneyTransfer.IsSameBank();

            Assert.True(actual);
        }

        public void When_Diffence_Bank_Should_Be_Return_False()
        {
            var originBank = "SCB";
            var destinationBank = "KBANK";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actual = moneyTransfer.IsSameBank();

            Assert.False(actual);
        }

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

        [Theory]
        [InlineData(0,null)]
        [InlineData(20001,null)]
        public void When_Transfer_Difference_Bank_Should_Be_Return_False(double inputAmount, double? expectedFee)
        {
            var originBank = "SCB";
            var destinationBank = "KBANK";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.getFee(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.False(actualStatus);
        }
        
        [Theory]
        [InlineData(4999,0)]
        [InlineData(5000,0)]
        public void When_Transfer_Diffence_Bank_Amount_Should_Be_Return_True_And_Fee_0THB(double inputAmount, double expectedFee)
        {
            var originBank = "SCB";
            var destinationBank = "KBANK";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.getFee(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.True(actualStatus);
        }
        
        [Theory]
        [InlineData(5001,1)]
        [InlineData(9999,1)]
        [InlineData(10000,1)]
        public void When_Transfer_Diffence_Bank_Amount_Should_Be_Return_True_And_Fee_1THB(double inputAmount, double expectedFee)
        {
            var originBank = "SCB";
            var destinationBank = "KBANK";

            MoneyTransfer moneyTransfer = new MoneyTransfer(originBank, destinationBank);
            var actualFee = moneyTransfer.getFee(inputAmount);
            var actualStatus = moneyTransfer.IsTransfer(inputAmount);

            Assert.Equal(expectedFee, actualFee);
            Assert.True(actualStatus);
        }
    }
}
