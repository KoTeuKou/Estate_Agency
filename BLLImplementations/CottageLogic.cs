using System;
using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using Cache.CacheUtil;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    public class CottageLogic : ICottageLogic
    {
        private ICottageDao _cottageDao;
        private CottageCache _cottageCache;
        public CottageLogic(ICottageDao cottageDao)
        {
            _cottageDao = cottageDao;
            _cottageCache = new CottageCache();
        }
        
        public List<Cottage> GetAll()
        {
            var cottagesFromCache = _cottageCache.GetAll();
            List<Cottage> cottagesFromDb;
            if (cottagesFromCache.Count == 0)
            {
                cottagesFromDb = _cottageDao.GetAll().ToList();
                _cottageCache.AddListOfCottages(cottagesFromDb);
                return cottagesFromDb;
            }
            return cottagesFromCache;
        }
        
        public Cottage Create(Cottage cottage)
        {
            var cottageFromDb = _cottageDao.Create(cottage);
            _cottageCache.AddCottage(cottageFromDb);
            return cottageFromDb;
        }
        
        public Boolean Delete(int id)
        {
            var isDeleted = _cottageDao.Delete(id);
            if (isDeleted)
            {
                _cottageCache.Delete(id);
            }
            return isDeleted;
        }
        
        public List<Cottage> GetCottagesByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax,
            string city, string street)
        {
            return _cottageDao.GetCottagesByFilters(flNumMin, flNumMax, sqMin, sqMax, 
                numOfRmsMin, numOfRmsMax, priceMin, priceMax,
                city, street).ToList();
        }
        public List<Cottage> GetSortedBy(SortBy sortBy)
        {
            var cottagesFromCache = _cottageCache.GetAll();
            List<Cottage> cottagesFromDb = new List<Cottage>();
            List<Cottage> tempCottages;
            if (cottagesFromCache.Count == 0)
            {
                cottagesFromDb = _cottageDao.GetAll().ToList();
                _cottageCache.AddListOfCottages(cottagesFromDb);
                tempCottages = cottagesFromDb;
            }
            tempCottages = cottagesFromDb ?? cottagesFromCache;
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
            return tempCottages;
        }
    }
}