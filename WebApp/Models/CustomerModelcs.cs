using System.ComponentModel.DataAnnotations;
using Entities;

namespace WebApp.Models
{
    public class CustomerModel: Customer
    {
        [RegularExpression("[\\d]+")] public int Name { get; set; }

        [RegularExpression("[\\d]+")] public string City { get; set; }

        public CustomerModel(int name, string city)
        {
        }
    }
}