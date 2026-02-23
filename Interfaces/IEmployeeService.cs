using Lab2.Models;

namespace Lab2.Interfaces;

public interface IEmployeeService
{
    IEnumerable<Employee> GetAllEmployees();
    Employee? GetEmployeeById(int id);
    Employee AddEmployee(Employee employee);
}