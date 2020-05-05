using System.ComponentModel.DataAnnotations;
using Entities;

namespace WebApp.Models
{
    public class FlatModel: Flat
    {
        [RegularExpression("[\\d]+")] public int IdFlat { get; set; }
        
        [RegularExpression("[\\d]+")] public int FlatNumber { get; set; }
        
        [RegularExpression("[\\d]+")] public int FloorNumber { get; set; }
        
        [RegularExpression("[\\d]+")] public double SquareOfFlat { get; set; }
        
        [RegularExpression("[\\d]+")] public int NumOfRooms { get; set; }
        
        [RegularExpression("[\\d]+")] public int Price { get; set; }
        
        [RegularExpression("[\\d]+")] public string Owner { get; set; }
        
        [RegularExpression("[\\d]+")] public int House { get; set; }
        
        [RegularExpression("[\\d]+")] public string Street { get; set; }
        
        [RegularExpression("[\\d]+")] public string City { get; set; }
        

        public FlatModel(int idFlat, int flatNumber, int floorNumber, int squareOfFlat, int numOfRooms, int price, string owner, int house, string street, string city)
        {}

    }
}