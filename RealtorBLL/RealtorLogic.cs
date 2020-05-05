using System.Collections.Generic;
using System.Linq;
using Entities;
using IRealtorBLL;
using IRealtorDAL;
using RealtorDAL;

namespace RealtorBLL
{
    public class RealtorLogic : IRealtorLogic
    {
        private IRealtorDao _objDao;
        public RealtorLogic()
        {
            _objDao = new RealtorDao();
        }
        
        public List<Realtor> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public Realtor Create(Realtor obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }

        public List<Realtor> GetSortedByNumOfContracts(List<Realtor> realtorsList)
        {
            return realtorsList.OrderBy(x => x.NumOfContracts).Reverse().ToList();
        }

        public List<Realtor> GetSortedByRealtorName(List<Realtor> realtorsList)
        {
            return realtorsList.OrderBy(x => x.RealtorName).ToList();
        }
    }
}