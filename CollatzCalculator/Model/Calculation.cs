using System;

namespace CollatzCalculator.Model
{
    public class Calculation
    {
        public int StepsTaken { get; set; }
        public Int64 NumberToCalculate { get; set; }

        public Calculation(Int64 userInput)
        {
            StepsTaken = 0;
            NumberToCalculate = userInput;
        }
    }
}
