using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Data.Sqlite;

namespace di.unidad3.ejercicio5;

public partial class MainWindow : Window
{
    private const string DatabaseName = "empresa.db";

    public MainWindow()
    {
        InitializeComponent();
        EnsureDatabaseExists();
    }

    public static void EnsureDatabaseExists()
    {
        var databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DatabaseName);

        using var connection = new SqliteConnection($"Data Source={databasePath}");
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Empleados (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre TEXT NOT NULL,
                Apellidos TEXT NOT NULL,
                Departamento TEXT NOT NULL,
                Puesto TEXT NOT NULL,
                FechaAlta TEXT NOT NULL DEFAULT (date('now'))
            );";

        command.ExecuteNonQuery();
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }

    private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void BtnMaximizar_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    private void BtnCerrar_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnNuevoEmpleado_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new AddEmpleadoDialog();
        dialog.Owner = this;
        dialog.ShowDialog();
    }
}

public class AddEmpleadoDialog : Window
{
    private readonly string _databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "empresa.db");

    public AddEmpleadoDialog()
    {
        Width = 520;
        Height = 470;
        WindowStyle = WindowStyle.None;
        ResizeMode = ResizeMode.NoResize;
        AllowsTransparency = true;
        Background = Brushes.Transparent;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var outerBorder = new Border
        {
            Background = new SolidColorBrush(Color.FromRgb(244, 247, 255)),
            CornerRadius = new CornerRadius(18),
            BorderBrush = new SolidColorBrush(Color.FromRgb(215, 221, 243)),
            BorderThickness = new Thickness(1),
            Padding = new Thickness(24),
            Margin = new Thickness(0)
        };

        var stack = new StackPanel();

        var title = new TextBlock
        {
            Text = "Añadir nuevo empleado",
            FontSize = 28,
            FontWeight = FontWeights.Bold,
            Foreground = new SolidColorBrush(Color.FromRgb(31, 37, 68)),
            Margin = new Thickness(0, 12, 0, 24)
        };

        var nombreTextBox = CreateTextBox("Nombre");
        var apellidosTextBox = CreateTextBox("Apellidos");
        var departamentoCombo = CreateComboBox(new[] { "Recursos Humanos", "Ventas", "Administración", "Producción", "Logística" });
        var puestoCombo = CreateComboBox(new[] { "Analista", "Técnico", "Supervisor", "Jefe de equipo", "Administrativo" });

        var guardarButton = new Button
        {
            Content = "Guardar",
            Width = 170,
            Height = 42,
            Margin = new Thickness(0, 26, 0, 0),
            HorizontalAlignment = HorizontalAlignment.Right,
            Background = new SolidColorBrush(Color.FromRgb(58, 91, 255)),
            Foreground = Brushes.White,
            BorderThickness = new Thickness(0),
            FontWeight = FontWeights.Bold,
            Cursor = Cursors.Hand
        };

        guardarButton.Click += (_, _) => GuardarEmpleado(nombreTextBox, apellidosTextBox, departamentoCombo, puestoCombo);

        var cancelarButton = new Button
        {
            Content = "Cancelar",
            Width = 120,
            Height = 42,
            Margin = new Thickness(0, 26, 14, 0),
            HorizontalAlignment = HorizontalAlignment.Right,
            Background = new SolidColorBrush(Color.FromRgb(255, 90, 130)),
            Foreground = Brushes.White,
            BorderThickness = new Thickness(0),
            FontWeight = FontWeights.Bold,
            Cursor = Cursors.Hand
        };

        cancelarButton.Click += (_, _) => Close();

        var actionsPanel = new StackPanel
        {
            Orientation = Orientation.Horizontal,
            HorizontalAlignment = HorizontalAlignment.Right,
            Margin = new Thickness(0, 10, 0, 0)
        };

        actionsPanel.Children.Add(cancelarButton);
        actionsPanel.Children.Add(guardarButton);

        stack.Children.Add(title);
        stack.Children.Add(nombreTextBox);
        stack.Children.Add(apellidosTextBox);
        stack.Children.Add(departamentoCombo);
        stack.Children.Add(puestoCombo);
        stack.Children.Add(actionsPanel);

        outerBorder.Child = stack;

        var closeButton = new Button
        {
            Content = "✕",
            Width = 32,
            Height = 32,
            HorizontalAlignment = HorizontalAlignment.Right,
            VerticalAlignment = VerticalAlignment.Top,
            Margin = new Thickness(0, 12, 12, 0),
            Background = new SolidColorBrush(Color.FromRgb(255, 90, 130)),
            Foreground = Brushes.White,
            BorderThickness = new Thickness(0),
            Cursor = Cursors.Hand
        };

        Grid.SetZIndex(closeButton, 1);
        closeButton.Click += (_, _) => Close();

        var root = new Grid();
        root.Children.Add(outerBorder);
        root.Children.Add(closeButton);
        Content = root;
    }

    private static TextBox CreateTextBox(string placeholder)
    {
        return new TextBox
        {
            Margin = new Thickness(0, 0, 0, 12),
            Height = 42,
            Padding = new Thickness(10, 0, 0, 0),
            FontSize = 15,
            VerticalContentAlignment = VerticalAlignment.Center,
            BorderBrush = new SolidColorBrush(Color.FromRgb(204, 211, 230)),
            Background = Brushes.White,
            Text = string.Empty,
            ToolTip = placeholder
        };
    }

    private static ComboBox CreateComboBox(string[] items)
    {
        var comboBox = new ComboBox
        {
            Margin = new Thickness(0, 0, 0, 12),
            Height = 42,
            FontSize = 15,
            Background = Brushes.White,
            BorderBrush = new SolidColorBrush(Color.FromRgb(204, 211, 230)),
            SelectedIndex = 0,
            ToolTip = "Selecciona un valor"
        };

        foreach (var item in items)
        {
            comboBox.Items.Add(item);
        }

        return comboBox;
    }

    private void GuardarEmpleado(TextBox nombreTextBox, TextBox apellidosTextBox, ComboBox departamentoCombo, ComboBox puestoCombo)
    {
        var nombre = nombreTextBox.Text.Trim();
        var apellidos = apellidosTextBox.Text.Trim();
        var departamento = departamentoCombo.SelectedItem?.ToString();
        var puesto = puestoCombo.SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(departamento) || string.IsNullOrWhiteSpace(puesto))
        {
            MessageBox.Show("Debes completar todos los campos del empleado antes de guardar.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        try
        {
            MainWindow.EnsureDatabaseExists();

            using var connection = new SqliteConnection($"Data Source={_databasePath}");
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Empleados (Nombre, Apellidos, Departamento, Puesto)
                VALUES (@nombre, @apellidos, @departamento, @puesto);";

            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellidos", apellidos);
            command.Parameters.AddWithValue("@departamento", departamento);
            command.Parameters.AddWithValue("@puesto", puesto);

            command.ExecuteNonQuery();

            MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar el empleado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}