using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    public class CityLogic : ICityLogic
    {
        private ICityDao _cityDao;
        
        public CityLogic(ICityDao cityDao)
        {
            _cityDao = cityDao;
        }
        
        public List<City> GetAll()
        {
            return _cityDao.GetAll().ToList();
        }
    }
}