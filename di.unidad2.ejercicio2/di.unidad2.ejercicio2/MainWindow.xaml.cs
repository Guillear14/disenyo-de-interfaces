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

namespace di.unidad2.ejercicio2
{
    /// <summary>
    /// Logica de interaccion para MainWindow.xaml (Unidad 2 - Ejercicio 2).
    /// public: Accesible desde todo el ensamblado.
    /// partial: Se fusiona con el XAML compilado.
    /// : MetroWindow: Hereda de la ventana personalizada de MahApps.Metro en vez de la estandar Window.
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Constructor principal. Carga la interfaz visual y recursos de MahApps.
        /// </summary>
        public MainWindow()
        {
            // Inicializa todos los componentes XAML
            InitializeComponent();
        }
    }
}
