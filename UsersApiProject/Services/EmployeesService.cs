using System;
using UsersApiProject.Models;
using UsersApiProject.Repositories;
namespace UsersApiProject.Services
{ 
    public interface IEmployeesService
    {
        List<Employee> SearchEmployeeList(string? searchString = null);
        List<Employee> AddEmployees(CreateEmployeeDto createEmployeeDto);
    }

    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public List<Employee> SearchEmployeeList(string? searchString = null)
        {
            var employees = _employeesRepository.GetEmployeeList();
            
            if (!string.IsNullOrEmpty(searchString))
            {
                employees = employees
                    .Where(e => e.FirstName.ToUpper().Contains(searchString.ToUpper())
                        || e.LastName.ToUpper().Contains(searchString.ToUpper())
                        || e.EmployeeId.ToString().Contains(searchString)
                        || e.DisplayName.ToUpper().Contains(searchString.ToUpper())).ToList();
            }

            return employees;
        }

        public List<Employee> AddEmployees(CreateEmployeeDto createEmployeeDto)
        {
            var employee = new Employee(createEmployeeDto.FirstName,
                createEmployeeDto.LastName,
                createEmployeeDto.Position,
                createEmployeeDto.EmployeeId);

            var employees = _employeesRepository.CreateEmployee(employee);

            return employees;
        }
    }       
}

