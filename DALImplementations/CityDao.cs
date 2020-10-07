using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DALInterfaces;
using Entities;

namespace DALImplementations
{
    public class CityDao : ICityDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["EstateAgency"].ConnectionString;

        public IEnumerable<City> GetAll()
        {
            var result = new List<City>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GET_ALL_CITIES", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var city = new City()
                    {
                        IdCity = (int) reader["id_city"],
                        CityName = (string) reader["city_name"]
                    };
                    result.Add(city);
                }
            }

            return result.AsEnumerable();
        }
    }
}
