# Guía rápida de Diseño de Interfaces

Chuleta práctica de **WPF, XAML, C# y Jetpack Compose**, basada en los proyectos de este repositorio y en los ejemplos Android del workspace. Los fragmentos están pensados para copiar dentro de una `Window`, `Page`, clase o función Compose equivalente.

## Índice

- [Layouts y contenedores](#layouts-y-contenedores)
- [Controles de usuario e interacción](#controles-de-usuario-e-interacción)
- [Enlace de datos](#enlace-de-datos)
- [Estilos, plantillas y recursos](#estilos-plantillas-y-recursos)
- [Eventos y navegación](#eventos-y-navegación)
- [Errores frecuentes en exámenes y cómo solucionarlos](#errores-frecuentes-en-exámenes-y-cómo-solucionarlos)

## Layouts y contenedores

### `Grid`: formularios y paneles por filas y columnas

`Auto` adapta la celda al contenido, `*` reparte el espacio disponible y un número fijo reserva una medida concreta.

```xaml
<Grid Margin="16">
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" /> <!-- Alto según el contenido -->
        <RowDefinition Height="*" />    <!-- Ocupa el espacio restante -->
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="220" /> <!-- Ancho fijo, por ejemplo para el menú -->
        <ColumnDefinition Width="*" />   <!-- Panel principal flexible -->
    </Grid.ColumnDefinitions>

    <TextBlock Grid.Row="0" Grid.ColumnSpan="2"
               Text="Gestión de empleados" FontSize="22" FontWeight="Bold" />
    <StackPanel Grid.Row="1" Grid.Column="0">
        <Button Content="Inicio" Margin="0,8" />
        <Button Content="Empleados" Margin="0,8" />
    </StackPanel>
    <Grid Grid.Row="1" Grid.Column="1" Margin="20">
        <TextBlock Text="Contenido principal" />
    </Grid>
</Grid>
```

### Otros paneles WPF

```xaml
<!-- StackPanel: organiza en una sola dirección; no reparte el espacio sobrante. -->
<StackPanel Orientation="Horizontal" HorizontalAlignment="Right">
    <Button Content="Cancelar" Margin="4" />
    <Button Content="Guardar" Margin="4" />
</StackPanel>

<!-- WrapPanel: pasa elementos a la siguiente línea cuando ya no caben. -->
<WrapPanel Orientation="Horizontal">
    <Button Content="Uno" Width="100" Margin="4" />
    <Button Content="Dos" Width="100" Margin="4" />
    <Button Content="Tres" Width="100" Margin="4" />
</WrapPanel>

<!-- DockPanel: acopla a bordes; el último hijo ocupa el espacio restante. -->
<DockPanel LastChildFill="True">
    <Border DockPanel.Dock="Top" Height="48" Background="#263238" />
    <Border DockPanel.Dock="Left" Width="180" Background="#ECEFF1" />
    <Grid />
</DockPanel>

<!-- Canvas: coordenadas absolutas; útil para elementos superpuestos, no adaptable. -->
<Canvas Height="160">
    <Button Canvas.Left="20" Canvas.Top="20" Content="Posición absoluta" />
</Canvas>
```

### Equivalencias de layout en Jetpack Compose

En Compose, `Row`, `Column` y `Box` organizan contenido; `Modifier.weight` reparte espacio y `LazyColumn` representa listas largas de forma eficiente.

```kotlin
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp

@Composable
fun PantallaEmpleados() {
    var nombre by remember { mutableStateOf("") } // Estado local observable
    val empleados = remember { mutableStateListOf<String>() }

    Column(
        modifier = Modifier.fillMaxSize().padding(16.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        Row(horizontalArrangement = Arrangement.spacedBy(8.dp)) {
            OutlinedTextField(
                value = nombre,
                onValueChange = { nombre = it },
                label = { Text("Nombre") },
                modifier = Modifier.weight(1f)
            )
            Button(onClick = {
                if (nombre.isNotBlank()) {
                    empleados.add(nombre.trim())
                    nombre = ""
                }
            }) { Text("Añadir") }
        }
        LazyColumn {
            items(empleados) { empleado -> Text(empleado, modifier = Modifier.padding(8.dp)) }
        }
    }
}
```

## Controles de usuario e interacción

Los controles reciben eventos mediante `Click` o conectan sus datos con `ItemsSource`. Las columnas de `DataGrid` suelen enlazar cada campo con una propiedad del elemento de la fila.

```xaml
<StackPanel Margin="12">
    <!-- Click enlaza con un método del code-behind. -->
    <Button Content="Guardar" Click="Guardar_Click" IsDefault="True" />

    <!-- ItemsSource proporciona las opciones; SelectedItem conserva la selección. -->
    <ComboBox Margin="0,8"
              ItemsSource="{Binding Departamentos}"
              SelectedItem="{Binding DepartamentoSeleccionado, Mode=TwoWay}"
              DisplayMemberPath="Nombre" />

    <ListBox ItemsSource="{Binding Empleados}"
             SelectedItem="{Binding EmpleadoSeleccionado, Mode=TwoWay}"
             DisplayMemberPath="Nombre" />

    <DataGrid ItemsSource="{Binding Empleados}"
              AutoGenerateColumns="False" CanUserAddRows="False"
              IsReadOnly="True" Margin="0,8">
        <DataGrid.Columns>
            <DataGridTextColumn Header="Nombre" Binding="{Binding Nombre}" />
            <DataGridTextColumn Header="Departamento" Binding="{Binding Departamento}" />
        </DataGrid.Columns>
    </DataGrid>
</StackPanel>
```

En Compose, usa controles Material 3 equivalentes (`Button`, `Checkbox`, `RadioButton`, `Switch`, `OutlinedTextField`) y cambia el estado desde callbacks como `onClick`, `onCheckedChange` u `onValueChange`.

## Enlace de datos

### WPF: `DataContext`, `Binding` e `INotifyPropertyChanged`

`DataContext` indica de dónde obtiene valores `{Binding ...}`. `TwoWay` permite que la interfaz actualice el origen; `PropertyChanged` notifica cambios posteriores.

```xaml
<StackPanel Margin="16">
    <TextBox Text="{Binding Nombre, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"
             ToolTip="Escribe el nombre" />
    <TextBlock Text="{Binding Nombre}" Margin="0,8" />
    <DataGrid ItemsSource="{Binding Empleados}" AutoGenerateColumns="False">
        <DataGrid.Columns>
            <DataGridTextColumn Header="Nombre" Binding="{Binding Nombre}" />
            <DataGridTextColumn Header="Departamento" Binding="{Binding Departamento}" />
        </DataGrid.Columns>
    </DataGrid>
</StackPanel>
```

```csharp
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

public sealed class Empleado
{
    public string Nombre { get; set; } = "";
    public string Departamento { get; set; } = "";
}

public sealed class EmpleadosViewModel : INotifyPropertyChanged
{
    private string _nombre = "";

    public string Nombre
    {
        get => _nombre;
        set
        {
            if (_nombre == value) return;
            _nombre = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nombre)));
        }
    }

    public ObservableCollection<Empleado> Empleados { get; } = new()
    {
        new Empleado { Nombre = "Ana Martínez", Departamento = "Administración" },
        new Empleado { Nombre = "Pedro García", Departamento = "Ventas" }
    };

    public event PropertyChangedEventHandler? PropertyChanged;
}

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new EmpleadosViewModel(); // Debe coincidir con las rutas del XAML.
    }
}
```

### Compose: estado y `ViewModel`

Compose no utiliza `DataContext`. La UI observa estado con `remember` para estado local o con `StateFlow` y `collectAsState()` cuando el estado vive en un `ViewModel`.

```kotlin
// En un ViewModel: actualiza el flujo de estado de forma inmutable.
private val _uiState = MutableStateFlow(PantallaUiState())
val uiState: StateFlow<PantallaUiState> = _uiState.asStateFlow()

fun agregar(nombre: String) {
    _uiState.update { estado ->
        estado.copy(elementos = estado.elementos + nombre)
    }
}

// Dentro de una función @Composable:
val uiState by viewModel.uiState.collectAsState()
LazyColumn {
    items(uiState.elementos) { elemento -> Text(text = elemento) }
}
```

## Estilos, plantillas y recursos

### Recurso, estilo, `DataTemplate` y `ControlTemplate`

`StaticResource` busca un recurso definido antes de su uso. `DataTemplate` representa datos; `ControlTemplate` cambia la estructura visual del control.

```xaml
<Window.Resources>
    <SolidColorBrush x:Key="ColorPrimario" Color="#1565C0" />

    <Style x:Key="BotonPrincipal" TargetType="Button">
        <Setter Property="Background" Value="{StaticResource ColorPrimario}" />
        <Setter Property="Foreground" Value="White" />
        <Setter Property="Padding" Value="12,6" />
        <Style.Triggers>
            <Trigger Property="IsMouseOver" Value="True">
                <Setter Property="Opacity" Value="0.8" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <!-- Cambia la representación de cada elemento de datos. -->
    <DataTemplate x:Key="EmpleadoTemplate">
        <StackPanel Orientation="Horizontal">
            <TextBlock Text="{Binding Nombre}" FontWeight="Bold" />
            <TextBlock Text=" — " />
            <TextBlock Text="{Binding Departamento}" />
        </StackPanel>
    </DataTemplate>

    <!-- TemplateBinding conecta propiedades del control con su apariencia. -->
    <ControlTemplate x:Key="BotonRedondeado" TargetType="Button">
        <Border Background="{TemplateBinding Background}"
                Padding="{TemplateBinding Padding}" CornerRadius="6">
            <ContentPresenter HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                              VerticalAlignment="{TemplateBinding VerticalContentAlignment}" />
        </Border>
    </ControlTemplate>
</Window.Resources>

<StackPanel Margin="12">
    <Button Content="Aceptar" Style="{StaticResource BotonPrincipal}"
            Template="{StaticResource BotonRedondeado}" />
    <ListBox ItemsSource="{Binding Empleados}"
             ItemTemplate="{StaticResource EmpleadoTemplate}" />
</StackPanel>
```

### Recursos globales y temas del repositorio

En `App.xaml`, los diccionarios fusionados hacen que los estilos estén disponibles en todas las ventanas. Los paquetes NuGet y los namespaces XML deben estar instalados/declarados.

```xaml
<Application x:Class="MiProyecto.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <materialDesign:BundledTheme BaseTheme="Light"
                                             PrimaryColor="LightBlue"
                                             SecondaryColor="Indigo" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

## Eventos y navegación

### Eventos de controles y ventana

El nombre del evento del XAML debe coincidir con el método y la firma del code-behind.

```xaml
<Button Content="Cerrar" Click="Cerrar_Click" />
<Window MouseDown="Window_MouseDown" />
```

```csharp
using System.Windows;
using System.Windows.Input;

private void Cerrar_Click(object sender, RoutedEventArgs e)
{
    Close();
}

private void Window_MouseDown(object sender, MouseButtonEventArgs e)
{
    if (e.ChangedButton == MouseButton.Left && e.LeftButton == MouseButtonState.Pressed)
        DragMove(); // Permite arrastrar una ventana sin barra de título.
}

private void Maximizar_Click(object sender, RoutedEventArgs e)
{
    WindowState = WindowState == WindowState.Maximized
        ? WindowState.Normal
        : WindowState.Maximized;
}
```

### Navegación entre ventanas y páginas

Al cerrar la ventana principal de la aplicación, actualiza `Application.Current.MainWindow` antes de cerrar la ventana actual para evitar que WPF apague la aplicación.

```csharp
private void AbrirPrincipal_Click(object sender, RoutedEventArgs e)
{
    var principal = new MainWindow();
    Application.Current.MainWindow = principal;
    principal.Show();
    Close();
}

private void CerrarSesion_Click(object sender, RoutedEventArgs e)
{
    var login = new LoginWindow();
    Application.Current.MainWindow = login;
    login.Show();
    Close();
}
```

Para navegar dentro de una ventana, usa `Frame` y `Page` en lugar de abrir ventanas nuevas.

```xaml
<Frame x:Name="MarcoPrincipal" NavigationUIVisibility="Hidden" />
```

```csharp
private void IrAInicio_Click(object sender, RoutedEventArgs e)
{
    MarcoPrincipal.Navigate(new InicioPage());
}
```

## Errores frecuentes en exámenes y cómo solucionarlos

| Error | Causa habitual | Solución |
| --- | --- | --- |
| El binding muestra vacío | `DataContext` no asignado o tiene otro objeto | Asigna el ViewModel antes de usar la vista y verifica cada nombre de propiedad. |
| `BindingExpression path error` en Output | La ruta del binding no existe, tiene una errata o es sensible a mayúsculas | Compara `{Binding Propiedad}` con la propiedad pública exacta del modelo. |
| Cambia el modelo pero no la interfaz | Una propiedad escalar no notifica cambios | Implementa `INotifyPropertyChanged`; para listas usa `ObservableCollection<T>`. |
| No aparece un recurso `StaticResource` | La clave no existe, está mal escrita o se declara después del uso | Declara el recurso antes del control o muévelo a `Window.Resources`/`App.xaml`. |
| `XamlParseException` al iniciar con temas | Falta un paquete, namespace o URI de `ResourceDictionary` válido | Revisa NuGet, `xmlns` y la ruta `pack://application:,,,/...` carácter por carácter. |
| El botón no ejecuta su método | `Click="..."` no coincide con el nombre o la firma C# | Usa `void Metodo(object sender, RoutedEventArgs e)` y conserva el mismo nombre. |
| `Grid` no coloca el elemento donde se espera | Faltan `Grid.Row`/`Grid.Column` o el índice no existe | Define filas/columnas y asigna los índices; sin ellos el control queda en la celda 0,0. |
| `StackPanel` corta contenido | La pila mide su contenido y no limita el alto de una lista | Coloca listas largas en una fila/columna `*` o dentro de un `ScrollViewer`. |
| `Canvas` se desordena al cambiar tamaño | Usa coordenadas absolutas | Usa `Grid`, `DockPanel` o `WrapPanel` para diseños adaptables. |
| La app WPF se cierra al cambiar de ventana | Se cerró la ventana principal antes de asignar la siguiente | Crea y muestra la nueva ventana, actualiza `Application.Current.MainWindow` y luego cierra la anterior. |
| Compose no refresca al cambiar una variable | Se usa una variable Kotlin normal que Compose no observa | Usa `remember { mutableStateOf(...) }`, estado elevado o un `StateFlow` observado con `collectAsState()`. |
| Una lista Compose no se actualiza | Se mutó una lista normal sin emitir nuevo estado | Emite un nuevo estado/lista desde el ViewModel; renderiza colecciones con `LazyColumn` y `items(...)`. |

### Comprobación rápida antes de entregar

- XAML bien formado y eventos conectados a métodos existentes.
- `DataContext`, rutas de binding y nombres de recursos revisados.
- Controles ubicados en filas/columnas válidas y listas largas con scroll.
- La solución compila y se han probado las acciones principales.
