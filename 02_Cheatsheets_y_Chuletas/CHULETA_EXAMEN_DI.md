# 🚀 CHULETA DEFINITIVA DE EXAMEN: DISEÑO DE INTERFACES (C# + WPF)

> **Modo de uso rápido (`Ctrl + F`):** Usa las palabras clave entre paréntesis del índice o busca directamente nombres de controles (`DataGrid`, `ComboBox`, `MetroWindow`, `PackIcon`, `Trigger`, `ShowDialog`, `MessageBox`, `INotifyPropertyChanged`).

---

## 📑 Índice Navegable

1. [Configuración Inicial Rápida (`App.xaml` y Paquetes)](#1-configuración-inicial-rápida-appxaml-y-paquetes)
   - [1.1. Paquetes NuGet habituales (`.csproj`)](#11-paquetes-nuget-habituales-csproj)
   - [1.2. `App.xaml` Completo (MahApps.Metro + MaterialDesign + Fluent)](#12-appxaml-completo-mahappsmetro--materialdesign--fluent)
   - [1.3. Cabeceras y Namespaces (`xmlns`) para `Window`, `MetroWindow` y `UserControl`](#13-cabeceras-y-namespaces-xmlns-para-window-metrowindow-y-usercontrol)
2. [Layouts y Contenedores Esenciales (XAML Limpio)](#2-layouts-y-contenedores-esenciales-xaml-limpio)
   - [2.1. `Grid` (Filas, Columnas, `*`, `Auto`, `Span`)](#21-grid-filas-columnas--auto-span)
   - [2.2. `DockPanel` (Menú superior + Lateral + Contenido central)](#22-dockpanel-menú-superior--lateral--contenido-central)
   - [2.3. `StackPanel`, `WrapPanel`, `UniformGrid` y `Viewbox`](#23-stackpanel-wrappanel-uniformgrid-y-viewbox)
   - [2.4. Controles de Navegación del Repo (`Menu`, `ToolBar`, `Expander`, `HamburgerMenu`, `Fluent:Ribbon`)](#24-controles-de-navegación-del-repo-menu-toolbar-expander-hamburgermenu-fluentribbon)
3. [Estilos, Plantillas y Triggers (`Style`, `ControlTemplate`, `DataTemplate`)](#3-estilos-plantillas-y-triggers-style-controltemplate-datatemplate)
   - [3.1. `Style` con `TargetType`, `BasedOn` y `Trigger` (Extraído de `PantallaLogin.xaml`)](#31-style-con-targettype-basedon-y-trigger-extraído-de-pantallaloginxaml)
   - [3.2. `DataTrigger` y `MultiDataTrigger` (Cambiar aspecto según datos o condiciones múltiples)](#32-datatrigger-y-multidatatrigger-cambiar-aspecto-según-datos-o-condiciones-múltiples)
   - [3.3. `ControlTemplate` (Botón personalizado redondeado con efecto Hover/Click)](#33-controltemplate-botón-personalizado-redondeado-con-efecto-hoverclick)
   - [3.4. `DataTemplate` (Extraído de `di.unidad3.ejercicio4` y plantilla para listas)](#34-datatemplate-extraído-de-diunidad3ejercicio4-y-plantilla-para-listas)
4. [Data Binding, Modelos y Notificación de Cambios (`INotifyPropertyChanged`)](#4-data-binding-modelos-y-notificación-de-cambios-inotifypropertychanged)
   - [4.1. Clase Base `ViewModelBase` / Modelo con `INotifyPropertyChanged`](#41-clase-base-viewmodelbase--modelo-con-inotifypropertychanged)
   - [4.2. ViewModel Principal con `ObservableCollection<T>` y `RelayCommand`](#42-viewmodel-principal-con-observablecollectiont-y-relaycommand)
   - [4.3. Sintaxis de `Binding` en XAML (`TwoWay`, `PropertyChanged`, `ElementName`, `RelativeSource`)](#43-sintaxis-de-binding-en-xaml-twoway-propertychanged-elementname-relativesource)
   - [4.4. Conversor de Valores (`IValueConverter`) listo para copiar](#44-conversor-de-valores-ivalueconverter-listo-para-copiar)
5. [Controles de Datos (`DataGrid`, `ListView`, `ComboBox`)](#5-controles-de-datos-datagrid-listview-combobox)
   - [5.1. `DataGrid` Completo (Columnas de texto, CheckBox y botones de acción en `DataGridTemplateColumn`)](#51-datagrid-completo-columnas-de-texto-checkbox-y-botones-de-acción-en-datagridtemplatecolumn)
   - [5.2. `ListView` con `GridView` y `ComboBox` (Objetos y `SelectedValuePath`)](#52-listview-con-gridview-y-combobox-objetos-y-selectedvaluepath)
   - [5.3. Enlace y filtrado en C# (`ItemsSource`, `SelectedItem`, `ICollectionView`)](#53-enlace-y-filtrado-en-c-itemssource-selecteditem-icollectionview)
6. [Navegación, Ventanas y Cuadros de Diálogo](#6-navegación-ventanas-y-cuadros-de-diálogo)
   - [6.1. Ventanas Modales (`ShowDialog()`) y Paso de Datos (Ida y Vuelta)](#61-ventanas-modales-showdialog-y-paso-de-datos-ida-y-vuelta)
   - [6.2. Ventanas No Modales (`Show()`), Cambio de `MainWindow` (Login -> Main) y UserControls](#62-ventanas-no-modales-show-cambio-de-mainwindow-login---main-y-usercontrols)
   - [6.3. `MessageBox` con `MessageBoxResult` y Diálogos de MahApps (`ShowMessageAsync`)](#63-messagebox-con-messageboxresult-y-diálogos-de-mahapps-showmessageasync)
7. [Validaciones y Eventos Frecuentes](#7-validaciones-y-eventos-frecuentes)
   - [7.1. Validación completa de formularios en C# (Vacíos, Números, Fechas, Email, `PasswordBox`)](#71-validación-completa-de-formularios-en-c-vacíos-números-fechas-email-passwordbox)
   - [7.2. Eventos de Ventana sin bordes (Arrastrar `DragMove`, Minimizar, Maximizar, Cerrar)](#72-eventos-de-ventana-sin-bordes-arrastrar-dragmove-minimizar-maximizar-cerrar)
   - [7.3. Eventos de Teclado (Solo números en `TextBox`, tecla `Enter`)](#73-eventos-de-teclado-solo-números-en-textbox-tecla-enter)
8. [Errores Típicos Detectados en mi Repositorio (¡Cuidado en el Examen!)](#8-errores-típicos-detectados-en-mi-repositorio-cuidado-en-el-examen)

---

## 1. Configuración Inicial Rápida (`App.xaml` y Paquetes)

### 1.1. Paquetes NuGet habituales (`.csproj`)
Extraído de tus proyectos (`proyectoDefinitivo`, `di.unidad2.ejercicio12`, `di.unidad3.ejercicio2`, `Examen_DI_19_11_2025`):

```xml
<ItemGroup>
    <!-- CAMBIAR EN EXAMEN: Dejar solo los paquetes que pida el enunciado -->
    <PackageReference Include="MahApps.Metro" Version="2.4.11" />
    <PackageReference Include="MaterialDesignThemes" Version="5.4.0" />
    <PackageReference Include="MaterialDesignThemes.MahApps" Version="5.4.0" />
    <PackageReference Include="MahApps.Metro.IconPacks" Version="5.0.0" />
    <PackageReference Include="Fluent.Ribbon" Version="10.0.4" />
    <PackageReference Include="Microsoft.Data.Sqlite" Version="9.0.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.1" />
</ItemGroup>
```

---

### 1.2. `App.xaml` Completo (MahApps.Metro + MaterialDesign + Fluent)
Extraído y unificado de `di.unidad2.ejercicio12/App.xaml`, `di.unidad3.ejercicio3/App.xaml` y `proyectoDefinitivo/App.xaml`:

```xml
<!-- CAMBIAR EN EXAMEN: Ajustar 'MiProyecto.App' al nombre real de tu solución -->
<Application x:Class="MiProyecto.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:MiProyecto"
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             StartupUri="MainWindow.xaml">
    <!-- NOTA: Si usas Inyección de Dependencias o Login inicial en App.xaml.cs, BORRA 'StartupUri="MainWindow.xaml"' -->
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>

                <!-- 1. MAHAPPS.METRO (Sensible a mayúsculas/minúsculas) -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <!-- CAMBIAR EN EXAMEN: Base (Light o Dark) y Acento (Red, Blue, Cobalt, Indigo, Emerald, Orange...) -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Red.xaml" />

                <!-- 2. MATERIAL DESIGN IN XAML -->
                <!-- CAMBIAR EN EXAMEN: BaseTheme (Light/Dark), PrimaryColor (Red, Blue, LightBlue, Indigo...) y SecondaryColor -->
                <materialDesign:BundledTheme BaseTheme="Light"
                                             PrimaryColor="Red"
                                             SecondaryColor="Orange" />
                <!-- Si usas MaterialDesign v5+ con controles clásicos, usa MaterialDesign2.Defaults.xaml o MaterialDesign3.Defaults.xaml -->
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />

                <!-- 3. FLUENT RIBBON (Descomentar solo si el examen pide cinta Ribbon) -->
                <!-- <ResourceDictionary Source="pack://application:,,,/Fluent;Component/Themes/Generic.xaml" /> -->

            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

---

### 1.3. Cabeceras y Namespaces (`xmlns`) para `Window`, `MetroWindow` y `UserControl`

#### Opción A: Ventana estándar o sin bordes (`Window`)
Extraído de `Examen_DI_19_11_2025/MainWindow.xaml` y `di.unidad2.ejercicio12/MainWindow.xaml`:
```xml
<!-- CAMBIAR EN EXAMEN: 'MiProyecto.MainWindow' y 'clr-namespace:MiProyecto' -->
<Window x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:MiProyecto"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="Título Examen" Height="620" Width="800"
        WindowStartupLocation="CenterScreen"
        WindowStyle="None" ResizeMode="NoResize"
        AllowsTransparency="True" Background="Transparent"
        MouseLeftButtonDown="Window_MouseLeftButtonDown">
    <!-- Si quieres marco normal de Windows, borra WindowStyle, ResizeMode, AllowsTransparency y Background="Transparent" -->
</Window>
```

#### Opción B: Ventana moderna `mah:MetroWindow`
Extraído de `di.unidad3.ejercicio1/MainWindow.xaml` y `di.unidad2.ejercicio4/MainWindow.xaml`:
```xml
<!-- ¡IMPORTANTE!: En el archivo .xaml.cs la clase debe heredar de ': MetroWindow' en vez de ': Window' -->
<mah:MetroWindow x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:MiProyecto"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
        xmlns:Fluent="urn:fluent-ribbon"
        mc:Ignorable="d"
        Title="INVENTARIO MATISSE" Height="550" Width="850"
        WindowStartupLocation="CenterScreen"
        ShowTitleBar="True" ShowCloseButton="True" ShowMinButton="True" ShowMaxRestoreButton="True">

    <!-- Opcional: Botones en la barra superior derecha de MetroWindow -->
    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands ShowSeparators="True">
            <Button ToolTip="Usuario">
                <mat:PackIcon Kind="Account" Width="20" Height="20" Foreground="White" />
            </Button>
            <Button x:Name="btnSalir" ToolTip="Cerrar Sesión" Click="BtnSalir_Click">
                <mat:PackIcon Kind="Logout" Width="20" Height="20" Foreground="White" />
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <Grid>
        <!-- Contenido aquí -->
    </Grid>
</mah:MetroWindow>
```

#### Opción C: Cabecera de `UserControl`
```xml
<!-- CAMBIAR EN EXAMEN: 'MiProyecto.Vista.UserControl.MiVista' -->
<UserControl x:Class="MiProyecto.Vista.UserControl.MiVista"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
             xmlns:local="clr-namespace:MiProyecto.Vista.UserControl"
             xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
             xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
             mc:Ignorable="d"
             d:DesignHeight="450" d:DesignWidth="800">
    <Grid Background="White">
        <!-- Contenido del UserControl -->
    </Grid>
</UserControl>
```

---

## 2. Layouts y Contenedores Esenciales (XAML Limpio)

### 2.1. `Grid` (Filas, Columnas, `*`, `Auto`, `Span`)
Basado en la estructura de formularios y dashboards de `di.unidad2.ejercicio12` y `Examen_DI_19_11_2025`:

```xml
<Grid Margin="20">
    <!-- DEFINICIÓN DE FILAS:
         - Pixel fijo (ej. "70"): Cabeceras o barras superiores.
         - "Auto": Se adapta exactamente a la altura de los controles hijos.
         - "*" (o "2*", "3*"): Reparte proporcionalmente el espacio sobrante. -->
    <Grid.RowDefinitions>
        <RowDefinition Height="60" />   <!-- Fila 0: Cabecera fija de 60px -->
        <RowDefinition Height="Auto" /> <!-- Fila 1: Se ajusta al contenido -->
        <RowDefinition Height="2*" />   <!-- Fila 2: Ocupa 2/3 del espacio restante -->
        <RowDefinition Height="1*" />   <!-- Fila 3: Ocupa 1/3 del espacio restante -->
    </Grid.RowDefinitions>

    <!-- DEFINICIÓN DE COLUMNAS (con columna separadora en medio como en tus ejercicios 12-15) -->
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="220" /> <!-- Columna 0: Menú lateral fijo -->
        <ColumnDefinition Width="*" />   <!-- Columna 1: Campo izquierdo elástico -->
        <ColumnDefinition Width="24" />  <!-- Columna 2: Hueco/Espaciador fijo de 24px -->
        <ColumnDefinition Width="*" />   <!-- Columna 3: Campo derecho elástico -->
    </Grid.ColumnDefinitions>

    <!-- Uso de Grid.ColumnSpan para ocupar varias columnas -->
    <Border Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="4" Background="#1F2544" />

    <!-- Elementos en celdas específicas -->
    <TextBox Grid.Row="1" Grid.Column="1" mat:HintAssist.Hint="Campo Izquierdo" />
    <TextBox Grid.Row="1" Grid.Column="3" mat:HintAssist.Hint="Campo Derecho" />
</Grid>
```

---

### 2.2. `DockPanel` (Menú superior + Lateral + Contenido central)
Extraído y limpiado de `di.unidad2.ejercicio1` y `di.unidad3.ejercicio3`:

```xml
<!-- LastChildFill="True" (por defecto) hace que el ÚLTIMO elemento rellene todo el centro -->
<DockPanel LastChildFill="True">

    <!-- 1. Barra Superior (Dock="Top") -->
    <Border DockPanel.Dock="Top" Height="60" Background="#E5302E">
        <TextBlock Text="CABECERA SUPERIOR" Foreground="White" VerticalAlignment="Center" Margin="20,0" FontSize="20" FontWeight="Bold" />
    </Border>

    <!-- 2. Pie de página / Barra de estado (Dock="Bottom") -->
    <Border DockPanel.Dock="Bottom" Height="30" Background="#2D3358">
        <TextBlock Text="Listo" Foreground="White" VerticalAlignment="Center" Margin="10,0" />
    </Border>

    <!-- 3. Menú Lateral Izquierdo (Dock="Left") -->
    <StackPanel DockPanel.Dock="Left" Width="220" Background="#333333">
        <Button Content="Opción 1" Margin="10,10,10,5" />
        <Button Content="Opción 2" Margin="10,5" />
    </StackPanel>

    <!-- 4. Área Central Principal (SIEMPRE EL ÚLTIMO HIJO, sin DockPanel.Dock) -->
    <Grid x:Name="gridCentral" Background="#F4F7FF" Margin="15">
        <!-- Aquí va el contenido principal o el contenedor de vistas -->
    </Grid>
</DockPanel>
```

---

### 2.3. `StackPanel`, `WrapPanel`, `UniformGrid` y `Viewbox`

```xml
<!-- 1. STACKPANEL: Apila elementos en vertical (por defecto) u horizontal -->
<!-- Ideal para botoneras inferiores (Guardar / Cancelar) como en tus ejercicios 12-15 -->
<StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Bottom" Margin="0,15,0,0">
    <Button Content="Cancelar" Width="100" Height="36" Margin="0,0,12,0" />
    <Button Content="Guardar" Width="100" Height="36" />
</StackPanel>

<!-- 2. WRAPPANEL: Coloca elementos en fila y salta a la siguiente línea automáticamente si no caben -->
<!-- Ideal para galerías de tarjetas, etiquetas o botones dinámicos -->
<WrapPanel Orientation="Horizontal" ItemWidth="180" ItemHeight="100" Margin="10">
    <Border Background="#EAF8F3" CornerRadius="12" Margin="8" Padding="15">
        <TextBlock Text="Tarjeta 1" FontWeight="Bold" />
    </Border>
    <Border Background="#EEF1FF" CornerRadius="12" Margin="8" Padding="15">
        <TextBlock Text="Tarjeta 2" FontWeight="Bold" />
    </Border>
</WrapPanel>

<!-- 3. UNIFORMGRID: Cuadrícula donde TODAS las celdas miden exactamente lo mismo -->
<!-- Ideal para KPIs/Tarjetas de estadísticas (como las 3 tarjetas de Examen_DI_19_11_2025) o teclados -->
<!-- CAMBIAR EN EXAMEN: Rows y Columns según el número de tarjetas iguales -->
<UniformGrid Rows="1" Columns="3" Margin="0,0,0,20">
    <Border Background="#EAF8F3" CornerRadius="16" Margin="0,0,10,0" Padding="18">
        <StackPanel>
            <TextBlock Text="Personal" Foreground="#0B5E4B" FontWeight="Bold" FontSize="16" />
            <TextBlock Text="128" FontSize="30" FontWeight="Bold" Foreground="#0B5E4B" Margin="0,10,0,0" />
        </StackPanel>
    </Border>
    <Border Background="#EEF1FF" CornerRadius="16" Margin="5,0" Padding="18">
        <StackPanel>
            <TextBlock Text="Activos" Foreground="#3C4BAA" FontWeight="Bold" FontSize="16" />
            <TextBlock Text="96" FontSize="30" FontWeight="Bold" Foreground="#3C4BAA" Margin="0,10,0,0" />
        </StackPanel>
    </Border>
    <Border Background="#FFF0F4" CornerRadius="16" Margin="10,0,0,0" Padding="18">
        <StackPanel>
            <TextBlock Text="Bajas" Foreground="#C44367" FontWeight="Bold" FontSize="16" />
            <TextBlock Text="14" FontSize="30" FontWeight="Bold" Foreground="#C44367" Margin="0,10,0,0" />
        </StackPanel>
    </Border>
</UniformGrid>

<!-- 4. VIEWBOX: Escala automáticamente todo su interior sin deformarlo (Extraído de PantallaLogin.xaml) -->
<Viewbox Stretch="Uniform" StretchDirection="DownOnly" Margin="20">
    <Border Width="750" Height="580" CornerRadius="25" Background="#B3101826" Padding="40">
        <!-- Contenido con medidas fijas que se reescalará en pantallas pequeñas -->
    </Border>
</Viewbox>
```

---

### 2.4. Controles de Navegación del Repo (`Menu`, `ToolBar`, `Expander`, `HamburgerMenu`, `Fluent:Ribbon`)

#### A) `Menu` y `ToolBar` con Iconos (Extraído de `di.unidad3.ejercicio1`)
```xml
<DockPanel>
    <!-- Barra de Menú Principal -->
    <Menu DockPanel.Dock="Top" IsMainMenu="True">
        <MenuItem Header="Préstamos">
            <MenuItem Header="Salidas" Click="MenuSalidas_Click">
                <MenuItem.Icon>
                    <mat:PackIcon Kind="Output" />
                </MenuItem.Icon>
            </MenuItem>
            <Separator />
            <MenuItem Header="Listado Pendientes">
                <MenuItem.Icon>
                    <mat:PackIcon Kind="Clipboard" />
                </MenuItem.Icon>
            </MenuItem>
        </MenuItem>
    </Menu>

    <!-- Barra de Herramientas (ToolBar) -->
    <ToolBar DockPanel.Dock="Top">
        <Button ToolTip="Guardar registros" Click="BtnGuardar_Click">
            <mat:PackIcon Kind="ContentSave" />
        </Button>
        <Separator />
        <TextBlock Text="Buscar:" VerticalAlignment="Center" Margin="10,0,5,0" />
        <TextBox x:Name="txtBuscar" Width="150" VerticalAlignment="Center" />
    </ToolBar>

    <Grid x:Name=" contenedorPrincipal" />
</DockPanel>
```

#### B) Menú Lateral Acordeón con `Expander` (Extraído de `di.unidad3.ejercicio3`)
```xml
<StackPanel Background="#E5303030" Width="250">
    <Expander Header="Administración" IsExpanded="False" Foreground="White" Background="{x:Null}"
              Style="{StaticResource MaterialDesignExpander}">
        <ListView Foreground="White" ScrollViewer.HorizontalScrollBarVisibility="Disabled">
            <ListViewItem Content="Usuarios" Padding="20,5" />
            <ListViewItem Content="Artículos" Padding="20,5" />
        </ListView>
    </Expander>
</StackPanel>
```

---

## 3. Estilos, Plantillas y Triggers (`Style`, `ControlTemplate`, `DataTemplate`)

### 3.1. `Style` con `TargetType`, `BasedOn` y `Trigger` (Extraído de `PantallaLogin.xaml`)
Permite heredar de un estilo de Material Design y cambiar colores cuando el control recibe el foco o el ratón pasa por encima:

```xml
<!-- Puedes ponerlo dentro de <Window.Resources> (con x:Key) o directamente en <TextBox.Style> -->
<Style x:Key="EstiloTextBoxPersonalizado" TargetType="TextBox" BasedOn="{StaticResource MaterialDesignOutlinedTextBox}">
    <!-- Propiedades por defecto -->
    <Setter Property="Background" Value="#40000000" />
    <Setter Property="BorderBrush" Value="#C79F86" />
    <Setter Property="Foreground" Value="White" />
    <Setter Property="Padding" Value="12" />

    <Style.Triggers>
        <!-- TRIGGER 1: Cuando el usuario hace clic para escribir (Foco de teclado) -->
        <Trigger Property="IsKeyboardFocused" Value="True">
            <Setter Property="Background" Value="#80000000" />
            <Setter Property="BorderBrush" Value="#000C38" />
        </Trigger>

        <!-- TRIGGER 2: Cuando el ratón pasa por encima (Hover) -->
        <Trigger Property="IsMouseOver" Value="True">
            <Setter Property="BorderThickness" Value="2" />
        </Trigger>
    </Style.Triggers>
</Style>
```

---

### 3.2. `DataTrigger` y `MultiDataTrigger` (Cambiar aspecto según datos o condiciones múltiples)
Muy pedido en exámenes para colorear filas, cambiar textos o activar/desactivar botones según propiedades del ViewModel o de otros controles:

```xml
<Window.Resources>
    <!-- 1. DATATRIGGER: Cambia el color de un TextBlock o fila según una propiedad del modelo (ej. Estado o Stock) -->
    <Style x:Key="EstiloEstadoTexto" TargetType="TextBlock">
        <Setter Property="Foreground" Value="#3C4BAA" />
        <Setter Property="FontWeight" Value="SemiBold" />
        <Style.Triggers>
            <!-- CAMBIAR EN EXAMEN: 'Estado' por el nombre de la propiedad en tu clase C# -->
            <DataTrigger Binding="{Binding Estado}" Value="Baja">
                <Setter Property="Foreground" Value="#FF5A82" />
                <Setter Property="TextDecorations" Value="Strikethrough" />
            </DataTrigger>
            <DataTrigger Binding="{Binding Stock}" Value="0">
                <Setter Property="Foreground" Value="Red" />
                <Setter Property="Text" Value="SIN STOCK" />
            </DataTrigger>
        </Style.Triggers>
    </Style>

    <!-- 2. MULTIDATATRIGGER: Habilita o cambia el botón SOLO cuando se cumplen VARIAS condiciones a la vez -->
    <Style x:Key="EstiloBotonValidado" TargetType="Button" BasedOn="{StaticResource MaterialDesignRaisedButton}">
        <!-- Por defecto el botón está activo; lo desactivamos si algún TextBox está vacío -->
        <Setter Property="IsEnabled" Value="True" />
        <Style.Triggers>
            <!-- Si txtNombre está vacío, deshabilita -->
            <DataTrigger Binding="{Binding Text.Length, ElementName=txtNombre}" Value="0">
                <Setter Property="IsEnabled" Value="False" />
            </DataTrigger>
            <!-- MultiDataTrigger: Solo se aplica si AMBAS condiciones se cumplen simultáneamente -->
            <MultiDataTrigger>
                <MultiDataTrigger.Conditions>
                    <!-- CAMBIAR EN EXAMEN: Nombres de controles o propiedades del Binding -->
                    <Condition Binding="{Binding IsChecked, ElementName=chkTerminos}" Value="True" />
                    <Condition Binding="{Binding SelectedIndex, ElementName=cmbDepartamento}" Value="0" />
                </MultiDataTrigger.Conditions>
                <Setter Property="Background" Value="#05D79E" />
                <Setter Property="Content" Value="Listo para Guardar" />
            </MultiDataTrigger>
        </Style.Triggers>
    </Style>
</Window.Resources>
```

---

### 3.3. `ControlTemplate` (Botón personalizado redondeado con efecto Hover/Click)
Cuando creas botones sin MaterialDesign (como en `Examen_DI_19_11_2025`), WPF pone un fondo azul feo al pasar el ratón. Con este `ControlTemplate` mantienes esquinas redondeadas y controlas el color hover:

```xml
<Style x:Key="BotonRedondeadoTemplate" TargetType="Button">
    <Setter Property="Background" Value="#3A5BFF" />
    <Setter Property="Foreground" Value="White" />
    <Setter Property="FontWeight" Value="Bold" />
    <Setter Property="Cursor" Value="Hand" />
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="Button">
                <!-- TemplateBinding conecta el Border con las propiedades del Button -->
                <Border x:Name="bordeBoton"
                        Background="{TemplateBinding Background}"
                        BorderBrush="{TemplateBinding BorderBrush}"
                        BorderThickness="{TemplateBinding BorderThickness}"
                        CornerRadius="12"
                        Padding="{TemplateBinding Padding}">
                    <!-- ContentPresenter muestra el texto o icono que pongas dentro del Button -->
                    <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center" />
                </Border>
                <ControlTemplate.Triggers>
                    <Trigger Property="IsMouseOver" Value="True">
                        <Setter TargetName="bordeBoton" Property="Opacity" Value="0.85" />
                    </Trigger>
                    <Trigger Property="IsPressed" Value="True">
                        <Setter TargetName="bordeBoton" Property="Background" Value="#1F2544" />
                    </Trigger>
                    <Trigger Property="IsEnabled" Value="False">
                        <Setter TargetName="bordeBoton" Property="Opacity" Value="0.4" />
                    </Trigger>
                </ControlTemplate.Triggers>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

---

### 3.4. `DataTemplate` (Extraído de `di.unidad3.ejercicio4` y plantilla para listas)
Define cómo se dibuja cada objeto de una colección dentro de un `ListBox`, `ListView`, `ComboBox` o `HamburgerMenu`:

```xml
<Window.Resources>
    <!-- EJEMPLO 1: Extraído de tu repo (di.unidad3.ejercicio4) para HamburgerMenu -->
    <DataTemplate x:Key="MenuItemTemplateIcon" DataType="{x:Type mah:HamburgerMenuIconItem}">
        <Grid Height="48">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="48" />
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>
            <ContentControl Grid.Column="0" Content="{Binding Icon}" HorizontalAlignment="Center" VerticalAlignment="Center" Foreground="White" />
            <TextBlock Grid.Column="1" Text="{Binding Label}" VerticalAlignment="Center" FontSize="16" Foreground="White" />
        </Grid>
    </DataTemplate>

    <!-- EJEMPLO 2: Plantilla de tarjeta para mostrar Empleados/Productos en un ListBox -->
    <!-- CAMBIAR EN EXAMEN: 'Nombre', 'Departamento', 'Puesto' por las propiedades de tu clase C# -->
    <DataTemplate x:Key="EmpleadoCardTemplate">
        <Border Background="White" CornerRadius="10" BorderBrush="#DDE4FF" BorderThickness="1" Padding="12" Margin="0,4">
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto" />
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="Auto" />
                </Grid.ColumnDefinitions>
                <mat:PackIcon Grid.Column="0" Kind="AccountCircle" Width="36" Height="36" Foreground="#6266F7" VerticalAlignment="Center" Margin="0,0,12,0" />
                <StackPanel Grid.Column="1" VerticalAlignment="Center">
                    <TextBlock Text="{Binding NombreCompleto}" FontWeight="Bold" FontSize="15" Foreground="#1F2544" />
                    <TextBlock Text="{Binding Puesto}" FontSize="12" Foreground="#4B5678" />
                </StackPanel>
                <Border Grid.Column="2" Background="#EAF8F3" CornerRadius="8" Padding="8,4" VerticalAlignment="Center">
                    <TextBlock Text="{Binding Departamento}" Foreground="#0B5E4B" FontWeight="SemiBold" FontSize="12" />
                </Border>
            </Grid>
        </Border>
    </DataTemplate>
</Window.Resources>

<!-- Uso en el ListBox: -->
<!-- <ListBox ItemsSource="{Binding ListaEmpleados}" ItemTemplate="{StaticResource EmpleadoCardTemplate}" /> -->
```

---

## 4. Data Binding, Modelos y Notificación de Cambios (`INotifyPropertyChanged`)

### 4.1. Clase Base `ViewModelBase` / Modelo con `INotifyPropertyChanged`
Copia esta clase en tu carpeta `Modelos` o `ViewModel`. Hace que la interfaz XAML se actualice sola al cambiar cualquier propiedad en C#:

```csharp
using System.ComponentModel;
using System.Runtime.CompilerServices;

// CAMBIAR EN EXAMEN: Ajustar el namespace al de tu proyecto
namespace MiProyecto.Modelos
{
    public class Empleado : INotifyPropertyChanged
    {
        // Evento obligatorio de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Campos privados
        private int _id;
        private string _nombre = string.Empty;
        private string _apellidos = string.Empty;
        private string _departamento = string.Empty;
        private decimal _salario;
        private bool _activo = true;

        // Propiedades públicas con notificación automática
        // CAMBIAR EN EXAMEN: Adaptar nombres y tipos de propiedades a la tabla/entidad del examen
        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(); }
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto)); // Notifica también propiedades calculadas
            }
        }

        public string Apellidos
        {
            get => _apellidos;
            set
            {
                _apellidos = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Departamento
        {
            get => _departamento;
            set { _departamento = value; OnPropertyChanged(); }
        }

        public decimal Salario
        {
            get => _salario;
            set { _salario = value; OnPropertyChanged(); }
        }

        public bool Activo
        {
            get => _activo;
            set { _activo = value; OnPropertyChanged(); }
        }

        // Propiedad calculada de solo lectura (útil para mostrar en ListBox o TextBlock)
        public string NombreCompleto => $"{Nombre} {Apellidos}".Trim();
    }
}
```

---

### 4.2. ViewModel Principal con `ObservableCollection<T>` y `RelayCommand`
`ObservableCollection<T>` avisa automáticamente al `DataGrid` o `ListBox` cuando haces `.Add()` o `.Remove()`:

```csharp
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MiProyecto.Modelos;

namespace MiProyecto.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        // 1. LISTA OBSERVABLE: Se enlaza a ItemsSource del DataGrid / ListView / ListBox
        public ObservableCollection<Empleado> ListaEmpleados { get; set; } = new();

        // 2. LISTA PARA COMBOBOX: Opciones desplegables
        public ObservableCollection<string> Departamentos { get; set; } = new()
        {
            "Recursos Humanos", "Ventas", "Administración", "Producción", "Logística"
        };

        // 3. ELEMENTO SELECCIONADO: Se enlaza a SelectedItem (Mode=TwoWay)
        private Empleado? _empleadoSeleccionado;
        public Empleado? EmpleadoSeleccionado
        {
            get => _empleadoSeleccionado;
            set { _empleadoSeleccionado = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            // Datos de prueba iniciales
            ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "María", Apellidos = "López", Departamento = "Recursos Humanos", Salario = 24000, Activo = true });
            ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "Pedro", Apellidos = "García", Departamento = "Ventas", Salario = 28500, Activo = true });
        }
    }

    // Clase auxiliar RelayCommand por si necesitas enlazar botones con Command="{Binding MiComando}"
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Predicate<object?>? _canExecute;

        public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute(parameter);
        public void Execute(object? parameter) => _execute(parameter);
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
```

> **¡No olvides asignar el `DataContext` en el constructor de `MainWindow.xaml.cs`!**
> ```csharp
> public MainWindow()
> {
>     InitializeComponent();
>     this.DataContext = new MainViewModel(); // Sin esto, ningún {Binding ...} funcionará
> }
> ```

---

### 4.3. Sintaxis de `Binding` en XAML (`TwoWay`, `PropertyChanged`, `ElementName`, `RelativeSource`)

```xml
<!-- 1. BINDING BÁSICO EN TIEMPO REAL (TwoWay + PropertyChanged) -->
<!-- Actualiza la propiedad C# con cada tecla pulsada (ideal para buscadores o contadores) -->
<TextBox Text="{Binding EmpleadoSeleccionado.Nombre, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" />

<!-- 2. BINDING CON FORMATO (Moneda, Fecha, Texto compuesto) -->
<TextBlock Text="{Binding Salario, StringFormat='{}{0:N2} €'}" />
<TextBlock Text="{Binding FechaAlta, StringFormat='{}{0:dd/MM/yyyy}'}" />
<TextBlock Text="{Binding ListaEmpleados.Count, StringFormat='Total registros: {0}'}" />

<!-- 3. BINDING A OTRO CONTROL DEL XAML (ElementName) -->
<!-- ¡SOLUCIÓN AL CONTADOR ESTÁTICO "0 / 45" DE TUS EJERCICIOS 12-15! -->
<TextBox x:Name="txtSerie" MaxLength="45" />
<TextBlock HorizontalAlignment="Right" FontSize="11" Foreground="#757575">
    <Run Text="{Binding Text.Length, ElementName=txtSerie, Mode=OneWay}" />
    <Run Text=" / " />
    <Run Text="{Binding MaxLength, ElementName=txtSerie, Mode=OneWay}" />
</TextBlock>

<!-- Otro ejemplo con ElementName: Mostrar/Ocultar o Habilitar según un CheckBox -->
<CheckBox x:Name="chkAceptar" Content="Acepto las condiciones" />
<Button Content="Continuar" IsEnabled="{Binding IsChecked, ElementName=chkAceptar}" />

<!-- 4. BINDING RELATIVESOURCE (Acceder al ViewModel de la Ventana desde dentro de una fila de DataGrid/ListBox) -->
<Button Content="Eliminar"
        Command="{Binding DataContext.EliminarCommand, RelativeSource={RelativeSource AncestorType=Window}}"
        CommandParameter="{Binding}" />
```

---

### 4.4. Conversor de Valores (`IValueConverter`) listo para copiar
Útil si en el examen te piden convertir un `bool` en un color, un texto (`"Sí"/"No"`) o en `Visibility` (`Visible`/`Collapsed`):

```csharp
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace MiProyecto.Converters
{
    // Convierte un booleano (ej. Activo = true/false) en un color (Verde / Rojo)
    public class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool activo && activo)
                return new SolidColorBrush(Color.FromRgb(5, 215, 158)); // Verde (#05D79E)
            
            return new SolidColorBrush(Color.FromRgb(255, 90, 130));   // Rojo (#FF5A82)
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
```

**Uso en XAML:**
```xml
<!-- 1. Declarar en <Window.Resources> (Nota: para Visibility ya existe BooleanToVisibilityConverter nativo en WPF) -->
<BooleanToVisibilityConverter x:Key="BoolToVis" />
<local:BoolToBrushConverter x:Key="BoolToBrush" />

<!-- 2. Usar en el control -->
<Border Background="{Binding Activo, Converter={StaticResource BoolToBrush}}" />
<StackPanel Visibility="{Binding MostrarPanel, Converter={StaticResource BoolToVis}}" />
```

---

## 5. Controles de Datos (`DataGrid`, `ListView`, `ComboBox`)

### 5.1. `DataGrid` Completo (Columnas de texto, CheckBox y botones de acción en `DataGridTemplateColumn`)

```xml
<!-- AutoGenerateColumns="False": Nos permite definir nuestras propias columnas con cabeceras limpias -->
<!-- IsReadOnly="True": Evita que el usuario edite celdas haciendo doble clic si solo queremos lectura -->
<DataGrid x:Name="dgEmpleados"
          ItemsSource="{Binding ListaEmpleados}"
          SelectedItem="{Binding EmpleadoSeleccionado, Mode=TwoWay}"
          AutoGenerateColumns="False"
          CanUserAddRows="False"
          IsReadOnly="True"
          SelectionMode="Single"
          HeadersVisibility="Column"
          GridLinesVisibility="Horizontal"
          Background="White"
          BorderBrush="#DDE4FF"
          BorderThickness="1"
          SelectionChanged="DgEmpleados_SelectionChanged">

    <DataGrid.Columns>
        <!-- Columna de Texto Fija -->
        <!-- CAMBIAR EN EXAMEN: Header (título visual) y Binding (propiedad de tu clase C#) -->
        <DataGridTextColumn Header="ID" Binding="{Binding Id}" Width="60" />

        <!-- Columnas de Texto Elásticas (*) -->
        <DataGridTextColumn Header="Nombre" Binding="{Binding Nombre}" Width="*" />
        <DataGridTextColumn Header="Apellidos" Binding="{Binding Apellidos}" Width="1.5*" />
        <DataGridTextColumn Header="Departamento" Binding="{Binding Departamento}" Width="*" />

        <!-- Columna con formato numérico / moneda -->
        <DataGridTextColumn Header="Salario" Binding="{Binding Salario, StringFormat='{}{0:N2} €'}" Width="110" />

        <!-- Columna CheckBox -->
        <DataGridCheckBoxColumn Header="Activo" Binding="{Binding Activo}" Width="80" />

        <!-- Columna Personalizada (Botones Editar / Eliminar dentro de la fila) -->
        <DataGridTemplateColumn Header="Acciones" Width="140">
            <DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                        <Button Content="Editar" Padding="8,2" Margin="0,0,6,0"
                                Background="#3A5BFF" Foreground="White" BorderThickness="0"
                                Click="BtnEditarFila_Click" />
                        <Button Content="✕" Padding="8,2"
                                Background="#FF5A82" Foreground="White" BorderThickness="0"
                                Click="BtnEliminarFila_Click" />
                    </StackPanel>
                </DataTemplate>
            </DataGridTemplateColumn.CellTemplate>
        </DataGridTemplateColumn>
    </DataGrid.Columns>
</DataGrid>
```

---

### 5.2. `ListView` con `GridView` y `ComboBox` (Objetos y `SelectedValuePath`)

```xml
<!-- 1. LISTVIEW EN MODO TABLA (GridView) -->
<ListView x:Name="lvEmpleados"
          ItemsSource="{Binding ListaEmpleados}"
          SelectedItem="{Binding EmpleadoSeleccionado, Mode=TwoWay}">
    <ListView.View>
        <GridView>
            <GridViewColumn Header="Nombre" DisplayMemberBinding="{Binding Nombre}" Width="150" />
            <GridViewColumn Header="Departamento" DisplayMemberBinding="{Binding Departamento}" Width="180" />
            <GridViewColumn Header="Salario" DisplayMemberBinding="{Binding Salario, StringFormat='{}{0:C}'}" Width="100" />
        </GridView>
    </ListView.View>
</ListView>

<!-- 2. COMBOBOX ENLAZADO A LISTA DE STRINGS (Con estilo Material Design de tus ejercicios 12-15) -->
<ComboBox x:Name="cmbDepartamento"
          ItemsSource="{Binding Departamentos}"
          SelectedItem="{Binding EmpleadoSeleccionado.Departamento, Mode=TwoWay}"
          mat:HintAssist.Hint="Selecciona un departamento*"
          Style="{StaticResource MaterialDesignFloatingHintComboBox}"
          FontSize="12.5" />

<!-- 3. COMBOBOX DE CLAVE AJENA / OBJETOS (Como Gama o Representante en tus ejercicios 14 y 15) -->
<!-- DisplayMemberPath: Qué propiedad ve el usuario (ej. NombreGama) -->
<!-- SelectedValuePath: Qué propiedad interna es la PK/FK (ej. CodigoGama) -->
<ComboBox x:Name="cmbGama"
          ItemsSource="{Binding ListaGamas}"
          DisplayMemberPath="NombreGama"
          SelectedValuePath="CodigoGama"
          SelectedValue="{Binding ProductoActual.CodigoGama, Mode=TwoWay}"
          mat:HintAssist.Hint="Selecciona una gama*"
          Style="{StaticResource MaterialDesignFloatingHintComboBox}" />
```

---

### 5.3. Enlace y filtrado en C# (`ItemsSource`, `SelectedItem`, `ICollectionView`)
Si en el examen no usas MVVM completo y prefieres manejar las listas directamente en el code-behind (`MainWindow.xaml.cs`):

```csharp
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MiProyecto.Modelos;

// Colección principal en la ventana
private ObservableCollection<Empleado> _empleados = new();
private ICollectionView? _vistaFiltrada;

private void InicializarDatos()
{
    // 1. Cargar datos y asignar ItemsSource
    _empleados.Add(new Empleado { Id = 1, Nombre = "Ana", Apellidos = "Martínez", Departamento = "Administración" });
    _empleados.Add(new Empleado { Id = 2, Nombre = "José", Apellidos = "Ruiz", Departamento = "Producción" });

    dgEmpleados.ItemsSource = _empleados;

    // 2. Preparar vista para buscador / filtro en tiempo real
    _vistaFiltrada = CollectionViewSource.GetDefaultView(_empleados);
    _vistaFiltrada.Filter = FiltrarEmpleados;
}

// Función de filtrado (se activa al llamar a _vistaFiltrada.Refresh())
private bool FiltrarEmpleados(object obj)
{
    if (obj is not Empleado emp) return false;
    if (string.IsNullOrWhiteSpace(txtBuscar.Text)) return true;

    string filtro = txtBuscar.Text.Trim().ToLower();
    return emp.Nombre.ToLower().Contains(filtro) ||
           emp.Apellidos.ToLower().Contains(filtro) ||
           emp.Departamento.ToLower().Contains(filtro);
}

// Evento TextChanged del TextBox buscador
private void TxtBuscar_TextChanged(object sender, TextChangedEventArgs e)
{
    _vistaFiltrada?.Refresh();
}

// Obtener el elemento seleccionado en el DataGrid / ListBox
private void DgEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (dgEmpleados.SelectedItem is Empleado seleccionado)
    {
        // Rellenar cajas de texto con el elemento seleccionado
        txtNombre.Text = seleccionado.Nombre;
        txtApellidos.Text = seleccionado.Apellidos;
        cmbDepartamento.SelectedItem = seleccionado.Departamento;
    }
}

// Obtener el objeto de la fila cuando se pulsa un botón dentro de DataGridTemplateColumn
private void BtnEliminarFila_Click(object sender, RoutedEventArgs e)
{
    if (sender is Button boton && boton.DataContext is Empleado empleadoFila)
    {
        _empleados.Remove(empleadoFila);
    }
}
```

---

## 6. Navegación, Ventanas y Cuadros de Diálogo

### 6.1. Ventanas Modales (`ShowDialog()`) y Paso de Datos (Ida y Vuelta)
En `Examen_DI_19_11_2025/MainWindow.xaml.cs` abrías `AddEmpleadoDialog` con `ShowDialog()`, pero no devolvías `DialogResult = true` para actualizar la ventana principal. Aquí tienes el patrón completo y limpio:

#### En la Ventana Secundaria / Diálogo (`VentanaDetalle.xaml.cs`):
```csharp
using System.Windows;
using MiProyecto.Modelos;

namespace MiProyecto
{
    public partial class VentanaDetalle : Window
    {
        // Propiedad pública donde guardamos el objeto creado o editado para que MainWindow lo recoja
        public Empleado? EmpleadoResultado { get; private set; }

        // Constructor 1: Para CREAR un nuevo registro
        public VentanaDetalle()
        {
            InitializeComponent();
        }

        // Constructor 2: Para EDITAR un registro existente (recibe datos desde MainWindow)
        public VentanaDetalle(Empleado empleadoAEditar) : this()
        {
            EmpleadoResultado = empleadoAEditar;
            // Rellenar controles con los datos recibidos
            txtNombre.Text = empleadoAEditar.Nombre;
            txtApellidos.Text = empleadoAEditar.Apellidos;
            cmbDepartamento.SelectedItem = empleadoAEditar.Departamento;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Guardamos los datos en la propiedad pública
            EmpleadoResultado ??= new Empleado();
            EmpleadoResultado.Nombre = txtNombre.Text.Trim();
            EmpleadoResultado.Apellidos = txtApellidos.Text.Trim();
            EmpleadoResultado.Departamento = cmbDepartamento.SelectedItem?.ToString() ?? "General";

            // ¡CLAVE EN EXAMEN!: Asignar DialogResult = true cierra la ventana modal automáticamente
            // y hace que dialog.ShowDialog() devuelva 'true' en la ventana principal.
            this.DialogResult = true;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; // Cierra el diálogo indicando que se canceló
        }
    }
}
```

#### En la Ventana Principal (`MainWindow.xaml.cs`):
```csharp
private void BtnNuevoEmpleado_Click(object sender, RoutedEventArgs e)
{
    var dialogo = new VentanaDetalle
    {
        Owner = this, // Centra el diálogo respecto a la ventana principal
        WindowStartupLocation = WindowStartupLocation.CenterOwner
    };

    // ShowDialog() bloquea la ventana de atrás hasta que se cierre el diálogo
    if (dialogo.ShowDialog() == true && dialogo.EmpleadoResultado != null)
    {
        // Recogemos el objeto creado y lo añadimos a la ObservableCollection / Base de datos
        _empleados.Add(dialogo.EmpleadoResultado);
    }
}
```

---

### 6.2. Ventanas No Modales (`Show()`), Cambio de `MainWindow` (Login -> Main) y UserControls

```csharp
// 1. ABRIR VENTANA NO MODAL (Permite seguir usando ambas ventanas a la vez)
private void BtnAbrirAyuda_Click(object sender, RoutedEventArgs e)
{
    var ventanaAyuda = new VentanaAyuda();
    ventanaAyuda.Show();
}

// 2. PASAR DEL LOGIN A LA VENTANA PRINCIPAL Y CERRAR EL LOGIN (Extraído de proyectoDefinitivo)
private void BtnLogin_Click(object sender, RoutedEventArgs e)
{
    MainWindow principal = new MainWindow();
    Application.Current.MainWindow = principal; // Actualiza la ventana principal oficial de la app
    principal.Show();
    this.Close(); // Cierra la pantalla de Login
}

// 3. CAMBIAR DE VISTA CENTRAL CON USERCONTROLS (Ideal para menús laterales tipo Dashboard / HamburgerMenu)
private void BtnIrAEmpleados_Click(object sender, RoutedEventArgs e)
{
    // Si tienes un <Grid x:Name="gridCentral"/> o <ContentControl x:Name="contenedorCentral"/>:
    gridCentral.Children.Clear();
    gridCentral.Children.Add(new VistaEmpleadosUserControl());
}
```

---

### 6.3. `MessageBox` con `MessageBoxResult` y Diálogos de MahApps (`ShowMessageAsync`)

```csharp
// 1. MESSAGEBOX CON CONFIRMACIÓN (Sí / No) ANTES DE ELIMINAR O SALIR
private void BtnEliminar_Click(object sender, RoutedEventArgs e)
{
    MessageBoxResult respuesta = MessageBox.Show(
        "¿Estás seguro de que deseas eliminar este registro de forma permanente?",
        "Confirmar eliminación",
        MessageBoxButton.YesNo,
        MessageBoxImage.Question,
        MessageBoxResult.No); // Botón seleccionado por defecto por seguridad

    if (respuesta == MessageBoxResult.Yes)
    {
        // Ejecutar borrado aquí
        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}

// 2. DIÁLOGO MODERNO ASÍNCRONO DE MAHAPPS.METRO (Extraído de proyectoDefinitivo/PantallaLogin.xaml.cs)
// Requiere: using MahApps.Metro.Controls; y using MahApps.Metro.Controls.Dialogs;
// Y que la ventana herede de MetroWindow
private async void BtnAvisoModerno_Click(object sender, RoutedEventArgs e)
{
    await this.ShowMessageAsync("Error de inicio de sesión", "Por favor, ingrese su correo y contraseña.");
}
```

---

## 7. Validaciones y Eventos Frecuentes

### 7.1. Validación completa de formularios en C# (Vacíos, Números, Fechas, Email, `PasswordBox`)
Combina y mejora las validaciones de `Examen_DI_19_11_2025` y `proyectoDefinitivo`:

```csharp
private bool ValidarFormulario()
{
    // 1. Validar TextBox de texto obligatorio
    if (string.IsNullOrWhiteSpace(txtNombre.Text))
    {
        MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        txtNombre.Focus();
        return false;
    }

    // 2. Validar PasswordBox (¡OJO!: Usa .Password, no tiene propiedad .Text)
    if (string.IsNullOrWhiteSpace(passClave.Password) || passClave.Password.Length < 4)
    {
        MessageBox.Show("La contraseña debe tener al menos 4 caracteres.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        passClave.Focus();
        return false;
    }

    // 3. Validar ComboBox obligatorio
    if (cmbDepartamento.SelectedItem == null)
    {
        MessageBox.Show("Debes seleccionar un departamento.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        cmbDepartamento.IsDropDownOpen = true;
        return false;
    }

    // 4. Validar formato numérico (int / double / decimal) desde un TextBox
    // (Si usas mah:NumericUpDown como en tus ejercicios 14 y 15, lee directamente su propiedad: double valor = numPrecio.Value ?? 0;)
    if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
    {
        MessageBox.Show("Introduce un precio numérico válido mayor o igual a 0.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        txtPrecio.Focus();
        return false;
    }

    // 5. Validar DatePicker obligatorio
    if (dpFechaAlta.SelectedDate == null)
    {
        MessageBox.Show("Selecciona una fecha válida.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        return false;
    }

    // 6. Validar formato básico de Email
    if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
    {
        MessageBox.Show("Introduce un correo electrónico válido.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        txtEmail.Focus();
        return false;
    }

    return true; // Todo correcto
}
```

---

### 7.2. Eventos de Ventana sin bordes (Arrastrar `DragMove`, Minimizar, Maximizar, Cerrar)
Extraído directamente de `di.unidad2.ejercicio12/MainWindow.xaml.cs`, `di.unidad3.ejercicio1/MainWindow.xaml.cs` y `Examen_DI_19_11_2025/MainWindow.xaml.cs`:

```csharp
// 1. Permitir arrastrar la ventana manteniendo pulsado el botón izquierdo del ratón
// En XAML: MouseLeftButtonDown="Window_MouseLeftButtonDown" (o MouseDown="Window_MouseDown")
private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
{
    if (e.LeftButton == MouseButtonState.Pressed)
    {
        this.DragMove();
    }
}

// 2. Minimizar ventana
private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
{
    this.WindowState = WindowState.Minimized;
}

// 3. Alternar entre Maximizar y Restaurar tamaño normal
private void BtnMaximizar_Click(object sender, RoutedEventArgs e)
{
    this.WindowState = (this.WindowState == WindowState.Maximized)
        ? WindowState.Normal
        : WindowState.Maximized;
}

// 4. Cerrar solo la ventana actual vs Cerrar toda la aplicación
private void BtnCerrarVentana_Click(object sender, RoutedEventArgs e)
{
    this.Close(); // Cierra esta ventana
}

private void BtnSalirAplicacion_Click(object sender, RoutedEventArgs e)
{
    Application.Current.Shutdown(); // Cierra TODA la aplicación inmediatamente (usado en unidad3.ejercicio1)
}
```

---

### 7.3. Eventos de Teclado (Solo números en `TextBox`, tecla `Enter`)

```csharp
using System.Text.RegularExpressions;
using System.Windows.Input;

// 1. Impedir que se escriban letras en un TextBox numérico (Teléfono, CP, Stock)
// En XAML: PreviewTextInput="TxtSoloNumeros_PreviewTextInput"
private void TxtSoloNumeros_PreviewTextInput(object sender, TextCompositionEventArgs e)
{
    // Si el texto introducido NO es dígito, marcamos e.Handled = true para bloquearlo
    e.Handled = !Regex.IsMatch(e.Text, "^[0-9]+$");
}

// 2. Ejecutar Login o Búsqueda al pulsar la tecla ENTER en una caja de texto
// En XAML: KeyDown="Txt_KeyDown" (o pon IsDefault="True" en el Button de Login y IsCancel="True" en el de Cancelar)
private void Txt_KeyDown(object sender, KeyEventArgs e)
{
    if (e.Key == Key.Enter)
    {
        BtnLogin_Click(sender, e);
    }
}
```

---

## 8. Errores Típicos Detectados en mi Repositorio (¡Cuidado en el Examen!)

Tras analizar todos tus proyectos de las Unidades 2, 3, `proyectoDefinitivo` y `Examen_DI_19_11_2025`, evita repetir estos fallos el día del examen:

1. **Guardar en BD o en un diálogo sin refrescar la lista de la ventana principal (`Examen_DI_19_11_2025` y `di.unidad3.ejercicio5`)**:
   - **El fallo**: En `Examen_DI_19_11_2025`, `AddEmpleadoDialog` hace el `INSERT INTO Empleados` en SQLite correctamente, pero en `MainWindow.xaml` el `<ListBox>` tiene 4 `<ListBoxItem>` fijos ("María López...", "Pedro García...") escritos a mano en XAML. Al guardar un empleado nuevo, la lista de la pantalla principal **nunca se actualiza**.
   - **La solución en el examen**: No pongas `<ListBoxItem>` fijos si hay alta de datos. Enlaza el `ListBox` o `DataGrid` a una `ObservableCollection<T>` (o llama a un método `CargarEmpleadosDesdeBD()` justo después de `dialog.ShowDialog()`).

2. **Bindings rotos en `ListView` cuando declaras `ListViewItem` manuales (`di.unidad3.ejercicio3`)**:
   - **El fallo**: En `di.unidad3.ejercicio3/MainWindow.xaml` pusiste `<ListView ItemsSource="{Binding Path=SubItems}">` y a la vez metiste `<ListViewItem Content="Users"/>` dentro en XAML, sin tener `DataContext` asignado.
   - **El peligro**: En WPF, si un control tiene `ItemsSource` y además hijos manuales directos en XAML, o bien el binding falla silenciosamente o lanza `InvalidOperationException` ("La colección Items debe estar vacía antes de usar ItemsSource") si el binding llega a resolverse. Usa **solo uno de los dos**: o `ItemsSource` o elementos manuales.

3. **Contadores de caracteres estáticos `"0 / 45"` (`di.unidad2.ejercicio12`, `13`, `14`, `15`)**:
   - **El fallo**: Pusiste `<TextBlock Text="0 / 45"/>` debajo de los `TextBox` con `MaxLength="45"`. Al escribir en el `TextBox`, el contador se queda congelado en `0 / 45`.
   - **La solución en el examen**: Ponle `x:Name="txtCampo"` al `TextBox` y usa el Binding con `ElementName` de la [Sección 4.3](#43-sintaxis-de-binding-en-xaml-twoway-propertychanged-elementname-relativesource), o activa la propiedad nativa de Material Design:
     ```xml
     <TextBox MaxLength="45" mat:CharacterCounterAssist.IsVisible="True" />
     ```

4. **Construir toda la ventana de diálogo por código C# en vez de XAML (`AddEmpleadoDialog` en `Examen_DI_19_11_2025`)**:
   - **El fallo**: En `MainWindow.xaml.cs` creaste la clase `AddEmpleadoDialog : Window` instanciando `Border`, `StackPanel`, `TextBox`, `ComboBox` y `Button` a mano en más de 150 líneas de C#.
   - **Por qué evitarlo en el examen**: Es muchísimo más lento de escribir, propenso a errores de márgenes y no puedes usar previsualización ni estilos XAML fácilmente. Crea siempre `Click derecho en el proyecto -> Agregar -> Ventana (WPF)...` y maqueta en XAML en 2 minutos.

5. **Posicionamiento con márgenes gigantes dentro de un `Grid` sin filas (`di.unidad2.ejercicio3`)**:
   - **El fallo**: En `di.unidad2.ejercicio3/MainWindow.xaml` colocaste todos los controles dentro de un único `<Grid>` sin `RowDefinitions`, separándolos con `Margin="0,220,0,0"`, `Margin="0,290,0,0"`, `Margin="0,550,0,0"`, `Margin="25,700,0,0"`.
   - **Por qué evitarlo**: Si redimensionas la ventana o cambias el tamaño de fuente, los controles se montan unos encima de otros. Usa siempre `<Grid.RowDefinitions>` con `Auto` / `*` o un `<StackPanel>`.

6. **Inyección de Dependencias con referencia circular o instancias cautivas (`proyectoDefinitivo`)**:
   - **El fallo**: En `proyectoDefinitivo`, `PantallaLogin` recibe `MainWindow` en el constructor, y `MainWindow` recibe `Func<PantallaLogin>`. Además, en `App.xaml` olvidaste borrar o sincronizar `StartupUri` en algunos proyectos cuando sobrescribes `OnStartup`.
   - **La solución en el examen**: A menos que el enunciado exija explícitamente `IServiceCollection`, no te compliques con Inyección de Dependencias en un examen con límite de tiempo; instancia las ventanas con `new MainWindow()` o `new PantallaLogin()`.

7. **Rutas de imágenes y diccionarios sensibles a barra inicial o nombres (`di.unidad2` y `proyectoDefinitivo`)**:
   - Asegúrate siempre de que las imágenes añadidas al proyecto tengan en Propiedades: **Acción de compilación (Build Action) = `Resource`** (como tienes bien configurado en `proyectoDefinitivo.csproj`) y usa rutas comenzando por barra `/Recursos/Imagenes/foto.png`.
