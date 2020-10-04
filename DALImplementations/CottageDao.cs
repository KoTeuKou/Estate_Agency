﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DALInterfaces;
using Entities;
using System.Configuration;

namespace DALImplementations
{
    public class CottageDao : ICottageDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["EstateAgency"].ConnectionString;

        public IEnumerable<Cottage> GetAll()
        {
            var result = new List<Cottage>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GET_ALL_COTTAGES", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var cottageFromDb = new Cottage()
                    {
                        IdCottage = (int) reader["id_cottage"],
                        CottageNumber = (int) reader["cottage_number"],
                        SquareOfCottage = (double) reader["square_of_cottage"],
                        NumOfFloors = (int) reader["num_of_floors"],
                        NumOfRooms = (int) reader["num_of_rooms"],
                        Price = (int) reader["price"],
                        Owner = (string) reader["owner_name"],
                        Street = (string) reader["street_name"],
                        City = (string) reader["city_name"],
                    };
                    result.Add(cottageFromDb);
                }
            }
            return result.AsEnumerable();
        }

        public Cottage Create(Cottage cottage)
        {
             using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand("ADD_COTTAGE", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cottage_number", cottage.CottageNumber);
                    cmd.Parameters.AddWithValue("@num_of_floors", cottage.NumOfFloors);
                    cmd.Parameters.AddWithValue("@square_of_cottage", cottage.SquareOfCottage);
                    cmd.Parameters.AddWithValue("@num_of_rooms", cottage.NumOfRooms);
                    cmd.Parameters.AddWithValue("@price", cottage.Price);
                    cmd.Parameters.AddWithValue("@id_owner", cottage.IdOwner);
                    cmd.Parameters.AddWithValue("@id_street", cottage.IdStreet);
                    
                    var reader = cmd.ExecuteReader();
                    Cottage cottageFromDb = null;
                    if (reader.Read())
                    {
                        cottageFromDb = new Cottage()
                        {
                            IdCottage = (int) reader["id_cottage"],
                            CottageNumber = (int) reader["cottage_number"],
                            SquareOfCottage = (double) reader["square_of_cottage"],
                            NumOfFloors = (int) reader["num_of_floors"],
                            NumOfRooms = (int) reader["num_of_rooms"],
                            Price = (int) reader["price"],
                            Owner = (string) reader["owner_name"],
                            Street = (string) reader["street_name"],
                            City = (string) reader["city_name"],
                        };
                    }
                    return cottageFromDb;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public bool Delete(int idCottage)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    const string sql = "DELETE * FROM Cottage WHERE id_cottage = @id";
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idCottage);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
         public IEnumerable<Cottage> GetCottagesByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax,
            string city, string street)
        {
            var result = new List<Cottage>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("FIND_COTTAGE_BY_FILTERS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_of_floors_min", flNumMin);
                cmd.Parameters.AddWithValue("@num_of_floors_max", flNumMax);
                cmd.Parameters.AddWithValue("@sq_min", sqMin);
                cmd.Parameters.AddWithValue("@sq_max", sqMax);
                cmd.Parameters.AddWithValue("@num_of_rms_min", numOfRmsMin);
                cmd.Parameters.AddWithValue("@num_of_rms_max", numOfRmsMax);
                cmd.Parameters.AddWithValue("@price_min", priceMin);
                cmd.Parameters.AddWithValue("@price_max", priceMax);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@street", street);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var cottageFromDb = new Cottage()
                    {
                        IdCottage = (int) reader["id_cottage"],
                        CottageNumber = (int) reader["cottage_number"],
                        SquareOfCottage = (double) reader["square_of_cottage"],
                        NumOfFloors = (int) reader["num_of_floors"],
                        NumOfRooms = (int) reader["num_of_rooms"],
                        Price = (int) reader["price"],
                        Owner = (string) reader["owner_name"],
                        Street = (string) reader["street_name"],
                        City = (string) reader["city_name"],
                    };
                    result.Add(cottageFromDb);
                }
            }

            return result.AsEnumerable();
        }
         
    }
}