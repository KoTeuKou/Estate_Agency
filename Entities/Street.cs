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
        public int IdStreet { get; set; }
        public int IdCity { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string StreetName { get; set; }
    }
}