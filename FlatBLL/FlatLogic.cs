using System.Collections.Generic;
using System.Linq;
using FlatDAL;
using Entities;
using IFlat.BLL;
using IFlatDAL;

namespace FlatBLL
{
    public class FlatLogic : IFlatLogic
    {
        private IFlatDao _flatDao;
        public FlatLogic()
        {
            _flatDao = new FlatDao();
        }
        
        public List<Flat> GetAll()
        {
            return _flatDao.GetAll().ToList();
        }
        
        public Flat Create(Flat flat)
        {
            return  _flatDao.Create(flat);;
        }
        
        public string Delete(int idFlat)
        {
            return _flatDao.Delete(idFlat);
        }
        public List<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street)
        {
            return _flatDao.GetFlatsByFilters(flNumMin, flNumMax, sqMin, sqMax, 
                numOfRmsMin, numOfRmsMax, priceMin, priceMax, numOfHouseMin, numOfHouseMax,
                city, street).ToList();
        }
        public List<Flat> GetSortedByPrice(List<Flat> flats)
        {
            return flats.OrderBy(x => x.Price).ToList();
        }

        public List<Flat> GetSortedByNumOfRooms(List<Flat> flats)
        {
            return flats.OrderBy(x => x.NumOfRooms).ToList();
        }

        public List<Flat> GetSortedBySquare(List<Flat> flats)
        {
            return flats.OrderBy(x => x.SquareOfFlat).ToList();
        }

        public List<Flat> GetSortedByFloorNumber(List<Flat> flats)
        {
            return flats.OrderBy(x => x.FloorNumber).ToList();
        }

        public List<Flat> GetSortedByFlatNumber(List<Flat> flats)
        {
            return flats.OrderBy(x => x.FlatNumber).ToList();
        }

        public string MakeContract(int idBuilding, int idRealtor, int idCustomer, string saleOrRent)
        {
            return _flatDao.MakeContract(idBuilding, idRealtor, idCustomer, saleOrRent);
        }
    }
}