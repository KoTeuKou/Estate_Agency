using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using IAward.DAL;

namespace Award.DAL 
{
    public class AwardDao : IAwardDao
    {
        private string connectionString = "Data Source=KoTeuka;Initial Catalog=Users;Integrated Security=True";

        public AwardDao()
        {
        }
        public IEnumerable<Entities.Award> GetAllAwards()
        {
            var result = new List<Entities.Award>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllAwards", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var f = new Entities.Award()
                    {
                        IdAward = (int) reader["IDAward"],
                        Tittle = (string) reader["Tittle"],
                    };

                    result.Add(f);
                }
            }

            return result.AsEnumerable();
        }
        public string CreateAward(Entities.Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("CreateAward", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tittle", award.Tittle);
                    var rowCount = cmd.ExecuteNonQuery();
                    return $"Награда успешно добавлена.";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return $"Ошибка:  {e}";
                }
            }
        }

        public string DeleteAward(int idAward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteAward", connection);
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
    }
}