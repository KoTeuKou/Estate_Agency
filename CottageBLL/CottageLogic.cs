using System.Collections.Generic;
using System.Linq;
using CottageDAL;
using Entities;
using ICottageBLL;
using ICottageDAL;

namespace CottageBLL
{
    public class CottageLogic : ICottageLogic
    {
        private ICottageDao _objDao;
        public CottageLogic()
        {
            _objDao = new CottageDao();
        }
        
        public List<Cottage> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public Cottage Create(Cottage obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }
        
        public List<Cottage> GetCottagesByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street)
        {
            return _objDao.GetCottagesByFilters(flNumMin, flNumMax, sqMin, sqMax, 
                numOfRmsMin, numOfRmsMax, priceMin, priceMax, numOfHouseMin, numOfHouseMax,
                city, street).ToList();
        }
        public List<Cottage> GetSortedByPrice(List<Cottage> cottages)
        {
            return cottages.OrderBy(x => x.Price).ToList();
        }

        public List<Cottage> GetSortedByNumOfRooms(List<Cottage> cottages)
        {
            return cottages.OrderBy(x => x.NumOfRooms).ToList();
        }

        public List<Cottage> GetSortedBySquare(List<Cottage> cottages)
        {
            return cottages.OrderBy(x => x.SquareOfCottage).ToList();
        }

        public List<Cottage> GetSortedByFloorNumber(List<Cottage> cottages)
        {
            return cottages.OrderBy(x => x.NumOfFloors).ToList();
        }

        public List<Cottage> GetSortedByCottageNumber(List<Cottage> cottages)
        {
            return cottages.OrderBy(x => x.CottageNumber).ToList();
        }

        public string MakeContract(int idBuilding, int idRealtor, int idCustomer, string saleOrRent)
        {
            return _objDao.MakeContract(idBuilding, idRealtor, idCustomer, saleOrRent);
        }
    }
}