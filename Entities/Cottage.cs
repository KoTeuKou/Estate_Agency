namespace Entities
{
    public class Cottage
    {
        public Cottage()
        {}

        public Cottage(int idCottage, int cottageNumber, int numOfFloors, double squareOfCottage, int numOfRooms, int price, int idOwner, int idStreet)
        {
            IdCottage = idCottage;
            CottageNumber = cottageNumber;
            SquareOfCottage = squareOfCottage;
            NumOfFloors = numOfFloors;
            NumOfRooms = numOfRooms;
            Price = price;
            IdOwner = idOwner;
            IdStreet = idStreet;
        }
        
        public Cottage(int cottageNumber, int numOfFloors, double squareOfCottage, int numOfRooms, int price, int idOwner, int idStreet)
        {
            CottageNumber = cottageNumber;
            SquareOfCottage = squareOfCottage;
            NumOfFloors = numOfFloors;
            NumOfRooms = numOfRooms;
            Price = price;
            IdOwner = idOwner;
            IdStreet = idStreet;
        }
        
        public Cottage(int cottageNumber, int numOfFloors, double squareOfCottage, int numOfRooms, int price)
        {
            CottageNumber = cottageNumber;
            SquareOfCottage = squareOfCottage;
            NumOfFloors = numOfFloors;
            NumOfRooms = numOfRooms;
            Price = price;
        }

        public Cottage(int idCottage, int numOfFloors, int cottageNumber, double squareOfCottage, int numOfRooms, int price, string owner, string street, string city)
        {
            IdCottage = idCottage;
            NumOfFloors = numOfFloors;
            CottageNumber = cottageNumber;
            SquareOfCottage = squareOfCottage;
            NumOfRooms = numOfRooms;
            Price = price;
            Owner = owner;
            Street = street;
            City = city;
        }

        public int IdCottage { get; set; }

        public int NumOfFloors { get; set; }

        public int CottageNumber { get; set; }

        public double SquareOfCottage { get; set; }

        public int NumOfRooms { get; set; }
        
        public int Price { get; set; }
        
        public int IdOwner { get; set; }
        
        public int IdStreet { get; set; }
        
        public string Owner { get; set; }

        public string Street { get; set; }
        
        public string City { get; set; }
    }
}