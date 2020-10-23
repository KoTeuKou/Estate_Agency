using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DALInterfaces;
using Entities;

namespace DALImplementations
{
    public class CottageDao : BaseDao, ICottageDao
    {

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
            return result;
        }

        public Cottage Create(Cottage cottage)
        {
             using (var connection = new SqlConnection(_connectionString))
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
        }

        public bool Delete(int idCottage)
        {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var cmd = new SqlCommand("DELETE_COTTAGE", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idCottage);
                    var executeNonQuery = cmd.ExecuteNonQuery();
                    return true;
                }
           
        }
         public IEnumerable<Cottage> GetCottagesByFilters(CottageFilter filter)
        {
            var result = new List<Cottage>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("FIND_COTTAGE_BY_FILTERS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_of_floors_min", filter.MinFloorNumber);
                cmd.Parameters.AddWithValue("@num_of_floors_max", filter.MaxFloorNumber);
                cmd.Parameters.AddWithValue("@sq_min", filter.MinSquareOfFlat);
                cmd.Parameters.AddWithValue("@sq_max", filter.MaxSquareOfFlat);
                cmd.Parameters.AddWithValue("@num_of_rms_min", filter.MinNumOfRooms);
                cmd.Parameters.AddWithValue("@num_of_rms_max", filter.MaxNumOfRooms);
                cmd.Parameters.AddWithValue("@price_min", filter.MinPrice);
                cmd.Parameters.AddWithValue("@price_max", filter.MaxPrice);
                cmd.Parameters.AddWithValue("@city", filter.City);
                cmd.Parameters.AddWithValue("@street", filter.Street);
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

            return result;
        }
         
    }
}