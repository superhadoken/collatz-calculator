using CollatzCalculator.View;
using Ninject.Modules;

namespace CollatzCalculator
{
    public class ContainerRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IBanner>().To<Banner>();
        }
    }
}
