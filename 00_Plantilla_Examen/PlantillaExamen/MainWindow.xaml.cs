using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Data.Sqlite;
using PlantillaExamen.Modelos;
using PlantillaExamen.Vista.Dialogo;

namespace PlantillaExamen
{
    public partial class MainWindow : Window
    {
        private const string DbFile = "datos_examen.db";
        public ObservableCollection<RegistroItem> ListaRegistros { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            dpFecha.SelectedDate = DateTime.Today;
            dgRegistros.ItemsSource = ListaRegistros;

            EnsureDatabaseExists();
            CargarDesdeSqlite();
            ActualizarIndicadores();
        }

        // ================= 1. CONTROLES DE VENTANA Y ARRASTRE =================
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void Close_Click(object sender, RoutedEventArgs e) => Close();

        // ================= 2. BASE DE DATOS SQLITE (PORTABLE SIN SERVIDOR) =================
        private void EnsureDatabaseExists()
        {
            using var connection = new SqliteConnection($"Data Source={DbFile}");
            connection.Open();
            string sql = @"
                CREATE TABLE IF NOT EXISTS Registros (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Categoria TEXT NOT NULL,
                    Fecha TEXT NOT NULL,
                    Importe REAL NOT NULL,
                    Activo INTEGER NOT NULL
                );";
            using var cmd = new SqliteCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        private void CargarDesdeSqlite()
        {
            ListaRegistros.Clear();
            using var connection = new SqliteConnection($"Data Source={DbFile}");
            connection.Open();

            using var cmd = new SqliteCommand("SELECT Id, Nombre, Categoria, Fecha, Importe, Activo FROM Registros", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListaRegistros.Add(new RegistroItem
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Categoria = reader.GetString(2),
                    Fecha = reader.GetString(3),
                    Importe = reader.GetDouble(4),
                    Activo = reader.GetInt32(5) == 1
                });
            }

            // Datos de ejemplo iniciales si la tabla está vacía
            if (ListaRegistros.Count == 0)
            {
                InsertarEnSqlite(new RegistroItem { Nombre = "Licencia Anual WPF", Categoria = "General", Fecha = DateTime.Today.ToString("dd/MM/yyyy"), Importe = 150, Activo = true });
                InsertarEnSqlite(new RegistroItem { Nombre = "Servidor Cloud Pro", Categoria = "Prioritario", Fecha = DateTime.Today.ToString("dd/MM/yyyy"), Importe = 300, Activo = true });
            }
        }

        private void InsertarEnSqlite(RegistroItem item)
        {
            using var connection = new SqliteConnection($"Data Source={DbFile}");
            connection.Open();
            string sql = @"INSERT INTO Registros (Nombre, Categoria, Fecha, Importe, Activo)
                           VALUES (@nombre, @categoria, @fecha, @importe, @activo);
                           SELECT last_insert_rowid();";
            using var cmd = new SqliteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@nombre", item.Nombre);
            cmd.Parameters.AddWithValue("@categoria", item.Categoria);
            cmd.Parameters.AddWithValue("@fecha", item.Fecha);
            cmd.Parameters.AddWithValue("@importe", item.Importe);
            cmd.Parameters.AddWithValue("@activo", item.Activo ? 1 : 0);

            long idGenerado = (long)(cmd.ExecuteScalar() ?? 0L);
            item.Id = (int)idGenerado;
            ListaRegistros.Add(item);
        }

        // ================= 3. EVENTOS DE FORMULARIO, TABLA Y VENTANA MODAL =================
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string categoria = (cmbCategoria.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "General";
            string fecha = dpFecha.SelectedDate?.ToString("dd/MM/yyyy") ?? DateTime.Today.ToString("dd/MM/yyyy");

            var nuevo = new RegistroItem
            {
                Nombre = txtNombre.Text.Trim(),
                Categoria = categoria,
                Fecha = fecha,
                Importe = numImporte.Value ?? 0,
                Activo = chkActivo.IsChecked == true
            };

            InsertarEnSqlite(nuevo);
            ActualizarIndicadores();
            LimpiarFormulario();
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = 0;
            dpFecha.SelectedDate = DateTime.Today;
            numImporte.Value = 50;
            chkActivo.IsChecked = true;
            dgRegistros.SelectedItem = null;
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgRegistros.SelectedItem is not RegistroItem seleccionado)
            {
                MessageBox.Show("Selecciona primero una fila de la tabla.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var confirmar = MessageBox.Show($"¿Seguro que deseas eliminar '{seleccionado.Nombre}'?",
                                            "Confirmar eliminación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (confirmar == MessageBoxResult.Yes)
            {
                using var connection = new SqliteConnection($"Data Source={DbFile}");
                connection.Open();
                using var cmd = new SqliteCommand("DELETE FROM Registros WHERE Id = @id", connection);
                cmd.Parameters.AddWithValue("@id", seleccionado.Id);
                cmd.ExecuteNonQuery();

                ListaRegistros.Remove(seleccionado);
                ActualizarIndicadores();
            }
        }

        private void DgRegistros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgRegistros.SelectedItem is RegistroItem item)
            {
                txtNombre.Text = item.Nombre;
                numImporte.Value = item.Importe;
                chkActivo.IsChecked = item.Activo;
            }
        }

        private void BtnAbrirModal_Click(object sender, RoutedEventArgs e)
        {
            var modal = new VentanaSecundaria { Owner = this };
            if (modal.ShowDialog() == true && modal.NuevoRegistro != null)
            {
                InsertarEnSqlite(modal.NuevoRegistro);
                ActualizarIndicadores();
            }
        }

        private void ActualizarIndicadores()
        {
            lblTotalRegistros.Text = ListaRegistros.Count.ToString();
            double suma = ListaRegistros.Sum(r => r.Importe);
            lblTotalImporte.Text = $"{suma:N2} €";
        }
    }
}
