// =========================================================================
// UNIDAD 3 - EJERCICIO 4: VENTANA METROWINDOW CON HAMBURGERMENU
// =========================================================================
// IMPORTANTE PARA EXAMEN:
//   Cuando en el XAML usamos <mah:MetroWindow ...>, aquí en el .xaml.cs
//   la clase DEBE heredar de ": MetroWindow" (y no de ": Window"),
//   importando "using MahApps.Metro.Controls;".
// =========================================================================

using Fluent;
using MahApps.Metro.Controls;

namespace di.unidad3.ejercicio4
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
