using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using proyectoDefinitivo.Vista.Dialogo;

namespace proyectoDefinitivo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<PantallaLogin>();
            services.AddTransient<MainWindow>();
            services.AddTransient<Func<PantallaLogin>>(serviceProvider =>
                () => serviceProvider.GetRequiredService<PantallaLogin>());
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            PantallaLogin login = _serviceProvider.GetRequiredService<PantallaLogin>();
            MainWindow = login;
            ShutdownMode = ShutdownMode.OnMainWindowClose;
            login.Show();
        }
    }

}
