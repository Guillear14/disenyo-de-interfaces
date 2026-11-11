using System;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using proyectoDefinitivo.Servicios.Interfaces;
using proyectoDefinitivo.ViewModel;

namespace proyectoDefinitivo.Vista.Dialogo
{
    public partial class PantallaLogin : MetroWindow
    {
        private readonly LoginViewModel _viewModel;
        private readonly Func<MainWindow> _mainWindowFactory;
        private readonly Func<PantallaRecuperarClave> _recuperarClaveFactory;
        private readonly Func<PantallaRegistro> _registroFactory;

        public PantallaLogin(
            LoginViewModel viewModel,
            Func<MainWindow> mainWindowFactory,
            Func<PantallaRecuperarClave> recuperarClaveFactory,
            Func<PantallaRegistro> registroFactory)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _mainWindowFactory = mainWindowFactory;
            _recuperarClaveFactory = recuperarClaveFactory;
            _registroFactory = registroFactory;
            DataContext = _viewModel;
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ResultadoOperacion resultado = _viewModel.IniciarSesion(passClaveAcceso.Password);

            if (!resultado.Exito)
            {
                await this.ShowMessageAsync(resultado.Titulo, resultado.Mensaje);
                return;
            }

            MainWindow mainWindow = _mainWindowFactory();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            Close();
        }

        private void btnOlvidarContraseña_Click(object sender, RoutedEventArgs e)
        {
            PantallaRecuperarClave pantallaRecuperar = _recuperarClaveFactory();
            Application.Current.MainWindow = pantallaRecuperar;
            pantallaRecuperar.Show();
            Close();
        }

        private void Registrobtn_Click(object sender, RoutedEventArgs e)
        {
            PantallaRegistro pantallaRegistro = _registroFactory();
            Application.Current.MainWindow = pantallaRegistro;
            pantallaRegistro.Show();
            Close();
        }
    }
}
