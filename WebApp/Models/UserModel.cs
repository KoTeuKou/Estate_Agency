using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities;

namespace WebApp.Models
{
    public class UserModel: User
    {
        [RegularExpression("[\\d]+")] public int IdUser { get; set; }

        [Required] [RegularExpression("[\\D]+")] public string Surname { get; set; }

        [Required] [RegularExpression("[\\D]+")] public string Name { get; set; }
        
        [Required] [RegularExpression("[\\D]+")] public string Patronymic { get; set; }
        
        [Required] [RegularExpression("[\\d]+")] public string PhoneNumber { get; set; }

        [Required]
        public List<Award> Awards{ get; set;}
        
        [Required] public DateTime DateOfBirth { get; set; }

        public UserModel(int idUser, string surname, string name, string patronymic, string phoneNumber, DateTime dateOfBirth, List<Award> awards) : 
            base(idUser, surname, name, patronymic, phoneNumber, dateOfBirth, awards)
        {}
        public UserModel(string surname, string name, string patronymic, string phoneNumber, DateTime dateOfBirth, List<Award> awards) : 
            base(surname, name, patronymic, phoneNumber, dateOfBirth, awards)
        {}


    }
}