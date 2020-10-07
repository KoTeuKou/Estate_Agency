using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    namespace BLLImplementations
    {
        public class StreetLogic : IStreetLogic
        {
            private IStreetDao _streetDao;
        
            public StreetLogic(IStreetDao streetDao)
            {
                _streetDao = streetDao;
            }
        
            public List<Street> GetAll()
            {
                return _streetDao.GetAll().ToList();
            }
        }
    }
}