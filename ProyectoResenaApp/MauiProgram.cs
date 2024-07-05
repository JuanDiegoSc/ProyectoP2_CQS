using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ProyectoResenaApp
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
                })
                .UseMauiCommunityToolkit();

            //builder.Services.AddHttpClient("apiCategoria", HttpClient => HttpClient.BaseAddress = new Uri("https://localhost:7118/api/Categoria"));
            //builder.Services.AddHttpClient("apiJuego", HttpClient => HttpClient.BaseAddress = new Uri("https://localhost:7118/api/Juego"));
            //builder.Services.AddHttpClient("apiResena", HttpClient => HttpClient.BaseAddress = new Uri("https://localhost:7118/api/Resena"));
#if DEBU
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
