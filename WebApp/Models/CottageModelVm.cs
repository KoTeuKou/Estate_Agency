namespace WebApp.Models
{
    public class CottageModelVm
    {
        public int Id { get; set; }
        public int CottageNumber { get; set; }
        public int NumOfFloors { get; set; }
        public double SquareOfCottage { get; set; }
        public int NumOfRooms { get; set; }
        public int Price { get; set; }
        public int IdOwner { get; set; }
        public int IdStreet { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        
        public CottageModelVm()
        {
        }

        public CottageModelVm(int cottageNumber, int numOfFloors, double squareOfCottage, int numOfRooms, int price, int idOwner, int idStreet, string city)
        {
          CottageNumber = cottageNumber;
            NumOfFloors = numOfFloors;
            SquareOfCottage = squareOfCottage;
            NumOfRooms = numOfRooms;
            Price = price;
            IdOwner = idOwner;
            IdStreet = idStreet;
            City = city;
        }
    }
}