using System.Collections.Generic;
using System.Linq;
using CityDAL;
using Entities;
using ICityBLL;
using ICityDAL;

namespace CityBLL
{
    public class CityLogic : ICityLogic
    {
        private ICityDao _objDao;
        public CityLogic()
        {
            _objDao = new CityDao();
        }
        
        public List<City> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public City Create(City obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }
    }
}