using System;
using System.ComponentModel.DataAnnotations;
namespace UsersApiProject.Models
{
    public class CreateEmployeeDto
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string LastName { get; set;  } = string.Empty;

        [Required]
        public EmployeeType Position { get; set; }

        [Required]
        public int EmployeeId { get; set; }
    }
}

