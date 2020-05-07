using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using IStreetDAL;

namespace StreetDAL
{
    public class StreetDao: IStreetDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public IEnumerable<Street> GetAll()
        {
            var result = new List<Street>();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT st.id_street, st.street_name, c.city_name, st.id_city FROM Street st INNER JOIN City c ON st.id_city = c.id_city";
                var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var s = new Street()
                    {
                        IdStreet = (int) reader["id_street"],
                        StreetName = (string) reader["street_name"],
                        CityName = (string) reader["city_name"],
                        IdCity = (int) reader["id_city"],
                    };
                    result.Add(s);
                }
            }
            return result.AsEnumerable();
        }

        public string Delete(int idStreet)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM Street WHERE id_street = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idStreet);
                    cmd.ExecuteNonQuery();
                    return $"Улица успешно удалена.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return $"Ошибка:  {e}";
            }
        }

        public Street Create(Street street)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "INSERT INTO Street Values (@street_name, @id_city); " + 
                    "SELECT st.id_street, st.street_name, c.city_name, st.id_city FROM Street st INNER JOIN City c ON st.id_city = c.id_city WHERE st.id_street = SCOPE_IDENTITY()";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@street_name", street.StreetName);
                    cmd.Parameters.AddWithValue("@id_city", street.IdCity);

                    var reader = cmd.ExecuteReader();
                    Street s = null;
                    if (reader.Read())
                    {
                        s = new Street()
                        {
                            IdStreet = (int) reader["id_street"],
                            StreetName = (string) reader["street_name"],
                            CityName = (string) reader["city_name"],
                            IdCity = (int) reader["id_city"],
                        };
                    }
                    return s;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new Street();
                }
            }
        }
    }
}