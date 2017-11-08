using CollatzCalculator.CalculatorLogic;
using Xunit;

namespace CollatzCalculatorTests.CalculatorLogic
{
    public class IsOddRuleFixture
    {
        private readonly IsOddRule _isOddRule;

        public IsOddRuleFixture()
        {
            _isOddRule = new IsOddRule();
        }

        [Fact]
        public void ApplyIsOddRule_ReturnsCorrectRule()
        {
            // Arrange
            long inputNumber = 10;
            
            // Act
            var result = _isOddRule.ApplyIsOddRule(inputNumber);

            // Assert
            Assert.IsType<long>(result);
            Assert.Equal(31, result);
        }
    }
}
