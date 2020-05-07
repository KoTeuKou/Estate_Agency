using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using IHouseDAL;

namespace HouseDAL
{
    public class HouseDao : IHouseDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public IEnumerable<House> GetAll()
        {
            var result = new List<House>();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sql =
                    "SELECT h.id_house, h.house_num , h.num_of_floors , h.id_street , st.street_name, c.city_name FROM House h INNER JOIN Street st ON h.id_street = st.id_street INNER JOIN City c ON st.id_city = c.id_city";
                                   var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var h = new House()
                    {
                        IdHouse = (int) reader["id_house"],
                        HouseNum = (int) reader["house_num"],
                        NumOfFloors = (int) reader["num_of_floors"],
                        IdStreet = (int) reader["id_street"],
                        StreetName = (string) reader["street_name"],
                        CityName = (string) reader["city_name"]
                    };
                    result.Add(h);
                }
            }
            return result.AsEnumerable();
        }

        public House Create(House house)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "INSERT INTO House Values (@house_num, @num_of_floors, @id_street);" + 
                    " Select * FROM House h INNER JOIN Street st ON h.id_street = st.id_street INNER JOIN City c ON st.id_city = c.id_city WHERE h.id_house = SCOPE_IDENTITY()";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@house_num", house.HouseNum);
                    cmd.Parameters.AddWithValue("@num_of_floors", house.NumOfFloors);
                    cmd.Parameters.AddWithValue("@id_street", house.IdStreet);
                    var reader = cmd.ExecuteReader();
                    House h = null;
                    if (reader.Read())
                    {
                        h = new House()
                        {
                            IdHouse = (int) reader["id_house"],
                            HouseNum = (int) reader["house_num"],
                            NumOfFloors = (int) reader["num_of_floors"],
                            IdStreet = (int) reader["id_street"],
                            StreetName = (string) reader["street_name"],
                            CityName = (string) reader["city_name"]
                        };
                    }
                    return h;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new House();
                }
            }
        }

        public string Delete(int idHouse)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM House WHERE id_house = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idHouse);
                    cmd.ExecuteNonQuery();
                    return $"Дом успешно удален.";
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