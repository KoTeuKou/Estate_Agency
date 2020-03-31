using System;
using System.ComponentModel.DataAnnotations;
using Entities;

namespace WebApp.Models
{
    public class AwardModel : Award
    {
        [RegularExpression("[\\d]+")] public int IdAward { get; set; }

        [Required] [RegularExpression("[\\D]+")] public string Tittle { get; set; }

        public AwardModel(int idAward, string tittle) : base(idAward, tittle)
        {
        }
    }
}