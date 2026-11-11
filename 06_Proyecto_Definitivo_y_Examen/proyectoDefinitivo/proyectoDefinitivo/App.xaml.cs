using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using proyectoDefinitivo.Datos.Repositorios;
using proyectoDefinitivo.Servicios;
using proyectoDefinitivo.Servicios.Interfaces;
using proyectoDefinitivo.ViewModel;
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
            // 1. Capa de Datos y Servicios (Singleton para compartir estado y persistencia)
            services.AddSingleton<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddSingleton<IAutenticacionServicio, AutenticacionServicio>();

            // 2. Capa de ViewModels (MVVM)
            services.AddTransient<LoginViewModel>();
            services.AddTransient<RegistroViewModel>();
            services.AddTransient<RecuperarClaveViewModel>();
            services.AddTransient<MainViewModel>();

            // 3. Vistas (Ventanas con nombres PascalCase limpios)
            services.AddTransient<PantallaLogin>();
            services.AddTransient<PantallaRegistro>();
            services.AddTransient<PantallaRecuperarClave>();
            services.AddTransient<MainWindow>();

            // 4. Factorías para navegación desacoplada entre ventanas
            services.AddTransient<Func<PantallaLogin>>(sp => () => sp.GetRequiredService<PantallaLogin>());
            services.AddTransient<Func<PantallaRegistro>>(sp => () => sp.GetRequiredService<PantallaRegistro>());
            services.AddTransient<Func<PantallaRecuperarClave>>(sp => () => sp.GetRequiredService<PantallaRecuperarClave>());
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
