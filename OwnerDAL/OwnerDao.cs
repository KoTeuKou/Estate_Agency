using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using IOwnerDAL;

namespace OwnerDAL
{
    public class OwnerDao : IOwnerDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public IEnumerable<Owner> GetAll()
        {
            var result = new List<Owner>();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM Owner_";
                var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var o = new Owner()
                    {
                        IdOwner = (int) reader["id_owner"],
                        OwnerName = (string) reader["owner_name"],
                    };
                    result.Add(o);
                }
            }
            return result.AsEnumerable();
        }

        public Owner Create(Owner owner)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int idOwner)
        {
            throw new System.NotImplementedException();
        }
    }
}