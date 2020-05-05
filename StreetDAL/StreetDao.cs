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
                const string sql = "SELECT * FROM Street";
                var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var s = new Street()
                    {
                        IdStreet = (int) reader["id_street"],
                        StreetName = (string) reader["street_name"],
                        IdCity = (int) reader["id_city"],
                    };
                    result.Add(s);
                }
            }
            return result.AsEnumerable();
        }

        public string Delete(int idStreet)
        {
            throw new System.NotImplementedException();
        }

        public Street Create(Street street)
        {
            throw new System.NotImplementedException();
        }
    }
}