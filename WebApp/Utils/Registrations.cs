using AutoMapper;
using BLLImplementations;
using BLLImplementations.BLLImplementations;
using BLLInterfaces;
using DALImplementations;
using DALInterfaces;
using Ninject.Modules;

namespace WebApp.Utils
{
    public class Registrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ICottageLogic>().To<CottageLogic>().InSingletonScope();
            Bind<IFlatLogic>().To<FlatLogic>().InSingletonScope();
            Bind<ICityLogic>().To<CityLogic>().InSingletonScope();
            Bind<IStreetLogic>().To<StreetLogic>().InSingletonScope();
            Bind<IHouseLogic>().To<HouseLogic>().InSingletonScope();
            Bind<IOwnerLogic>().To<OwnerLogic>().InSingletonScope();
            
            Bind<IFlatDao>().To<FlatDao>().InSingletonScope();
            Bind<ICottageDao>().To<CottageDao>().InSingletonScope();
            Bind<ICityDao>().To<CityDao>().InSingletonScope();
            Bind<IStreetDao>().To<StreetDao>().InSingletonScope();
            Bind<IHouseDao>().To<HouseDao>().InSingletonScope();
            Bind<IOwnerDao>().To<OwnerDao>().InSingletonScope();
            
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperWebConfiguration.FlatToVmProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.CottageToVmProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.VmToCottageProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.VmToFlatProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.CottageFilterProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.FlatFilterProfile>();
                
                cfg.AddProfile<AutoMapperWebConfiguration.CityProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.HouseProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.OwnerProfile>();
                cfg.AddProfile<AutoMapperWebConfiguration.StreetProfile>();

            });
    
            Bind<IMapper>().ToConstructor(c => new Mapper(mapperConfiguration)).InSingletonScope();

        }
    }
}