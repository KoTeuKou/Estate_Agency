using BLLImplementations;
using BLLInterfaces;
using Ninject.Modules;

namespace WebApp.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ICottageLogic>().To<CottageLogic>();
            Bind<IFlatLogic>().To<FlatLogic>();
        }
    }
}