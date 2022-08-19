using Microsoft.AspNetCore.Mvc;
using UsersApiProject.Services;
using UsersApiProject.Models;
using System.ComponentModel.DataAnnotations;

namespace UsersApiProject.Controllers
{
    [Route("/users/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public readonly IEmployeesService _employeeService;

        public EmployeesController(IEmployeesService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetEmployees(string? searchString = null)
        {
            var employees = _employeeService.SearchEmployeeList(searchString);

            if (employees != null && employees.Count > 0)
            {
                return Ok(employees);
            }

            return NotFound();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> CreateEmployees([FromBody, Required] CreateEmployeeDto createEmployeeDto)
        {
            var employees = _employeeService.AddEmployees(createEmployeeDto);

            if (employees != null && employees.Count > 0)
            {
                return Ok(employees);
            }

            return NotFound();
        }
    }
}


