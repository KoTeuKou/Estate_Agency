namespace WebApp.Models
{
    public class CityVm
    {
        public CityVm(){}

        public CityVm(int idCity, string cityName)
        {
            IdCity = idCity;
            CityName = cityName;
        }
        
        public int IdCity { get; set; }
        public string CityName { get; set; }
    }
}