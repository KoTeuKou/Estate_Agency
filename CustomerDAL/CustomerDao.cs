using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using ICustomerDAL;

namespace CustomerDAL
{
    public class CustomerDao : ICustomerDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public IEnumerable<Customer> GetAll()
        {
            var result = new List<Customer>();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM Customer";
                var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Customer()
                    {
                        IdCustomer = (int) reader["id_customer"],
                        CustomerName = (string) reader["customer_name"],
                        IdCityOfResidence = (int) reader["id_city_of_residence"],
                    };
                    result.Add(c);
                }
            }
            return result.AsEnumerable();
        }

        public Customer Create(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int idCustomer)
        {
            throw new System.NotImplementedException();
        }
    }
}