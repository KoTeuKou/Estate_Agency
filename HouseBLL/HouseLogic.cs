using System.Collections.Generic;
using System.Linq;
using Entities;
using HouseDAL;
using IHouseBLL;
using IHouseDAL;

namespace HouseBLL
{
    public class HouseLogic : IHouseLogic
    {
        private IHouseDao _objDao;
        public HouseLogic()
        {
            _objDao = new HouseDao();
        }
        
        public List<House> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public House Create(House obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }
    }
}