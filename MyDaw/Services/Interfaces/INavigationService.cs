namespace MyDaw.Services.Interfaces;

public interface INavigationService
{
    Task NavigateToAsync(string url, IDictionary<string, object> parameters);
    Task GoBackAsync();
}
