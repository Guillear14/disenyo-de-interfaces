using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace proyectoDefinitivo.Vista.Dialogo
{
    /// <summary>
    /// Interaction logic for registro.xaml
    /// </summary>
    public partial class registro : MetroWindow
    {
        private readonly MainWindow _mainWindow;
        private readonly Func<PantallaLogin> _PantallaLoginFactory;
        public registro(MainWindow mainWindow, Func<PantallaLogin> pantallaLoginFactory)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _PantallaLoginFactory = pantallaLoginFactory;
        }

        private async void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(passClaveAcceso.Password) || string.IsNullOrEmpty(passClaveAccesoRepetir.Password))
            {
                // Muestra diálogo modal embebido de MahApps.Metro
                await this.ShowMessageAsync("Error de inicio de sesión", "Por favor, ingrese su correo y contraseña.");
            }
            else
            {
                PantallaLogin pantallaLogin = _PantallaLoginFactory();
                Application.Current.MainWindow = pantallaLogin;
                pantallaLogin.Show();
                this.Close();
            }
        }
    }
}
