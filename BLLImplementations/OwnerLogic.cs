using System.Collections.Generic;
using System.Linq;
using BLLInterfaces;
using DALInterfaces;
using Entities;

namespace BLLImplementations
{
    namespace BLLImplementations
    {
        public class OwnerLogic : IOwnerLogic
        {
            private IOwnerDao _ownerDao;
        
            public OwnerLogic(IOwnerDao ownerDao)
            {
                _ownerDao = ownerDao;
            }
        
            public List<Owner> GetAll()
            {
                return _ownerDao.GetAll().ToList();
            }
        }
    }
}