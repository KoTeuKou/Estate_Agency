using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    namespace BLLImplementations
    {
        public class HouseLogic : IHouseLogic
        {
            private IHouseDao _houseDao;
        
            public HouseLogic(IHouseDao houseDao)
            {
                _houseDao = houseDao;
            }
        
            public List<House> GetAll()
            {
                return _houseDao.GetAll().ToList();
            }
        }
    }
}