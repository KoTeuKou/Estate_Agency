
namespace Entities
{
    public class Flat
    {
        public Flat()
        {}

        public Flat(int idFlat, int floorNumber, int flatNumber, double squareOfFlat, int numOfRooms, int price, int house, string owner, string street, string city)
        {
            IdFlat = idFlat;
            FloorNumber = floorNumber;
            FlatNumber = flatNumber;
            SquareOfFlat = squareOfFlat;
            NumOfRooms = numOfRooms;
            Price = price;
            Owner = owner;
            House = house;
            Street = street;
            City = city;
        }
        
        public Flat(int idFlat, int flatNumber, int floorNumber, double squareOfFlat, int numOfRooms, int price, int idOwner, int idHouse)
        {
            IdFlat = idFlat;
            FlatNumber = flatNumber;
            FloorNumber = floorNumber;
            SquareOfFlat = squareOfFlat;
            NumOfRooms = numOfRooms;
            Price = price;
            IdOwner = idOwner;
            IdHouse = idHouse;
        }

        public Flat(int flatNumber, int floorNumber, double squareOfFlat, int numOfRooms, int price, int idOwner, int idHouse)
        {
            FlatNumber = flatNumber;
            FloorNumber = floorNumber;
            SquareOfFlat = squareOfFlat;
            NumOfRooms = numOfRooms;
            Price = price;
            IdOwner = idOwner;
            IdHouse = idHouse;
        }

        public int IdFlat { get; set; }

        public int FloorNumber { get; set; }

        public int FlatNumber { get; set; }

       public double SquareOfFlat { get; set; }

        public int NumOfRooms { get; set; }
        
        public int Price { get; set; }
        
        public int IdOwner { get; set; }
        
        public int IdHouse { get; set; }
        
        public string Owner { get; set; }
        
        public int House { get; set; }
        
        public string Street { get; set; }
        
        public string City { get; set; }
    }
}