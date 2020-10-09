using System.ComponentModel;

namespace WebApp.Models
{
    public class FlatFilterVm
    {
        public int MinFloorNumber { get; set; } = 1;
        public int MaxFloorNumber { get; set; } = 1000;
        public int MinSquareOfFlat { get; set; } = 1;
        public int MaxSquareOfFlat { get; set; } = 100;
        public int MinNumOfRooms { get; set; } = 1;
        public int MaxNumOfRooms { get; set; } = 10;
        public int MinPrice { get; set; } = 1000000;
        public int MaxPrice { get; set; } = 1000000000;
        public int NumOfHouse { get; set; } = 10000;
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public FlatFilterVm()
        {
        }
        public FlatFilterVm(int minFloorNumber, int maxFloorNumber, int minSquareOfFlat, int maxSquareOfFlat,
            int minNumOfRooms, int maxNumOfRooms, int minPrice, int maxPrice, int numOfHouse, string street, string city)
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