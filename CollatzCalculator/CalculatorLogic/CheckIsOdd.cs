namespace CollatzCalculator.CalculatorLogic
{
    public interface ICheckIsOdd
    {
        bool NumberIsOdd(long numberToCheck);
    }

    public class CheckIsOdd : ICheckIsOdd
    {
        public bool NumberIsOdd(long numberToCheck)
        {
            return numberToCheck % 2 != 0;
        }
    }
}
