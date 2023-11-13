using MyDaw.ViewModels;

namespace MyDaw.Pages;

public partial class AddProjectPage : ContentPage
{
    public AddProjectPage(AddProjectPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}