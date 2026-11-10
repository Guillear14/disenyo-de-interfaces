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

namespace di.unidad3.ejercicio1
{
    /// <summary>
    /// Logica de interaccion para MainWindow.xaml (Unidad 3 - Ejercicio 1).
    /// Controla el menu superior y la barra de herramientas.
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador para el boton de salir de la barra de herramientas.
        /// Exigido en el enunciado: "Al apretar el botón de salir se cerrará el programa.
        /// Para ello utilizar Application.Current.Shutdown()."
        /// </summary>
        private void salir_Click(object sender, RoutedEventArgs e)
        {
            // Cierra la aplicacion entera de forma limpia
            Application.Current.Shutdown();
        }
    }
}
