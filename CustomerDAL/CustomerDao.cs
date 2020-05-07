using System;
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
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "INSERT INTO Customer Values (@customer_name, @id_city_of_residence); Select * FROM Customer c WHERE c.id_customer = SCOPE_IDENTITY()";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@customer_name", customer.CustomerName);
                    cmd.Parameters.AddWithValue("@id_city_of_residence", customer.IdCityOfResidence);

                    var reader = cmd.ExecuteReader();
                    Customer c = null;
                    if (reader.Read())
                    {
                        c = new Customer()
                        {
                            IdCustomer = (int) reader["id_customer"],
                            CustomerName = (string) reader["customer_name"],
                            IdCityOfResidence = (int) reader["id_city_of_residence"]
                        };
                    }
                    return c;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new Customer();
                }
            }
        }

        public string Delete(int idCustomer)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM Customer WHERE id_customer = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idCustomer);
                    cmd.ExecuteNonQuery();
                    return $"Покупатель успешно удален.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return $"Ошибка:  {e}";
            }
        }
    }
}