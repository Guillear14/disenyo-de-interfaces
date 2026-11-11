// =========================================================================
// ARRANQUE DE LA APLICACIÓN CON INYECCIÓN DE DEPENDENCIAS (APP.XAML.CS)
// =========================================================================
// QUÉ HACE ESTE ARCHIVO:
//   1. Configura el contenedor de servicios (ServiceCollection) registrando
//      PantallaLogin y MainWindow como Transient.
//   2. En OnStartup, obtiene PantallaLogin del contenedor y la abre como
//      primera ventana de la aplicación (sin usar StartupUri en App.xaml).
// =========================================================================

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
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

        // Registro de ventanas y factorías para Inyección de Dependencias
        private static void ConfigureServices(IServiceCollection services)
        {
            // Registros base de las ventanas
            services.AddTransient<PantallaLogin>();
            services.AddTransient<MainWindow>();
            services.AddTransient<registro>();
            services.AddTransient<olvidarContraseña>();

            // Factoría original para el Login
            services.AddTransient<Func<PantallaLogin>>(serviceProvider =>
                () => serviceProvider.GetRequiredService<PantallaLogin>());

            // AÑADE ESTO: Enseña al sistema cómo resolver Func<olvidarContraseña>
            services.AddTransient<Func<olvidarContraseña>>(serviceProvider =>
                () => serviceProvider.GetRequiredService<olvidarContraseña>());

            // AÑADE ESTO TAMBIÉN: Para evitar el mismo error al abrir el Registro
            services.AddTransient<Func<registro>>(serviceProvider =>
                () => serviceProvider.GetRequiredService<registro>());
        }

        // Sobrescribe el inicio de la aplicación para lanzar primero PantallaLogin
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
