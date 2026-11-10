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
    /// Interaction logic for PantallaLogin.xaml
    /// </summary>
    public partial class PantallaLogin : MetroWindow
    {
        private readonly MainWindow _mainWindow;

        public PantallaLogin(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(passClaveAcceso.Password))
            {
                await this.ShowMessageAsync("Error de inicio de sesión", "Por favor, ingrese su correo y contraseña.");
            }
            else {
                Application.Current.MainWindow = _mainWindow;
                _mainWindow.Show();
                this.Close();
            }
        }
    }
}
