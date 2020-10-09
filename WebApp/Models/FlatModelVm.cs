namespace WebApp.Models
{
    public class FlatModelVm
    {
        public int Id { get; set; }
        public int FlatNumber { get; set; }
        public int FloorNumber { get; set; }
        public int SquareOfFlat { get; set; }
        public int NumOfRooms { get; set; }
        public int Price { get; set; }
        public int IdOwner { get; set; }
        public int House { get; set; }
        public int IdHouse { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public FlatModelVm()
        {
        }

        public FlatModelVm(int flatNumber, int floorNumber, int squareOfFlat, int numOfRooms, int price, int idOwner,
            int house, string street, string city)
        {
            FlatNumber = flatNumber;
            FloorNumber = floorNumber;
            SquareOfFlat = squareOfFlat;
            NumOfRooms = numOfRooms;
            Price = price;
            IdOwner = idOwner;
            House = house;
            Street = street;
            City = city;
        }
    }
}