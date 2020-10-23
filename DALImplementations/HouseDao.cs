using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DALInterfaces;
using Entities;

namespace DALImplementations
{
    public class HouseDao : BaseDao, IHouseDao
    {
        public IEnumerable<House> GetAll()
        {
            var result = new List<House>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GET_ALL_HOUSES", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var house = new House()
                    {
                        IdHouse = (int) reader["id_house"],
                        HouseNum = (int) reader["house_num"],
                        NumOfFloors = (int) reader["num_of_floors"],
                        IdStreet = (int) reader["id_street"],
                        StreetName = (string) reader["street_name"],
                        CityName = (string) reader["city_name"]
                    };
                    result.Add(house);
                }
            }

            return result;
        }
    }
}