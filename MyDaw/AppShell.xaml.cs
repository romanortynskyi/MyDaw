using MyDaw.Pages;

namespace MyDaw
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(AddProjectPage), typeof(AddProjectPage));
        }
    }
}