using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using IAwardDAL;

namespace AwardDAL 
{
    public class AwardDao : IAwardDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Users;Integrated Security=True";

        public AwardDao()
        {
        }
        public IEnumerable<Award> GetAllAwards()
        {
            var result = new List<Award>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllAwards", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new Award()
                    {
                        IdAward = (int) reader["IDAward"],
                        Tittle = (string) reader["Tittle"],
                    };
                    result.Add(f);
                }
            }

            return result.AsEnumerable();
        }
        public Award CreateAward(Award award)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    var cmd = new SqlCommand("CreateAward", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tittle", award.Tittle);
                    var reader = cmd.ExecuteReader();
                    Award a = null;
                    if (reader.Read())
                    {
                        a = new Award()
                        {
                            IdAward = (int) reader["IDAward"],
                            Tittle = (string) reader["Tittle"],
                        };
                    }
                    return a;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new Award();
                }
            }
        }

        public string DeleteAward(int idAward)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var cmd = new SqlCommand("DeleteAward", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", idAward);
                    connection.Open();
                    var rowCount = cmd.ExecuteNonQuery();
                    return $"Награда успешно удалена.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return $"Ошибка:  {e}";
            }
        }

        public Award GetAwardById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAwardById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                Award a = null;
                if (reader.Read())
                {
                    a = new Award
                    {
                        IdAward = (int) reader["IDAward"],
                        Tittle = (string) reader["Tittle"],
                    };
                }
                return a;
            }
        }
    }
}