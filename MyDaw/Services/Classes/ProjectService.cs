﻿using MyDaw.Models;
using MyDaw.Services.Interfaces;
using Newtonsoft.Json;

namespace MyDaw.Services.Classes;

public class ProjectService : IProjectService
{
    private IDirectoryService _directoryService;

    public ProjectService(IDirectoryService directoryService)
    {
        _directoryService = directoryService;
    }

    private string GetProjectsPath()
    {
        return "D:/MyDaw Projects";
    }

    private string GetProjectPath(ProjectModel project)
    {
        string projectsPath = GetProjectsPath();
        string projectPath = Path.Combine(projectsPath, project.Name);

        return projectPath;
    }

    public ProjectModel AddProject(ProjectModel project)
    {
        string projectPath = GetProjectPath(project);

        _directoryService.EnsureDirectoryExists(projectPath);

        string filePath = Path.Combine(projectPath, $"{project.Name}.json");

        ProjectModel newProject = new(project)
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        string json = JsonConvert.SerializeObject(newProject, Formatting.None);
        File.WriteAllText(filePath, json);

        return newProject;
    }
}
