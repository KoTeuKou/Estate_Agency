using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Award
    {
        public Award(){}

        public Award(int? idAward, string tittle)
        {
            IdAward = idAward;
            Tittle = tittle;
        }
        public int? IdAward { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid tittle length")]
        public string Tittle { get; set; }
    }
}