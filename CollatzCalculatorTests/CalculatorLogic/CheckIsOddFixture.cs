using System.Runtime.Remoting.Messaging;
using CollatzCalculator.CalculatorLogic;
using Xunit;

namespace CollatzCalculatorTests.CalculatorLogic
{
    public class CheckIsOddFixture
    {
        private readonly ICheckIsOdd _checkIsOdd;
        public CheckIsOddFixture()
        {
            _checkIsOdd = new CheckIsOdd();
        }

        [Fact]
        public void NumberIsOdd_ReturnsCorrectBoolValue()
        {
            // Arrange
            var inputNumber = 11;

            // Act
            var result = _checkIsOdd.NumberIsOdd(inputNumber);

            // Assert
            Assert.True(result);
        }
    }
}
