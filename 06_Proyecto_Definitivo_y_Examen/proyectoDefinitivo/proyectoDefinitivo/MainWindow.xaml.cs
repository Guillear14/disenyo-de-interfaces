// =========================================================================
// LÓGICA C# DE MAINWINDOW (CERRAR SESIÓN Y VOLVER AL LOGIN)
// =========================================================================

using proyectoDefinitivo.Vista.Dialogo;
using System;
using System.Windows;

namespace proyectoDefinitivo
{
    public partial class MainWindow : Window
    {
        private readonly Func<PantallaLogin> _loginFactory;

        public MainWindow(Func<PantallaLogin> loginFactory)
        {
            InitializeComponent();
            _loginFactory = loginFactory;
        }

        // Al pulsar "Cerrar Sesión", crea una nueva instancia de PantallaLogin, la muestra y cierra esta ventana
        private void btmcerrarsesion_Click(object sender, RoutedEventArgs e)
        {
            PantallaLogin pantallaLogin = _loginFactory();
            Application.Current.MainWindow = pantallaLogin;
            pantallaLogin.Show();
            this.Close();
        }
    }
}
