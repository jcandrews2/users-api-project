using System;
using UsersApiProject.Repositories;
using UsersApiProject.Models;
namespace UsersApiProject.Services
{
    public interface IUsersService
    {
        List<User> AllUsers(string? searchString = null);
    }

    public class UsersService : IUsersService
    {
        private readonly IEmployeesRepository _employeeRepository;
        private readonly ICustomersRepository _customersRepository;

        public UsersService(IEmployeesRepository employeeRepository, ICustomersRepository customersRepository)
        {
            _employeeRepository = employeeRepository;
            _customersRepository = customersRepository;
        }

        public List<User> AllUsers(string? searchString = null)
        {
            var users = new List<User>();
            users.AddRange(_employeeRepository.GetEmployeeList());
            users.AddRange(_customersRepository.GetCustomerList());

            if (!string.IsNullOrEmpty(searchString))
            {
                users = users
                .Where(e => e.FirstName.ToUpper().Contains(searchString.ToUpper())
                        || e.LastName.ToUpper().Contains(searchString.ToUpper())
                        || e.DisplayName.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return users;
        }
    }
}
