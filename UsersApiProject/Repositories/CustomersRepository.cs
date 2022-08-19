using System;
using UsersApiProject.Models;
namespace UsersApiProject.Repositories;

public interface ICustomersRepository
{
    List<Customer> GetCustomerList();
}

public class CustomersRepository : ICustomersRepository
{
    public CustomersRepository ()
    {

    }
    public List<Customer> GetCustomerList()
    {
        var customer = new List<Customer>()
        {
            new Customer("Tristin", "Shaye", "Kansas City", 1),
            new Customer("Briar", "Stark", "Kansas City", 2),
            new Customer("Brooklyn", "Henson", "Kansas City", 3),
            new Customer("Favour", "Waller", "Kansas City", 4),
            new Customer("Jewell", "Wickham", "Kansas City", 5),
            new Customer("Sam", "Harvey", "Kansas City", 6),
            new Customer("Dannie", "Newell", "Kansas City", 7),
            new Customer("Royale", "Bridges", "Kansas City", 8),
        };
        return customer;
    }
}

