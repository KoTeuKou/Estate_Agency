using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Realtor
    {
        public Realtor(){}

        public Realtor(int idRealtor, string realtorName, int numOfContracts)
        {
            IdRealtor = idRealtor;
            RealtorName = realtorName;
            NumOfContracts = numOfContracts;
        }
        public Realtor(string realtorName)
        {
            RealtorName = realtorName;
        }
        public int IdRealtor { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string RealtorName { get; set; }
        
        public int NumOfContracts { get; set; }
    }
}