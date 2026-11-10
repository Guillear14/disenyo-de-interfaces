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

namespace di.unidad2.ejercicio3
{
    /// <summary>
    /// Logica de interaccion para MainWindow.xaml (Unidad 2 - Ejercicio 3).
    /// public: Visible para toda la aplicacion.
    /// partial: Se une al archivo XAML autogenerado al compilar.
    /// : Window: Clase base de ventana grafica en WPF.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor: se ejecuta automaticamente al instanciar la ventana.
        /// </summary>
        public MainWindow()
        {
            // Inicializa los componentes declarados en el archivo XAML
            InitializeComponent();
        }
    }
}
