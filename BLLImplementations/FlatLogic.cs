using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using DALImplementations;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    public class FlatLogic : IFlatLogic
    {
        private IFlatDao _flatDao;
        private List<Flat> _flats;

        public FlatLogic()
        {
            _flatDao = new FlatDao();
            _flats = new List<Flat>();
        }
        
        public List<Flat> GetAll()
        {
            if (_flats != null && _flats.Count != 0) 
                return _flats;

            var cottages = _flatDao.GetAll().ToList();
            _flats = cottages;
            return cottages;
        }
        
        public void Create(Flat flat)
        {
            _flats.Add(_flatDao.Create(flat));
        }
        
        public void Delete(int id)
        {
            _flats.Remove(_flats.First(cottage => cottage.IdFlat == id));
            _flatDao.Delete(id);
        }
        public List<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street)
        {
            var flatsByFilters = _flatDao.GetFlatsByFilters(flNumMin, flNumMax, sqMin, sqMax,
                numOfRmsMin, numOfRmsMax, priceMin, priceMax, numOfHouseMin, numOfHouseMax,
                city, street).ToList();
            _flats = flatsByFilters;
            return flatsByFilters;
        }
        public List<Flat> GetSortedBy(SortBy sortBy)
        {
            List<Flat> tempFlats = _flats;
            switch (sortBy)
            {
                case SortBy.FLOOR:
                    tempFlats = _flats.OrderBy(x => x.FloorNumber).ToList();
                    break;
                case SortBy.NUMBER:
                    tempFlats = _flats.OrderBy(x => x.FlatNumber).ToList();
                    break;
                case SortBy.ROOMS:
                    tempFlats = _flats.OrderBy(x => x.NumOfRooms).ToList();
                    break;
                case SortBy.SQUARE:
                    tempFlats = _flats.OrderBy(x => x.SquareOfFlat).ToList();
                    break;
                case SortBy.PRICE:
                    tempFlats = _flats.OrderBy(x => x.Price).ToList();
                    break;
            }
            return tempFlats;
        }
        
    }
}