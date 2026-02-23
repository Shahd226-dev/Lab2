using Lab2.Models;

namespace Lab2.Interfaces;

public interface IProjectService
{
    IEnumerable<Project> GetAllProjects();
    Project? GetProjectById(int id);
    Project AddProject(Project project);
}
