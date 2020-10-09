namespace WebApp.Models
{
    public class CottageFilterVm
    {
        public int MinFloorNumber { get; set; } = 1;

        public int MaxFloorNumber { get; set; } = 1000;

        public double MinSquareOfCottage { get; set; } = 1;

        public double MaxSquareOfCottage { get; set; } = 1000;

        public int MinNumOfRooms { get; set; } = 1;

        public int MaxNumOfRooms { get; set; } = 100;

        public int MinPrice { get; set; } = 10000;

        public int MaxPrice { get; set; } = 1000000000;

        public string Street { get; set; } = "";

        public string City { get; set; } = "";

        public CottageFilterVm()
        {
        }

        public CottageFilterVm(int minFloorNumber, int maxFloorNumber, int minSquareOfCottage, int maxSquareOfCottage,
            int minNumOfRooms, int maxNumOfRooms, int minPrice, int maxPrice, string street, string city)
        {
            MinFloorNumber = minFloorNumber;
            MaxFloorNumber = maxFloorNumber;
            MinSquareOfCottage = minSquareOfCottage;
            MaxSquareOfCottage = maxSquareOfCottage;
            MinNumOfRooms = minNumOfRooms;
            MaxNumOfRooms = maxNumOfRooms;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            Street = street;
            City = city;
        }
    }
}