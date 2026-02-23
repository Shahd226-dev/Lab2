using Lab2.Interfaces;
using Lab2.Models;

namespace Lab2.Services;

public class ProjectService : IProjectService
{
    private static readonly List<Project> projects = new()
    {
        new Project { Id = 1, Title = "Website Development", Budget = 50000 },
        new Project { Id = 2, Title = "Mobile Application", Budget = 75000 }
    };

    private static int nextId = 3;

    public IEnumerable<Project> GetAllProjects()
    {
        return projects;
    }

    public Project? GetProjectById(int id)
    {
        return projects.FirstOrDefault(p => p.Id == id);
    }

    public Project AddProject(Project project)
    {
        project.Id = nextId++;
        projects.Add(project);
        return project;
    }
}