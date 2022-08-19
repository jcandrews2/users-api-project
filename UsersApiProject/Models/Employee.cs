using System;
namespace UsersApiProject.Models
{
    public class Employee : User
    {
        public EmployeeType Position { get; set; }

        public int EmployeeId { get; set; }

        public Employee(string firstName, string lastName, EmployeeType position, int employeeId)
            : base(firstName, lastName)
        {
            Position = position;
            EmployeeId = employeeId;
        }
    }
}

