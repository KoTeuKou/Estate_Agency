using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class FlatFilter
    {
        [RegularExpression("[\\d]+")] [DefaultValue("1")] public string MinFloorNumber { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("1000")] public string MaxFloorNumber { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("1")] public string MinSquareOfFlat { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("100")] public string MaxSquareOfFlat { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("1")] public string MinNumOfRooms { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("10")] public string MaxNumOfRooms { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("100000")] public string MinPrice { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("1000000000")] public string MaxPrice { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("1000")] public string NumOfHouse { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("")] public string Street { get; set; }
        [RegularExpression("[\\d]+")] [DefaultValue("")] public string City { get; set; }

        public FlatFilter()
        {
        }

        public FlatFilter(string minFloorNumber, string maxFloorNumber, string minSquareOfFlat, string maxSquareOfFlat,
            string minNumOfRooms, string maxNumOfRooms, string minPrice, string maxPrice, string numOfHouse, string street, string city)
        {
            MinFloorNumber = minFloorNumber;
            MaxFloorNumber = maxFloorNumber;
            MinSquareOfFlat = minSquareOfFlat;
            MaxSquareOfFlat = maxSquareOfFlat;
            MinNumOfRooms = minNumOfRooms;
            MaxNumOfRooms = maxNumOfRooms;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            NumOfHouse = numOfHouse;
            Street = street;
            City = city;
        }
    }
}