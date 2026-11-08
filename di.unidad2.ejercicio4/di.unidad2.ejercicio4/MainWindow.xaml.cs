using MahApps.Metro.Controls;
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

namespace di.unidad2.ejercicio4
{
    /// <summary>
    /// Logica de interaccion para MainWindow.xaml (Unidad 2 - Ejercicio 4).
    /// public: Visible para toda la aplicacion.
    /// partial: Se une con el diseño XAML compilado.
    /// : MetroWindow: Ventana moderna de MahApps sin bordes nativos.
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Constructor principal de la ventana de login.
        /// </summary>
        public MainWindow()
        {
            // Inicializa la ventana y los controles XAML
            InitializeComponent();
        }
    }
}
