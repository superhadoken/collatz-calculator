using System;
using CollatzCalculator.CalculatorLogic;
using CollatzCalculator.Model;
using CollatzCalculator.View;

namespace CollatzCalculator.Controller
{
    public interface IRunCalculator
    {
        void SetupCalculator();
    }

    public class RunCalculator : IRunCalculator
    {
        private readonly IBanner _banner;
        private readonly IIsOddRule _isOddRule;
        private readonly IIsEvenCalculationRule _isEvenCalculationRule;
        private readonly ICheckIsOdd _checkIsOdd;

        public RunCalculator(IBanner banner,
            IIsOddRule isOddRule,
            IIsEvenCalculationRule isEvenCalculationRule,
            ICheckIsOdd checkIsOdd)
        {
            _banner = banner;
            _isOddRule = isOddRule;
            _isEvenCalculationRule = isEvenCalculationRule;
            _checkIsOdd = checkIsOdd;
        }

        public void SetupCalculator()
        {
            Console.Clear();

            Console.WriteLine(_banner.RenderBanner());
            Console.WriteLine("Please enter a number: ");
            var userInput = Console.ReadLine();
            long numberToCalculate;

            while (!long.TryParse(userInput, out numberToCalculate))
            {
                Console.WriteLine("Not a valid number! Please enter a number: ");
                userInput = Console.ReadLine();
            }

            var calculation = new Calculation(numberToCalculate);

            while (calculation.NumberToCalculate > 1)
            {
                if (_checkIsOdd.NumberIsOdd(calculation.NumberToCalculate))
                {
                    calculation.NumberToCalculate = _isOddRule.ApplyIsOddRule(calculation.NumberToCalculate);
                }
                else
                    calculation.NumberToCalculate = _isEvenCalculationRule.CalculateOutput(calculation.NumberToCalculate);

                calculation.StepsTaken++;
                Console.Write(calculation.NumberToCalculate + ", ");
            }

            Console.WriteLine("\nSteps taken: " + calculation.StepsTaken);
            CalculateAgainQuestion();
        }

        private void CalculateAgainQuestion()
        {
            Console.WriteLine("Play again? [Y/N]");
            var userInput = Console.ReadLine();
            if (UserDidntAnswerYes(userInput))
                return;
            Console.Clear();
            SetupCalculator();
        }

        private bool UserDidntAnswerYes(string userInput)
        {
            return userInput.IndexOf("yes", StringComparison.InvariantCultureIgnoreCase) == -1 &&
                   userInput.IndexOf("y", StringComparison.InvariantCultureIgnoreCase) == -1;
        }
    }
}
