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
        private readonly IFlatDao _flatDao;
        private readonly CacheLogic _cache;
        private readonly string _cacheKey = "flats";
        public FlatLogic(IFlatDao flatDao)
        {
            _flatDao = flatDao;
            _cache = new CacheLogic();
        }
        
        public List<Flat> GetAll()
        {
            return _cache.GetAll( () =>_flatDao.GetAll().ToList(), _cacheKey);
        }
        
        public Flat Create(Flat flat)
        {
            return _cache.Add(() => _flatDao.Create(flat), _cacheKey);
        }
        
        public bool Delete(int id)
        {
            return  _cache.Delete(id, () => _flatDao.Delete(id), _cacheKey);;
        }
        
        public List<Flat> GetFlatsByFilters(FlatFilter filter)
        {
            return _cache.SetAll(() => _flatDao.GetFlatsByFilters(filter).ToList(), _cacheKey);
        }
        public List<Flat> GetSortedBy(SortBy sortBy)
        {
            var flatsFromCache = _cache.GetAll(_cacheKey, () => _flatDao.GetAll().ToList());
            flatsFromCache = GetSortedCollectionBy(sortBy, flatsFromCache);
            return flatsFromCache;
        }

        private static List<Flat> GetSortedCollectionBy(SortBy sortBy, IEnumerable<Flat> tempFlats)
        {
            switch (sortBy)
            {
                case SortBy.FLOOR:
                    return tempFlats.OrderBy(x => x.FloorNumber).ToList();
                case SortBy.NUMBER:
                    return tempFlats.OrderBy(x => x.FlatNumber).ToList();
                case SortBy.ROOMS:
                    return tempFlats.OrderBy(x => x.NumOfRooms).ToList();
                case SortBy.SQUARE:
                    return tempFlats.OrderBy(x => x.SquareOfFlat).ToList();
                case SortBy.PRICE:
                    return tempFlats.OrderBy(x => x.Price).ToList();
                default:
                    throw new ArgumentOutOfRangeException(nameof(sortBy), sortBy, null);
            }
        }
    }
}