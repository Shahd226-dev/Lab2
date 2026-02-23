using Microsoft.AspNetCore.Mvc;
using Lab2.Interfaces;
using Lab2.Models;

namespace Lab2.Controllers;

[Route("employees")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }

    // GET /employees
    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        var employees = employeeService.GetAllEmployees();
        return Ok(employees);
    }

    // GET /employees/5
    [HttpGet("{id}")]
    public IActionResult GetEmployeeById(int id)
    {
        var employee = employeeService.GetEmployeeById(id);
        if (employee == null) return NotFound();
        return Ok(employee);
    }

    // POST /employees
    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        var created = employeeService.AddEmployee(employee);
        return Ok(created);
    }
}