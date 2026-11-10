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

namespace di.unidad2.ejercicio1
{
    /// <summary>
    /// Logica de interaccion para MainWindow.xaml.
    /// public: Modificador de acceso accesible desde cualquier parte.
    /// partial: Indica que la clase esta dividida entre el XAML compilado y este archivo C#.
    /// : Window: Herencia orientada a objetos; MainWindow hereda todas las funciones de una ventana WPF.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor de la ventana. Se ejecuta automaticamente al abrirse la aplicacion.
        /// </summary>
        public MainWindow()
        {
            // InitializeComponent() es el metodo esencial que lee el XAML, carga
            // los elementos visuales en memoria y conecta los eventos y nombres (x:Name).
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de evento (Event Handler) para cerrar la ventana.
        /// private: Solo se puede llamar desde esta clase.
        /// void: No devuelve ningun valor tras ejecutarse.
        /// object sender: Representa el control que origino el evento (el boton de cerrar).
        /// RoutedEventArgs e: Contiene informacion detallada sobre el evento de enrutamiento.
        /// </summary>
        private void btnClose_click(object sender, RoutedEventArgs e)
        {
            // this.Close() cierra la ventana actual.
            this.Close();
        }

        /// <summary>
        /// Manejador para minimizar la ventana a la barra de tareas.
        /// </summary>
        private void btnminimice_click(object sender, RoutedEventArgs e)
        {
            // WindowState.Minimized oculta la ventana reduciendola a la barra de tareas.
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Manejador para alternar entre Maximizar (pantalla completa) y Normal.
        /// </summary>
        private void btnmaximice_click(object sender, RoutedEventArgs e)
        {
            // Comprobamos si la ventana ya esta maximizada
            if (this.WindowState.Equals(WindowState.Maximized))
            {
                // Si estaba maximizada, la devolvemos a tamaño normal
                this.WindowState = WindowState.Normal;
            }
            else
            {
                // Si estaba en tamaño normal, la maximizamos
                this.WindowState = WindowState.Maximized;
            }
        }
    }
}
