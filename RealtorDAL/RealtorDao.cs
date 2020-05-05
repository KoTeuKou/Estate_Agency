using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using IRealtorDAL;

namespace RealtorDAL
{
    public class RealtorDao : IRealtorDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public IEnumerable<Realtor> GetAll()
        {
            var result = new List<Realtor>();
            using (var connection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM Realtor";
                var cmd = new SqlCommand(sql, connection);
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var r = new Realtor()
                    {
                        IdRealtor = (int) reader["id_realtor"],
                        RealtorName = (string) reader["realtor_name"],
                    };
                    result.Add(r);
                }
            }

            foreach (var realtor in result)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        var cmd = new SqlCommand("HOW_MANY_CONTRACTS", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_realtor", realtor.IdRealtor);
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            realtor.NumOfContracts = (int) reader["times"];
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                }
            }
            
            return result.AsEnumerable();
        }

        public Realtor Create(Realtor realtor)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    const string sql = "INSERT INTO Realtor Values (@realtor_name); Select * FROM Realtor r WHERE r.id_realtor = SCOPE_IDENTITY()";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@realtor_name", realtor.RealtorName);

                    var reader = cmd.ExecuteReader();
                    Realtor r = null;
                    if (reader.Read())
                    {
                        r = new Realtor()
                        {
                            IdRealtor = (int) reader["id_realtor"],
                            RealtorName = (string) reader["realtor_name"],
                        };
                    }
                    try
                    {
                        connection.Open();
                        cmd = new SqlCommand("HOW_MANY_CONTRACTS", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_realtor", r.IdRealtor);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            realtor.NumOfContracts = (int) reader["times"];
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                   
                    return r;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new Realtor();
                }
            }
        }

        public string Delete(int idRealtor)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM Realtor WHERE id_realtor = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idRealtor);
                    cmd.ExecuteNonQuery();
                    return $"Риэлтор успешно удален.";
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