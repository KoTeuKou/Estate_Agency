using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class FlatModel
    {
      [RegularExpression("[\\d]+")] [DefaultValue("")]  public int FlatNumber { get; set; }
        
        [RegularExpression("[\\d]+")]  [DefaultValue("")] public int FloorNumber { get; set; }
        
        [RegularExpression("[\\d]+")]  [DefaultValue("")] public int SquareOfFlat { get; set; }
        
        [RegularExpression("[\\d]+")]  [DefaultValue("")] public int NumOfRooms { get; set; }
        
        [RegularExpression("[\\d]+")]  [DefaultValue("")] public int Price { get; set; }
        
        [RegularExpression("[\\d]+")] [DefaultValue("")]  public string Owner { get; set; }
        
        [RegularExpression("[\\d]+")]  [DefaultValue("")] public int House { get; set; }
        
        [RegularExpression("[\\d]+")] [DefaultValue("")]  public string Street { get; set; }
        
        [RegularExpression("[\\d]+")]  [DefaultValue("")] public string City { get; set; }
        
        public FlatModel()
        {
        }
        public FlatModel(int flatNumber, int floorNumber, int squareOfFlat, int numOfRooms, int price, string owner, int house, string street, string city)
        {
            FlatNumber = flatNumber;
            FloorNumber = floorNumber;
            SquareOfFlat = squareOfFlat;
            NumOfRooms = numOfRooms;
            Price = price;
            Owner = owner;
            House = house;
            Street = street;
            City = city;
        }
    }
}