using System;
using UsersApiProject.Models;
using UsersApiProject.Repositories;
namespace UsersApiProject.Services
{
    public interface ICustomersService
    {
        List<Customer> SearchCustomerList(string? searchString = null);
    }

    public class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        public List<Customer> SearchCustomerList(string? searchString = null)
        {
            var customers = _customersRepository.GetCustomerList(); 

            if (!string.IsNullOrEmpty(searchString))
            {
                customers = customers
                    .Where(e => e.FirstName.ToUpper().Contains(searchString.ToUpper())
                        || e.LastName.ToUpper().Contains(searchString.ToUpper())
                        || e.CustomerId.ToString().Contains(searchString)
                        || e.DisplayName.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return customers;
        }
    }
}




