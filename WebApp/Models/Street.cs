using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class StreetVm
    {
        public StreetVm(){}
        
        public StreetVm(int idStreet, string streetName, string cityName)
        {
            IdStreet = idStreet;
            StreetName = streetName;
            CityName = cityName;
        }

        public int IdStreet { get; set; }
        public int IdCity { get; set; }
        public string StreetName { get; set; }
        
        public string CityName { get; set; }
    }
}