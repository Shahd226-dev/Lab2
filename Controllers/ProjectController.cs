using Microsoft.AspNetCore.Mvc;
using Lab2.Interfaces;
using Lab2.Models;

namespace Lab2.Controllers;

[Route("projects")]
[ApiController]
public class ProjectController : ControllerBase
{
    private readonly IProjectService projectService;

    public ProjectController(IProjectService projectService)
    {
        this.projectService = projectService;
    }

    // GET /projects
    [HttpGet]
    public IActionResult GetAllProjects()
    {
        var projects = projectService.GetAllProjects();
        return Ok(projects);
    }

    // GET /projects/5
    [HttpGet("{id}")]
    public IActionResult GetProjectById(int id)
    {
        var project = projectService.GetProjectById(id);
        if (project == null) return NotFound();
        return Ok(project);
    }

    // POST /projects
    [HttpPost]
    public IActionResult AddProject([FromBody] Project project)
    {
        var created = projectService.AddProject(project);
        return Ok(created);
    }
}