using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Street
    {
        public Street(){}

        public Street(int idStreet, string sName, int idCity)
        {
            IdStreet = idStreet;
            StreetName = sName;
            IdCity = idCity;
        }

        public Street(int idStreet, string streetName, string cityName)
        {
            IdStreet = idStreet;
            StreetName = streetName;
            CityName = cityName;
        }

        public Street(int idCity, string streetName)
        {
            IdCity = idCity;
            StreetName = streetName;
        }

        public int IdStreet { get; set; }
        public int IdCity { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string StreetName { get; set; }
        
        public string CityName { get; set; }
    }
}