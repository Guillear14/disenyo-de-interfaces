using System;
using System.Windows;
using proyectoDefinitivo.ViewModel;
using proyectoDefinitivo.Vista.Dialogo;

namespace proyectoDefinitivo
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;
        private readonly Func<PantallaLogin> _loginFactory;

        public MainWindow(MainViewModel viewModel, Func<PantallaLogin> loginFactory)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _loginFactory = loginFactory;
            DataContext = _viewModel;
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.CerrarSesion();
            PantallaLogin pantallaLogin = _loginFactory();
            Application.Current.MainWindow = pantallaLogin;
            pantallaLogin.Show();
            Close();
        }
    }
}
