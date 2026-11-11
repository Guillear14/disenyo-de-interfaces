using System;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace proyectoDefinitivo.Vista.Dialogo
{
    /// <summary>
    /// Interaction logic for olvidarContraseña.xaml
    /// </summary>
    public partial class olvidarContraseña : MetroWindow
    {
        private readonly Func<PantallaLogin> _loginFactory;
        public olvidarContraseña(Func<PantallaLogin> loginFactory)
        {
            InitializeComponent();
            _loginFactory = loginFactory;
        }

        private async void RecuperarClaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text))
            {
                // Muestra diálogo modal embebido de MahApps.Metro
                await this.ShowMessageAsync("Error de inicio de sesión", "Por favor, ingrese su correo.");
            }
            else
            {
                PantallaLogin pantallaLogin = _loginFactory();
                Application.Current.MainWindow = pantallaLogin;
                pantallaLogin.Show();
                this.Close();
            }
        }
    }
}
