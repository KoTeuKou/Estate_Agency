using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Owner
    {
        public Owner(){}

        public Owner(int idOwner, string ownerName)
        {
            IdOwner = idOwner;
            OwnerName = ownerName;
        }
        public int IdOwner { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string OwnerName { get; set; }
    }
}