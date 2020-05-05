using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using ICityDAL;

namespace CityDAL
{
    public class CityDao : ICityDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public IEnumerable<City> GetAll()
        {
            var result = new List<City>();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM City";
                var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var c = new City()
                    {
                        IdCity = (int) reader["id_city"],
                        CityName = (string) reader["city_name"]
                    };
                    result.Add(c);
                }
            }
            return result.AsEnumerable();
        }

        public City Create(City city)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int idCity)
        {
            throw new System.NotImplementedException();
        }
    }
}