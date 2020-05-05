using System.Collections.Generic;
using Entities;

namespace ICustomerDAL
{
    public interface ICustomerDao
    {
        IEnumerable<Customer> GetAll();
        Customer Create(Customer customer);
        string Delete(int idCustomer);
    }
}