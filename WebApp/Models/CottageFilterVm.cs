using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class CottageFilterVm
    {
        [RegularExpression("[\\d]+")] 
        [DefaultValue("1")] 
        public string MinFloorNumber { get; set; }
        
        [RegularExpression("[\\d]+")] 
        [DefaultValue("1000")] 
        public string MaxFloorNumber { get; set; }
        
        [RegularExpression("[\\d]+")]
        [DefaultValue("1")]
        public string MinSquareOfCottage { get; set; }
        
        [RegularExpression("[\\d]+")] 
        [DefaultValue("100")] 
        public string MaxSquareOfCottage { get; set; }
        
        [RegularExpression("[\\d]+")]
        [DefaultValue("1")]
        public string MinNumOfRooms { get; set; }
        
        [RegularExpression("[\\d]+")]
        [DefaultValue("10")] 
        public string MaxNumOfRooms { get; set; }
        
        [RegularExpression("[\\d]+")] 
        [DefaultValue("100000")]
        public string MinPrice { get; set; }
        
        [RegularExpression("[\\d]+")] 
        [DefaultValue("1000000000")] 
        public string MaxPrice { get; set; }
        
        [RegularExpression("[\\d]+")]
        [DefaultValue("")] 
        public string Street { get; set; }
        
        [RegularExpression("[\\d]+")] 
        [DefaultValue("")]
        public string City { get; set; }

        public CottageFilterVm()
        {
        }

        public CottageFilterVm(string minFloorNumber, string maxFloorNumber, string minSquareOfCottage, string maxSquareOfCottage,
            string minNumOfRooms, string maxNumOfRooms, string minPrice, string maxPrice, string street, string city)
        {
            MinFloorNumber = minFloorNumber;
            MaxFloorNumber = maxFloorNumber;
            MinSquareOfCottage = minSquareOfCottage;
            MaxSquareOfCottage = maxSquareOfCottage;
            MinNumOfRooms = minNumOfRooms;
            MaxNumOfRooms = maxNumOfRooms;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            Street = street;
            City = city;
        }
    }
}