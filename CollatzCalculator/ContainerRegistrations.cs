using CollatzCalculator.CalculatorLogic;
using CollatzCalculator.View;
using Ninject.Modules;

namespace CollatzCalculator
{
    public class ContainerRegistrations : NinjectModule
    {
        public override void Load()
        {
            // Views
            Bind<IBanner>().To<Banner>();

            // Logic
            Bind<IIsOddRule>().To<IsOddRule>();
            Bind<ICheckIsOdd>().To<CheckIsOdd>();
            Bind<IIsEvenCalculationRule>().To<IsEvenCalculationRule>();
        }
    }
}
