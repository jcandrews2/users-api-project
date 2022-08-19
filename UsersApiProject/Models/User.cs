using System;
using System.ComponentModel.DataAnnotations;
namespace UsersApiProject.Models
{
    public class User
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        public string DisplayName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public User() { }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

