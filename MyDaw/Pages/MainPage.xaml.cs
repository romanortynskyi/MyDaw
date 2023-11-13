using MyDaw.ViewModels;

namespace MyDaw.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
