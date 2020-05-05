using System.ComponentModel.DataAnnotations;
using Entities;

namespace WebApp.Models
{
    public class RealtorModel : Realtor
    {
        [RegularExpression("[\\d]+")] public int IdRealtor { get; set; }
        
        [RegularExpression("[\\d]+")] public string RealtorName { get; set; }
        
        [RegularExpression("[\\d]+")] public string NumOfContracts { get; set; }

        public RealtorModel(int idRealtor, string realtorName, int numOfContracts) : base(idRealtor, realtorName, numOfContracts)
        {
        }
    }
}