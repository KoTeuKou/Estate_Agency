using System.Collections.Generic;
using System.Linq;
using Entities;
using IOwnerBLL;
using IOwnerDAL;
using OwnerDAL;

namespace OwnerBLL
{
    public class OwnerLogic : IOwnerLogic
    {
        private IOwnerDao _objDao;
        public OwnerLogic()
        {
            _objDao = new OwnerDao();
        }
        
        public List<Owner> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public Owner Create(Owner obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }
    }
}