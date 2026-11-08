using MahApps.Metro.Controls.Dialogs;
using proyectoDefinitivo.Vista.Dialogo;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proyectoDefinitivo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btmcerrarsesion_Click(object sender, RoutedEventArgs e)
        {
            PantallaLogin pantallaLogin = new PantallaLogin();
            pantallaLogin.Show();
            this.Close();
        }
    }
}