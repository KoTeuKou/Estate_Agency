using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using DALImplementations;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    public class CottageLogic : ICottageLogic
    {
        private ICottageDao _cottageDao;
        private List<Cottage> _cottages;
        public CottageLogic()
        {
            _cottageDao = new CottageDao();
            _cottages = new List<Cottage>();
        }
        
        public List<Cottage> GetAll()
        {
            if (_cottages != null && _cottages.Count != 0) 
                return _cottages;

            var cottages = _cottageDao.GetAll().ToList();
            _cottages = cottages;
            return cottages;
        }
        
        public void Create(Cottage obj)
        {
            _cottages.Add(_cottageDao.Create(obj));
        }
        
        public void Delete(int id)
        {
            _cottages.Remove(_cottages.First(cottage => cottage.IdCottage == id));
            _cottageDao.Delete(id);
        }
        
        public List<Cottage> GetCottagesByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax,
            string city, string street)
        {
            var cottagesByFilters = _cottageDao.GetCottagesByFilters(flNumMin, flNumMax, sqMin, sqMax, 
                numOfRmsMin, numOfRmsMax, priceMin, priceMax,
                city, street).ToList();
            _cottages = cottagesByFilters;
            return cottagesByFilters;
        }
        public List<Cottage> GetSortedBy(SortBy sortBy)
        {
            List<Cottage> tempCottages = _cottages;
            switch (sortBy)
            {
                case SortBy.FLOOR:
                    tempCottages = tempCottages.OrderBy(x => x.NumOfFloors).ToList();
                    break;
                case SortBy.NUMBER:
                    tempCottages = tempCottages.OrderBy(x => x.CottageNumber).ToList();
                    break;
                case SortBy.ROOMS:
                    tempCottages = tempCottages.OrderBy(x => x.NumOfRooms).ToList();
                    break;
                case SortBy.SQUARE:
                    tempCottages = tempCottages.OrderBy(x => x.SquareOfCottage).ToList();
                    break;
                case SortBy.PRICE:
                    tempCottages = tempCottages.OrderBy(x => x.Price).ToList();
                    break;
            }

            _cottages = tempCottages;
            return tempCottages;
        }
    }
}