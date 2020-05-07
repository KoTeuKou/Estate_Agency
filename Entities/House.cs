namespace Entities
{
    public class House
    {
        public House(){}

        public House(int idHouse, int houseNum, int numOfFloors, int idStreet)
        {
            IdHouse = idHouse;
            HouseNum = houseNum;
            NumOfFloors = numOfFloors;
            IdStreet = idStreet;
        }

        public House(int idHouse, int houseNum, int numOfFloors, int idStreet, string streetName, string cityName)
        {
            IdHouse = idHouse;
            HouseNum = houseNum;
            NumOfFloors = numOfFloors;
            IdStreet = idStreet;
            StreetName = streetName;
            CityName = cityName;
        }

        public House(int houseNum, int numOfFloors, int idStreet)
        {
            HouseNum = houseNum;
            NumOfFloors = numOfFloors;
            IdStreet = idStreet;
        }

        public int IdHouse { get; set; }
        public int HouseNum { get; set; }
        public int NumOfFloors { get; set; }
        public int IdStreet { get; set; }
        public string StreetName { get; set; }
        
        public string CityName { get; set; }
        
        

    }
}