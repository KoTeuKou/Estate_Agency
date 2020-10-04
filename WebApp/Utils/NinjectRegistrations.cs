using BLLImplementations;
using BLLInterfaces;
using DALImplementations;
using DALInterfaces;
using Ninject.Modules;

namespace WebApp.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ICottageLogic>().To<CottageLogic>();
            Bind<IFlatLogic>().To<FlatLogic>();
            Bind<IFlatDao>().To<FlatDao>();
            Bind<ICottageDao>().To<CottageDao>();
        }
    }
}