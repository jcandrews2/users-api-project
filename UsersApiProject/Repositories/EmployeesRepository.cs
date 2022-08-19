using System;
using UsersApiProject.Models;
namespace UsersApiProject.Repositories;

public interface IEmployeesRepository
{
    List<Employee> GetEmployeeList();
    List<Employee> CreateEmployee(Employee employee);
}

public class EmployeesRepository : IEmployeesRepository
{
    public EmployeesRepository()
    {
       
    }

    public List<Employee> GetEmployeeList()
    {
        var employees = new List<Employee>()
        {
            new Employee("Jimmy", "Andrews", EmployeeType.Intern, 1),
            new Employee("Katrina", "Potter", EmployeeType.Designer, 2),
            new Employee("Marc", "Barton", EmployeeType.Developer, 3),
            new Employee("Otis", "Williams", EmployeeType.Director, 4),
            new Employee("Levi", "Wong", EmployeeType.Tester, 5),
            new Employee("Stanley", "Larson", EmployeeType.Developer, 6),
            new Employee("Ricky", "Weber", EmployeeType.Developer, 7),
            new Employee("Jessica", "Matthews", EmployeeType.Developer, 8),
        };

        return employees;
    }

    public List<Employee> CreateEmployee(Employee employee)
    {
        var employees = GetEmployeeList();
        employees.Add(employee);

        return employees;
    }
}

