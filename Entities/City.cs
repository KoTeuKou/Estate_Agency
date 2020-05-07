using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class City
    {
        public City(){}

        public City(int idCity, string cityName)
        {
            IdCity = idCity;
            CityName = cityName;
        }

        public City(string cityName)
        {
            CityName = cityName;
        }

        public int IdCity { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string CityName { get; set; }
    }
}