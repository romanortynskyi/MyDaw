using CommunityToolkit.Mvvm.Input;
using MyDaw.Services.Interfaces;

namespace MyDaw.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    [RelayCommand]
    async Task GoToAddProjectPage()
    {
        await NavigationService.NavigateToAsync("AddProjectPage", null);
    }
}
