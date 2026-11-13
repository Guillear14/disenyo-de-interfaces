using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using proyectoDefinitivo.Vista.Dialogo;

namespace proyectoDefinitivo
{
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
            services.AddTransient<registro>();
            services.AddTransient<olvidarContraseña>();
            services.AddTransient<MainWindow>();

            services.AddTransient<Func<PantallaLogin>>(sp => () => sp.GetRequiredService<PantallaLogin>());
            services.AddTransient<Func<registro>>(sp => () => sp.GetRequiredService<registro>());
            services.AddTransient<Func<olvidarContraseña>>(sp => () => sp.GetRequiredService<olvidarContraseña>());
            services.AddTransient<Func<MainWindow>>(sp => () => sp.GetRequiredService<MainWindow>());
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
