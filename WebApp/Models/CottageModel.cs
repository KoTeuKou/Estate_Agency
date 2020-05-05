using System.ComponentModel.DataAnnotations;
using Entities;

namespace WebApp.Models
{
    public class CottageModel: Cottage
    {
        [RegularExpression("[\\d]+")] public int IdCottage { get; set; }
        
        [RegularExpression("[\\d]+")] public int CottageNumber { get; set; }
        
        [RegularExpression("[\\d]+")] public int NumOfFloors { get; set; }
        
        [RegularExpression("[\\d]+")] public double SquareOfCottage { get; set; }
        
        [RegularExpression("[\\d]+")] public int NumOfRooms { get; set; }
        
        [RegularExpression("[\\d]+")] public int Price { get; set; }
        
        [RegularExpression("[\\d]+")] public string Owner { get; set; }
        
        [RegularExpression("[\\d]+")] public string Street { get; set; }
        
        [RegularExpression("[\\d]+")] public string City { get; set; }


        public CottageModel(int idCottage, int cottageNumber, int numOfFloors, double squareOfCottage, int numOfRooms, int price, string owner, string street, string city)
        {
        }
    }
}