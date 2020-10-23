using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DALInterfaces;
using Entities;

namespace DALImplementations
{
    public class StreetDao : BaseDao, IStreetDao
    {
        public IEnumerable<Street> GetAll()
        {
            var result = new List<Street>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GET_ALL_STREETS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var street = new Street()
                    {
                        IdStreet = (int) reader["id_street"],
                        StreetName = (string) reader["street_name"],
                        CityName = (string) reader["city_name"],
                        IdCity = (int) reader["id_city"],
                    };
                    result.Add(street);
                }
            }

            return result;
        }
    }
}