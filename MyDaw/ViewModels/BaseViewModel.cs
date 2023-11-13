using CommunityToolkit.Mvvm.ComponentModel;

using MyDaw.Services.Interfaces;

namespace MyDaw.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    protected INavigationService NavigationService;

    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }
}
