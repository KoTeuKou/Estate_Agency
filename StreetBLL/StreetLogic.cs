using System.Collections.Generic;
using System.Linq;
using Entities;
using IStreetBLL;
using IStreetDAL;
using StreetDAL;

namespace StreetBLL
{
    public class StreetLogic : IStreetLogic
    {
        private IStreetDao _objDao;
        public StreetLogic()
        {
            _objDao = new StreetDao();
        }
        
        public List<Street> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public Street Create(Street obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }
    }
}