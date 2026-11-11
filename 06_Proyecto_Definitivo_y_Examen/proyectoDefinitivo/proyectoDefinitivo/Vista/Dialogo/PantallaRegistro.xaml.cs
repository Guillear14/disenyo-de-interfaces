using System;
using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using proyectoDefinitivo.Servicios.Interfaces;
using proyectoDefinitivo.ViewModel;

namespace proyectoDefinitivo.Vista.Dialogo
{
    public partial class PantallaRegistro : MetroWindow
    {
        private readonly RegistroViewModel _viewModel;
        private readonly Func<PantallaLogin> _pantallaLoginFactory;

        public PantallaRegistro(RegistroViewModel viewModel, Func<PantallaLogin> pantallaLoginFactory)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _pantallaLoginFactory = pantallaLoginFactory;
            DataContext = _viewModel;
        }

        private async void BtnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            ResultadoOperacion resultado = _viewModel.Registrar(
                passClaveAcceso.Password,
                passClaveAccesoRepetir.Password);

            await this.ShowMessageAsync(resultado.Titulo, resultado.Mensaje);

            if (resultado.Exito)
            {
                VolverALogin();
            }
        }

        private void BtnVolverLogin_Click(object sender, MouseButtonEventArgs e)
        {
            VolverALogin();
        }

        private void VolverALogin()
        {
            PantallaLogin pantallaLogin = _pantallaLoginFactory();
            Application.Current.MainWindow = pantallaLogin;
            pantallaLogin.Show();
            Close();
        }
    }
}
