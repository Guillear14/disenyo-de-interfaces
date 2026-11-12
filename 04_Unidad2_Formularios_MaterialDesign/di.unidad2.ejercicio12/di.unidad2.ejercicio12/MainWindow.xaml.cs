using System.Windows;
using System.Windows.Input;

namespace di.unidad2.ejercicio12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // Ejercicio de WPF. Esta clase representa la ventana principal del programa.
    // En este archivo se inicializa la interfaz definida en XAML y se gestionan los eventos del formulario.
    public partial class MainWindow : Window
    {
        // Constructor: se ejecuta al abrir la ventana y carga el contenido del archivo XAML.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = (this.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
