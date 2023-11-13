using Microsoft.Extensions.Logging;

using MyDaw.Pages;
using MyDaw.Services.Classes;
using MyDaw.Services.Interfaces;
using MyDaw.ViewModels;

namespace MyDaw
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IDirectoryService, DirectoryService>();
            builder.Services.AddSingleton<IProjectService, ProjectService>();

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<AddProjectPageViewModel>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<AddProjectPage>();

        #if DEBUG
            builder.Logging.AddDebug();
        #endif

            return builder.Build();
        }
    }
}