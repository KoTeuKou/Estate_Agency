namespace Entities
{
    public class FlatFilter
    {
        public int MinFloorNumber { get; set; }

        public int MaxFloorNumber { get; set; }
        public int MinSquareOfFlat { get; set; }

        public int MaxSquareOfFlat { get; set; }


        public int MinNumOfRooms { get; set; }


        public int MaxNumOfRooms { get; set; }


        public int MinPrice { get; set; }


        public int MaxPrice { get; set; }


        public int NumOfHouse { get; set; }


        public string Street { get; set; }


        public string City { get; set; }

        public FlatFilter()
        {
        }

        public FlatFilter(int minFloorNumber, int maxFloorNumber, int minSquareOfFlat, int maxSquareOfFlat,
            int minNumOfRooms, int maxNumOfRooms, int minPrice, int maxPrice, int numOfHouse, string street,
            string city)
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