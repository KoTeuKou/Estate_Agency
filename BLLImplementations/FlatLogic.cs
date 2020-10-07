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
        private IFlatDao _flatDao;
        private FlatCache _flatCache;
        public FlatLogic(IFlatDao flatDao)
        {
            _flatDao = flatDao;
            _flatCache = new FlatCache();
        }
        
        public List<Flat> GetAll()
        {
            var flatsFromCache = _flatCache.GetAll();
            List<Flat> flatsFromDb;
            if (flatsFromCache == null || flatsFromCache.Count == 0)
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
            if (flatFromDb != null)
            {
                _flatCache.AddFlat(flatFromDb);
            }

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
        
        public List<Flat> GetFlatsByFilters(FlatFilter filter)
        {
            var flatsByFilters = _flatDao.GetFlatsByFilters(filter).ToList();
            _flatCache.AddListOfFLats(flatsByFilters);
            return flatsByFilters;
        }
        public List<Flat> GetSortedBy(SortBy sortBy)
        {
            var flatsFromCache = _flatCache.GetAll();
            List<Flat> tempFlats;
            if (flatsFromCache == null || flatsFromCache.Count == 0)
            {
                tempFlats = _flatDao.GetAll().ToList();
            }
            else
            {
                tempFlats = flatsFromCache;
            }
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
            _flatCache.AddListOfFLats(tempFlats);
            return tempFlats;
        }
    }
}