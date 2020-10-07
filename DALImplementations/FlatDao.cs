using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DALInterfaces;
using Entities;

namespace DALImplementations 
{
    public class FlatDao : IFlatDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["EstateAgency"].ConnectionString;

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
                    var flatFromDb = new Flat()
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
                    result.Add(flatFromDb);
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
                    Flat flatFromDb = null;
                    if (reader.Read())
                    {
                        flatFromDb = new Flat()
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
                    return flatFromDb;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public bool Delete(int idFlat)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var cmd = new SqlCommand("DELETE_FLAT", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idFlat);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Flat> GetFlatsByFilters(FlatFilter filter)
        {
            var result = new List<Flat>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("FIND_FLAT_BY_FILTERS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fl_num_min", filter.MinFloorNumber);
                cmd.Parameters.AddWithValue("@fl_num_max", filter.MaxFloorNumber);
                cmd.Parameters.AddWithValue("@sq_min", filter.MinSquareOfFlat);
                cmd.Parameters.AddWithValue("@sq_max", filter.MaxSquareOfFlat);
                cmd.Parameters.AddWithValue("@num_of_rms_min", filter.MinNumOfRooms);
                cmd.Parameters.AddWithValue("@num_of_rms_max", filter.MaxNumOfRooms);
                cmd.Parameters.AddWithValue("@price_min", filter.MinPrice);
                cmd.Parameters.AddWithValue("@price_max", filter.MaxPrice);
                cmd.Parameters.AddWithValue("@num_of_house_min", filter.NumOfHouse);
                cmd.Parameters.AddWithValue("@num_of_house_max", filter.NumOfHouse);
                cmd.Parameters.AddWithValue("@city", filter.City);
                cmd.Parameters.AddWithValue("@street", filter.Street);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var flatFromDb = new Flat()
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
                    result.Add(flatFromDb);
                }
            }

            return result.AsEnumerable();
        }
    }
}