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
                const string sql = "SELECT * FROM House";
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
                    };
                    result.Add(h);
                }
            }
            return result.AsEnumerable();
        }

        public House Create(House house)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int idHouse)
        {
            throw new System.NotImplementedException();
        }
    }
}