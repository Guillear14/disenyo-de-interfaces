using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace PlantillaExamen
{
    public partial class App : Application
    {
        /* =========================================================================
         * OPCIÓN B (SI EL EXAMEN PIDE INYECCIÓN DE DEPENDENCIAS O EMPEZAR EN LOGIN):
         * 1. Quita StartupUri="MainWindow.xaml" de App.xaml
         * 2. Descomenta el código de abajo:
         * =========================================================================
        private IServiceProvider _serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainWindow>();
            services.AddTransient<Func<MainWindow>>(sp => () => sp.GetRequiredService<MainWindow>());
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
        */
    }
}
