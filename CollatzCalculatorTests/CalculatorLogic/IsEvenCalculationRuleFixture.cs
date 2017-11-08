using CollatzCalculator.CalculatorLogic;
using Xunit;

namespace CollatzCalculatorTests.CalculatorLogic
{
    public class IsEvenCalculationRuleFixture
    {
        private readonly IIsEvenCalculationRule _isEvenCalculationRule;

        public IsEvenCalculationRuleFixture()
        {
            _isEvenCalculationRule = new IsEvenCalculationRule();
        }

        [Fact]
        public void CalculateOutput_ReturnsHalfNumber()
        {
            // Arrange
            var inputNumber = 10;

            // Act
            var result = _isEvenCalculationRule.CalculateOutput(inputNumber);

            // Assert
            Assert.Equal(result, inputNumber / 2);
        }
    }
}
