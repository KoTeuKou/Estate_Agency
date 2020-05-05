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
        public int IdHouse { get; set; }
        public int HouseNum { get; set; }
        public int NumOfFloors { get; set; }
        public int IdStreet { get; set; }
    }
}