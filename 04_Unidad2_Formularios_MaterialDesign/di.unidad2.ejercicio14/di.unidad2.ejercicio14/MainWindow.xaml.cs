// =========================================================================
// UNIDAD 2 - EJERCICIO 14: CONTROL DE VENTANA SIN BORDES (CODE-BEHIND)
// =========================================================================
// QUÉ HACE ESTE ARCHIVO:
//   1. Window_MouseDown: Permite arrastrar la ventana por la pantalla con DragMove().
//   2. Minimize_Click: Minimiza la ventana a la barra de tareas.
//   3. Maximize_Click: Alterna entre Maximized y Normal.
//   4. Close_Click: Cierra la ventana actual.
// =========================================================================

using System.Windows;
using System.Windows.Input;

namespace di.unidad2.ejercicio14
{
    // Ejercicio de WPF. Esta clase representa la ventana principal del programa.
    // En este archivo se inicializa la interfaz definida en XAML y se gestionan los eventos del formulario.
    public partial class MainWindow : Window
    {
        // Constructor: se ejecuta al abrir la ventana y carga el contenido del archivo XAML.
        public MainWindow()
        {
            InitializeComponent();
        }

        // 1. Arrastrar la ventana al mantener pulsado el clic izquierdo del ratón
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        // 2. Minimizar ventana
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // 3. Maximizar o restaurar tamaño original
        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = (this.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        }

        // 4. Cerrar aplicación/ventana
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
