using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DALInterfaces;
using Entities;

namespace DALImplementations 
{
    public class FlatDao : IFlatDao
    {
        private string _connectionString = "Data Source=KoTeuka;Initial Catalog=Estate_Agency;Integrated Security=True";

        public FlatDao()
        {
        }
        public IEnumerable<Flat> GetAll()
        {
            var result = new List<Flat>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GET_ALL_FLATS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new Flat()
                    {
                        IdFlat = (int) reader["id_flat"],
                        FlatNumber = (int) reader["flat_number"],
                        FloorNumber =(int) reader["floor_number"],
                        SquareOfFlat = (double) reader["square_of_flat"],
                        NumOfRooms = (int) reader["num_of_rooms"],
                        Price = (int) reader["price"],
                        Owner = (string) reader["owner_name"],
                        House = (int) reader["house_num"],
                        Street = (string) reader["street_name"],
                        City = (string) reader["city_name"],
                    };
                    result.Add(f);
                }
            }

            return result.AsEnumerable();
        }
        public Flat Create(Flat flat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand("ADD_FLAT", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flat_number", flat.FlatNumber);
                    cmd.Parameters.AddWithValue("@floor_number", flat.FloorNumber);
                    cmd.Parameters.AddWithValue("@square_of_flat", flat.SquareOfFlat);
                    cmd.Parameters.AddWithValue("@num_of_rooms", flat.NumOfRooms);
                    cmd.Parameters.AddWithValue("@price", flat.Price);
                    cmd.Parameters.AddWithValue("@id_owner", flat.IdOwner);
                    cmd.Parameters.AddWithValue("@id_house", flat.IdHouse);
                    
                    var reader = cmd.ExecuteReader();
                    Flat f = null;
                    if (reader.Read())
                    {
                        f = new Flat()
                        {
                            IdFlat = (int) reader["id_flat"],
                            FlatNumber = (int) reader["flat_number"],
                            FloorNumber =(int) reader["floor_number"],
                            SquareOfFlat = (double) reader["square_of_flat"],
                            NumOfRooms = (int) reader["num_of_rooms"],
                            Price = (int) reader["price"],
                            Owner = (string) reader["owner_name"],
                            House = (int) reader["house_num"],
                            Street = (string) reader["street_name"],
                            City = (string) reader["city_name"],
                        };
                    }
                    return f;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return new Flat();
                }
            }
        }

        public string Delete(int idFlat)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM Flat WHERE id_flat = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idFlat);
                    cmd.ExecuteNonQuery();
                    return $"Квартира успешно удалена.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return $"Ошибка:  {e}";
            }
        }

        public IEnumerable<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street)
        {
            var result = new List<Flat>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("FIND_FLAT_BY_FILTERS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fl_num_min", flNumMin);
                cmd.Parameters.AddWithValue("@fl_num_max", flNumMax);
                cmd.Parameters.AddWithValue("@sq_min", sqMin);
                cmd.Parameters.AddWithValue("@sq_max", sqMax);
                cmd.Parameters.AddWithValue("@num_of_rms_min", numOfRmsMin);
                cmd.Parameters.AddWithValue("@num_of_rms_max", numOfRmsMax);
                cmd.Parameters.AddWithValue("@price_min", priceMin);
                cmd.Parameters.AddWithValue("@price_max", priceMax);
                cmd.Parameters.AddWithValue("@num_of_house_min", numOfHouseMin);
                cmd.Parameters.AddWithValue("@num_of_house_max", numOfHouseMax);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@street", street);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var f = new Flat()
                    {
                        IdFlat = (int) reader["id_flat"],
                        FlatNumber = (int) reader["flat_number"],
                        FloorNumber =(int) reader["floor_number"],
                        SquareOfFlat = (double) reader["square_of_flat"],
                        NumOfRooms = (int) reader["num_of_rooms"],
                        Price = (int) reader["price"],
                        Owner = (string) reader["owner_name"],
                        House = (int) reader["house_num"],
                        Street = (string) reader["street_name"],
                        City = (string) reader["city_name"],
                    };
                    result.Add(f);
                }
            }

            return result.AsEnumerable();
        }

        public string MakeContract(int idBuilding, int idRealtor, int idCustomer, string saleOrRent)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd;
                    if (saleOrRent == "Аренда")
                    {
                        cmd = new SqlCommand("RENT_BUILDING", connection);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELL_BUILDING", connection);
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_building", idBuilding);
                    cmd.Parameters.AddWithValue("@id_realtor", idRealtor);
                    cmd.Parameters.AddWithValue("@cottage_or_flat", "FLAT");
                    cmd.Parameters.AddWithValue("@id_customer", idCustomer);

                    cmd.ExecuteNonQuery();
                    return $"Контракт успешно заключен.";
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