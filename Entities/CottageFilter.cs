namespace Entities
{
    public class CottageFilter
    {
        public int MinFloorNumber { get; set; }

        public int MaxFloorNumber { get; set; }

        public int MinSquareOfFlat { get; set; }


        public int MaxSquareOfFlat { get; set; }


        public int MinNumOfRooms { get; set; }


        public int MaxNumOfRooms { get; set; }


        public int MinPrice { get; set; }


        public int MaxPrice { get; set; }


        public string Street { get; set; }


        public string City { get; set; }

        public CottageFilter()
        {
        }

        public CottageFilter(int minFloorNumber, int maxFloorNumber, int minSquareOfFlat,
            int maxSquareOfFlat,
            int minNumOfRooms, int maxNumOfRooms, int minPrice, int maxPrice, string street, string city)
        {
            MinFloorNumber = minFloorNumber;
            MaxFloorNumber = maxFloorNumber;
            MinSquareOfFlat = minSquareOfFlat;
            MaxSquareOfFlat = maxSquareOfFlat;
            MinNumOfRooms = minNumOfRooms;
            MaxNumOfRooms = maxNumOfRooms;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            Street = street;
            City = city;
        }
    }
}