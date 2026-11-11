# ⚡ Chuleta Rápida de Examen — Diseño de Interfaces (WPF, C#, MaterialDesign, MahApps & MVVM)

> **Guía de supervivencia para el examen práctico de DAM**: Todo el código de este documento está extraído y depurado directamente de tus propios proyectos del repositorio (`proyectoDefinitivo`, `Examen_DI_19_11_2025`, `00_Plantilla_Examen` y ejercicios de las Unidades 2 y 3), listo para copiar y pegar sin errores de compilación.

---

## 📑 Índice Rápido

1. [Configuración Base (`.csproj`, `App.xaml` y `MainWindow.xaml`)](#1-configuración-base-csproj-appxaml-y-mainwindowxaml)
   - [1.1. Archivo `.csproj` Todoterreno (NuGet + Recursos Automáticos)](#11-archivo-csproj-todoterreno-nuget--recursos-automáticos)
   - [1.2. `App.xaml` con MaterialDesign v5 + MahApps.Metro + Paleta Global](#12-appxaml-con-materialdesign-v5--mahappsmetro--paleta-global)
   - [1.3. Opción A de Ventana: `mah:MetroWindow` con `RightWindowCommands`](#13-opción-a-de-ventana-mahmetrowindow-con-rightwindowcommands)
   - [1.4. Opción B de Ventana: Ventana Sin Bordes Redondeada (`WindowStyle="None"`)](#14-opción-b-de-ventana-ventana-sin-bordes-redondeada-windowstylenone)
2. [Layouts Principales (`Grid`, `DockPanel`, `StackPanel`, Menú Lateral y Pestañas)](#2-layouts-principales-grid-dockpanel-stackpanel-menú-lateral-y-pestañas)
   - [2.1. Estructura Dashboard Completa (Cabecera + Sidebar + 3 Tarjetas KPI + Contenido)](#21-estructura-dashboard-completa-cabecera--sidebar--3-tarjetas-kpi--contenido)
   - [2.2. Panel Efecto Cristal (`Glassmorphism`) + `Viewbox` Adaptativo 720p/1080p](#22-panel-efecto-cristal-glassmorphism--viewbox-adaptativo-720p1080p)
   - [2.3. Menú Superior Clásico (`<Menu>`) + Barra de Herramientas (`<ToolBar>`)](#23-menú-superior-clásico-menu--barra-de-herramientas-toolbar)
   - [2.4. Menú Lateral Desplegable con Acordeón (`<Expander>`)](#24-menú-lateral-desplegable-con-acordeón-expander)
   - [2.5. Menú Hamburguesa (`<mah:HamburgerMenu>`) con `DataTemplate`](#25-menú-hamburguesa-mahhamburgermenu-con-datatemplate)
   - [2.6. Cinta de Opciones `<Fluent:Ribbon>` con `<Fluent:Backstage>`](#26-cinta-de-opciones-fluentribbon-con-fluentbackstage)
   - [2.7. Formas Geométricas, Giro (`RotateTransform`) y Recorte Circular (`OpacityMask`)](#27-formas-geométricas-giro-rotatetransform-y-recorte-circular-opacitymask)
3. [Controles de Formulario, `DataGrid` y Botones de Acción](#3-controles-de-formulario-datagrid-y-botones-de-acción)
   - [3.1. `TextBox` y `PasswordBox` Outlined con Icono `PackIcon` y `Triggers` de Foco](#31-textbox-y-passwordbox-outlined-con-icono-packicon-y-triggers-de-foco)
   - [3.2. `ComboBox`, `DatePicker`, Contador de Caracteres (`0/45`) y `NumericUpDown`](#32-combobox-datepicker-contador-de-caracteres-045-y-numericupdown)
   - [3.3. `DataGrid` con Columnas Personalizadas Enlazado a `ObservableCollection<T>`](#33-datagrid-con-columnas-personalizadas-enlazado-a-observablecollectiont)
   - [3.4. Botones de Acción (Degradado Redondeado, Outlined y Flotante `FAB`)](#34-botones-de-acción-degradado-redondeado-outlined-y-flotante-fab)
4. [Eventos en Code-Behind, MVVM, Diálogos Modales y SQLite](#4-eventos-en-code-behind-mvvm-diálogos-modales-y-sqlite)
   - [4.1. Mover Ventana Sin Bordes (`DragMove`) + Minimizar, Maximizar y Cerrar](#41-mover-ventana-sin-bordes-dragmove--minimizar-maximizar-y-cerrar)
   - [4.2. Validación de Formularios + `MessageBox` y `ShowMessageAsync` (MahApps)](#42-validación-de-formularios--messagebox-y-showmessageasync-mahapps)
   - [4.3. Apertura de Ventana Secundaria Modal (`ShowDialog()`) y Paso de Datos](#43-apertura-de-ventana-secundaria-modal-showdialog-y-paso-de-datos)
   - [4.4. Cambio de Ventana Login ↔ `MainWindow` e Inyección de Dependencias (`App.xaml.cs`)](#44-cambio-de-ventana-login--mainwindow-e-inyección-de-dependencias-appxamlcs)
   - [4.5. Base de Datos SQLite Completa (`CREATE TABLE`, `INSERT`, `SELECT`, `DELETE`)](#45-base-de-datos-sqlite-completa-create-table-insert-select-delete)
   - [4.6. Esqueleto Rápido MVVM (`INotifyPropertyChanged` + `RelayCommand`)](#46-esqueleto-rápido-mvvm-inotifypropertychanged--relaycommand)

---

## 1. Configuración Base (`.csproj`, `App.xaml` y `MainWindow.xaml`)

### 1.1. Archivo `.csproj` Todoterreno (NuGet + Recursos Automáticos)
*Extraído de: `00_Plantilla_Examen/PlantillaExamen/PlantillaExamen.csproj`*

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <UseWPF>true</UseWPF>
  </PropertyGroup>

  <!-- Comodín: cualquier imagen/icono/fuente en Recursos/ se compila como Resource automáticamente -->
  <ItemGroup>
    <None Remove="Recursos\**\*" />
    <Resource Include="Recursos\**\*" />
  </ItemGroup>

  <!-- Paquetes NuGet compatibles con .NET 8 y .NET 9 -->
  <ItemGroup>
    <PackageReference Include="MahApps.Metro" Version="2.4.11" />
    <PackageReference Include="MaterialDesignThemes.MahApps" Version="5.3.2" />
    <PackageReference Include="Microsoft.Data.Sqlite" Version="8.0.10" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.1" />
    <!-- Opcional si piden cinta Office: <PackageReference Include="Fluent.Ribbon" Version="9.0.0" /> -->
  </ItemGroup>

</Project>
```

---

### 1.2. `App.xaml` con MaterialDesign v5 + MahApps.Metro + Paleta Global
*Extraído de: `proyectoDefinitivo/App.xaml` y `00_Plantilla_Examen/PlantillaExamen/App.xaml`*

> **Regla de oro para evitar errores en tiempo de ejecución**: En MaterialDesign v5 es obligatorio incluir tanto `<materialDesign:BundledTheme .../>` como `MaterialDesign2.Defaults.xaml` (o `MaterialDesign3.Defaults.xaml`). En MahApps, respeta las mayúsculas de `Controls.xaml`, `Fonts.xaml` y `Light.Blue.xaml`.

```xml
<Application x:Class="PlantillaExamen.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- 1. Tema MaterialDesign (BaseTheme="Light" o "Dark") -->
                <materialDesign:BundledTheme BaseTheme="Light" PrimaryColor="Indigo" SecondaryColor="Amber" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />

                <!-- 2. Diccionarios MahApps.Metro -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml" />
            </ResourceDictionary.MergedDictionaries>

            <!-- 3. Paleta de colores corporativos reutilizables con {StaticResource ...} -->
            <SolidColorBrush x:Key="PrimaryColor" Color="#0F2C59"/>
            <SolidColorBrush x:Key="SecondaryColor" Color="#1E3E62"/>
            <SolidColorBrush x:Key="AccentColor" Color="#FF6500"/>
            <SolidColorBrush x:Key="BackgroundLight" Color="#F5F7FA"/>
            <SolidColorBrush x:Key="CardBackground" Color="#FFFFFF"/>
            <SolidColorBrush x:Key="TextDark" Color="#1E293B"/>
            <SolidColorBrush x:Key="TextMuted" Color="#64748B"/>
            <SolidColorBrush x:Key="BorderSubtle" Color="#E2E8F0"/>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

---

### 1.3. Opción A de Ventana: `mah:MetroWindow` con `RightWindowCommands`
*Extraído de: `di.unidad3.ejercicio1/MainWindow.xaml` y `di.unidad3.ejercicio3/MainWindow.xaml`*

```xml
<mah:MetroWindow x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        Title="SISTEMA DE GESTIÓN"
        Height="650" Width="1100"
        WindowStartupLocation="CenterScreen"
        WindowTitleBrush="#0F2C59"
        NonActiveWindowTitleBrush="#1E3E62">

    <!-- Botones en la barra de título superior derecha -->
    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands>
            <Button ToolTip="Mi Perfil">
                <StackPanel Orientation="Horizontal">
                    <mat:PackIcon Kind="Account" VerticalAlignment="Center"/>
                    <TextBlock Text="Admin" Margin="6,0,0,0" VerticalAlignment="Center"/>
                </StackPanel>
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <Grid>
        <!-- Contenido principal -->
    </Grid>
</mah:MetroWindow>
```
**En `MainWindow.xaml.cs`** (¡recuerda heredar de `MetroWindow`!):
```csharp
using MahApps.Metro.Controls;

namespace MiProyecto
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
```

---

### 1.4. Opción B de Ventana: Ventana Sin Bordes Redondeada (`WindowStyle="None"`)
*Extraído de: `Examen_DI_19_11_2025/MainWindow.xaml` y `di.unidad3.ejercicio5/MainWindow.xaml`*

```xml
<Window x:Class="MiProyecto.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        Title="Panel de Gestión" Height="700" Width="1150"
        WindowStartupLocation="CenterScreen"
        WindowStyle="None"
        AllowsTransparency="True"
        Background="Transparent"
        MouseLeftButtonDown="Window_MouseDown">

    <Border Background="#F5F7FA" CornerRadius="12" BorderBrush="#E2E8F0" BorderThickness="1">
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="55"/>
                <RowDefinition Height="*"/>
            </Grid.RowDefinitions>

            <!-- Barra superior personalizada con botones Minimizar, Maximizar y Cerrar -->
            <Border Grid.Row="0" Background="#0F2C59" CornerRadius="12,12,0,0" Padding="20,0">
                <Grid>
                    <TextBlock Text="PANEL DE CONTROL" Foreground="White" FontSize="16" FontWeight="Bold" VerticalAlignment="Center"/>
                    <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Center">
                        <Button Content="—" Width="34" Height="28" Margin="2" Background="Transparent" BorderThickness="0" Foreground="White" Click="Minimize_Click"/>
                        <Button Content="▢" Width="34" Height="28" Margin="2" Background="Transparent" BorderThickness="0" Foreground="White" Click="Maximize_Click"/>
                        <Button Content="✕" Width="34" Height="28" Margin="2" Background="#E11D48" BorderThickness="0" Foreground="White" Click="Close_Click"/>
                    </StackPanel>
                </Grid>
            </Border>

            <!-- Cuerpo de la aplicación -->
            <Grid Grid.Row="1">
            </Grid>
        </Grid>
    </Border>
</Window>
```

---

## 2. Layouts Principales (`Grid`, `DockPanel`, `StackPanel`, Menú Lateral y Pestañas)

### 2.1. Estructura Dashboard Completa (Cabecera + Sidebar + 3 Tarjetas KPI + Contenido)
*Extraído de: `Examen_DI_19_11_2025/MainWindow.xaml` y `00_Plantilla_Examen/PlantillaExamen/MainWindow.xaml`*

```xml
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="220"/> <!-- Menú Lateral Izquierdo -->
        <ColumnDefinition Width="*"/>   <!-- Área Central -->
    </Grid.ColumnDefinitions>

    <!-- 1. SIDEBAR LATERAL CON DOCKPANEL (Botón Salir anclado abajo) -->
    <Border Grid.Column="0" Background="#1E3E62" Padding="14">
        <DockPanel LastChildFill="False">
            <TextBlock DockPanel.Dock="Top" Text="MENÚ PRINCIPAL" Foreground="#94A3B8" FontSize="11" FontWeight="Bold" Margin="5,8,0,12"/>

            <Button DockPanel.Dock="Top" Content="📊 Dashboard" HorizontalContentAlignment="Left" Background="#FF6500" BorderThickness="0" Foreground="White" Height="40" Margin="0,0,0,8"/>
            <Button DockPanel.Dock="Top" Content="👥 Empleados" HorizontalContentAlignment="Left" Background="Transparent" BorderThickness="0" Foreground="White" Height="40" Margin="0,0,0,8"/>
            <Button DockPanel.Dock="Top" Content="➕ Nuevo Empleado" HorizontalContentAlignment="Left" Background="#3A5BFF" BorderThickness="0" Foreground="White" Height="42" FontWeight="Bold" Click="BtnAbrirModal_Click"/>

            <!-- Botón anclado en la parte inferior -->
            <Button DockPanel.Dock="Bottom" Content="Salir" Background="#334155" BorderThickness="0" Foreground="White" Height="38" Click="Close_Click"/>
        </DockPanel>
    </Border>

    <!-- 2. ÁREA CENTRAL: 3 TARJETAS KPI ARRIBA + TABLA/LISTA ABAJO -->
    <Grid Grid.Column="1" Margin="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- 2.1. Tres Tarjetas KPI de Resumen con UniformGrid -->
        <UniformGrid Grid.Row="0" Columns="3" Margin="0,0,0,18">
            <Border Background="White" CornerRadius="10" Padding="16" Margin="0,0,8,0" BorderBrush="#E2E8F0" BorderThickness="1">
                <StackPanel>
                    <TextBlock Text="USUARIOS ACTIVOS" Foreground="#64748B" FontSize="11" FontWeight="Bold"/>
                    <TextBlock x:Name="lblKpi1" Text="128" Foreground="#0F2C59" FontSize="26" FontWeight="Bold" Margin="0,4,0,0"/>
                </StackPanel>
            </Border>
            <Border Background="White" CornerRadius="10" Padding="16" Margin="4,0,4,0" BorderBrush="#E2E8F0" BorderThickness="1">
                <StackPanel>
                    <TextBlock Text="VENTAS DEL MES" Foreground="#64748B" FontSize="11" FontWeight="Bold"/>
                    <TextBlock x:Name="lblKpi2" Text="14.520 €" Foreground="#16A34A" FontSize="26" FontWeight="Bold" Margin="0,4,0,0"/>
                </StackPanel>
            </Border>
            <Border Background="White" CornerRadius="10" Padding="16" Margin="8,0,0,0" BorderBrush="#E2E8F0" BorderThickness="1">
                <StackPanel>
                    <TextBlock Text="INCIDENCIAS" Foreground="#64748B" FontSize="11" FontWeight="Bold"/>
                    <TextBlock x:Name="lblKpi3" Text="3" Foreground="#E11D48" FontSize="26" FontWeight="Bold" Margin="0,4,0,0"/>
                </StackPanel>
            </Border>
        </UniformGrid>

        <!-- 2.2. Contenedor Principal Inferior -->
        <Border Grid.Row="1" Background="White" CornerRadius="10" Padding="18" BorderBrush="#E2E8F0" BorderThickness="1">
            <!-- Aquí va el DataGrid, ListBox o Formulario -->
        </Border>
    </Grid>
</Grid>
```

---

### 2.2. Panel Efecto Cristal (`Glassmorphism`) + `Viewbox` Adaptativo 720p/1080p
*Extraído de: `proyectoDefinitivo/Vista/Dialogo/PantallaLogin.xaml`*

```xml
<Grid>
    <!-- Fondo de imagen a pantalla completa -->
    <Image Source="/Recursos/Imagenes/Onades de seda blava i daurada.png" Stretch="UniformToFill"/>

    <!-- Viewbox DownOnly: escala automáticamente si el monitor del examen es 720p -->
    <Viewbox Stretch="Uniform" StretchDirection="DownOnly" Margin="20">
        <Border Width="750" Height="620"
                BorderBrush="#C79F86" BorderThickness="2"
                CornerRadius="25" Background="#B3101826"
                Padding="120,25,120,25">
            <Border.Effect>
                <DropShadowEffect BlurRadius="40" ShadowDepth="10" Direction="270" Color="Black" Opacity="0.5"/>
            </Border.Effect>

            <Grid>
                <!-- Filas del Login / Registro -->
            </Grid>
        </Border>
    </Viewbox>
</Grid>
```

---

### 2.3. Menú Superior Clásico (`<Menu>`) + Barra de Herramientas (`<ToolBar>`)
*Extraído de: `di.unidad3.ejercicio1/MainWindow.xaml`*

```xml
<DockPanel>
    <!-- 1. Menú desplegable superior -->
    <Menu DockPanel.Dock="Top" Background="White">
        <MenuItem Header="_Archivo">
            <MenuItem Header="Nuevo Registro" Click="BtnNuevo_Click">
                <MenuItem.Icon><mat:PackIcon Kind="FilePlusOutline"/></MenuItem.Icon>
            </MenuItem>
            <Separator/>
            <MenuItem Header="Salir" Click="Close_Click">
                <MenuItem.Icon><mat:PackIcon Kind="ExitToApp"/></MenuItem.Icon>
            </MenuItem>
        </MenuItem>
        <MenuItem Header="_Ayuda">
            <MenuItem Header="Acerca de..."/>
        </MenuItem>
    </Menu>

    <!-- 2. Barra de herramientas con iconos y ToolTip -->
    <ToolBarTray DockPanel.Dock="Top" Background="#F1F5F9">
        <ToolBar>
            <Button ToolTip="Guardar cambios" Click="BtnGuardar_Click">
                <mat:PackIcon Kind="ContentSaveOutline" Width="20" Height="20"/>
            </Button>
            <Separator/>
            <Button ToolTip="Eliminar seleccionado" Click="BtnEliminar_Click">
                <mat:PackIcon Kind="DeleteOutline" Foreground="#E11D48" Width="20" Height="20"/>
            </Button>
        </ToolBar>
    </ToolBarTray>

    <!-- 3. Contenido central -->
    <Grid/>
</DockPanel>
```

---

### 2.4. Menú Lateral Desplegable con Acordeón (`<Expander>`)
*Extraído de: `di.unidad3.ejercicio3/MainWindow.xaml`*

> **Nota importante**: Si pones `<ListViewItem>` estáticos dentro del `<ListView>`, **NO** pongas `ItemsSource="{Binding ...}"` a la vez o WPF lanzará `InvalidOperationException`.

```xml
<Grid DockPanel.Dock="Left" Background="#E5303030" Width="250">
    <StackPanel Margin="10">
        <!-- Opción directa -->
        <Grid>
            <mat:PackIcon Kind="ViewDashboard" Width="16" Height="16" Margin="10,16" Foreground="White"/>
            <ListBoxItem Content="Dashboard" Padding="37,14" FontSize="15" Foreground="White"
                         Style="{StaticResource MaterialDesignListBoxItem}"/>
        </Grid>

        <!-- Bloque desplegable Expander -->
        <Grid>
            <mat:PackIcon Kind="Settings" Width="16" Height="16" Margin="10,16" Foreground="White"/>
            <Expander IsExpanded="False" Width="210" HorizontalAlignment="Right"
                      Header="Configuración" Style="{StaticResource MaterialDesignExpander}"
                      Background="{x:Null}" Foreground="White">
                <ListView Foreground="White" Style="{StaticResource MaterialDesignListView}"
                          ScrollViewer.HorizontalScrollBarVisibility="Disabled">
                    <ListViewItem Content="Usuarios" Padding="20,5"/>
                    <ListViewItem Content="Hardware" Padding="20,5"/>
                    <ListViewItem Content="Software" Padding="20,5"/>
                </ListView>
            </Expander>
        </Grid>
    </StackPanel>
</Grid>
```

---

### 2.5. Menú Hamburguesa (`<mah:HamburgerMenu>`) con `DataTemplate`
*Extraído de: `di.unidad3.ejercicio4/MainWindow.xaml`*

```xml
<mah:MetroWindow.Resources>
    <DataTemplate x:Key="MenuItemTemplateIcon" DataType="{x:Type mah:HamburgerMenuIconItem}">
        <Grid Height="48">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="48"/>
                <ColumnDefinition/>
            </Grid.ColumnDefinitions>
            <ContentControl Grid.Column="0" Content="{Binding Icon}" HorizontalAlignment="Center" VerticalAlignment="Center" Foreground="White"/>
            <TextBlock Grid.Column="1" Text="{Binding Label}" VerticalAlignment="Center" FontSize="15" Foreground="White"/>
        </Grid>
    </DataTemplate>
</mah:MetroWindow.Resources>

<Grid>
    <mah:HamburgerMenu x:Name="hamMenuPrincipal"
                       Foreground="White" PaneBackground="#3B3B3B"
                       DisplayMode="CompactInline"
                       ItemTemplate="{StaticResource MenuItemTemplateIcon}"
                       OptionsItemTemplate="{StaticResource MenuItemTemplateIcon}">
        <mah:HamburgerMenu.ItemsSource>
            <mah:HamburgerMenuItemCollection>
                <mah:HamburgerMenuIconItem Label="Préstamos" Icon="{mat:PackIcon Kind=Sync}"/>
                <mah:HamburgerMenuIconItem Label="Artículos" Icon="{mat:PackIcon Kind=PackageVariantClosed}"/>
                <mah:HamburgerMenuIconItem Label="Inventario" Icon="{mat:PackIcon Kind=ClipboardListOutline}"/>
            </mah:HamburgerMenuItemCollection>
        </mah:HamburgerMenu.ItemsSource>
        <mah:HamburgerMenu.OptionsItemsSource>
            <mah:HamburgerMenuItemCollection>
                <mah:HamburgerMenuIconItem Label="Ayuda" Icon="{mat:PackIcon Kind=Help}"/>
            </mah:HamburgerMenuItemCollection>
        </mah:HamburgerMenu.OptionsItemsSource>
    </mah:HamburgerMenu>
</Grid>
```

---

### 2.6. Cinta de Opciones `<Fluent:Ribbon>` con `<Fluent:Backstage>`
*Extraído de: `di.unidad3.ejercicio2/MainWindow.xaml`*
*(Requiere en `App.xaml`: `<ResourceDictionary Source="pack://application:,,,/Fluent;Component/Themes/Generic.xaml" />`)*

```xml
<Fluent:Ribbon VerticalAlignment="Top">
    <!-- Menú Archivo (Backstage) -->
    <Fluent:Ribbon.Menu>
        <Fluent:Backstage>
            <Fluent:BackstageTabControl>
                <Fluent:BackstageTabItem Header="Opciones"/>
                <Fluent:Button Header="Cerrar" Click="Close_Click"/>
            </Fluent:BackstageTabControl>
        </Fluent:Backstage>
    </Fluent:Ribbon.Menu>

    <!-- Pestaña 1 -->
    <Fluent:RibbonTabItem Header="PRÉSTAMOS">
        <Fluent:RibbonGroupBox Header="Operaciones">
            <Fluent:Button Header="Salida" Icon="/recursos/Iconos/addarticulo.png"/>
            <Fluent:Button Header="Devolución" Icon="/recursos/Iconos/gesarticulo.png"/>
        </Fluent:RibbonGroupBox>
        <Fluent:RibbonGroupBox Header="Búsquedas">
            <StackPanel>
                <TextBlock Text="Por número de serie" FontWeight="Bold"/>
                <TextBox Width="150" Margin="0,8,0,0"/>
            </StackPanel>
        </Fluent:RibbonGroupBox>
    </Fluent:RibbonTabItem>
</Fluent:Ribbon>
```

---

### 2.7. Formas Geométricas, Giro (`RotateTransform`) y Recorte Circular (`OpacityMask`)
*Extraído de: `di.unidad2.ejercicio8/MainWindow.xaml` y `di.unidad2.ejercicio10/MainWindow.xaml`*

```xml
<!-- 1. Rectángulo con degradado girado -30 grados (di.unidad2.ejercicio8) -->
<Rectangle Width="440" Height="110" VerticalAlignment="Bottom" Margin="50,0,0,-70">
    <Rectangle.Fill>
        <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
            <GradientStop Color="#FF224268" Offset="0"/>
            <GradientStop Color="#FF142135" Offset="0.8"/>
        </LinearGradientBrush>
    </Rectangle.Fill>
    <Rectangle.RenderTransform>
        <RotateTransform Angle="-30"/>
    </Rectangle.RenderTransform>
</Rectangle>

<!-- 2. Avatar circular recortado con OpacityMask (di.unidad2.ejercicio10) -->
<Grid Width="120" Height="120">
    <Ellipse x:Name="Mask" Fill="White"/>
    <Image Source="/Recursos/Imagenes/LocoClaro.jpg" Stretch="UniformToFill">
        <Image.OpacityMask>
            <VisualBrush Visual="{Binding ElementName=Mask}"/>
        </Image.OpacityMask>
    </Image>
    <Ellipse Stroke="White" StrokeThickness="3"/>
</Grid>
```

---

## 3. Controles de Formulario, `DataGrid` y Botones de Acción

### 3.1. `TextBox` y `PasswordBox` Outlined con Icono `PackIcon` y `Triggers` de Foco
*Extraído de: `proyectoDefinitivo/Vista/Dialogo/PantallaLogin.xaml`*

```xml
<!-- TEXTBOX CON ICONO Y CAMBIO DE COLOR AL RECIBIR EL FOCO -->
<TextBox x:Name="txtCorreo"
         CaretBrush="White"
         materialDesign:HintAssist.Foreground="#99C79F86"
         materialDesign:HintAssist.Background="Transparent"
         materialDesign:TextFieldAssist.UnderlineBrush="#000C38"
         materialDesign:TextFieldAssist.HasClearButton="True"
         materialDesign:TextFieldAssist.TextFieldCornerRadius="15">
    <TextBox.Style>
        <Style TargetType="TextBox" BasedOn="{StaticResource MaterialDesignOutlinedTextBox}">
            <Setter Property="Background" Value="#40000000"/>
            <Setter Property="Foreground" Value="White"/>
            <Setter Property="BorderBrush" Value="#C79F86"/>
            <Style.Triggers>
                <Trigger Property="IsKeyboardFocused" Value="True">
                    <Setter Property="Background" Value="#80000000"/>
                    <Setter Property="BorderBrush" Value="#000C38"/>
                </Trigger>
            </Style.Triggers>
        </Style>
    </TextBox.Style>
    <materialDesign:HintAssist.Hint>
        <StackPanel Orientation="Horizontal" Margin="-2,0,0,0">
            <mat:PackIcon Kind="EmailOutline" Margin="0,0,8,0" VerticalAlignment="Center" Foreground="#C79F86"/>
            <TextBlock Text="Correo electrónico" VerticalAlignment="Center" Foreground="#C79F86"/>
        </StackPanel>
    </materialDesign:HintAssist.Hint>
</TextBox>

<!-- PASSWORDBOX CON ICONO CANDADO Y BOTÓN DE MOSTRAR CONTRASEÑA -->
<PasswordBox x:Name="txtPass"
             CaretBrush="White"
             materialDesign:HintAssist.Foreground="#99C79F86"
             materialDesign:TextFieldAssist.TextFieldCornerRadius="15"
             materialDesign:PasswordBoxAssist.IsPasswordRevealed="False">
    <PasswordBox.Style>
        <Style TargetType="PasswordBox" BasedOn="{StaticResource MaterialDesignOutlinedPasswordBox}">
            <Setter Property="Background" Value="#40000000"/>
            <Setter Property="Foreground" Value="White"/>
            <Setter Property="BorderBrush" Value="#C79F86"/>
            <Style.Triggers>
                <Trigger Property="IsKeyboardFocused" Value="True">
                    <Setter Property="Background" Value="#80000000"/>
                    <Setter Property="BorderBrush" Value="#000C38"/>
                </Trigger>
            </Style.Triggers>
        </Style>
    </PasswordBox.Style>
    <materialDesign:HintAssist.Hint>
        <StackPanel Orientation="Horizontal" Margin="-2,0,0,0">
            <mat:PackIcon Kind="LockOutline" Margin="0,0,8,0" VerticalAlignment="Center" Foreground="#C79F86"/>
            <TextBlock Text="Contraseña" VerticalAlignment="Center" Foreground="#C79F86"/>
        </StackPanel>
    </materialDesign:HintAssist.Hint>
</PasswordBox>
```

---

### 3.2. `ComboBox`, `DatePicker`, Contador de Caracteres (`0/45`) y `NumericUpDown`
*Extraído de: `di.unidad2.ejercicio12..15/MainWindow.xaml`*

```xml
<!-- 1. TextBox con contador de caracteres (0 / 45) y texto de ayuda -->
<TextBox x:Name="txtNombreProducto"
         Style="{StaticResource MaterialDesignFloatingHintTextBox}"
         mat:HintAssist.Hint="Nombre del Producto *"
         mat:HintAssist.HelperText="Obligatorio (máx. 45 caracteres)"
         MaxLength="45"
         mat:TextFieldAssist.CharacterCounterVisibility="Visible"
         Margin="0,0,0,18"/>

<!-- 2. ComboBox desplegable con etiqueta flotante -->
<ComboBox x:Name="cmbCategoria"
          Style="{StaticResource MaterialDesignFloatingHintComboBox}"
          mat:HintAssist.Hint="Categoría *"
          SelectedIndex="0"
          Margin="0,0,0,18">
    <ComboBoxItem Content="Electrónica"/>
    <ComboBoxItem Content="Mobiliario"/>
    <ComboBoxItem Content="Periféricos"/>
</ComboBox>

<!-- 3. Selector de fecha DatePicker -->
<DatePicker x:Name="dpFechaAlta"
            Style="{StaticResource MaterialDesignFloatingHintDatePicker}"
            mat:HintAssist.Hint="Fecha de alta"
            Margin="0,0,0,18"/>

<!-- 4. Selector numérico MahApps para Precios (€) o Unidades -->
<mah:NumericUpDown x:Name="numPrecio"
                   Minimum="0" Maximum="99999" Interval="0.50"
                   Value="25.00" StringFormat="C2"
                   mat:HintAssist.Hint="Precio unitario (€)"
                   Margin="0,0,0,18"/>
```

---

### 3.3. `DataGrid` con Columnas Personalizadas Enlazado a `ObservableCollection<T>`
*Extraído de: `00_Plantilla_Examen/PlantillaExamen/MainWindow.xaml`*

```xml
<DataGrid x:Name="dgRegistros"
          AutoGenerateColumns="False"
          IsReadOnly="True"
          CanUserAddRows="False"
          SelectionMode="Single"
          SelectionChanged="DgRegistros_SelectionChanged">
    <DataGrid.Columns>
        <DataGridTextColumn Header="ID" Binding="{Binding Id}" Width="55"/>
        <DataGridTextColumn Header="Nombre" Binding="{Binding Nombre}" Width="*"/>
        <DataGridTextColumn Header="Categoría" Binding="{Binding Categoria}" Width="120"/>
        <DataGridTextColumn Header="Fecha" Binding="{Binding Fecha}" Width="105"/>
        <DataGridTextColumn Header="Importe" Binding="{Binding Importe, StringFormat={}{0:C2}}" Width="100"/>
        <DataGridCheckBoxColumn Header="Activo" Binding="{Binding Activo}" Width="75"/>

        <!-- Columna de botones de acción dentro de cada fila -->
        <DataGridTemplateColumn Header="Acciones" Width="100">
            <DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <Button Content="Borrar" Padding="8,2" Height="26"
                            Background="#E11D48" BorderBrush="#E11D48" Foreground="White"
                            Click="BtnEliminarFila_Click"/>
                </DataTemplate>
            </DataGridTemplateColumn.CellTemplate>
        </DataGridTemplateColumn>
    </DataGrid.Columns>
</DataGrid>
```

---

### 3.4. Botones de Acción (Degradado Redondeado, Outlined y Flotante `FAB`)
*Extraído de: `proyectoDefinitivo/Vista/Dialogo/PantallaLogin.xaml` y `di.unidad2.ejercicio10/MainWindow.xaml`*

```xml
<!-- Botón Principal Redondeado con Degradado -->
<Button x:Name="btnGuardar" Content="Guardar Registro" Click="BtnGuardar_Click"
        Height="42" FontSize="16" FontWeight="Bold" Foreground="#101826"
        mat:ButtonAssist.CornerRadius="21">
    <Button.Background>
        <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
            <GradientStop Color="#8B5D50" Offset="0.0"/>
            <GradientStop Color="#E7B8A0" Offset="1.0"/>
        </LinearGradientBrush>
    </Button.Background>
    <Button.BorderBrush>
        <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
            <GradientStop Color="#8B5D50" Offset="0.0"/>
            <GradientStop Color="#E7B8A0" Offset="1.0"/>
        </LinearGradientBrush>
    </Button.BorderBrush>
</Button>

<!-- Botón Secundario Outlined -->
<Button Content="Limpiar Formulario" Click="BtnLimpiar_Click"
        Style="{StaticResource MaterialDesignOutlinedButton}" Height="36"/>

<!-- Botón Flotante Circular (FAB) -->
<Button Style="{StaticResource MaterialDesignFloatingActionMiniLightButton}"
        Background="#FF6500" BorderBrush="#FF6500" Foreground="White"
        ToolTip="Añadir rápido" Click="BtnAbrirModal_Click">
    <mat:PackIcon Kind="Plus" Width="20" Height="20"/>
</Button>
```

---

## 4. Eventos en Code-Behind, MVVM, Diálogos Modales y SQLite

### 4.1. Mover Ventana Sin Bordes (`DragMove`) + Minimizar, Maximizar y Cerrar
*Extraído de: `Examen_DI_19_11_2025/MainWindow.xaml.cs`*

```csharp
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
    this.WindowState = this.WindowState == WindowState.Maximized
        ? WindowState.Normal
        : WindowState.Maximized;
}

private void Close_Click(object sender, RoutedEventArgs e)
{
    this.Close();
}
```

---

### 4.2. Validación de Formularios + `MessageBox` y `ShowMessageAsync` (MahApps)
*Extraído de: `proyectoDefinitivo/Vista/Dialogo/registro.xaml.cs` y `00_Plantilla_Examen`*

```csharp
// OPCIÓN A: Con MessageBox estándar de WPF (funciona en cualquier Window)
private void BtnGuardar_Click(object sender, RoutedEventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtNombre.Text))
    {
        MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
        txtNombre.Focus();
        return;
    }

    string categoria = (cmbCategoria.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "General";
    string fecha = dpFecha.SelectedDate?.ToString("dd/MM/yyyy") ?? DateTime.Today.ToString("dd/MM/yyyy");
    double importe = numImporte.Value ?? 0.0;

    ListaRegistros.Add(new RegistroItem
    {
        Id = ListaRegistros.Count + 1,
        Nombre = txtNombre.Text.Trim(),
        Categoria = categoria,
        Fecha = fecha,
        Importe = importe,
        Activo = chkActivo.IsChecked == true
    });
}

// OPCIÓN B: Con diálogo integrado de MahApps.Metro (requiere MetroWindow y 'async')
// using MahApps.Metro.Controls.Dialogs;
private async void BtnRegistrar_Click(object sender, RoutedEventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtcorreo.Text) || string.IsNullOrWhiteSpace(passClaveAcceso.Password))
    {
        await this.ShowMessageAsync("Campos incompletos", "Por favor, rellena todos los campos.");
        return;
    }

    if (passClaveAcceso.Password != passClaveAccesoRepetir.Password)
    {
        await this.ShowMessageAsync("Error", "Las contraseñas no coinciden.");
        return;
    }

    await this.ShowMessageAsync("¡Éxito!", "Usuario registrado correctamente.");
    this.Close();
}
```

---

### 4.3. Apertura de Ventana Secundaria Modal (`ShowDialog()`) y Paso de Datos
*Extraído de: `Examen_DI_19_11_2025/MainWindow.xaml.cs` y `00_Plantilla_Examen/Vista/Dialogo/VentanaSecundaria.xaml.cs`*

```csharp
// 1. EN LA VENTANA PRINCIPAL (MainWindow.xaml.cs):
private void BtnAbrirModal_Click(object sender, RoutedEventArgs e)
{
    var dialogo = new VentanaSecundaria { Owner = this };
    if (dialogo.ShowDialog() == true && dialogo.NuevoRegistro != null)
    {
        ListaRegistros.Add(dialogo.NuevoRegistro);
    }
}

// 2. EN LA VENTANA SECUNDARIA (VentanaSecundaria.xaml.cs):
public RegistroItem? NuevoRegistro { get; private set; }

private void BtnAceptar_Click(object sender, RoutedEventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtModalNombre.Text))
    {
        MessageBox.Show("Introduce un nombre.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
        return;
    }

    NuevoRegistro = new RegistroItem
    {
        Nombre = txtModalNombre.Text.Trim(),
        Categoria = (cmbModalCategoria.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "General",
        Fecha = DateTime.Today.ToString("dd/MM/yyyy"),
        Importe = numModalImporte.Value ?? 0
    };

    this.DialogResult = true; // Devuelve true a ShowDialog() y cierra la ventana
    this.Close();
}

private void BtnCancelar_Click(object sender, RoutedEventArgs e)
{
    this.DialogResult = false;
    this.Close();
}
```

---

### 4.4. Cambio de Ventana Login ↔ `MainWindow` e Inyección de Dependencias (`App.xaml.cs`)
*Extraído de: `proyectoDefinitivo/App.xaml.cs` y `proyectoDefinitivo/MainWindow.xaml.cs`*

```csharp
// CAMBIAR DE LOGIN A MAINWINDOW (O CERRAR SESIÓN VOLVIENDO AL LOGIN):
private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
{
    var login = new PantallaLogin();
    Application.Current.MainWindow = login;
    login.Show();
    this.Close();
}

// CONFIGURACIÓN DE INYECCIÓN DE DEPENDENCIAS EN App.xaml.cs
// (Recuerda quitar StartupUri="MainWindow.xaml" de App.xaml si usas OnStartup)
using Microsoft.Extensions.DependencyInjection;

public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App()
    {
        var services = new ServiceCollection();
        services.AddTransient<MainWindow>();
        services.AddTransient<PantallaLogin>();
        services.AddTransient<Func<MainWindow>>(sp => () => sp.GetRequiredService<MainWindow>());
        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var loginWindow = _serviceProvider.GetRequiredService<PantallaLogin>();
        MainWindow = loginWindow;
        loginWindow.Show();
    }
}
```

---

### 4.5. Base de Datos SQLite Completa (`CREATE TABLE`, `INSERT`, `SELECT`, `DELETE`)
*Extraído de: `Examen_DI_19_11_2025/MainWindow.xaml.cs` y `00_Plantilla_Examen/PlantillaExamen/MainWindow.xaml.cs`*

```csharp
using Microsoft.Data.Sqlite;

private const string DbFile = "datos_examen.db";

private void EnsureDatabaseExists()
{
    using var conn = new SqliteConnection($"Data Source={DbFile}");
    conn.Open();
    string sql = @"
        CREATE TABLE IF NOT EXISTS Registros (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Categoria TEXT NOT NULL,
            Fecha TEXT NOT NULL,
            Importe REAL NOT NULL,
            Activo INTEGER NOT NULL
        );";
    using var cmd = new SqliteCommand(sql, conn);
    cmd.ExecuteNonQuery();
}

private void InsertarEnSqlite(RegistroItem item)
{
    using var conn = new SqliteConnection($"Data Source={DbFile}");
    conn.Open();
    string sql = @"INSERT INTO Registros (Nombre, Categoria, Fecha, Importe, Activo)
                   VALUES (@n, @c, @f, @i, @a);
                   SELECT last_insert_rowid();";
    using var cmd = new SqliteCommand(sql, conn);
    cmd.Parameters.AddWithValue("@n", item.Nombre);
    cmd.Parameters.AddWithValue("@c", item.Categoria);
    cmd.Parameters.AddWithValue("@f", item.Fecha);
    cmd.Parameters.AddWithValue("@i", item.Importe);
    cmd.Parameters.AddWithValue("@a", item.Activo ? 1 : 0);

    item.Id = Convert.ToInt32(cmd.ExecuteScalar());
    ListaRegistros.Add(item);
}

private void CargarDesdeSqlite()
{
    ListaRegistros.Clear();
    using var conn = new SqliteConnection($"Data Source={DbFile}");
    conn.Open();
    using var cmd = new SqliteCommand("SELECT Id, Nombre, Categoria, Fecha, Importe, Activo FROM Registros", conn);
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
}
```

---

### 4.6. Esqueleto Rápido MVVM (`INotifyPropertyChanged` + `RelayCommand`)
*Para copiar en `ViewModel/BaseViewModel.cs` si el enunciado del examen exige patrón MVVM estricto sin eventos en Code-Behind:*

```csharp
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PlantillaExamen.ViewModel
{
    // 1. Clase base para Modelos y ViewModels
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }

    // 2. Comando reutilizable para enlazar con Command="{Binding GuardarCommand}" en XAML
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
