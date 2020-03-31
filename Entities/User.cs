using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        public User()
        {}

        public User(int idUser, string surname, string name, string patronymic, string phoneNumber,DateTime dateOfBirth, List<Award> awards)
        {
            IdUser = idUser;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Awards = awards;

        }

        protected User(string surname, string name, string patronymic, string phoneNumber, DateTime dateOfBirth,  List<Award> awards)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Awards = awards;
        }

        public int IdUser { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid name length")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid surname length")]
        public string Surname { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid patronymic length")]
        public string Patronymic { get; set; }

        [RegularExpression(@"^\+[2-9]\d{3}\d{3}\d{4}$", ErrorMessage = "Number Format +xxxxxxxxxxx")]
        public String PhoneNumber { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        public List<Award> Awards { get; set; }
    }
}