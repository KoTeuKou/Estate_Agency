using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class CottageModel
    {
     
        [RegularExpression("[\\d]+")] [DefaultValue("")] public int CottageNumber { get; set; }
        
        [RegularExpression("[\\d]+")] [DefaultValue("")] public int NumOfFloors { get; set; }
       
        [RegularExpression("[\\d]+")] [DefaultValue("")] public double SquareOfCottage { get; set; }
       
        [RegularExpression("[\\d]+")] [DefaultValue("")] public int NumOfRooms { get; set; }
      
        [RegularExpression("[\\d]+")] [DefaultValue("")] public int Price { get; set; }
     
        [RegularExpression("[\\d]+")] [DefaultValue("")] public string Owner { get; set; }
     
        [RegularExpression("[\\d]+")] [DefaultValue("")] public string Street { get; set; }
      
        [RegularExpression("[\\d]+")] [DefaultValue("")] public string City { get; set; }


        public CottageModel()
        {
        }

        public CottageModel(int cottageNumber, int numOfFloors, double squareOfCottage, int numOfRooms, int price, string owner, string street, string city)
        {
          CottageNumber = cottageNumber;
            NumOfFloors = numOfFloors;
            SquareOfCottage = squareOfCottage;
            NumOfRooms = numOfRooms;
            Price = price;
            Owner = owner;
            Street = street;
            City = city;
        }
    }
}