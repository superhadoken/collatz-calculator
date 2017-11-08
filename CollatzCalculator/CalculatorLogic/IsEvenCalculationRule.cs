namespace CollatzCalculator.CalculatorLogic
{
    public interface IIsEvenCalculationRule
    {
        long CalculateOutput(long inputNumber);
    }

    public class IsEvenCalculationRule : IIsEvenCalculationRule
    {
        public long CalculateOutput(long inputNumber)
        {
            return inputNumber / 2;
        }
    }
}
