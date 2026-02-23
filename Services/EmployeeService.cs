using Lab2.Interfaces;
using Lab2.Models;

namespace Lab2.Services;

public class EmployeeService : IEmployeeService
{
    private static readonly List<Employee> employees = new()
    {
        new Employee { Id = 1, Name = "Mohamed", Department = 1 },
        new Employee { Id = 2, Name = "Shahd", Department = 2 }
    };

    private static int nextId = 3;

    public IEnumerable<Employee> GetAllEmployees()
    {
        return employees;
    }

    public Employee? GetEmployeeById(int id)
    {
        return employees.FirstOrDefault(e => e.Id == id);
    }

    public Employee AddEmployee(Employee employee)
    {
        employee.Id = nextId++;
        employees.Add(employee);
        return employee;
    }
}