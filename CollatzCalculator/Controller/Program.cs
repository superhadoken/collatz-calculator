using System;
using System.Reflection;
using Ninject;

namespace CollatzCalculator.Controller
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kernal = new StandardKernel();
            kernal.Load(Assembly.GetExecutingAssembly());

            int numberToCalculate;
            int stepsCount = 0;
            var userInput = Console.ReadLine();

            while (!Int32.TryParse(userInput, out numberToCalculate))
            {
                Console.WriteLine("Please enter a number: ");
                userInput = Console.ReadLine();
            }

            while (numberToCalculate > 1)
            {
                if (numberToCalculate % 2 == 0)
                    numberToCalculate = numberToCalculate / 2;

                else numberToCalculate = 3 * numberToCalculate + 1;

                Console.WriteLine(numberToCalculate);
                stepsCount++;
            }

            Console.WriteLine(string.Format("Steps taken: {0}", stepsCount));
            Console.ReadLine();
        }
    }
}
