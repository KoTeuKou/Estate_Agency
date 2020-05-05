using System.Collections.Generic;
using System.Linq;
using CustomerDAL;
using Entities;
using ICustomerBLL;
using ICustomerDAL;

namespace CustomerBLL
{
    public class CustomerLogic : ICustomerLogic
    {
        private ICustomerDao _objDao;
        public CustomerLogic()
        {
            _objDao = new CustomerDao();
        }
        
        public List<Customer> GetAll()
        {
            return _objDao.GetAll().ToList();
        }
        
        public Customer Create(Customer obj)
        {
            return  _objDao.Create(obj);;
        }
        
        public string Delete(int id)
        {
            return _objDao.Delete(id);
        }
    }
}