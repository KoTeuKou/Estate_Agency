using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DALInterfaces;
using Entities;

namespace DALImplementations
{
    public class OwnerDao : IOwnerDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["EstateAgency"].ConnectionString;

        public IEnumerable<Owner> GetAll()
        {
            var result = new List<Owner>();
            using (var connection = new SqlConnection(_connectionString))
            {
               
                var cmd = new SqlCommand("GET_ALL_OWNERS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var owner = new Owner()
                    {
                        IdOwner = (int) reader["id_owner"],
                        OwnerName = (string) reader["owner_name"],
                    };
                    result.Add(owner);
                }
            }

            return result.AsEnumerable();
        }
    }
}