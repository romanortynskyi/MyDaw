using MyDaw.Services.Interfaces;

namespace MyDaw.Services.Classes;

public class NavigationService : INavigationService
{
    public Task NavigateToAsync(string url, IDictionary<string, object> parameters)
    {
        if (parameters == null)
        {
            return Shell.Current.GoToAsync(url);
        }

        return Shell.Current.GoToAsync(url, parameters);
    }

    public Task GoBackAsync()
    {
        return Shell.Current.Navigation.PopAsync();
    }

}
