using System;
using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using Cache.CacheUtil;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    public class FlatLogic : IFlatLogic
    {
        private FlatCache _flatCache;
        private IFlatDao _flatDao;
      
        public FlatLogic(IFlatDao flatDao)
        {
            _flatDao = flatDao;
            _flatCache = new FlatCache();
        }
        
        public List<Flat> GetAll()
        {
            var flatsFromCache = _flatCache.GetAll();
            List<Flat> flatsFromDb;
            if (flatsFromCache.Count == 0)
            {
                flatsFromDb = _flatDao.GetAll().ToList();
                _flatCache.AddListOfFLats(flatsFromDb);
                return flatsFromDb;
            }
            return flatsFromCache;
        }
        
        public Flat Create(Flat flat)
        {
            var flatFromDb = _flatDao.Create(flat);
            _flatCache.AddFlat(flatFromDb);
            return flatFromDb;
        }
        
        public Boolean Delete(int id)
        {
            var isDeleted = _flatDao.Delete(id);
            if (isDeleted)
            {
                _flatCache.Delete(id);
            }
            return isDeleted;
        }
        public List<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street)
        {
            return _flatDao.GetFlatsByFilters(flNumMin, flNumMax, sqMin, sqMax,
                numOfRmsMin, numOfRmsMax, priceMin, priceMax, numOfHouseMin, numOfHouseMax,
                city, street).ToList();
        }
        public List<Flat> GetSortedBy(SortBy sortBy)
        {
            var flatsFromCache = _flatCache.GetAll();
            List<Flat> flatsFromDb = new List<Flat>();
            List<Flat> tempFlats;
            if (flatsFromCache.Count == 0)
            {
                flatsFromDb = _flatDao.GetAll().ToList();
                _flatCache.AddListOfFLats(flatsFromDb);
                tempFlats = flatsFromDb;
            }
            tempFlats = flatsFromDb ?? flatsFromCache;
            switch (sortBy)
            {
                case SortBy.FLOOR:
                    tempFlats = tempFlats.OrderBy(x => x.FloorNumber).ToList();
                    break;
                case SortBy.NUMBER:
                    tempFlats = tempFlats.OrderBy(x => x.FlatNumber).ToList();
                    break;
                case SortBy.ROOMS:
                    tempFlats = tempFlats.OrderBy(x => x.NumOfRooms).ToList();
                    break;
                case SortBy.SQUARE:
                    tempFlats = tempFlats.OrderBy(x => x.SquareOfFlat).ToList();
                    break;
                case SortBy.PRICE:
                    tempFlats = tempFlats.OrderBy(x => x.Price).ToList();
                    break;
            }
            return tempFlats;
        }
        
    }
}