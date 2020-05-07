using System;
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
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "INSERT INTO City Values (@city_name); Select * FROM City c WHERE c.id_city = SCOPE_IDENTITY()";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@city_name", city.CityName);

                    var reader = cmd.ExecuteReader();
                    City c = null;
                    if (reader.Read())
                    {
                        c = new City()
                        {
                            IdCity = (int) reader["id_city"],
                            CityName = (string) reader["city_name"],
                        };
                    }
                    return c;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new City();
                }
            }
        }

        public string Delete(int idCity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM City WHERE id_city = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idCity);
                    cmd.ExecuteNonQuery();
                    return $"Город успешно удален.";
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