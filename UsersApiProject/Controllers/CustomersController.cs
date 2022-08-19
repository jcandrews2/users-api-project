using Microsoft.AspNetCore.Mvc;
using UsersApiProject.Services;
using UsersApiProject.Models;
namespace UsersApiProject.Controllers
{
    [Route("/users/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public readonly ICustomersService _customerService;

        public CustomersController(ICustomersService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers(string? searchString = null)
        {
            var customers = _customerService.SearchCustomerList(searchString);

            if (customers != null && customers.Count > 0)
            {
                return Ok(customers);
            }

            return NotFound();
        }
    }
}


