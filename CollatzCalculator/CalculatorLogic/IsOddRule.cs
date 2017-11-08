using System;

namespace CollatzCalculator.CalculatorLogic
{
    public interface IIsOddRule
    {
        long ApplyIsOddRule(long intValue);
    }

    public class IsOddRule : IIsOddRule
    {
        public IsOddRule()
        {

        }

        public long ApplyIsOddRule(long intValue)
        {
            return intValue * 3 + 1;
        }
    }
}
