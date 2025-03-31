using Microsoft.Extensions.Logging;

namespace MauiAppMinhaCompras
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder(); // Cria o construtor do aplicativo MAUI.
            builder
                .UseMauiApp<App>() // Define a classe principal do aplicativo.
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); // Adiciona fonte personalizada.
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold"); // Outra fonte personalizada.
                });

#if DEBUG
            builder.Logging.AddDebug(); // Ativa logs de depuração apenas no modo DEBUG.
#endif

            return builder.Build(); // Retorna o aplicativo configurado.
        }
    }
}
