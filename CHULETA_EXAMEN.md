# ⚡ CHULETA EXAMEN PRÁCTICO: DISEÑO DE INTERFACES (WPF + MahApps + MaterialDesign)

> **Búsqueda ultrarrápida (`Ctrl + F`):** Usa palabras clave como `App.xaml`, `MetroWindow`, `DockPanel`, `HamburgerMenu`, `TabControl`, `Menu`, `ComboBox`, `DatePicker`, `RadioButton`, `NumericUpDown`, `Trigger`, `DataGrid`, `ListView`, `ObservableCollection`, `ShowDialog`, `MessageBox`, `Validar`.

---

## 📑 Índice de Acceso Rápido

1. [Configuración Base de `App.xaml` y `MainWindow.xaml` (MahApps + MaterialDesign)](#1-configuración-base-de-appxaml-y-mainwindowxaml-mahapps--materialdesign)
   - [1.1. Paquetes NuGet en `.csproj`](#11-paquetes-nuget-en-csproj)
   - [1.2. `App.xaml` A Prueba de Fallos (Sin `XamlParseException`)](#12-appxaml-a-prueba-de-fallos-sin-xamlparseexception)
   - [1.3. `MainWindow.xaml` con `mah:MetroWindow` (Extraído de `di.unidad3.ejercicio1`)](#13-mainwindowxaml-con-mahmetrowindow-extraído-de-diunidad3ejercicio1)
   - [1.4. `MainWindow.xaml` sin Marco OS y Barra Propia (Extraído de `di.unidad2.ejercicio12` y `Examen_DI_19_11_2025`)](#14-mainwindowxaml-sin-marco-os-y-barra-propia-extraído-de-diunidad2ejercicio12-y-examen_di_19_11_2025)
2. [Layouts Principales y Menús de Navegación](#2-layouts-principales-y-menús-de-navegación)
   - [2.1. `Grid` Maestro, `DockPanel`, `StackPanel` y `WrapPanel`](#21-grid-maestro-dockpanel-stackpanel-y-wrappanel)
   - [2.2. `mah:HamburgerMenu` con `DataTemplate` y Navegación C# (De `di.unidad3.ejercicio4`)](#22-mahhamburgermenu-con-datatemplate-y-navegación-c-de-diunidad3ejercicio4)
   - [2.3. `TabControl` (Pestañas con Iconos Material Design)](#23-tabcontrol-pestañas-con-iconos-material-design)
   - [2.4. `Menu` Superior Jerárquico + `ToolBar` + `Expander` Lateral (De `di.unidad3.ejercicio1` y `3`)](#24-menu-superior-jerárquico--toolbar--expander-lateral-de-diunidad3ejercicio1-y-3)
3. [Formularios Completos, Controles y Estilos (`Style`, `Triggers`)](#3-formularios-completos-controles-y-estilos-style-triggers)
   - [3.1. `TextBox`, `PasswordBox`, `ComboBox`, `DatePicker`, `mah:NumericUpDown` (De `di.unidad2.ejercicio12` y `14`)](#31-textbox-passwordbox-combobox-datepicker-mahnumericupdown-de-diunidad2ejercicio12-y-14)
   - [3.2. `CheckBox`, `RadioButton` y Botones con Iconos (`PackIcon`) y Degradados](#32-checkbox-radiobutton-y-botones-con-iconos-packicon-y-degradados)
   - [3.3. Estilos Personalizados (`Style`, `BasedOn`, `Trigger`, `DataTrigger`) (De `PantallaLogin.xaml`)](#33-estilos-personalizados-style-basedon-trigger-datatrigger-de-pantallaloginxaml)
4. [Tablas y Listas (`DataGrid` y `ListView` con `Binding` y `ObservableCollection`)](#4-tablas-y-listas-datagrid-y-listview-con-binding-y-observablecollection)
   - [4.1. Modelo + ViewModel / Code-Behind con `INotifyPropertyChanged` y `ObservableCollection<T>`](#41-modelo--viewmodel--code-behind-con-inotifypropertychanged-y-observablecollectiont)
   - [4.2. `DataGrid` Completo con Columnas Personalizadas y Botones en Fila](#42-datagrid-completo-con-columnas-personalizadas-y-botones-en-fila)
   - [4.3. `ListView` con `GridView` y Buscador / Filtro en Tiempo Real](#43-listview-con-gridview-y-buscador--filtro-en-tiempo-real)
5. [Ventanas Modales, Diálogos de Login/Confirmación y Eventos](#5-ventanas-modales-diálogos-de-loginconfirmación-y-eventos)
   - [5.1. Abrir Ventana Modal (`ShowDialog()`) y Pasar Datos entre Ventanas](#51-abrir-ventana-modal-showdialog-y-pasar-datos-entre-ventanas)
   - [5.2. Flujo Completo de Login a Ventana Principal y Cerrar Sesión (De `proyectoDefinitivo`)](#52-flujo-completo-de-login-a-ventana-principal-y-cerrar-sesión-de-proyectodefinitivo)
   - [5.3. Diálogos de Confirmación (`MessageBoxResult` y `ShowMessageAsync` de MahApps)](#53-diálogos-de-confirmación-messageboxresult-y-showmessageasync-de-mahapps)
   - [5.4. Validaciones de Formulario, `SelectionChanged` y Eventos Frecuentes](#54-validaciones-de-formulario-selectionchanged-y-eventos-frecuentes)

---

## 1. Configuración Base de `App.xaml` y `MainWindow.xaml` (MahApps + MaterialDesign)

### 1.1. Paquetes NuGet en `.csproj`
Extraído de `di.unidad2.ejercicio12.csproj` y `proyectoDefinitivo.csproj`. Con incluir `MaterialDesignThemes.MahApps` ya se instalan automáticamente `MahApps.Metro` y `MaterialDesignThemes`:

```xml
<ItemGroup>
    <!-- Paquete todo-en-uno que incluye MahApps.Metro + MaterialDesignThemes + Integración -->
    <PackageReference Include="MaterialDesignThemes.MahApps" Version="5.4.0" />
    <!-- Opcionales según enunciado -->
    <PackageReference Include="Fluent.Ribbon" Version="9.0.0" />
    <PackageReference Include="Microsoft.Data.Sqlite" Version="9.0.0" />
</ItemGroup>

<!-- Incluir automáticamente todas las imágenes e iconos de la carpeta Recursos -->
<ItemGroup>
    <Resource Include="Recursos\**\*" />
</ItemGroup>
```

---

### 1.2. `App.xaml` A Prueba de Fallos (Sin `XamlParseException`)
Extraído de `di.unidad2.ejercicio12/App.xaml` y `di.unidad3.ejercicio1/App.xaml`. **Importante**: En MaterialDesign v5+, incluir siempre `MaterialDesign2.Defaults.xaml` debajo de `BundledTheme` para que funcionen estilos como `MaterialDesignFloatingHintTextBox` o `MaterialDesignOutlinedTextBox`:

```xml
<!-- CAMBIAR EN EXAMEN: 'MiProyecto.App' por el namespace de tu solución -->
<Application x:Class="MiProyecto.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- 1. Diccionarios base de MahApps.Metro (¡Sensibles a mayúsculas/minúsculas!) -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <!-- Tema MahApps: Light.Red, Light.Blue, Light.Orange, Dark.Blue, Dark.Cobalt -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Red.xaml" />

                <!-- 2. Diccionarios de Material Design -->
                <!-- Colores válidos: Red, Blue, Indigo, Orange, DeepOrange, LightBlue, DeepPurple, Green, Teal -->
                <materialDesign:BundledTheme BaseTheme="Light"
                                             PrimaryColor="Red"
                                             SecondaryColor="Orange" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />

                <!-- 3. Fluent.Ribbon (Descomentar SOLO si usas <Fluent:Ribbon>) -->
                <!-- <ResourceDictionary Source="pack://application:,,,/Fluent;Component/Themes/Generic.xaml" /> -->
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

---

### 1.3. `MainWindow.xaml` con `mah:MetroWindow` (Extraído de `di.unidad3.ejercicio1`)

**XAML (`MainWindow.xaml`):**
```xml
<!-- CAMBIAR EN EXAMEN: 'MiProyecto.MainWindow' -->
<mah:MetroWindow x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:MiProyecto"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="GESTIÓN MATISSE" Height="600" Width="950"
        WindowStartupLocation="CenterScreen">

    <!-- Botones en la barra de título derecha de MetroWindow -->
    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands ShowSeparators="True">
            <Button ToolTip="Perfil de Usuario">
                <mat:PackIcon Kind="Account" Width="20" Height="20" Foreground="White" />
            </Button>
            <Button x:Name="btnSalir" ToolTip="Cerrar Sesión" Click="BtnSalir_Click">
                <mat:PackIcon Kind="Logout" Width="20" Height="20" Foreground="White" />
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <Grid>
        <!-- Contenido principal -->
    </Grid>
</mah:MetroWindow>
```

**C# (`MainWindow.xaml.cs`):**
```csharp
using System.Windows;
using MahApps.Metro.Controls;

namespace MiProyecto
{
    // ¡IMPORTANTE!: Heredar de MetroWindow cuando la etiqueta raíz en XAML es <mah:MetroWindow>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
```

---

### 1.4. `MainWindow.xaml` sin Marco OS y Barra Propia (Extraído de `di.unidad2.ejercicio12` y `Examen_DI_19_11_2025`)

**XAML (`MainWindow.xaml`):**
```xml
<Window x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        Title="GESTIÓN EMPRESARIAL" Height="620" Width="850"
        WindowStyle="None" ResizeMode="NoResize"
        AllowsTransparency="True" Background="Transparent"
        WindowStartupLocation="CenterScreen"
        MouseLeftButtonDown="Window_MouseLeftButtonDown">

    <Border Background="White" CornerRadius="16" BorderBrush="#D7DDF3" BorderThickness="1">
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="42" /> <!-- Fila 0: Barra superior personalizada -->
                <RowDefinition Height="46" /> <!-- Fila 1: Subtítulo oscuro -->
                <RowDefinition Height="*" />  <!-- Fila 2: Contenido principal -->
            </Grid.RowDefinitions>

            <!-- Barra de título roja con controles de ventana -->
            <Border Grid.Row="0" Background="#E5302E" CornerRadius="16,16,0,0">
                <Grid>
                    <TextBlock Text="GESTIÓN ARTÍCULOS" Foreground="White" FontWeight="SemiBold"
                               FontSize="15" VerticalAlignment="Center" Margin="16,0,0,0" />
                    <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Center" Margin="0,0,12,0">
                        <Button Click="Minimize_Click" Background="Transparent" BorderThickness="0" Margin="0,0,8,0" Cursor="Hand">
                            <mat:PackIcon Kind="WindowMinimize" Foreground="White" Width="16" Height="16" />
                        </Button>
                        <Button Click="Maximize_Click" Background="Transparent" BorderThickness="0" Margin="0,0,8,0" Cursor="Hand">
                            <mat:PackIcon Kind="WindowMaximize" Foreground="White" Width="16" Height="16" />
                        </Button>
                        <Button Click="Close_Click" Background="Transparent" BorderThickness="0" Cursor="Hand">
                            <mat:PackIcon Kind="Close" Foreground="White" Width="18" Height="18" />
                        </Button>
                    </StackPanel>
                </Grid>
            </Border>

            <!-- Banner secundario oscuro -->
            <Border Grid.Row="1" Background="#3E3E3E">
                <TextBlock Text="PANEL DE CONTROL" Foreground="White" FontSize="16"
                           HorizontalAlignment="Center" VerticalAlignment="Center" />
            </Border>

            <!-- Contenido -->
            <Grid Grid.Row="2" Margin="24">
                <!-- Aquí va el formulario o tabla -->
            </Grid>
        </Grid>
    </Border>
</Window>
```

**C# (`MainWindow.xaml.cs`):**
```csharp
using System.Windows;
using System.Windows.Input;

namespace MiProyecto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void Maximize_Click(object sender, RoutedEventArgs e)
            => WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;

        private void Close_Click(object sender, RoutedEventArgs e) => Close();
    }
}
```

---

## 2. Layouts Principales y Menús de Navegación

### 2.1. `Grid` Maestro, `DockPanel`, `StackPanel` y `WrapPanel`

```xml
<!-- 1. DOCKPANEL (Estructura clásica de aplicación: Barra superior + Menú izquierdo + Centro) -->
<DockPanel LastChildFill="True">
    <!-- Barra superior -->
    <Border DockPanel.Dock="Top" Height="60" Background="#1F2544" Padding="20,0">
        <TextBlock Text="APLICACIÓN CORPORATIVA" Foreground="White" FontSize="22" FontWeight="Bold" VerticalAlignment="Center" />
    </Border>

    <!-- Menú lateral izquierdo -->
    <Border DockPanel.Dock="Left" Width="210" Background="#EEF3FF" BorderBrush="#D3DAF2" BorderThickness="0,0,1,0">
        <StackPanel Margin="16,20">
            <Button Content="Inicio" Height="40" Margin="0,0,0,10" Background="#6266F7" Foreground="White" BorderThickness="0" />
            <Button Content="Empleados" Height="40" Margin="0,0,0,10" Background="#05D79E" Foreground="White" BorderThickness="0" />
            <Button Content="Productos" Height="40" Margin="0,0,0,10" Background="#FF5A82" Foreground="White" BorderThickness="0" />
        </StackPanel>
    </Border>

    <!-- Zona central (Último hijo del DockPanel rellena todo el espacio restante) -->
    <Grid Margin="24">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" /> <!-- Tarjetas KPI superiores -->
            <RowDefinition Height="*" />    <!-- Tabla o contenido elástico -->
        </Grid.RowDefinitions>

        <!-- 2. WRAPPANEL: Tarjetas que saltan de línea automáticamente si se estrecha la ventana -->
        <WrapPanel Grid.Row="0" Orientation="Horizontal" Margin="0,0,0,20">
            <Border Width="220" Background="#EAF8F3" CornerRadius="14" Padding="18" Margin="0,0,15,10">
                <StackPanel>
                    <TextBlock Text="Personal Total" Foreground="#0B5E4B" FontWeight="Bold" FontSize="15" />
                    <TextBlock Text="128" FontSize="28" FontWeight="Bold" Foreground="#0B5E4B" Margin="0,8,0,0" />
                </StackPanel>
            </Border>
            <Border Width="220" Background="#EEF1FF" CornerRadius="14" Padding="18" Margin="0,0,15,10">
                <StackPanel>
                    <TextBlock Text="En Activo" Foreground="#3C4BAA" FontWeight="Bold" FontSize="15" />
                    <TextBlock Text="96" FontSize="28" FontWeight="Bold" Foreground="#3C4BAA" Margin="0,8,0,0" />
                </StackPanel>
            </Border>
        </WrapPanel>

        <!-- Contenido fila 1 -->
        <Border Grid.Row="1" Background="White" CornerRadius="14" BorderBrush="#DDE4FF" BorderThickness="1" Padding="16">
            <!-- DataGrid o Formulario aquí -->
        </Border>
    </Grid>
</DockPanel>
```

---

### 2.2. `mah:HamburgerMenu` con `DataTemplate` y Navegación C# (De `di.unidad3.ejercicio4`)

**XAML:**
```xml
<mah:MetroWindow.Resources>
    <!-- Molde para dibujar cada opción del HamburgerMenu -->
    <DataTemplate x:Key="MenuItemTemplateIcon" DataType="{x:Type mah:HamburgerMenuIconItem}">
        <Grid Height="48">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="48" />
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>
            <ContentControl Grid.Column="0" Content="{Binding Icon}" HorizontalAlignment="Center" VerticalAlignment="Center" Foreground="White" />
            <TextBlock Grid.Column="1" Text="{Binding Label}" VerticalAlignment="Center" FontSize="15" Foreground="White" />
        </Grid>
    </DataTemplate>
</mah:MetroWindow.Resources>

<Grid>
    <mah:HamburgerMenu x:Name="hamMenuPrincipal"
                       Foreground="White"
                       PaneBackground="#3B3B3B"
                       DisplayMode="CompactInline"
                       ItemTemplate="{StaticResource MenuItemTemplateIcon}"
                       OptionsItemTemplate="{StaticResource MenuItemTemplateIcon}"
                       ItemInvoked="HamMenuPrincipal_ItemInvoked">

        <!-- Botones principales (Arriba) -->
        <mah:HamburgerMenu.ItemsSource>
            <mah:HamburgerMenuItemCollection>
                <mah:HamburgerMenuIconItem Label="Préstamos" Tag="Prestamos" Icon="{mat:PackIcon Kind=Sync}" />
                <mah:HamburgerMenuIconItem Label="Artículos" Tag="Articulos" Icon="{mat:PackIcon Kind=PackageVariant}" />
                <mah:HamburgerMenuIconItem Label="Usuarios" Tag="Usuarios" Icon="{mat:PackIcon Kind=AccountGroup}" />
            </mah:HamburgerMenuItemCollection>
        </mah:HamburgerMenu.ItemsSource>

        <!-- Botones secundarios (Abajo) -->
        <mah:HamburgerMenu.OptionsItemsSource>
            <mah:HamburgerMenuItemCollection>
                <mah:HamburgerMenuIconItem Label="Ayuda" Tag="Ayuda" Icon="{mat:PackIcon Kind=HelpCircle}" />
            </mah:HamburgerMenuItemCollection>
        </mah:HamburgerMenu.OptionsItemsSource>

        <!-- Contenido que se muestra a la derecha del menú -->
        <mah:HamburgerMenu.Content>
            <Grid x:Name="gridContenidoMenu" Margin="20" Background="#F4F7FF">
                <TextBlock Text="Selecciona una opción del menú lateral" VerticalAlignment="Center" HorizontalAlignment="Center" FontSize="18" />
            </Grid>
        </mah:HamburgerMenu.Content>
    </mah:HamburgerMenu>
</Grid>
```

**C# (`ItemInvoked` en `MainWindow.xaml.cs`):**
```csharp
private void HamMenuPrincipal_ItemInvoked(object sender, MahApps.Metro.Controls.HamburgerMenuItemInvokedEventArgs args)
{
    if (args.InvokedItem is MahApps.Metro.Controls.HamburgerMenuIconItem item)
    {
        gridContenidoMenu.Children.Clear();
        switch (item.Tag?.ToString())
        {
            case "Prestamos":
                // Puedes cargar un UserControl: gridContenidoMenu.Children.Add(new PrestamosControl());
                gridContenidoMenu.Children.Add(new TextBlock { Text = "Vista de Préstamos", FontSize = 24 });
                break;
            case "Articulos":
                gridContenidoMenu.Children.Add(new TextBlock { Text = "Vista de Artículos", FontSize = 24 });
                break;
        }
    }
}
```

---

### 2.3. `TabControl` (Pestañas con Iconos Material Design)

```xml
<TabControl Margin="10" Style="{StaticResource MaterialDesignFilledTabControl}">
    <!-- Pestaña 1 -->
    <TabItem>
        <TabItem.Header>
            <StackPanel Orientation="Horizontal">
                <mat:PackIcon Kind="AccountMultiple" Width="20" Height="20" Margin="0,0,8,0" VerticalAlignment="Center" />
                <TextBlock Text="EMPLEADOS" VerticalAlignment="Center" FontWeight="SemiBold" />
            </StackPanel>
        </TabItem.Header>
        <Grid Margin="16">
            <!-- Contenido de la pestaña 1 -->
        </Grid>
    </TabItem>

    <!-- Pestaña 2 -->
    <TabItem>
        <TabItem.Header>
            <StackPanel Orientation="Horizontal">
                <mat:PackIcon Kind="PackageVariantClosed" Width="20" Height="20" Margin="0,0,8,0" VerticalAlignment="Center" />
                <TextBlock Text="INVENTARIO" VerticalAlignment="Center" FontWeight="SemiBold" />
            </StackPanel>
        </TabItem.Header>
        <Grid Margin="16">
            <!-- Contenido de la pestaña 2 -->
        </Grid>
    </TabItem>
</TabControl>
```

---

### 2.4. `Menu` Superior Jerárquico + `ToolBar` + `Expander` Lateral (De `di.unidad3.ejercicio1` y `3`)

```xml
<DockPanel>
    <!-- 1. MENU SUPERIOR JERÁRQUICO -->
    <Menu DockPanel.Dock="Top" IsMainMenu="True">
        <MenuItem Header="Artículos">
            <MenuItem Header="Artículo Nuevo" Click="MenuNuevoArticulo_Click">
                <MenuItem.Icon><mat:PackIcon Kind="ContentSaveAll" /></MenuItem.Icon>
            </MenuItem>
            <MenuItem Header="Lista">
                <MenuItem.Icon><mat:PackIcon Kind="ListBox" /></MenuItem.Icon>
            </MenuItem>
            <Separator />
            <MenuItem Header="Salir" Click="BtnSalir_Click">
                <MenuItem.Icon><mat:PackIcon Kind="Logout" /></MenuItem.Icon>
            </MenuItem>
        </MenuItem>

        <MenuItem Header="Administración">
            <!-- Submenú anidado -->
            <MenuItem Header="Gestión Usuarios">
                <MenuItem Header="Nuevo">
                    <MenuItem.Icon><mat:PackIcon Kind="AccountMultiplePlus" /></MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Editar">
                    <MenuItem.Icon><mat:PackIcon Kind="AccountEdit" /></MenuItem.Icon>
                </MenuItem>
            </MenuItem>
        </MenuItem>
    </Menu>

    <!-- 2. TOOLBAR DE ACCESO RÁPIDO -->
    <ToolBar DockPanel.Dock="Top">
        <Button ToolTip="Salidas de material">
            <mat:PackIcon Kind="Output" />
        </Button>
        <Button ToolTip="Guardar registros">
            <mat:PackIcon Kind="ContentSave" />
        </Button>
        <Separator />
        <TextBlock Text="Buscar artículo:" VerticalAlignment="Center" Margin="10,0,6,0" />
        <TextBox x:Name="txtFiltroBarra" Width="140" VerticalAlignment="Center" />
    </ToolBar>

    <!-- 3. PANEL LATERAL CON EXPANDER (Acordeón de di.unidad3.ejercicio3) -->
    <StackPanel DockPanel.Dock="Left" Width="230" Background="#E5303030">
        <Expander Header="Configuración" IsExpanded="True" Foreground="White" Background="{x:Null}"
                  Style="{StaticResource MaterialDesignExpander}">
            <StackPanel Margin="20,0,0,10">
                <Button Content="Usuarios" Style="{StaticResource MaterialDesignFlatButton}" Foreground="White" HorizontalAlignment="Left" />
                <Button Content="Permisos" Style="{StaticResource MaterialDesignFlatButton}" Foreground="White" HorizontalAlignment="Left" />
            </StackPanel>
        </Expander>
    </StackPanel>

    <!-- Área de trabajo central -->
    <Grid x:Name="gridTrabajo" />
</DockPanel>
```

---

## 3. Formularios Completos, Controles y Estilos (`Style`, `Triggers`)

### 3.1. `TextBox`, `PasswordBox`, `ComboBox`, `DatePicker`, `mah:NumericUpDown` (De `di.unidad2.ejercicio12` y `14`)

```xml
<!-- Grid de formulario a 2 columnas con calle central de 28px (Patrón de ejercicios 12, 13, 14 y 15) -->
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="28" />
        <ColumnDefinition Width="*" />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>

    <!-- Encabezado de Sección con línea divisoria -->
    <StackPanel Grid.Row="0" Grid.ColumnSpan="3" Margin="0,0,0,10">
        <TextBlock Text="DATOS DEL REGISTRO" FontStyle="Italic" FontWeight="SemiBold" FontSize="16" Foreground="#E5302E" />
        <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,0" />
    </StackPanel>

    <!-- 1. TEXTBOX CON FLOATING HINT Y CONTADOR DINÁMICO DE CARACTERES -->
    <StackPanel Grid.Row="1" Grid.Column="0" Margin="0,0,0,12">
        <TextBox x:Name="txtNombre"
                 mat:HintAssist.Hint="Nombre del Producto*"
                 Style="{StaticResource MaterialDesignFloatingHintTextBox}"
                 MaxLength="50" FontSize="13" />
        <!-- Contador reactivo en vivo usando ElementName -->
        <TextBlock HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0">
            <Run Text="{Binding Text.Length, ElementName=txtNombre, Mode=OneWay}" />
            <Run Text=" / 50" />
        </TextBlock>
    </StackPanel>

    <!-- 2. COMBOBOX CON FLOATING HINT -->
    <ComboBox x:Name="cmbCategoria" Grid.Row="1" Grid.Column="2"
              mat:HintAssist.Hint="Selecciona una categoría*"
              Style="{StaticResource MaterialDesignFloatingHintComboBox}"
              FontSize="13" Margin="0,0,0,12" VerticalAlignment="Top">
        <ComboBoxItem Content="Electrónica" />
        <ComboBoxItem Content="Mobiliario" />
        <ComboBoxItem Content="Informática" />
    </ComboBox>

    <!-- 3. DATEPICKER CON FLOATING HINT -->
    <DatePicker x:Name="dpFechaAlta" Grid.Row="2" Grid.Column="0"
                mat:HintAssist.Hint="Fecha de Alta*"
                Style="{StaticResource MaterialDesignFloatingHintDatePicker}"
                FontSize="13" Margin="0,0,0,12" />

    <!-- 4. PASSWORDBOX CON FLOATING HINT -->
    <PasswordBox x:Name="passClave" Grid.Row="2" Grid.Column="2"
                 mat:HintAssist.Hint="Contraseña de acceso*"
                 Style="{StaticResource MaterialDesignFloatingHintPasswordBox}"
                 FontSize="13" Margin="0,0,0,12" />

    <!-- 5. NUMERICUPDOWN DE MAHAPPS (Para Stock, Precios o Cantidades - De ejercicio 14) -->
    <StackPanel Grid.Row="3" Grid.Column="0">
        <TextBlock Text="Precio de Venta (€)*" FontSize="11" Foreground="#757575" Margin="0,0,0,4" />
        <mah:NumericUpDown x:Name="numPrecio"
                           Minimum="0" Maximum="99999"
                           Value="0.00" Interval="0.50"
                           StringFormat="{}{0:N2} €"
                           Height="36" FontSize="13" />
    </StackPanel>
</Grid>
```

---

### 3.2. `CheckBox`, `RadioButton` y Botones con Iconos (`PackIcon`) y Degradados

```xml
<!-- 1. RADIOBUTTONS AGRUPADOS (GroupName hace que solo uno pueda marcarse a la vez) -->
<StackPanel Orientation="Horizontal" Margin="0,10">
    <TextBlock Text="Jornada:" FontWeight="SemiBold" VerticalAlignment="Center" Margin="0,0,15,0" />
    <RadioButton x:Name="rbCompleta" Content="Completa" GroupName="GrupoJornada" IsChecked="True" Margin="0,0,15,0" />
    <RadioButton x:Name="rbParcial" Content="Parcial" GroupName="GrupoJornada" Margin="0,0,15,0" />
    <RadioButton x:Name="rbRemoto" Content="Teletrabajo" GroupName="GrupoJornada" />
</StackPanel>

<!-- 2. CHECKBOX -->
<CheckBox x:Name="chkActivo" Content="Empleado en activo" IsChecked="True" Margin="0,8" />

<!-- 3. TEXTBOX REDONDEADO CON ICONO INTERIOR (De di.unidad2.ejercicio5 y PantallaLogin.xaml) -->
<TextBox x:Name="txtUsuarioIcono" Width="300"
         Style="{StaticResource MaterialDesignOutlinedTextBox}"
         mat:TextFieldAssist.HasClearButton="True"
         mat:TextFieldAssist.TextFieldCornerRadius="20">
    <mat:HintAssist.Hint>
        <StackPanel Orientation="Horizontal" Margin="-2,0,0,0">
            <mat:PackIcon Kind="Account" Margin="0,0,6,0" VerticalAlignment="Center" />
            <TextBlock Text="Nombre de usuario" VerticalAlignment="Center" />
        </StackPanel>
    </mat:HintAssist.Hint>
</TextBox>

<!-- 4. BOTÓN CON ICONO + TEXTO + DEGRADADO + SOMBRA (De di.unidad2.ejercicio11 y 12) -->
<Button x:Name="btnGuardar" Width="150" Height="40" Cursor="Hand"
        BorderThickness="0" Foreground="White" FontWeight="SemiBold"
        mat:ButtonAssist.CornerRadius="20" Click="BtnGuardar_Click">
    <Button.Background>
        <LinearGradientBrush StartPoint="0,0.5" EndPoint="1,0.5">
            <GradientStop Color="#FF911E" Offset="0.0" />
            <GradientStop Color="#FF5F07" Offset="1.0" />
        </LinearGradientBrush>
    </Button.Background>
    <Button.Effect>
        <DropShadowEffect Color="#FF7810" BlurRadius="10" Opacity="0.35" ShadowDepth="3" Direction="270" />
    </Button.Effect>
    <StackPanel Orientation="Horizontal">
        <mat:PackIcon Kind="ContentSave" Width="18" Height="18" VerticalAlignment="Center" Margin="0,0,8,0" />
        <TextBlock Text="GUARDAR" VerticalAlignment="Center" />
    </StackPanel>
</Button>
```

---

### 3.3. Estilos Personalizados (`Style`, `BasedOn`, `Trigger`, `DataTrigger`) (De `PantallaLogin.xaml`)

```xml
<Window.Resources>
    <!-- 1. STYLE CON BASEDON Y TRIGGER DE FOCO / HOVER (Extraído de proyectoDefinitivo/PantallaLogin.xaml) -->
    <Style x:Key="EstiloInputCristal" TargetType="TextBox" BasedOn="{StaticResource MaterialDesignOutlinedTextBox}">
        <Setter Property="Background" Value="#40000000" />
        <Setter Property="BorderBrush" Value="#C79F86" />
        <Setter Property="Foreground" Value="White" />
        <Style.Triggers>
            <!-- Cambia el fondo y borde cuando el usuario está escribiendo dentro -->
            <Trigger Property="IsKeyboardFocused" Value="True">
                <Setter Property="Background" Value="#80000000" />
                <Setter Property="BorderBrush" Value="#3A5BFF" />
            </Trigger>
            <!-- Cambia cuando pasa el ratón por encima -->
            <Trigger Property="IsMouseOver" Value="True">
                <Setter Property="BorderBrush" Value="White" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <!-- 2. DATATRIGGER: Deshabilita el botón Guardar automáticamente si el CheckBox de términos no está marcado -->
    <Style x:Key="BotonRequiereCheck" TargetType="Button" BasedOn="{StaticResource MaterialDesignRaisedButton}">
        <Setter Property="IsEnabled" Value="False" />
        <Style.Triggers>
            <DataTrigger Binding="{Binding IsChecked, ElementName=chkTerminos}" Value="True">
                <Setter Property="IsEnabled" Value="True" />
            </DataTrigger>
        </Style.Triggers>
    </Style>
</Window.Resources>
```

---

## 4. Tablas y Listas (`DataGrid` y `ListView` con `Binding` y `ObservableCollection`)

### 4.1. Modelo + ViewModel / Code-Behind con `INotifyPropertyChanged` y `ObservableCollection<T>`

```csharp
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiProyecto
{
    // 1. CLASE MODELO CON NOTIFICACIÓN DE CAMBIOS A LA INTERFAZ
    public class Articulo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? prop = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        private string _numSerie = string.Empty;
        private string _modelo = string.Empty;
        private string _departamento = string.Empty;
        private int _stock;
        private double _precio;
        private bool _operativo = true;

        public string NumSerie { get => _numSerie; set { _numSerie = value; OnPropertyChanged(); } }
        public string Modelo { get => _modelo; set { _modelo = value; OnPropertyChanged(); } }
        public string Departamento { get => _departamento; set { _departamento = value; OnPropertyChanged(); } }
        public int Stock { get => _stock; set { _stock = value; OnPropertyChanged(); } }
        public double Precio { get => _precio; set { _precio = value; OnPropertyChanged(); } }
        public bool Operativo { get => _operativo; set { _operativo = value; OnPropertyChanged(); } }
    }
}
```

**Inicialización en `MainWindow.xaml.cs` (sirve tanto para Binding directo como para Code-Behind):**
```csharp
public partial class MainWindow : Window
{
    // ObservableCollection actualiza automáticamente el DataGrid y ListView al hacer .Add() o .Remove()
    public ObservableCollection<Articulo> ListaArticulos { get; set; } = new();
    public Articulo? ArticuloSeleccionado { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        // Datos de ejemplo iniciales
        ListaArticulos.Add(new Articulo { NumSerie = "SN-001", Modelo = "Portátil Dell XPS", Departamento = "Informática", Stock = 15, Precio = 1250.50, Operativo = true });
        ListaArticulos.Add(new Articulo { NumSerie = "SN-002", Modelo = "Proyector Epson", Departamento = "Audiovisuales", Stock = 4, Precio = 480.00, Operativo = true });

        // Conectamos el DataContext de la ventana consigo misma (o con un ViewModel separado)
        this.DataContext = this;
    }
}
```

---

### 4.2. `DataGrid` Completo con Columnas Personalizadas y Botones en Fila

```xml
<DataGrid x:Name="dgArticulos"
          ItemsSource="{Binding ListaArticulos}"
          SelectedItem="{Binding ArticuloSeleccionado, Mode=TwoWay}"
          AutoGenerateColumns="False"
          CanUserAddRows="False"
          IsReadOnly="True"
          SelectionMode="Single"
          SelectionChanged="DgArticulos_SelectionChanged">

    <DataGrid.Columns>
        <!-- Columnas de texto y formato numérico -->
        <DataGridTextColumn Header="Nº Serie" Binding="{Binding NumSerie}" Width="110" />
        <DataGridTextColumn Header="Modelo" Binding="{Binding Modelo}" Width="1.5*" />
        <DataGridTextColumn Header="Departamento" Binding="{Binding Departamento}" Width="*" />
        <DataGridTextColumn Header="Stock" Binding="{Binding Stock}" Width="80" />
        <DataGridTextColumn Header="Precio" Binding="{Binding Precio, StringFormat='{}{0:N2} €'}" Width="110" />

        <!-- Columna Booleana CheckBox -->
        <DataGridCheckBoxColumn Header="Operativo" Binding="{Binding Operativo}" Width="90" />

        <!-- Columna Personalizada con indicador de color y botón Eliminar -->
        <DataGridTemplateColumn Header="Acciones" Width="130">
            <DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                        <Button ToolTip="Editar fila" Padding="6,2" Margin="0,0,6,0"
                                Background="#3A5BFF" Foreground="White" BorderThickness="0"
                                Click="BtnEditarFila_Click">
                            <mat:PackIcon Kind="Pencil" Width="16" Height="16" />
                        </Button>
                        <Button ToolTip="Eliminar fila" Padding="6,2"
                                Background="#FF5A82" Foreground="White" BorderThickness="0"
                                Click="BtnEliminarFila_Click">
                            <mat:PackIcon Kind="Delete" Width="16" Height="16" />
                        </Button>
                    </StackPanel>
                </DataTemplate>
            </DataGridTemplateColumn.CellTemplate>
        </DataGridTemplateColumn>
    </DataGrid.Columns>
</DataGrid>
```

---

### 4.3. `ListView` con `GridView` y Buscador / Filtro en Tiempo Real

**XAML:**
```xml
<DockPanel>
    <!-- Buscador superior -->
    <TextBox x:Name="txtBuscar" DockPanel.Dock="Top" Margin="0,0,0,12"
             mat:HintAssist.Hint="Buscar por modelo o departamento..."
             Style="{StaticResource MaterialDesignOutlinedTextBox}"
             TextChanged="TxtBuscar_TextChanged" />

    <!-- ListView con columnas GridView -->
    <ListView x:Name="lvArticulos" ItemsSource="{Binding ListaArticulos}">
        <ListView.View>
            <GridView>
                <GridViewColumn Header="Nº Serie" DisplayMemberBinding="{Binding NumSerie}" Width="100" />
                <GridViewColumn Header="Modelo" DisplayMemberBinding="{Binding Modelo}" Width="200" />
                <GridViewColumn Header="Departamento" DisplayMemberBinding="{Binding Departamento}" Width="150" />
                <GridViewColumn Header="Precio" DisplayMemberBinding="{Binding Precio, StringFormat='{}{0:N2} €'}" Width="100" />
            </GridView>
        </ListView.View>
    </ListView>
</DockPanel>
```

**C# (Filtrado instantáneo con `ICollectionView`):**
```csharp
using System.ComponentModel;
using System.Windows.Data;

private void TxtBuscar_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
{
    ICollectionView vista = CollectionViewSource.GetDefaultView(ListaArticulos);
    string filtro = txtBuscar.Text.Trim().ToLower();

    if (string.IsNullOrEmpty(filtro))
    {
        vista.Filter = null;
    }
    else
    {
        vista.Filter = obj =>
        {
            if (obj is not Articulo art) return false;
            return art.Modelo.ToLower().Contains(filtro) ||
                   art.Departamento.ToLower().Contains(filtro) ||
                   art.NumSerie.ToLower().Contains(filtro);
        };
    }
}
```

---

## 5. Ventanas Modales, Diálogos de Login/Confirmación y Eventos

### 5.1. Abrir Ventana Modal (`ShowDialog()`) y Pasar Datos entre Ventanas
Mejora directa del diálogo de `Examen_DI_19_11_2025/MainWindow.xaml.cs`:

```csharp
// EN LA VENTANA HIJA / MODAL (DialogoArticuloWindow.xaml.cs):
public partial class DialogoArticuloWindow : Window
{
    public Articulo? NuevoArticulo { get; private set; }

    public DialogoArticuloWindow()
    {
        InitializeComponent();
    }

    private void BtnGuardar_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtModelo.Text))
        {
            MessageBox.Show("Completa los campos obligatorios.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        NuevoArticulo = new Articulo
        {
            NumSerie = txtSerie.Text.Trim(),
            Modelo = txtModelo.Text.Trim(),
            Departamento = cmbDepartamento.Text,
            Stock = (int)(numStock.Value ?? 0),
            Precio = numPrecio.Value ?? 0
        };

        // Cierra la ventana modal y devuelve 'true' al ShowDialog() de la ventana padre
        this.DialogResult = true;
    }

    private void BtnCancelar_Click(object sender, RoutedEventArgs e)
    {
        this.DialogResult = false;
    }
}

// EN LA VENTANA PRINCIPAL (MainWindow.xaml.cs):
private void BtnAbrirModal_Click(object sender, RoutedEventArgs e)
{
    var modal = new DialogoArticuloWindow { Owner = this };
    if (modal.ShowDialog() == true && modal.NuevoArticulo != null)
    {
        ListaArticulos.Add(modal.NuevoArticulo); // Se añade y refresca la tabla al instante
    }
}
```

---

### 5.2. Flujo Completo de Login a Ventana Principal y Cerrar Sesión (De `proyectoDefinitivo`)

```csharp
// 1. En PantallaLogin.xaml.cs (Botón Iniciar Sesión):
private void BtnLogin_Click(object sender, RoutedEventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtcorreo.Text) || string.IsNullOrWhiteSpace(passClaveAcceso.Password))
    {
        MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Warning);
        return;
    }

    var ventanaPrincipal = new MainWindow();
    Application.Current.MainWindow = ventanaPrincipal;
    ventanaPrincipal.Show();
    this.Close();
}

// 2. En MainWindow.xaml.cs (Botón / MenuItem Cerrar Sesión):
private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
{
    var login = new PantallaLogin();
    Application.Current.MainWindow = login;
    login.Show();
    this.Close();
}
```

---

### 5.3. Diálogos de Confirmación (`MessageBoxResult` y `ShowMessageAsync` de MahApps)

```csharp
// OPCIÓN A: Estándar WPF con confirmación Sí/No (Funciona en cualquier Window o MetroWindow)
private void BtnEliminarFila_Click(object sender, RoutedEventArgs e)
{
    if (sender is System.Windows.Controls.Button btn && btn.DataContext is Articulo articulo)
    {
        var resultado = MessageBox.Show(
            $"¿Seguro que deseas eliminar el artículo '{articulo.Modelo}'?",
            "Confirmar borrado",
            MessageBoxButton.YesNo,
            MessageBoxImage.Warning);

        if (resultado == MessageBoxResult.Yes)
        {
            ListaArticulos.Remove(articulo);
        }
    }
}

// OPCIÓN B: Diálogo integrado de MahApps.Metro (Solo si la ventana es <mah:MetroWindow>)
// Requiere: using MahApps.Metro.Controls.Dialogs;
private async void BtnConfirmarMahApps_Click(object sender, RoutedEventArgs e)
{
    MessageDialogResult res = await this.ShowMessageAsync(
        "Confirmación",
        "¿Deseas guardar los cambios realizados?",
        MessageDialogStyle.AffirmativeAndNegative);

    if (res == MessageDialogResult.Affirmative)
    {
        await this.ShowMessageAsync("Guardado", "Los datos se han registrado con éxito.");
    }
}
```

---

### 5.4. Validaciones de Formulario, `SelectionChanged` y Eventos Frecuentes

```csharp
// 1. EVENTO SELECTIONCHANGED: Cargar datos de la fila seleccionada en el formulario para editar
private void DgArticulos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
{
    if (dgArticulos.SelectedItem is Articulo seleccionado)
    {
        txtNombre.Text = seleccionado.Modelo;
        cmbCategoria.Text = seleccionado.Departamento;
        numPrecio.Value = seleccionado.Precio;
        chkActivo.IsChecked = seleccionado.Operativo;
    }
}

// 2. VALIDACIÓN COMPLETA ANTES DE GUARDAR
private bool ValidarCampos()
{
    // Validar TextBox vacío
    if (string.IsNullOrWhiteSpace(txtNombre.Text))
    {
        MessageBox.Show("El nombre es obligatorio.", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
        txtNombre.Focus();
        return false;
    }

    // Validar selección en ComboBox
    if (cmbCategoria.SelectedIndex < 0 && string.IsNullOrWhiteSpace(cmbCategoria.Text))
    {
        MessageBox.Show("Selecciona una categoría de la lista.", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
        return false;
    }

    // Validar DatePicker
    if (dpFechaAlta.SelectedDate == null)
    {
        MessageBox.Show("Selecciona una fecha de alta.", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
        return false;
    }

    // Validar RadioButton seleccionado
    string jornadaElegida = rbCompleta.IsChecked == true ? "Completa"
                          : rbParcial.IsChecked == true ? "Parcial" : "Teletrabajo";

    return true;
}

// 3. LIMPIAR FORMULARIO TRAS GUARDAR
private void LimpiarFormulario()
{
    txtNombre.Clear();
    passClave.Clear();
    cmbCategoria.SelectedIndex = -1;
    dpFechaAlta.SelectedDate = null;
    numPrecio.Value = 0;
    chkActivo.IsChecked = true;
    dgArticulos.SelectedItem = null;
}
```
