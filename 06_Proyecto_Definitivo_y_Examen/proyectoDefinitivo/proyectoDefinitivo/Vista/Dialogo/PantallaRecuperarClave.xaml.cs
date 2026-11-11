using System;
using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using proyectoDefinitivo.Servicios.Interfaces;
using proyectoDefinitivo.ViewModel;

namespace proyectoDefinitivo.Vista.Dialogo
{
    public partial class PantallaRecuperarClave : MetroWindow
    {
        private readonly RecuperarClaveViewModel _viewModel;
        private readonly Func<PantallaLogin> _loginFactory;

        public PantallaRecuperarClave(RecuperarClaveViewModel viewModel, Func<PantallaLogin> loginFactory)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _loginFactory = loginFactory;
            DataContext = _viewModel;
        }

        private async void BtnRecuperarClave_Click(object sender, RoutedEventArgs e)
        {
            ResultadoOperacion resultado = _viewModel.SolicitarRecuperacion();
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
            PantallaLogin pantallaLogin = _loginFactory();
            Application.Current.MainWindow = pantallaLogin;
            pantallaLogin.Show();
            Close();
        }
    }
}
