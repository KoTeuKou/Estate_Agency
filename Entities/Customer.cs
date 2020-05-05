using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Customer
    {
        public Customer(){}

        public Customer(int idCustomer, string customerName, int idCityOfResidence)
        {
            IdCustomer = idCustomer;
            CustomerName = customerName;
            IdCityOfResidence = idCityOfResidence;
        }

        public Customer(int idCityOfResidence, string customerName)
        {
            IdCityOfResidence = idCityOfResidence;
            CustomerName = customerName;
        }

        public int IdCustomer { get; set; }
        public int IdCityOfResidence { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string CustomerName { get; set; }
    }
}