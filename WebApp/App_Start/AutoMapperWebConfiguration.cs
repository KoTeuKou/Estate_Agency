using AutoMapper;
using Entities;
using WebApp.Models;

namespace WebApp
{
    public class AutoMapperWebConfiguration
    {
        public class FlatToVmProfile : Profile
        {
            public FlatToVmProfile()
            {
                CreateMap<Flat, FlatModelVm>()
                    .ForMember(flat => flat.Id, map => map.MapFrom(p => p.IdFlat))
                    .ForMember(flat => flat.FlatNumber, map => map.MapFrom(p => p.FlatNumber))
                    .ForMember(flat => flat.FloorNumber, map => map.MapFrom(p => p.FloorNumber))
                    .ForMember(flat => flat.SquareOfFlat, map => map.MapFrom(p => p.SquareOfFlat))
                    .ForMember(flat => flat.NumOfRooms, map => map.MapFrom(p => p.NumOfRooms))
                    .ForMember(flat => flat.Price, map => map.MapFrom(p => p.Price))
                    .ForMember(flat => flat.Owner, map => map.MapFrom(p => p.Owner))
                    .ForMember(flat => flat.House, map => map.MapFrom(p => p.House))
                    .ForMember(flat => flat.Street, map => map.MapFrom(p => p.Street))
                    .ForMember(flat => flat.City, map => map.MapFrom(p => p.City))
                    ;
            }
        }
        
        public class VmToFlatProfile : Profile
        {
            public VmToFlatProfile()
            {
                CreateMap<FlatModelVm, Flat>()
                    .ForMember(flat => flat.FlatNumber, map => map.MapFrom(p => p.FlatNumber))
                    .ForMember(flat => flat.FloorNumber, map => map.MapFrom(p => p.FloorNumber))
                    .ForMember(flat => flat.SquareOfFlat, map => map.MapFrom(p => p.SquareOfFlat))
                    .ForMember(flat => flat.NumOfRooms, map => map.MapFrom(p => p.NumOfRooms))
                    .ForMember(flat => flat.Price, map => map.MapFrom(p => p.Price))
                    .ForMember(flat => flat.Owner, map => map.MapFrom(p => p.Owner))
                    .ForMember(flat => flat.House, map => map.MapFrom(p => p.House))
                    .ForMember(flat => flat.Street, map => map.MapFrom(p => p.Street))
                    .ForMember(flat => flat.City, map => map.MapFrom(p => p.City))
                    ;
            }
        }
        public class CottageToVmProfile : Profile
        {
            public CottageToVmProfile()
            {
                CreateMap<Cottage, CottageModelVm>()
                    .ForMember(cottage => cottage.Id, map => map.MapFrom(p => p.IdCottage))
                    .ForMember(cottage => cottage.CottageNumber, map => map.MapFrom(p => p.CottageNumber))
                    .ForMember(cottage => cottage.NumOfFloors, map => map.MapFrom(p => p.NumOfFloors))
                    .ForMember(cottage => cottage.SquareOfCottage, map => map.MapFrom(p => p.SquareOfCottage))
                    .ForMember(cottage => cottage.NumOfRooms, map => map.MapFrom(p => p.NumOfRooms))
                    .ForMember(cottage => cottage.Price, map => map.MapFrom(p => p.Price))
                    .ForMember(cottage => cottage.Owner, map => map.MapFrom(p => p.Owner))
                    .ForMember(cottage => cottage.Street, map => map.MapFrom(p => p.Street))
                    .ForMember(cottage => cottage.City, map => map.MapFrom(p => p.City))
                    ;
            }
        }
        
        public class VmToCottageProfile : Profile
        {
            public VmToCottageProfile()
            {
                CreateMap<CottageModelVm, Cottage>()
                    .ForMember(cottage => cottage.CottageNumber, map => map.MapFrom(p => p.CottageNumber))
                    .ForMember(cottage => cottage.NumOfFloors, map => map.MapFrom(p => p.NumOfFloors))
                    .ForMember(cottage => cottage.SquareOfCottage, map => map.MapFrom(p => p.SquareOfCottage))
                    .ForMember(cottage => cottage.NumOfRooms, map => map.MapFrom(p => p.NumOfRooms))
                    .ForMember(cottage => cottage.Price, map => map.MapFrom(p => p.Price))
                    .ForMember(cottage => cottage.Owner, map => map.MapFrom(p => p.Owner))
                    .ForMember(cottage => cottage.Street, map => map.MapFrom(p => p.Street))
                    .ForMember(cottage => cottage.City, map => map.MapFrom(p => p.City))
                    ;
            }
        }
        
        public class CottageFilterProfile : Profile
        {
            public CottageFilterProfile()
            {
                CreateMap<CottageFilterVm, CottageFilter>()
                    .ForMember(cottage => cottage.MinFloorNumber, map => map.MapFrom(p => p.MinFloorNumber))
                    .ForMember(cottage => cottage.MaxFloorNumber, map => map.MapFrom(p => p.MaxFloorNumber))
                    .ForMember(cottage => cottage.MinSquareOfFlat, map => map.MapFrom(p => p.MinSquareOfCottage))
                    .ForMember(cottage => cottage.MaxSquareOfFlat, map => map.MapFrom(p => p.MaxSquareOfCottage))
                    .ForMember(cottage => cottage.MinNumOfRooms, map => map.MapFrom(p => p.MinNumOfRooms))
                    .ForMember(cottage => cottage.MaxNumOfRooms, map => map.MapFrom(p => p.MaxNumOfRooms))
                    .ForMember(cottage => cottage.MinPrice, map => map.MapFrom(p => p.MinPrice))
                    .ForMember(cottage => cottage.MaxPrice, map => map.MapFrom(p => p.MaxPrice))
                    .ForMember(cottage => cottage.Street, map => map.MapFrom(p => p.Street))
                    .ForMember(cottage => cottage.City, map => map.MapFrom(p => p.City))
                    ;
            }
        }
        
        public class FlatFilterProfile : Profile
        {
            public FlatFilterProfile()
            {
                CreateMap<FlatFilterVm, FlatFilter>()
                    .ForMember(flat => flat.MinFloorNumber, map => map.MapFrom(p => p.MinFloorNumber))
                    .ForMember(flat => flat.MaxFloorNumber, map => map.MapFrom(p => p.MaxFloorNumber))
                    .ForMember(flat => flat.MinSquareOfFlat, map => map.MapFrom(p => p.MinSquareOfFlat))
                    .ForMember(flat => flat.MaxSquareOfFlat, map => map.MapFrom(p => p.MaxSquareOfFlat))
                    .ForMember(flat => flat.MinNumOfRooms, map => map.MapFrom(p => p.MinNumOfRooms))
                    .ForMember(flat => flat.MaxNumOfRooms, map => map.MapFrom(p => p.MaxNumOfRooms))
                    .ForMember(flat => flat.MinPrice, map => map.MapFrom(p => p.MinPrice))
                    .ForMember(flat => flat.MaxPrice, map => map.MapFrom(p => p.MaxPrice))
                    .ForMember(flat => flat.Street, map => map.MapFrom(p => p.Street))
                    .ForMember(flat => flat.City, map => map.MapFrom(p => p.City))
                    ;
            }
        }
        
        public class CityProfile : Profile
        {
            public CityProfile()
            {
                CreateMap<City, CityVm>()
                    .ForMember(city => city.IdCity, map => map.MapFrom(p => p.IdCity))
                    .ForMember(city => city.CityName, map => map.MapFrom(p => p.CityName));
            }
        }
        public class HouseProfile : Profile
        {
            public HouseProfile()
            {
                CreateMap<House, HouseVm>()
                    .ForMember(house => house.IdHouse, map => map.MapFrom(p => p.IdHouse))
                    .ForMember(house => house.HouseNum, map => map.MapFrom(p => p.HouseNum));
            }
        }
        
        public class OwnerProfile : Profile
        {
            public OwnerProfile()
            {
                CreateMap<Owner, OwnerVm>()
                    .ForMember(owner => owner.IdOwner, map => map.MapFrom(p => p.IdOwner))
                    .ForMember(owner => owner.OwnerName, map => map.MapFrom(p => p.OwnerName));
            }
        }
        public class StreetProfile : Profile
        {
            public StreetProfile()
            {
                CreateMap<Street, StreetVm>()
                    .ForMember(street => street.IdStreet, map => map.MapFrom(p => p.IdStreet))
                    .ForMember(street => street.StreetName, map => map.MapFrom(p => p.StreetName));
            }
        }
    }
}