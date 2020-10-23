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
        private CacheLogic _cache;
        private readonly string _cacheKey = "cottages";
        
        public CottageLogic(ICottageDao cottageDao)
        {
            _cottageDao = cottageDao;
            _cache = new CacheLogic();
        }
        
        public List<Cottage> GetAll()
        {
            return _cache.GetAll( () =>_cottageDao.GetAll().ToList(), _cacheKey);
        }
        
        public Cottage Create(Cottage cottage)
        {
            return _cache.Add(() => _cottageDao.Create(cottage), _cacheKey);
        }
        
        public bool Delete(int id)
        {
            return  _cache.Delete(id, () => _cottageDao.Delete(id), _cacheKey);;
        }
        
        public List<Cottage> GetCottagesByFilters(CottageFilter filter)
        {
            return _cache.SetAll(() => _cottageDao.GetCottagesByFilters(filter).ToList(), _cacheKey);
        }
        public List<Cottage> GetSortedBy(SortBy sortBy)
        {
            var cottagesFromCache = _cache.GetAll(_cacheKey, () => _cottageDao.GetAll().ToList());
            cottagesFromCache = GetSortedCollectionBy(sortBy, cottagesFromCache);
            return cottagesFromCache;
        }
        private List<Cottage> GetSortedCollectionBy(SortBy sortBy, IEnumerable<Cottage> tempCottages)
        {
            switch (sortBy)
                {
                    case SortBy.FLOOR:
                        return tempCottages.OrderBy(x => x.NumOfFloors).ToList();
                    case SortBy.NUMBER:
                        return tempCottages.OrderBy(x => x.CottageNumber).ToList();
                    case SortBy.ROOMS:
                        return tempCottages.OrderBy(x => x.NumOfRooms).ToList();
                    case SortBy.SQUARE:
                        return tempCottages.OrderBy(x => x.SquareOfCottage).ToList();
                    case SortBy.PRICE:
                        return tempCottages.OrderBy(x => x.Price).ToList();
                    default:
                        throw new ArgumentOutOfRangeException(nameof(sortBy), sortBy, null);
                }
        }
    }
}