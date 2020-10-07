using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class FlatModelVm
    {
        public int Id { get; set; }
        
        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public int FlatNumber { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public int FloorNumber { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public int SquareOfFlat { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public int NumOfRooms { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public int Price { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public string Owner { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public int House { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public string Street { get; set; }

        [Required]
        [RegularExpression("[\\d]+")]
        [DefaultValue("")]
        public string City { get; set; }


        public FlatModelVm()
        {
        }

        public FlatModelVm(int flatNumber, int floorNumber, int squareOfFlat, int numOfRooms, int price, string owner,
            int house, string street, string city)
        {
            FlatNumber = flatNumber;
            FloorNumber = floorNumber;
            SquareOfFlat = squareOfFlat;
            NumOfRooms = numOfRooms;
            Price = price;
            Owner = owner;
            House = house;
            Street = street;
            City = city;
        }
    }
}