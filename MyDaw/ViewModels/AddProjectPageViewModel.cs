using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyDaw.Models;
using MyDaw.Services.Interfaces;

namespace MyDaw.ViewModels;

public partial class AddProjectPageViewModel : BaseViewModel
{
    private IProjectService _projectService;

    [ObservableProperty]
    private Project _project = new();

    public AddProjectPageViewModel(
        INavigationService navigationService,
        IProjectService projectService
    ) : base(navigationService)
    {
        _projectService = projectService;
    }

    [RelayCommand]
    void AddProject()
    {
        Project newProject = _projectService.AddProject(Project);
    }
}
