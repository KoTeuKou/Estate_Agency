using System;
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
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "INSERT INTO Owner Values (@owner_name); Select * FROM Owner o WHERE o.id_owner = SCOPE_IDENTITY()";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@owner_name", owner.OwnerName);

                    var reader = cmd.ExecuteReader();
                    Owner o = null;
                    if (reader.Read())
                    {
                        o = new Owner()
                        {
                            IdOwner = (int) reader["id_owner"],
                            OwnerName = (string) reader["owner_name"],
                        };
                    }
                    return o;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new Owner();
                }
            }
        }

        public string Delete(int idOwner)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM Owner WHERE id_owner = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idOwner);
                    cmd.ExecuteNonQuery();
                    return $"Владелец успешно удален.";
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