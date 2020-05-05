using System.Collections.Generic;
using Entities;

namespace ICustomerBLL
{
    public interface ICustomerLogic
    {
        List<Customer> GetAll();
        Customer Create(Customer customer);
        string Delete(int idCustomer);
    }
}