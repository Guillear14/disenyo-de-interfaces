# 📋 CHEAT SHEET DEFINITIVO - DISEÑO DE INTERFACES (DI) - DAM
> **Guía de Consulta Rápida para Exámenes Prácticos (WPF, XAML, C#, MahApps.Metro y Material Design)**  
> *Optimizado para búsqueda instantánea con `Ctrl + F` y snippets directos para copiar y pegar.*

---

## 📑 ÍNDICE INTERACTIVO

1. [Configuración Inicial: App.xaml y Namespaces](#1-configuración-inicial-appxaml-y-namespaces)
   - [Namespaces XAML Habituales](#namespaces-xaml-habituales)
   - [Configuración de App.xaml (Material Design + MahApps)](#configuración-de-appxaml-material-design--mahapps)
2. [Estructuración y Layouts (Contenedores)](#2-estructuración-y-layouts-contenedores)
   - [Grid (Filas, Columnas y Spanning)](#grid-filas-columnas-y-spanning)
   - [StackPanel (Vertical / Horizontal)](#stackpanel-vertical--horizontal)
   - [DockPanel (Acoplamiento a Bordes)](#dockpanel-acoplamiento-a-bordes)
   - [WrapPanel (Alineación Fluida)](#wrappanel-alineación-fluida)
   - [Canvas (Posicionamiento Absoluto)](#canvas-posicionamiento-absoluto)
   - [Border y Sombras (Efecto Tarjeta / Cristal)](#border-y-sombras-efecto-tarjeta--cristal)
   - [Viewbox (Diseño Responsivo / Escalado)](#viewbox-diseño-responsivo--escalado)
3. [Estructura de Ventana y Navegación](#3-estructura-de-ventana-y-navegación)
   - [Ventana Metro (MahApps MetroWindow)](#ventana-metro-mahapps-metrowindow)
   - [Ventana Sin Marco Personalizada (Custom Chrome + DragMove)](#ventana-sin-marco-personalizada-custom-chrome--dragmove)
   - [Diálogos Asíncronos (MahApps ShowMessageAsync)](#diálogos-asíncronos-mahapps-showmessageasync)
   - [Transición / Navegación entre Ventanas en C#](#transición--navegación-entre-ventanas-en-c)
4. [Menús, Barras y Organización de la Aplicación](#4-menús-barras-y-organización-de-la-aplicación)
   - [Barra de Menú (Menu y MenuItem con Iconos)](#barra-de-menú-menu-y-menuitem-con-iconos)
   - [Barra de Herramientas (ToolBarTray y ToolBar)](#barra-de-herramientas-toolbartray-y-toolbar)
   - [Menú Acordeón / Desplegable (Expander)](#menú-acordeón--desplegable-expander)
   - [Pestañas (TabControl y TabItem)](#pestañas-tabcontrol-y-tabitem)
   - [Menú Hamburguesa (MahApps HamburgerMenu)](#menú-hamburguesa-mahapps-hamburgermenu)
   - [Cinta de Opciones (Fluent Ribbon)](#cinta-de-opciones-fluent-ribbon)
5. [Controles de Formulario y Estilos Visuales](#5-controles-de-formulario-y-estilos-visuales)
   - [TextBox (Outlined, Floating Hint y Contador)](#textbox-outlined-floating-hint-y-contador)
   - [PasswordBox (Contraseña con Icono y Revelar)](#passwordbox-contraseña-con-icono-y-revelar)
   - [ComboBox (Desplegable)](#combobox-desplegable)
   - [DatePicker (Selector de Fecha)](#datepicker-selector-de-fecha)
   - [NumericUpDown (MahApps Control Numérico)](#numericupdown-mahapps-control-numérico)
   - [CheckBox y RadioButton](#checkbox-y-radiobutton)
   - [Botones Estilizados y Degradados](#botones-estilizados-y-degradados)
   - [Iconos Material Design (PackIcon)](#iconos-material-design-packicon)
6. [Data Binding y Enlace de Datos](#6-data-binding-y-enlace-de-datos)
   - [Binding entre Controles (ElementName)](#binding-entre-controles-elementname)
   - [Establecer DataContext (Code-Behind y XAML)](#establecer-datacontext-code-behind-y-xaml)
   - [Implementación de INotifyPropertyChanged](#implementación-de-inotifypropertychanged)
   - [Listas y DataGrid con ObservableCollection](#listas-y-datagrid-con-observablecollection)
7. [Recursos, Estilos y Triggers](#7-recursos-estilos-y-triggers)
   - [Definición de Recursos Locales vs Globales](#definición-de-recursos-locales-vs-globales)
   - [Estilos y Herencia (BasedOn)](#estilos-y-herencia-basedon)
   - [Triggers de Propiedad (Efecto Hover / Foco)](#triggers-de-propiedad-efecto-hover--foco)
   - [DataTriggers](#datatriggers)
8. [Tabla Resumen de Propiedades Clave](#8-tabla-resumen-de-propiedades-clave)
9. [Errores Comunes en Exámenes y Solución Rápida](#9-errores-comunes-en-exámenes-y-solución-rápida)

---

## 1. CONFIGURACIÓN INICIAL: APP.XAML Y NAMESPACES

### Namespaces XAML Habituales
Copia los que necesites en la etiqueta raíz (`<Window>` o `<mah:MetroWindow>`):

```xml
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
xmlns:local="clr-namespace:MiProyecto"
<!-- Librería Material Design -->
xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
<!-- Librería MahApps.Metro -->
xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
<!-- Librería Fluent Ribbon (si se usa cinta Office) -->
xmlns:Fluent="urn:fluent-ribbon"
mc:Ignorable="d"
```

---

### Configuración de App.xaml (Material Design + MahApps)
Estructura lista para combinar **Material Design** y los estilos de **MahApps.Metro**:

```xml
<Application x:Class="MiProyecto.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- Tema Base y Paleta Material Design -->
                <mat:BundledTheme BaseTheme="Light" PrimaryColor="DeepPurple" SecondaryColor="Amber" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />

                <!-- Diccionarios de MahApps.Metro (¡Cuidado: Case-Sensitive!) -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

---

## 2. ESTRUCTURACIÓN Y LAYOUTS (CONTENEDORES)

### Grid (Filas, Columnas y Spanning)
El layout más versátil. Tamaños: `Auto` (se ajusta al contenido), `*` (proporcional), `100` (fijo en px).

```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />  <!-- Encabezado -->
        <RowDefinition Height="*" />     <!-- Contenido principal expansible -->
        <RowDefinition Height="50" />    <!-- Barra inferior fija -->
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="200" /> <!-- Barra lateral fija -->
        <ColumnDefinition Width="*" />   <!-- Columna principal -->
        <ColumnDefinition Width="2*" />  <!-- Columna el doble de ancha -->
    </Grid.ColumnDefinitions>

    <!-- Posicionamiento con propiedades adjuntas (índice 0-based) -->
    <TextBlock Grid.Row="0" Grid.Column="0" Text="Título" />
    <!-- Ocupar múltiples filas o columnas -->
    <Button Grid.Row="1" Grid.Column="0" Grid.ColumnSpan="2" Content="Botón Ancho" />
</Grid>
```

---

### StackPanel (Vertical / Horizontal)
Apila elementos de forma consecutiva. No usar cuando se requiera reescalado proporcional complejo.

```xml
<!-- Apilado vertical por defecto -->
<StackPanel Orientation="Vertical" Margin="10">
    <TextBlock Text="Usuario:" Margin="0,0,0,5" />
    <TextBox Margin="0,0,0,10" />
    
    <!-- Apilado horizontal para botones en línea -->
    <StackPanel Orientation="Horizontal" HorizontalAlignment="Right">
        <Button Content="Cancelar" Margin="0,0,10,0" Width="80" />
        <Button Content="Aceptar" Width="80" />
    </StackPanel>
</StackPanel>
```

---

### DockPanel (Acoplamiento a Bordes)
Ideal para ventanas tipo IDE/ERP con menús superiores, barras de estado inferiores y paneles laterales.

```xml
<!-- LastChildFill="True" hace que el último control ocupe todo el espacio sobrante -->
<DockPanel LastChildFill="True">
    <Menu DockPanel.Dock="Top"> ... </Menu>
    <StatusBar DockPanel.Dock="Bottom"> ... </StatusBar>
    <StackPanel DockPanel.Dock="Left" Width="180" Background="#F0F0F0"> ... </StackPanel>
    
    <!-- Este control central llenará el espacio restante automáticamente -->
    <Grid Background="White">
        <TextBlock Text="Área de trabajo" HorizontalAlignment="Center" VerticalAlignment="Center" />
    </Grid>
</DockPanel>
```

---

### WrapPanel (Alineación Fluida)
Coloca los elementos en línea y salta automáticamente a la siguiente cuando no caben (tarjetas, catálogos).

```xml
<WrapPanel Orientation="Horizontal" ItemWidth="120" ItemHeight="100">
    <Button Content="Item 1" Margin="5" />
    <Button Content="Item 2" Margin="5" />
    <Button Content="Item 3" Margin="5" />
    <Button Content="Item 4" Margin="5" />
</WrapPanel>
```

---

### Canvas (Posicionamiento Absoluto)
Posiciona elementos mediante coordenadas fijas `Top`, `Bottom`, `Left`, `Right`. No recomendado para interfaces adaptables salvo esquemas o dibujos.

```xml
<Canvas Width="300" Height="200" Background="#EAEAEA">
    <Button Canvas.Left="20" Canvas.Top="30" Content="En (20, 30)" />
    <TextBlock Canvas.Right="10" Canvas.Bottom="10" Text="Esquina inferior" />
</Canvas>
```

---

### Border y Sombras (Efecto Tarjeta / Cristal)
Permite redondear esquinas, añadir bordes de color y sombras `DropShadowEffect`.

```xml
<Border Width="350" Height="220"
        Background="#FFFFFF"
        BorderBrush="#DDDDDD"
        BorderThickness="1"
        CornerRadius="12"
        Padding="20">
    <Border.Effect>
        <DropShadowEffect BlurRadius="20" ShadowDepth="4" Direction="270" Color="Black" Opacity="0.2" />
    </Border.Effect>
    
    <TextBlock Text="Contenido dentro de la tarjeta" VerticalAlignment="Center" HorizontalAlignment="Center" />
</Border>
```

---

### Viewbox (Diseño Responsivo / Escalado)
Escala todo su contenido manteniendo la proporción independientemente del tamaño de la ventana.

```xml
<!-- Stretch="Uniform": Mantiene proporción sin deformar -->
<!-- StretchDirection="DownOnly": Evita que se pixele o crezca en exceso en resoluciones altas -->
<Viewbox Stretch="Uniform" StretchDirection="DownOnly" Margin="20">
    <Border Width="600" Height="400" Background="White">
        <!-- Contenido que escala proporcionalmente -->
    </Border>
</Viewbox>
```

---

## 3. ESTRUCTURA DE VENTANA Y NAVEGACIÓN

### Ventana Metro (MahApps MetroWindow)
Ventana moderna con barra de título integrada y comandos personalizados.

#### XAML:
```xml
<mah:MetroWindow x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        Title="GESTIÓN MATISSE" Height="500" Width="800"
        WindowStartupLocation="CenterScreen">

    <!-- Botones rápidos en la barra de título superior derecha -->
    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands ShowSeparators="True">
            <Button ToolTip="Perfil de usuario">
                <mat:PackIcon Kind="Account" Width="20" Height="20" Foreground="White" />
            </Button>
            <Button ToolTip="Cerrar Sesión" Click="BtnSalir_Click">
                <mat:PackIcon Kind="Logout" Width="20" Height="20" Foreground="White" />
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <Grid>
        <!-- Contenido principal -->
    </Grid>
</mah:MetroWindow>
```

#### Code-Behind (`MainWindow.xaml.cs`):
```csharp
using MahApps.Metro.Controls;
using System.Windows;

namespace MiProyecto
{
    // ¡IMPORTANTE!: Debe heredar de MetroWindow tanto en XAML como en C#
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

### Ventana Sin Marco Personalizada (Custom Chrome + DragMove)
Para ventanas modernas sin la barra clásica del sistema operativo (estilo login Matisse).

#### XAML:
```xml
<Window x:Class="MiProyecto.LoginView"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        WindowStyle="None"
        ResizeMode="NoResize"
        AllowsTransparency="True"
        Background="Transparent"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Height="450" Width="400">
    
    <Border Background="#1E1E1E" CornerRadius="15" Padding="20">
        <Grid>
            <!-- Botón de cierre en esquina superior derecha -->
            <Button Content="✕" Width="30" Height="30" 
                    HorizontalAlignment="Right" VerticalAlignment="Top"
                    Background="Transparent" Foreground="White" BorderThickness="0"
                    Click="BtnCerrar_Click" />
            
            <TextBlock Text="INICIAR SESIÓN" Foreground="White" FontSize="18" 
                       HorizontalAlignment="Center" Margin="0,30,0,0" />
        </Grid>
    </Border>
</Window>
```

#### Code-Behind (`LoginView.xaml.cs`):
```csharp
using System.Windows;
using System.Windows.Input;

namespace MiProyecto
{
    public partial class LoginView : Window
    {
        public LoginView() => InitializeComponent();

        // Permite arrastrar la ventana manteniendo presionado el botón izquierdo
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void BtnMinimizar_Click(object sender, RoutedEventArgs e) =>
            this.WindowState = WindowState.Minimized;

        private void BtnCerrar_Click(object sender, RoutedEventArgs e) =>
            this.Close();
    }
}
```

---

### Diálogos Asíncronos (MahApps ShowMessageAsync)
Muestra modales modernos dentro de una `MetroWindow` sin abrir ventanas emergentes secundarias.

```csharp
using MahApps.Metro.Controls.Dialogs;

private async void BtnValidar_Click(object sender, RoutedEventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtEmail.Text))
    {
        // Requiere async en la firma del método
        await this.ShowMessageAsync("Error de Validación", "El correo no puede estar vacío.");
        return;
    }

    MessageDialogResult respuesta = await this.ShowMessageAsync(
        "Confirmación", 
        "¿Desea guardar los cambios?", 
        MessageDialogStyle.AffirmativeAndNegative);

    if (respuesta == MessageDialogResult.Affirmative)
    {
        // Acción confirmada
    }
}
```

---

### Transición / Navegación entre Ventanas en C#
```csharp
private void BtnLogin_Click(object sender, RoutedEventArgs e)
{
    // 1. Instanciar nueva ventana
    MainWindow principal = new MainWindow();
    
    // 2. Mostrar la ventana destino
    principal.Show();
    
    // 3. Cerrar la ventana actual
    this.Close();
}
```

---

## 4. MENÚS, BARRAS Y ORGANIZACIÓN DE LA APLICACIÓN

### Barra de Menú (Menu y MenuItem con Iconos)
```xml
<Menu IsMainMenu="True" Background="#F5F5F5">
    <MenuItem Header="_Archivo">
        <MenuItem Header="_Nuevo" Click="MenuNuevo_Click" InputGestureText="Ctrl+N">
            <MenuItem.Icon>
                <mat:PackIcon Kind="FilePlusOutline" />
            </MenuItem.Icon>
        </MenuItem>
        <MenuItem Header="_Guardar" Click="MenuGuardar_Click">
            <MenuItem.Icon>
                <mat:PackIcon Kind="ContentSaveOutline" />
            </MenuItem.Icon>
        </MenuItem>
        <Separator />
        <MenuItem Header="_Salir" Click="MenuSalir_Click" />
    </MenuItem>
    
    <MenuItem Header="_Gestión">
        <MenuItem Header="Artículos" Click="AbrirArticulos_Click" />
        <MenuItem Header="Clientes" Click="AbrirClientes_Click" />
    </MenuItem>
</Menu>
```

---

### Barra de Herramientas (ToolBarTray y ToolBar)
```xml
<ToolBarTray DockPanel.Dock="Top">
    <ToolBar Band="0" BandIndex="0">
        <Button ToolTip="Crear nuevo registro" Click="MenuNuevo_Click">
            <mat:PackIcon Kind="PlusBox" Width="20" Height="20" />
        </Button>
        <Button ToolTip="Guardar cambios" Click="MenuGuardar_Click">
            <mat:PackIcon Kind="ContentSave" Width="20" Height="20" />
        </Button>
        <Separator />
        <Button ToolTip="Eliminar seleccionado">
            <mat:PackIcon Kind="TrashCan" Width="20" Height="20" Foreground="Red" />
        </Button>
    </ToolBar>
</ToolBarTray>
```

---

### Menú Acordeón / Desplegable (Expander)
Ideal para barras laterales con submenús replegables.

```xml
<StackPanel Width="220" Background="#2D2D30">
    <Expander Header="Administración" 
              IsExpanded="False" 
              Foreground="White"
              Style="{StaticResource MaterialDesignExpander}">
        <StackPanel Background="#1E1E1E">
            <Button Content="Usuarios" Foreground="White" Style="{StaticResource MaterialDesignFlatButton}" HorizontalAlignment="Left" Margin="20,0,0,0" />
            <Button Content="Roles" Foreground="White" Style="{StaticResource MaterialDesignFlatButton}" HorizontalAlignment="Left" Margin="20,0,0,0" />
        </StackPanel>
    </Expander>

    <Expander Header="Inventario" IsExpanded="True" Foreground="White">
        <StackPanel Background="#1E1E1E">
            <Button Content="Entradas" Foreground="White" Style="{StaticResource MaterialDesignFlatButton}" HorizontalAlignment="Left" Margin="20,0,0,0" />
            <Button Content="Salidas" Foreground="White" Style="{StaticResource MaterialDesignFlatButton}" HorizontalAlignment="Left" Margin="20,0,0,0" />
        </StackPanel>
    </Expander>
</StackPanel>
```

---

### Pestañas (TabControl y TabItem)
```xml
<TabControl Style="{StaticResource MaterialDesignNavigationRailTabControl}">
    <TabItem Header="Datos Generales">
        <StackPanel Margin="15">
            <TextBlock Text="Formulario General" />
        </StackPanel>
    </TabItem>
    <TabItem Header="Configuración">
        <StackPanel Margin="15">
            <TextBlock Text="Opciones avanzadas" />
        </StackPanel>
    </TabItem>
</TabControl>
```

---

### Menú Hamburguesa (MahApps HamburgerMenu)
Crea una barra de navegación lateral con soporte para iconos y templates personalizados.

```xml
<mah:MetroWindow.Resources>
    <!-- Template para cada ítem del menú lateral -->
    <DataTemplate x:Key="HamburgerItemTemplate" DataType="{x:Type mah:HamburgerMenuIconItem}">
        <Grid Height="48">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="48" />
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>
            <ContentControl Grid.Column="0" Content="{Binding Icon}" HorizontalAlignment="Center" VerticalAlignment="Center" />
            <TextBlock Grid.Column="1" Text="{Binding Label}" VerticalAlignment="Center" FontSize="15" />
        </Grid>
    </DataTemplate>
</mah:MetroWindow.Resources>

<mah:HamburgerMenu x:Name="MenuLateral"
                   DisplayMode="CompactInline"
                   ItemTemplate="{StaticResource HamburgerItemTemplate}"
                   OptionsItemTemplate="{StaticResource HamburgerItemTemplate}">
    <!-- Botones principales arriba -->
    <mah:HamburgerMenu.ItemsSource>
        <mah:HamburgerMenuItemCollection>
            <mah:HamburgerMenuIconItem Label="Inicio" Icon="{mat:PackIcon Kind=Home}" />
            <mah:HamburgerMenuIconItem Label="Artículos" Icon="{mat:PackIcon Kind=PackageVariant}" />
            <mah:HamburgerMenuIconItem Label="Préstamos" Icon="{mat:PackIcon Kind=BookSync}" />
        </mah:HamburgerMenuItemCollection>
    </mah:HamburgerMenu.ItemsSource>
    
    <!-- Botones secundarios abajo (opciones / perfil) -->
    <mah:HamburgerMenu.OptionsItemsSource>
        <mah:HamburgerMenuItemCollection>
            <mah:HamburgerMenuIconItem Label="Ajustes" Icon="{mat:PackIcon Kind=Cog}" />
        </mah:HamburgerMenuItemCollection>
    </mah:HamburgerMenu.OptionsItemsSource>
</mah:HamburgerMenu>
```

---

### Cinta de Opciones (Fluent Ribbon)
```xml
<Fluent:Ribbon>
    <!-- Menú Backstage (Botón Archivo de Office) -->
    <Fluent:Ribbon.Menu>
        <Fluent:Backstage>
            <Fluent:BackstageTabControl>
                <Fluent:BackstageTabItem Header="Información" />
                <Fluent:Button Header="Cerrar Aplicación" Click="BtnSalir_Click" />
            </Fluent:BackstageTabControl>
        </Fluent:Backstage>
    </Fluent:Ribbon.Menu>

    <!-- Pestaña 1 -->
    <Fluent:RibbonTabItem Header="Operaciones">
        <Fluent:RibbonGroupBox Header="Préstamos">
            <Fluent:Button Header="Nueva Salida" Icon="Recursos/Iconos/salida.png" />
            <Fluent:Button Header="Devolución" Icon="Recursos/Iconos/entrada.png" />
        </Fluent:RibbonGroupBox>
    </Fluent:RibbonTabItem>
</Fluent:Ribbon>
```

---

## 5. CONTROLES DE FORMULARIO Y ESTILOS VISUALES

### TextBox (Outlined, Floating Hint y Contador)
```xml
<!-- TextBox Outlined con etiqueta flotante e icono embebido -->
<TextBox x:Name="txtNombre"
         Style="{StaticResource MaterialDesignOutlinedTextBox}"
         mat:HintAssist.Hint="Nombre completo *"
         mat:TextFieldAssist.TextFieldCornerRadius="10"
         mat:TextFieldAssist.HasClearButton="True"
         MaxLength="50"
         Margin="0,0,0,15"
         FontSize="14">
    <!-- Icono dentro del campo -->
    <mat:HintAssist.Hint>
        <StackPanel Orientation="Horizontal">
            <mat:PackIcon Kind="Account" Margin="0,0,6,0" VerticalAlignment="Center" />
            <TextBlock Text="Nombre completo *" VerticalAlignment="Center" />
        </StackPanel>
    </mat:HintAssist.Hint>
</TextBox>

<!-- Contador manual de caracteres (si se pide en el ejercicio) -->
<TextBlock Text="{Binding ElementName=txtNombre, Path=Text.Length, StringFormat='{}{0} / 50'}"
           HorizontalAlignment="Right" FontSize="11" Foreground="Gray" Margin="0,-10,5,10" />
```

---

### PasswordBox (Contraseña con Icono y Revelar)
```xml
<PasswordBox x:Name="passClave"
             Style="{StaticResource MaterialDesignOutlinedPasswordBox}"
             mat:TextFieldAssist.TextFieldCornerRadius="10"
             mat:PasswordBoxAssist.IsPasswordRevealed="False"
             FontSize="14"
             Margin="0,0,0,15">
    <mat:HintAssist.Hint>
        <StackPanel Orientation="Horizontal">
            <mat:PackIcon Kind="LockOutline" Margin="0,0,6,0" VerticalAlignment="Center" />
            <TextBlock Text="Contraseña *" VerticalAlignment="Center" />
        </StackPanel>
    </mat:HintAssist.Hint>
</PasswordBox>
```

> **Truco C#**: En el code-behind, se accede al valor mediante `passClave.Password` (no `.Text`).

---

### ComboBox (Desplegable)
```xml
<ComboBox x:Name="cbCategoria"
          Style="{StaticResource MaterialDesignFloatingHintComboBox}"
          mat:HintAssist.Hint="Seleccione Categoría *"
          FontSize="14" Margin="0,0,0,15">
    <ComboBoxItem Content="Electrónica" IsSelected="True" />
    <ComboBoxItem Content="Mobiliario" />
    <ComboBoxItem Content="Material de Oficina" />
</ComboBox>
```

---

### DatePicker (Selector de Fecha)
```xml
<DatePicker x:Name="dpFechaAlta"
            Style="{StaticResource MaterialDesignFloatingHintDatePicker}"
            mat:HintAssist.Hint="Fecha de Alta"
            SelectedDateFormat="Short"
            FontSize="14" Margin="0,0,0,15" />
```

---

### NumericUpDown (MahApps Control Numérico)
Control numérico para evitar validar texto manualmente.

```xml
<!-- Permite incrementos, valores decimales y formatos de moneda -->
<mah:NumericUpDown x:Name="numCredito"
                   Minimum="0"
                   Maximum="100000"
                   Value="1000.00"
                   Interval="100.00"
                   StringFormat="{}{0:N2} €"
                   FontSize="14"
                   Margin="0,0,0,15" />
```

---

### CheckBox y RadioButton
```xml
<!-- CheckBox Material Design -->
<CheckBox x:Name="chkRecordar" Content="Recordar credenciales"
          IsChecked="True" Margin="0,0,0,15" />

<!-- RadioButtons agrupados -->
<StackPanel Orientation="Horizontal" Margin="0,0,0,15">
    <RadioButton GroupName="TipoUsuario" Content="Estudiante" IsChecked="True" Margin="0,0,20,0" />
    <RadioButton GroupName="TipoUsuario" Content="Profesor" />
</StackPanel>
```

---

### Botones Estilizados y Degradados
```xml
<!-- Botón Material Design con esquinas redondeadas -->
<Button Content="GUARDAR"
        Style="{StaticResource MaterialDesignRaisedButton}"
        mat:ButtonAssist.CornerRadius="20"
        Height="42" FontSize="15" FontWeight="Bold"
        Click="BtnGuardar_Click" />

<!-- Botón con Degradado Lineal Personalizado -->
<Button Content="ACCEDER" Height="45" Foreground="White" FontWeight="Bold" Click="BtnLogin_Click">
    <Button.Background>
        <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
            <GradientStop Color="#D14235" Offset="0.0"/> <!-- Rojo oscuro -->
            <GradientStop Color="#EB8643" Offset="1.0"/> <!-- Naranja -->
        </LinearGradientBrush>
    </Button.Background>
</Button>
```

---

### Iconos Material Design (PackIcon)
```xml
<!-- Icono simple -->
<mat:PackIcon Kind="Account" Width="24" Height="24" Foreground="#333333" />

<!-- Icono dentro de un botón -->
<Button Style="{StaticResource MaterialDesignOutlinedButton}">
    <StackPanel Orientation="Horizontal">
        <mat:PackIcon Kind="PlusCircle" VerticalAlignment="Center" Margin="0,0,8,0" />
        <TextBlock Text="Añadir Elemento" VerticalAlignment="Center" />
    </StackPanel>
</Button>
```

---

## 6. DATA BINDING Y ENLACE DE DATOS

### Binding entre Controles (ElementName)
Enlaza propiedades de controles visuales sin tocar una sola línea de C#.

```xml
<!-- Slider que controla el tamaño de un texto -->
<Slider x:Name="sldZoom" Minimum="10" Maximum="40" Value="14" />
<TextBlock Text="Texto que escala" FontSize="{Binding ElementName=sldZoom, Path=Value}" />

<!-- CheckBox que habilita o deshabilita un botón -->
<CheckBox x:Name="chkAcepto" Content="Acepto los términos y condiciones" />
<Button Content="Registrarme" IsEnabled="{Binding ElementName=chkAcepto, Path=IsChecked}" />

<!-- Espejo de texto en tiempo real -->
<TextBox x:Name="txtOriginal" />
<TextBlock Text="{Binding ElementName=txtOriginal, Path=Text}" />
```

---

### Establecer DataContext (Code-Behind y XAML)
El `DataContext` indica de dónde sacará el XAML las propiedades enlazadas con `{Binding}`.

#### En Code-Behind (Forma más rápida en examen):
```csharp
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Vincula los bindings de este XAML a las propiedades públicas de esta misma clase
        this.DataContext = this;
    }
    
    public string TituloApp { get; set; } = "Mi Inventario";
}
```

---

### Implementación de INotifyPropertyChanged
Obligatorio para que la interfaz se actualice cuando cambie el valor de una variable en C#.

```csharp
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ArticuloViewModel : INotifyPropertyChanged
{
    private string _nombre;
    private double _precio;

    public string Nombre
    {
        get => _nombre;
        set
        {
            if (_nombre != value)
            {
                _nombre = value;
                OnPropertyChanged(); // Notifica a la vista
            }
        }
    }

    public double Precio
    {
        get => _precio;
        set
        {
            if (_precio != value)
            {
                _precio = value;
                OnPropertyChanged();
            }
        }
    }

    // Evento obligatorio de la interfaz
    public event PropertyChangedEventHandler PropertyChanged;
    
    // Método auxiliar (CallerMemberName asigna el nombre de la propiedad automáticamente)
    protected void OnPropertyChanged([CallerMemberName] string nombrePropiedad = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
    }
}
```

#### Enlace en XAML:
```xml
<!-- UpdateSourceTrigger=PropertyChanged: Actualiza el objeto inmediatamente al teclear -->
<TextBox Text="{Binding Nombre, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" />
<TextBlock Text="{Binding Precio, StringFormat='Precio: {0:C}'}" />
```

---

### Listas y DataGrid con ObservableCollection

#### 1. Definición en C#:
```csharp
using System.Collections.ObjectModel;

public partial class MainWindow : Window
{
    // ObservableCollection notifica a la UI cuando se añade o elimina un elemento
    public ObservableCollection<Producto> ListaProductos { get; set; } = new ObservableCollection<Producto>();

    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;

        // Datos de prueba iniciales
        ListaProductos.Add(new Producto { Id = 1, Nombre = "Monitor 24\"", Stock = 15 });
        ListaProductos.Add(new Producto { Id = 2, Nombre = "Teclado Mecánico", Stock = 30 });
    }

    private void BtnNuevo_Click(object sender, RoutedEventArgs e)
    {
        ListaProductos.Add(new Producto { Id = 3, Nombre = "Ratón USB", Stock = 50 });
    }
}

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Stock { get; set; }
}
```

#### 2. XAML para DataGrid:
```xml
<DataGrid ItemsSource="{Binding ListaProductos}" 
          AutoGenerateColumns="False" 
          CanUserAddRows="False"
          IsReadOnly="True"
          SelectionMode="Single"
          Margin="10">
    <DataGrid.Columns>
        <DataGridTextColumn Header="Código" Binding="{Binding Id}" Width="80" />
        <DataGridTextColumn Header="Descripción" Binding="{Binding Nombre}" Width="*" />
        <DataGridTextColumn Header="Stock Actual" Binding="{Binding Stock}" Width="100" />
    </DataGrid.Columns>
</DataGrid>
```

#### 3. XAML para ListView con ItemTemplate:
```xml
<ListView ItemsSource="{Binding ListaProductos}">
    <ListView.ItemTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal" Margin="5">
                <mat:PackIcon Kind="PackageVariant" VerticalAlignment="Center" Margin="0,0,10,0" />
                <TextBlock Text="{Binding Nombre}" FontWeight="Bold" VerticalAlignment="Center" Margin="0,0,10,0" />
                <TextBlock Text="{Binding Stock, StringFormat='({0} uds)'}" Foreground="Gray" VerticalAlignment="Center" />
            </StackPanel>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

---

## 7. RECURSOS, ESTILOS Y TRIGGERS

### Definición de Recursos Locales vs Globales

#### Nivel Ventana (`Window.Resources`):
```xml
<Window.Resources>
    <!-- Brochas de color reutilizables -->
    <SolidColorBrush x:Key="ColorPrimario" Color="#E5302E" />
    <SolidColorBrush x:Key="ColorSecundario" Color="#333333" />
</Window.Resources>

<!-- Uso: -->
<Button Background="{StaticResource ColorPrimario}" Foreground="White" />
```

> **StaticResource vs DynamicResource**:
> - `StaticResource`: Se evalúa una sola vez en tiempo de carga. Más rápido. Usar por defecto.
> - `DynamicResource`: Se reevalúa si el recurso cambia en tiempo de ejecución (ej. cambio de tema claro/oscuro en caliente).

---

### Estilos y Herencia (BasedOn)
```xml
<Window.Resources>
    <!-- Estilo base para todos los botones del formulario -->
    <Style x:Key="BotonFormulario" TargetType="Button">
        <Setter Property="Height" Value="38" />
        <Setter Property="Width" Value="120" />
        <Setter Property="FontWeight" Value="SemiBold" />
        <Setter Property="Margin" Value="5" />
    </Style>

    <!-- Estilo derivado (Hereda propiedades del anterior) -->
    <Style x:Key="BotonPeligro" TargetType="Button" BasedOn="{StaticResource BotonFormulario}">
        <Setter Property="Background" Value="#D32F2F" />
        <Setter Property="Foreground" Value="White" />
    </Style>
</Window.Resources>

<Button Style="{StaticResource BotonPeligro}" Content="Eliminar" />
```

---

### Triggers de Propiedad (Efecto Hover / Foco)
```xml
<Style TargetType="TextBox" BasedOn="{StaticResource MaterialDesignOutlinedTextBox}">
    <Setter Property="Background" Value="#F8F9FA" />
    <Setter Property="BorderBrush" Value="#CCCCCC" />
    <Style.Triggers>
        <!-- Cuando el ratón está encima -->
        <Trigger Property="IsMouseOver" Value="True">
            <Setter Property="BorderBrush" Value="#E5302E" />
        </Trigger>
        <!-- Cuando el campo tiene el foco de teclado -->
        <Trigger Property="IsKeyboardFocused" Value="True">
            <Setter Property="Background" Value="#FFFFFF" />
            <Setter Property="BorderBrush" Value="#E5302E" />
        </Trigger>
    </Style.Triggers>
</Style>
```

---

### DataTriggers
Cambia propiedades visuales según el valor de un dato enlazado.

```xml
<Style TargetType="TextBlock">
    <Style.Triggers>
        <!-- Si el stock es 0, pinta el texto en rojo y negrita -->
        <DataTrigger Binding="{Binding Stock}" Value="0">
            <Setter Property="Foreground" Value="Red" />
            <Setter Property="FontWeight" Value="Bold" />
        </DataTrigger>
    </Style.Triggers>
</Style>
```

---

## 8. TABLA RESUMEN DE PROPIEDADES CLAVE

| Propiedad | Tipo / Sintaxis | Aplica a | Descripción rápida |
| :--- | :--- | :--- | :--- |
| **`Margin`** | `"10"` (todos) / `"10,5"` (X, Y) / `"10,5,10,5"` (izq, arr, der, abj) | Todos (`FrameworkElement`) | Espacio exterior que separa el control de los demás |
| **`Padding`** | Mismo formato que Margin | Contenedores, Border, Button, TextBox | Espacio interior entre el borde del control y su contenido |
| **`HorizontalAlignment`** | `Left`, `Center`, `Right`, `Stretch` | Todos | Alineación horizontal en su celda o contenedor padre |
| **`VerticalAlignment`** | `Top`, `Center`, `Bottom`, `Stretch` | Todos | Alineación vertical en su celda o contenedor padre |
| **`Grid.Row` / `Grid.Column`** | Número entero (0, 1, 2...) | Hijos directos de un `Grid` | Índice (0-based) de la fila / columna donde se coloca |
| **`Grid.RowSpan` / `ColumnSpan`** | Número entero (2, 3...) | Hijos directos de un `Grid` | Cantidad de filas o columnas que abarca el control |
| **`DockPanel.Dock`** | `Top`, `Bottom`, `Left`, `Right` | Hijos directos de `DockPanel` | Lado de la pantalla al que se ancla el elemento |
| **`Visibility`** | `Visible`, `Collapsed`, `Hidden` | Todos | `Collapsed` (oculto y no ocupa espacio), `Hidden` (oculto pero reserva el espacio) |
| **`IsEnabled`** | `True` / `False` | Todos | Habilita o deshabilita la interacción con el control |
| **`IsReadOnly`** | `True` / `False` | TextBox, DataGrid | Permite ver y seleccionar el texto pero no modificarlo |
| **`DataContext`** | Objeto C# o `{Binding ...}` | Ventanas, Contenedores | Origen de datos para todos los bindings hijos |
| **`ItemsSource`** | Colección (`ObservableCollection<T>`) | ComboBox, ListBox, ListView, DataGrid | Lista de datos que alimenta al control repetitivo |
| **`SelectedItem`** | `{Binding ObjetoSeleccionado}` | ComboBox, ListView, DataGrid | Elemento completo seleccionado por el usuario |
| **`CornerRadius`** | `"10"` o `"10,10,0,0"` | `Border`, `ButtonAssist` | Radio de curvatura de las esquinas |
| **`WindowStartupLocation`**| `CenterScreen`, `Manual`, `CenterOwner`| `Window`, `MetroWindow` | Posición inicial de apertura de la ventana |
| **`ResizeMode`** | `NoResize`, `CanResize`, `CanMinimize` | `Window`, `MetroWindow` | Controla si el usuario puede redimensionar la ventana |
| **`WindowStyle`** | `None`, `SingleBorderWindow` | `Window` | `None` elimina la barra superior y marcos estándar de Windows |

---

## 9. ERRORES COMUNES EN EXÁMENES Y SOLUCIÓN RÁPIDA

### 1. "The name 'MetroWindow' does not exist in the namespace '...'"
- **Causa**: Falta el namespace XAML o la herencia en C# no coincide.
- **Solución**:
  1. En el XAML añade: `xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"`.
  2. En el archivo `.xaml.cs`, asegúrate de heredar de `MetroWindow`:
     ```csharp
     public partial class MainWindow : MetroWindow // ¡NO debe decir : Window!
     ```

### 2. "ResourceDictionary no encuentra el recurso MaterialDesign / MahApps"
- **Causa**: Sintaxis o mayúsculas incorrectas en `App.xaml` (los pack URIs son sensibles a mayúsculas/minúsculas).
- **Solución**: Copia exactamente las rutas canónicas:
  ```xml
  <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />
  <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
  ```

### 3. "El Binding no actualiza la interfaz al cambiar la propiedad en C#"
- **Causa 1**: La clase no implementa `INotifyPropertyChanged` o no se llama a `OnPropertyChanged()`.
- **Causa 2**: Se olvidó establecer el DataContext (`this.DataContext = this;` en el constructor de la ventana).
- **Causa 3**: Si es un TextBox, por defecto solo actualiza al perder el foco (`LostFocus`). Agrega `UpdateSourceTrigger=PropertyChanged`:
  ```xml
  <TextBox Text="{Binding MiPropiedad, UpdateSourceTrigger=PropertyChanged}" />
  ```

### 4. "InvalidOperationException: DragMove solo se puede llamar cuando el botón izquierdo del ratón está presionado"
- **Causa**: Llamar a `DragMove()` en un evento `MouseDown` general sin validar qué botón se pulsó.
- **Solución**:
  ```csharp
  private void Window_MouseDown(object sender, MouseButtonEventArgs e)
  {
      if (e.ChangedButton == MouseButton.Left)
          this.DragMove();
  }
  ```

### 5. "Las imágenes no se muestran en tiempo de ejecución"
- **Causa**: La ruta relativa no coincide o la acción de compilación no es `Resource`.
- **Solución**:
  1. Usa barras inclinadas hacia adelante: `Source="/Recursos/Imagenes/foto.png"`.
  2. En las propiedades del archivo en Visual Studio, comprueba que **Acción de compilación (Build Action)** sea **Resource** o **Content** con **Copy if newer**.

### 6. "ShowMessageAsync no compila en el Code-Behind"
- **Causa**: Falta el `using` de MahApps Dialogs o el manejador de eventos no tiene el modificador `async`.
- **Solución**:
  ```csharp
  using MahApps.Metro.Controls.Dialogs; // <- Añadir using arriba

  private async void Btn_Click(object sender, RoutedEventArgs e) // <- Añadir async
  {
      await this.ShowMessageAsync("Título", "Mensaje");
  }
  ```

### 7. "DataGrid no muestra filas al añadir elementos con .Add()"
- **Causa**: Se utilizó una lista estándar `List<T>` en vez de `ObservableCollection<T>`.
- **Solución**: Cambia la propiedad a `public ObservableCollection<MiModelo> Lista { get; set; } = new();`. `List<T>` no emite notificaciones de cambio a la interfaz cuando se agregan o quitan filas.
