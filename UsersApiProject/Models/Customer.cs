using System;
using System.ComponentModel.DataAnnotations;
namespace UsersApiProject.Models
{
    public class Customer : User
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer(string firstName, string lastName, string location, int customerId)
            : base(firstName, lastName)
        {
            Location = location;
            CustomerId = customerId;
        }
    }
}

