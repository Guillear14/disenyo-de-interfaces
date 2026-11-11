using System;
using System.Windows;
using MahApps.Metro.Controls;
using proyectoDefinitivo.ViewModel;
using proyectoDefinitivo.Vista.Dialogo;

namespace proyectoDefinitivo
{
    public partial class MainWindow : MetroWindow
    {
        private readonly MainViewModel _viewModel;
        private readonly Func<PantallaLogin> _loginFactory;
        private bool _navegandoALogin;

        public MainWindow(MainViewModel viewModel, Func<PantallaLogin> loginFactory)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _loginFactory = loginFactory;
            DataContext = _viewModel;
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            if (_navegandoALogin)
                return;

            _navegandoALogin = true;
            _viewModel.CerrarSesion();
            PantallaLogin pantallaLogin = _loginFactory();
            Application.Current.MainWindow = pantallaLogin;
            pantallaLogin.Show();
            Close();
        }
    }
}
