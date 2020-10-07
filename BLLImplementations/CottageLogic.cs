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
            if (cottagesFromCache == null || cottagesFromCache.Count == 0)
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
            if (cottageFromDb != null)
            {
                _cottageCache.AddCottage(cottageFromDb);
            }

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
        
        public List<Cottage> GetCottagesByFilters(CottageFilter filter)
        {
            var cottagesByFilters = _cottageDao.GetCottagesByFilters(filter).ToList();
            _cottageCache.AddListOfCottages(cottagesByFilters);
            return cottagesByFilters;
        }
        public List<Cottage> GetSortedBy(SortBy sortBy)
        {
            var cottagesFromCache = _cottageCache.GetAll();
            List<Cottage> tempCottages;
            if (cottagesFromCache == null || cottagesFromCache.Count == 0)
            {
                tempCottages = _cottageDao.GetAll().ToList();
            }
            else
            {
                tempCottages = cottagesFromCache;
            }
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
            _cottageCache.AddListOfCottages(tempCottages);
            return tempCottages;
        }
    }
}