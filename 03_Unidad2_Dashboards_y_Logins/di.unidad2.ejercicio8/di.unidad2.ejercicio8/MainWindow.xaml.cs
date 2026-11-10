using System.Windows;
using System.Windows.Input;

namespace di.unidad2.ejercicio8
{
    /// <summary>
    /// Logica de interaccion para MainWindow.xaml (Unidad 2 - Ejercicio 8).
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
