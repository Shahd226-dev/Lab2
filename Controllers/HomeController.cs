using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(new
        {
            message = "Hello! Welcome to the Lab2 API",
            endpoints = new
            {
                employees = "Go to /employees to view all employees",
                projects = "Go to /projects to view all projects"
            }
        });
    }
}