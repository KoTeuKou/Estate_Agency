using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using IUser.DLL;

namespace UserDLL
{
    public class UserDao : IUserDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Users;Integrated Security=True";

        public UserDao()
        {
        }

        public User AddUser(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    var cmd = new SqlCommand("AddUser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Surname", user.Surname);
                    cmd.Parameters.AddWithValue("@Patronymic", user.Patronymic);
                    cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    var reader = cmd.ExecuteReader();
                    User u = null;
                    if (reader.Read())
                    {
                        u = new User
                        {
                            IdUser = (int) reader["IDUser"],
                            Name = (string) reader["Name"],
                            Surname = (string) reader["Surname"],
                            Patronymic = (string) reader["Patronymic"],
                            DateOfBirth = (DateTime) reader["DateOfBirth"],
                            PhoneNumber = (string) reader["PhoneNumber"]
                        };
                        u.Awards = GetAllAwardsOfUser(u.IdUser).ToList();
                    }
                    return u;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new User();
                }
            }
        }

        public User Edit(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var cmd = new SqlCommand("EditUser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Surname", user.Surname);
                    cmd.Parameters.AddWithValue("@Patronymic", ((object) user.Patronymic) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfBirth", ((object) user.DateOfBirth) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", ((object) user.PhoneNumber) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", user.IdUser);
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    User u = null;
                    if (reader.Read())
                    {
                        u = new User
                        {
                            IdUser = (int) reader["IDUser"],
                            Name = (string) reader["Name"],
                            Surname = (string) reader["Surname"],
                            Patronymic = (string) reader["Patronymic"],
                            DateOfBirth = (DateTime) reader["DateOfBirth"],
                            PhoneNumber = (string) reader["PhoneNumber"]
                        };
                        u.Awards = GetAllAwardsOfUser(u.IdUser).ToList();
                    }
                    return u;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                   return new User();
                }
            }
        }

        public IEnumerable<User> SearchByName(string name)
        {
            var result = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SearchByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", ((object) name) ?? DBNull.Value);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new User
                    {
                        IdUser = (int) reader["IDUser"],
                        Name = (string) reader["Name"],
                        Surname = (string) reader["Surname"],
                        Patronymic = (string) reader["Patronymic"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        PhoneNumber = (string) reader["PhoneNumber"]
                    };
                    result.Add(f);
                }
            }
            return result;
        }

        public IEnumerable<User> SearchBySurname(string surname)
        {
            var result = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SearchBySurname", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Surname", ((object) surname) ?? DBNull.Value);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new User
                    {
                        IdUser = (int) reader["IDUser"],
                        Name = (string) reader["Name"],
                        Surname = (string) reader["Surname"],
                        Patronymic = (string) reader["Patronymic"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        PhoneNumber = (string) reader["PhoneNumber"]
                    };
                    result.Add(f);
                }
            }
            return result;
        }

        public IEnumerable<User> SearchByPatronymic(string patronymic)
        {
            var result = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SearchByPatronymic", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patronymic", ((object) patronymic) ?? DBNull.Value);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new User
                    {
                        IdUser = (int) reader["IDUser"],
                        Name = (string) reader["Name"],
                        Surname = (string) reader["Surname"],
                        Patronymic = (string) reader["Patronymic"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        PhoneNumber = (string) reader["PhoneNumber"]
                    };
                    result.Add(f);
                }
            }
            return result;
        }

        public IEnumerable<User> SearchByPhone(string phone)
        {
            var result = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SearchByPhone", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", ((object) phone) ?? DBNull.Value);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new User
                    {
                        IdUser = (int) reader["IDUser"],
                        Name = (string) reader["Name"],
                        Surname = (string) reader["Surname"],
                        Patronymic = (string) reader["Patronymic"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        PhoneNumber = (string) reader["PhoneNumber"]
                    };
                    result.Add(f);
                }
            }
            return result;
        }


        public User GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetUserById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                User u = null;
                if (reader.Read())
                {
                    u = new User
                    {
                        IdUser = (int) reader["IDUser"],
                        Name = (string) reader["Name"],
                        Surname = (string) reader["Surname"],
                        Patronymic = (string) reader["Patronymic"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        PhoneNumber = (string) reader["PhoneNumber"]
                    };
                    u.Awards = GetAllAwardsOfUser(u.IdUser).ToList();
                }
                return u;
            }
        }


        public string DeleteUser(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var cmd = new SqlCommand("DeleteById", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    var rowCount = cmd.ExecuteNonQuery();
                    return $"Пользователь успешно удален.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return $"Ошибка:  {e}";
            }
        }


        public IEnumerable<User> GetAllUsers()
        {
            var result = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllUsers", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var f = new User
                    {
                        IdUser = (int) reader["IDUser"],
                        Name = (string) reader["Name"],
                        Surname = (string) reader["Surname"],
                        Patronymic = (string) reader["Patronymic"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        PhoneNumber = (string) reader["PhoneNumber"]
                    };
                    f.Awards = GetAllAwardsOfUser(f.IdUser).ToList();
                    result.Add(f);
                }
            }

            return result.AsEnumerable();
        }

        public User AddAwardToUser(int idUser, int idAward)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    var cmd = new SqlCommand("AddAwardToUser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDUser", idUser);
                    cmd.Parameters.AddWithValue("@IDAward", idAward);
                    var reader = cmd.ExecuteReader();
                    User u = null;
                    if (reader.Read())
                    {
                        u = new User
                        {
                            IdUser = (int) reader["IDUser"],
                            Name = (string) reader["Name"],
                            Surname = (string) reader["Surname"],
                            Patronymic = (string) reader["Patronymic"],
                            DateOfBirth = (DateTime) reader["DateOfBirth"],
                            PhoneNumber = (string) reader["PhoneNumber"]
                        };
                        u.Awards = GetAllAwardsOfUser(u.IdUser).ToList();
                    }

                    return u;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new User();
                }
            }
        }

        public IEnumerable<Award> GetAllAwardsOfUser(int idUser)
        {
            var result = new List<Award>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllAwardsOfUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDUser", idUser);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var m = new Award
                    {
                        IdAward = (int) reader["IDAward"],
                        Tittle = (string) reader["Tittle"],
                    };

                    result.Add(m);
                }
            }
            return result.AsEnumerable();
        }
    }
}
