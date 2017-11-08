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

            var runCalculator = kernal.Get<IRunCalculator>();
            runCalculator.SetupCalculator();
        }
    }
}
