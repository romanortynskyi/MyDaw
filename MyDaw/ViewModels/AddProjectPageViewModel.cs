using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyDaw.Models;
using MyDaw.Services.Interfaces;

namespace MyDaw.ViewModels;

public partial class AddProjectPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ProjectModel _project;

    private IProjectService _projectService;
    private INavigationService _navigationService;

    public AddProjectPageViewModel(
        INavigationService navigationService,
        IProjectService projectService
    ) : base(navigationService)
    {
        _projectService = projectService;
        _navigationService = navigationService;

        _project = new ProjectModel
        {
            Name = "",
            Location = Consts.GetDefaultProjectsDirectoryPath(),
            DefaultTempo = Consts.DefaultTempo,
            DefaultMeterUpper = Consts.DefaultMeterUpper,
            DefaultMeterLower = Consts.DefaultMeterLower,
            BitDepth = Consts.DefaultBitDepth,
            SampleRate = Consts.DefaultSampleRate,
        };
    }

    [RelayCommand]
    void AddProject()
    {
        ProjectModel newProject = _projectService.AddProject(Project);
    }

    [RelayCommand]
    void GoBack()
    {
        _navigationService.GoBackAsync();
    }

    [RelayCommand]
    async void SelectLocation()
    {
        CancellationTokenSource source = new();
        CancellationToken token = source.Token;

        var result = await FolderPicker.Default.PickAsync(token);

        if (result.IsSuccessful)
        {
            Project.Location = result.Folder.Path;
        }
    }
}
