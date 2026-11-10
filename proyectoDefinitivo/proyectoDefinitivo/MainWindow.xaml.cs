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
        private readonly Func<PantallaLogin> _loginFactory;

        public MainWindow(Func<PantallaLogin> loginFactory)
        {
            InitializeComponent();
            _loginFactory = loginFactory;
        }

        private void btmcerrarsesion_Click(object sender, RoutedEventArgs e)
        {
            PantallaLogin pantallaLogin = _loginFactory();
            Application.Current.MainWindow = pantallaLogin;
            pantallaLogin.Show();
            this.Close();
        }
    }
}