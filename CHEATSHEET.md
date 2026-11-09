# 📑 CHEATSHEET TÉCNICA - DISEÑO DE INTERFACES (DI) - WPF / C# / XAML
> **Repositorio analizado**: [https://github.com/Guillear14/disenyo-de-interfaces](https://github.com/Guillear14/disenyo-de-interfaces)
> **Propósito**: Guía y chuleta técnica optimizada para consulta rápida durante exámenes de Desarrollo de Interfaces (DAM).
> **Búsqueda Rápida**: Utiliza `Ctrl + F` para saltar inmediatamente a cualquier control, librería, estilo o evento.

---

## 🔍 MATRIZ DE BÚSQUEDA RÁPIDA POR PALABRAS CLAVE

| Concepto / Control Técnico | Palabras Clave Principales | Ejercicios de Referencia |
| :--- | :--- | :--- |
| **Ventana Metro / MahApps** | `mah:MetroWindow`, `RightWindowCommands`, `WindowCommands` | [Unidad 2 - Ej. 2](#ejercicio-unidad-2---ejercicio-2), [Unidad 2 - Ej. 4](#ejercicio-unidad-2---ejercicio-4), [Unidad 3 - Ej. 1](#ejercicio-unidad-3---ejercicio-1), [Unidad 3 - Ej. 2](#ejercicio-unidad-3---ejercicio-2), [Unidad 3 - Ej. 3](#ejercicio-unidad-3---ejercicio-3), [Unidad 3 - Ej. 4](#ejercicio-unidad-3---ejercicio-4), [Proyecto Definitivo](#ejercicio-proyecto-definitivo) |
| **Ventana Sin Borde OS + Arrastre** | `WindowStyle="None"`, `DragMove()`, `Window_MouseDown` | [Unidad 2 - Ej. 1](#ejercicio-unidad-2---ejercicio-1), [Unidad 2 - Ej. 8](#ejercicio-unidad-2---ejercicio-8), [Unidad 2 - Ej. 9](#ejercicio-unidad-2---ejercicio-9), [Unidad 2 - Ej. 10](#ejercicio-unidad-2---ejercicio-10), [Unidad 2 - Ej. 11](#ejercicio-unidad-2---ejercicio-11), [Unidad 2 - Ej. 12](#ejercicio-unidad-2---ejercicio-12), [Unidad 2 - Ej. 13](#ejercicio-unidad-2---ejercicio-13), [Unidad 2 - Ej. 14](#ejercicio-unidad-2---ejercicio-14), [Unidad 2 - Ej. 15](#ejercicio-unidad-2---ejercicio-15) |
| **Ventana Transparente / Curva** | `AllowsTransparency="True"`, `CornerRadius`, `OpacityMask` | [Unidad 2 - Ej. 1](#ejercicio-unidad-2---ejercicio-1), [Unidad 2 - Ej. 6](#ejercicio-unidad-2---ejercicio-6), [Unidad 2 - Ej. 7](#ejercicio-unidad-2---ejercicio-7) |
| **Controles de Ventana (Min/Max/Close)** | `WindowState.Minimized`, `WindowState.Maximized`, `this.Close()` | [Unidad 2 - Ej. 1](#ejercicio-unidad-2---ejercicio-1), [Unidad 2 - Ej. 12](#ejercicio-unidad-2---ejercicio-12), [Unidad 2 - Ej. 13](#ejercicio-unidad-2---ejercicio-13), [Unidad 2 - Ej. 14](#ejercicio-unidad-2---ejercicio-14), [Unidad 2 - Ej. 15](#ejercicio-unidad-2---ejercicio-15) |
| **Degradados Visuales** | `LinearGradientBrush`, `GradientStop`, `RotateTransform` | [Unidad 2 - Ej. 8](#ejercicio-unidad-2---ejercicio-8), [Unidad 2 - Ej. 10](#ejercicio-unidad-2---ejercicio-10), [Unidad 2 - Ej. 11](#ejercicio-unidad-2---ejercicio-11), [Proyecto Definitivo](#ejercicio-proyecto-definitivo) |
| **Formularios Material Design** | `MaterialDesignFloatingHintTextBox`, `ComboBox`, `DatePicker` | [Unidad 2 - Ej. 12](#ejercicio-unidad-2---ejercicio-12), [Unidad 2 - Ej. 13](#ejercicio-unidad-2---ejercicio-13), [Unidad 2 - Ej. 14](#ejercicio-unidad-2---ejercicio-14), [Unidad 2 - Ej. 15](#ejercicio-unidad-2---ejercicio-15) |
| **Controles Numéricos MahApps** | `mah:NumericUpDown`, `StringFormat`, `Interval`, `Minimum` | [Unidad 2 - Ej. 14](#ejercicio-unidad-2---ejercicio-14), [Unidad 2 - Ej. 15](#ejercicio-unidad-2---ejercicio-15) |
| **Iconos Vectoriales** | `mat:PackIcon Kind="..."`, `Account`, `Key`, `Close` | [Unidad 2 - Ej. 2](#ejercicio-unidad-2---ejercicio-2), [Unidad 2 - Ej. 5](#ejercicio-unidad-2---ejercicio-5), [Unidad 2 - Ej. 9](#ejercicio-unidad-2---ejercicio-9), [Unidad 3 - Ej. 1](#ejercicio-unidad-3---ejercicio-1), [Unidad 3 - Ej. 3](#ejercicio-unidad-3---ejercicio-3), [Proyecto Definitivo](#ejercicio-proyecto-definitivo) |
| **Menús Jerárquicos y ToolBars** | `Menu`, `MenuItem`, `ToolBar`, `ToolBarTray`, `ToolTip` | [Unidad 3 - Ej. 1](#ejercicio-unidad-3---ejercicio-1), [Proyecto Definitivo](#ejercicio-proyecto-definitivo) |
| **Cinta de Opciones Ribbon** | `Fluent:Ribbon`, `RibbonTabItem`, `RibbonGroupBox`, `Backstage` | [Unidad 3 - Ej. 2](#ejercicio-unidad-3---ejercicio-2) |
| **Menú Acordeón / Desplegable** | `Expander`, `MaterialDesignExpander`, `ListView` | [Unidad 3 - Ej. 3](#ejercicio-unidad-3---ejercicio-3) |
| **Menú Hamburguesa** | `mah:HamburgerMenu`, `HamburgerMenuIconItem`, `DataTemplate` | [Unidad 3 - Ej. 4](#ejercicio-unidad-3---ejercicio-4) |
| **Diálogo Asíncrono y Navegación** | `ShowMessageAsync`, `ventana.Show()`, `this.Close()` | [Proyecto Definitivo](#ejercicio-proyecto-definitivo) |
| **Configuración Global App.xaml** | `ResourceDictionary.MergedDictionaries`, `BundledTheme` | [Proyecto Definitivo](#ejercicio-proyecto-definitivo), [Configuración Global](#configuración-global-appxaml) |

---

## 📑 ÍNDICE DE EJERCICIOS

- [Unidad 2 - Ejercicio 1: Safetyboost Dashboard - Interfaz Principal Estilo Dashboard](#ejercicio-unidad-2---ejercicio-1)
- [Unidad 2 - Ejercicio 2: Login "Welcome Folk" - MahApps MetroWindow y Material Design](#ejercicio-unidad-2---ejercicio-2)
- [Unidad 2 - Ejercicio 3: Sign In To Your Account - Formulario Vertical Limpio con Botones Sociales](#ejercicio-unidad-2---ejercicio-3)
- [Unidad 2 - Ejercicio 4: Matisse Dark Login - MetroWindow Sin Barra de Título ni Botones de Control](#ejercicio-unidad-2---ejercicio-4)
- [Unidad 2 - Ejercicio 5: Bienvenido a Inventario Matisse - Cajas Outlined, Redondeadas y Botones Mini](#ejercicio-unidad-2---ejercicio-5)
- [Unidad 2 - Ejercicio 6: Esquinas Redondeadas con Border y OpacityMask VisualBrush para Imágenes](#ejercicio-unidad-2---ejercicio-6)
- [Unidad 2 - Ejercicio 7: Bienvenidos ! Ventana Flotante Transparente y Tarjetas Superpuestas](#ejercicio-unidad-2---ejercicio-7)
- [Unidad 2 - Ejercicio 8: IES Matisse con Franja Inclinada Degradada y Arrastre de Ventana (DragMove)](#ejercicio-unidad-2---ejercicio-8)
- [Unidad 2 - Ejercicio 9: Login Dividido Fondo Crema con Iconos PackIcon Integrados en Cajas](#ejercicio-unidad-2---ejercicio-9)
- [Unidad 2 - Ejercicio 10: Login con Fondo Degradado Horizontal Rojo-Azul e Inputs Píldora](#ejercicio-unidad-2---ejercicio-10)
- [Unidad 2 - Ejercicio 11: Login con Semicírculo Degradado Naranja y Avatar Circular](#ejercicio-unidad-2---ejercicio-11)
- [Unidad 2 - Ejercicio 12: Formulario Insertar Artículo Material Design con Controles Personalizados](#ejercicio-unidad-2---ejercicio-12)
- [Unidad 2 - Ejercicio 13: Formulario Añadir Usuario Material Design con Múltiples Secciones](#ejercicio-unidad-2---ejercicio-13)
- [Unidad 2 - Ejercicio 14: Formulario Gestión Productos con NumericUpDown de MahApps](#ejercicio-unidad-2---ejercicio-14)
- [Unidad 2 - Ejercicio 15: Formulario Gestión Clientes con NumericUpDown para Límite de Crédito](#ejercicio-unidad-2---ejercicio-15)
- [Unidad 3 - Ejercicio 1: Inventario Matisse con Menu Jerárquico y Barra de Herramientas ToolBar](#ejercicio-unidad-3---ejercicio-1)
- [Unidad 3 - Ejercicio 2: Cinta de Opciones Fluent Ribbon Estilo Office](#ejercicio-unidad-3---ejercicio-2)
- [Unidad 3 - Ejercicio 3: Menú Desplegable Lateral con Expander y ListView](#ejercicio-unidad-3---ejercicio-3)
- [Unidad 3 - Ejercicio 4: Menú Hamburguesa con HamburgerMenu de MahApps](#ejercicio-unidad-3---ejercicio-4)
- [Proyecto Definitivo: Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow](#ejercicio-proyecto-definitivo)

---

## Ejercicio: Unidad 2 - Ejercicio 1
**Título**: Safetyboost Dashboard - Interfaz Principal Estilo Dashboard  
**Palabras clave técnicas**: `Dashboard`, `DockPanel`, `StackPanel`, `Grid`, `Grid.ColumnSpan`, `Grid.RowSpan`, `WindowStyle=None`, `AllowsTransparency`, `WindowState=Maximized`, `Eventos de Ventana`, `Minimizar`, `Maximizar`, `Cerrar`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 1 - Safetyboost Dashboard - Interfaz Principal Estilo Dashboard
- **Archivo**: `di.unidad2.ejercicio1/di.unidad2.ejercicio1/MainWindow.xaml`
- **Inicio**: Línea 15: <Window x:Class="di.unidad2.ejercicio1.MainWindow"...
- **Fin**: Línea 175: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio1"
        mc:Ignorable="d"
        WindowStyle="None" AllowsTransparency="True"
        Title="MainWindow" WindowState="Maximized">

    <!-- <DockPanel>: Contenedor que ancla elementos a los bordes (Left, Top, etc.) -->
    <DockPanel>

        <!-- ==================================================================== -->
        <!-- PARTE LATERAL IZQUIERDA: Menu de navegacion vertical                 -->
        <!-- DockPanel.Dock="Left": Se ancla al lado izquierdo de la pantalla     -->
        <!-- Width="200": Ancho fijo de 200 pixeles                                -->
        <!-- Background="#333": Color gris oscuro de fondo                         -->
        <!-- ==================================================================== -->
        <StackPanel DockPanel.Dock="Left" Width="200" Background="#333">
            <!-- Icono principal superior con margen: izq=20, arr=20, der=20, abj=0 -->
            <Image Source="/recursos/iconos/TV.png" Width="64" Margin="20,20,20,0" />
            <!-- Texto del titulo del menu lateral -->
            <TextBlock Text="Make work" Foreground="White" FontWeight="Bold" HorizontalAlignment="Center"></TextBlock>

            <!-- Boton 'stats' con fondo transparente para que se vea el panel -->
            <Button Margin="20,20,20,5" Background="Transparent" Height="30" HorizontalAlignment="Left" BorderBrush="Black">
                <!-- StackPanel horizontal para poner el icono a la izquierda y el texto al lado -->
                <StackPanel Orientation="Horizontal">
                    <Image Source="/recursos/iconos/LineChart.png" Width="24" HorizontalAlignment="Left" Margin="20,0,0,0"></Image>
                    <TextBlock Text="stats" Foreground="White" VerticalAlignment="Center" Margin="30, 0, 52,0" FontSize="14"></TextBlock>
                </StackPanel>
            </Button>

            <!-- Boton 'safetyboost' -->
            <Button Margin="20,0,20,0" Background="Transparent" Height="30" HorizontalAlignment="Left" BorderBrush="Black">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/recursos/iconos/Lock.png" Width="24" HorizontalAlignment="Left" Margin="20,0,0,0"></Image>
                    <TextBlock Text="safetyboost" Foreground="White" VerticalAlignment="Center" Margin="30, 0, 38,0" FontSize="14"></TextBlock>
                </StackPanel>
            </Button>

            <!-- Boton 'trash' (papelera) -->
            <Button Margin="20,5,20,0" Background="Transparent" Height="30" HorizontalAlignment="Left" BorderBrush="Black">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/recursos/iconos/Trash.png" Width="24" HorizontalAlignment="Left" Margin="20,0,0,0"></Image>
                    <TextBlock Text="trash" Foreground="White" VerticalAlignment="Center" Margin="30, 0, 50,0" FontSize="14"></TextBlock>
                </StackPanel>
            </Button>

            <!-- Boton 'adjuntments' (ajustes) -->
            <Button Margin="20,5,20,0" Background="Transparent" Height="30" HorizontalAlignment="Left" BorderBrush="Black">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/recursos/iconos/Settings.png" Width="24" HorizontalAlignment="Left" Margin="20,0,0,0"></Image>
                    <TextBlock Text="adjuntments" Foreground="White" VerticalAlignment="Center" Margin="30, 0, 40,0" FontSize="14"></TextBlock>
                </StackPanel>
            </Button>

            <!-- Boton 'profile' (perfil) -->
            <Button Margin="20,5,20,0" Background="Transparent" Height="30" HorizontalAlignment="Left" BorderBrush="Black">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/recursos/iconos/Profile.png" Width="24" HorizontalAlignment="Left" Margin="20,0,0,0"></Image>
                    <TextBlock Text="profile" Foreground="White" VerticalAlignment="Center" Margin="30, 0, 42,0" FontSize="14"></TextBlock>
                </StackPanel>
            </Button>
        </StackPanel>

        <!-- ==================================================================== -->
        <!-- PARTE SUPERIOR: Barra roja de encabezado y botones de ventana        -->
        <!-- DockPanel.Dock="Top": Se ancla en la parte de arriba                 -->
        <!-- Height="60": Altura de 60 pixeles                                    -->
        <!-- Background="#e8464d": Color rojo corporativo                         -->
        <!-- ==================================================================== -->
        <Grid DockPanel.Dock="Top" Height="60" Background="#e8464d">
            <!-- Definicion de columnas en la barra superior -->
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"></ColumnDefinition> <!-- Columna 0: Titulo -->
                <ColumnDefinition Width="Auto"></ColumnDefinition> <!-- Columna 1: Descripcion -->
                <ColumnDefinition Width="Auto"></ColumnDefinition> <!-- Columna 2: Boton Check It -->
                <ColumnDefinition Width="*"></ColumnDefinition>    <!-- Columna 3: Espacio elastico -->
                <ColumnDefinition Width="Auto"></ColumnDefinition> <!-- Columna 4: Boton Minimizar/Maximizar -->
                <ColumnDefinition Width="Auto"></ColumnDefinition> <!-- Columna 5: Boton Cerrar -->
            </Grid.ColumnDefinitions>
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto"></RowDefinition>
            </Grid.RowDefinitions>

            <!-- Titulo de la aplicacion en Columna 0 -->
            <TextBlock Text="SafetyBoos" FontSize="24" Margin="30,10,0,0" Foreground="White"></TextBlock>
            <!-- Subtitulo con ajuste de linea automatico (TextWrapping) en Columna 1 -->
            <TextBlock Text="Esto es una prueba del módulo DI del ciclo de DAM" Foreground="White" Grid.Column="1" TextWrapping="WrapWithOverflow" Width="150" Margin="20,10,0,0"></TextBlock>
            <!-- Boton de accion 'Check It' en Columna 2 -->
            <Button Grid.Column="2" Background="Transparent" BorderBrush="White" Foreground="White" Content="Check It" Margin="20,10,0,0" Height="35" Padding="10"></Button>

            <!-- Boton para Minimizar la ventana (llama al metodo btnminimice_click en C#) -->
            <Button Grid.Column="3" HorizontalAlignment="Right" Margin="0,10,0,0" 
                    x:Name="btnminimice" Click="btnminimice_click">
                <Image Source="/recursos/iconos/icons8-minimize-32.png" Width="50"></Image>
            </Button>

            <!-- Boton para Alternar entre Maximizar y Restaurar ventana -->
            <Button Grid.Column="4" HorizontalAlignment="Right" Margin="0,10,0,0" 
                    x:Name="btnmaximice" Click="btnmaximice_click">
                <Image Source="/recursos/iconos/icons8-maximize-50.png" Width="50"></Image>
            </Button>

            <!-- Boton para Cerrar la ventana -->
            <Button Grid.Column="5" HorizontalAlignment="Right" Margin="0,10,0,0" 
                    x:Name="btnclose" Click="btnClose_click">
                <Image Source="/recursos/iconos/icons8-close-50.png" Width="50"></Image>
            </Button>
        </Grid>

        <!-- ==================================================================== -->
        <!-- PARTE CENTRAL: Graficos y tarjetas de informacion                    -->
        <!-- Rellena todo el espacio restante del DockPanel                       -->
        <!-- ==================================================================== -->
        <Grid>
            <!-- 3 columnas de ancho igual gracias a la medida proporcional '*' -->
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"></ColumnDefinition>
                <ColumnDefinition Width="*"></ColumnDefinition>
                <ColumnDefinition Width="*"></ColumnDefinition>
            </Grid.ColumnDefinitions>
            <!-- 3 filas de altura igual (3* cada una) -->
            <Grid.RowDefinitions>
                <RowDefinition Height="3*"></RowDefinition> <!-- Fila 0: Graficos circulares y lineas -->
                <RowDefinition Height="3*"></RowDefinition> <!-- Fila 1: Grafico temporal grande -->
                <RowDefinition Height="3*"></RowDefinition> <!-- Fila 2: Tres tarjetas inferiores -->
            </Grid.RowDefinitions>

            <!-- Imagenes decorativas superiores -->
            <Image Source="/Recursos/imagenes/lineas.png"></Image>
            <!-- Imagen que ocupa las columnas 1 y 2 combinadas mediante Grid.ColumnSpan="2" -->
            <Image Source="/Recursos/imagenes/circulos.gif" Grid.Column="1" Grid.ColumnSpan="2" Margin="40" />

            <!-- Grafico lineal que ocupa las 3 columnas en la fila 1 -->
            <Image Source="/Recursos/imagenes/linechart.jpg" Grid.Row="1" Grid.ColumnSpan="3" Margin="40,0,40,0" Stretch="Fill"/>

            <!-- Tarjeta 1 (Naranja): Fila 2, Columna 0 -->
            <StackPanel Grid.Row="2" Margin="30" Background="#FAAF3A">
                <TextBlock Text="GET MORE OUT FOR IT" FontSize="18" FontWeight="Bold" Foreground="white" HorizontalAlignment="Center" Margin="0,10,0,10"></TextBlock>
                <TextBlock Text="Esto es un ejemplo del ciclo de Dam del IES henri mattise" TextWrapping="WrapWithOverflow" Width="150" Foreground="White"/>
                <Button Content="Upgrade" Foreground="White" BorderBrush="White" Width="150" Margin="0,10,0,10" Background="Transparent" />
            </StackPanel>

            <!-- Tarjeta 2 (Azul): Fila 2, Columna 1 -->
            <StackPanel Grid.Row="2" Grid.Column="1" Margin="30" Background="#2280B3">
                <TextBlock Text="NEWSPEED" FontSize="18" FontWeight="Bold" Foreground="white" HorizontalAlignment="Center" Margin="0,10,0,10"></TextBlock>
                <TextBlock Text="Esto es un ejemplo del ciclo de Dam del IES henri mattise" TextWrapping="WrapWithOverflow" Width="150" Foreground="White"/>
                <Button Content="Read more" BorderBrush="White" Width="150" Margin="0,10,0,10" Background="Transparent" Foreground="White" />
            </StackPanel>

            <!-- Tarjeta 3 (Azul claro): Fila 2, Columna 2 -->
            <StackPanel Grid.Row="2" Grid.Column="2" Margin="30" Background="#97C3DA">
                <TextBlock Text="SYSTEM INFORMATION" FontSize="18" FontWeight="Bold" Foreground="white" HorizontalAlignment="Center" Margin="0,10,0,10"></TextBlock>
                <Image Source="/Recursos/imagenes/linechart80.png" Width="140" />
            </StackPanel>
        </Grid>
    </DockPanel>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 1 - Safetyboost Dashboard - Interfaz Principal Estilo Dashboard
- **Archivo**: `di.unidad2.ejercicio1/di.unidad2.ejercicio1/MainWindow.xaml.cs`
- **Inicio**: Línea 20: public partial class MainWindow : Window
- **Fin**: Línea 71: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor de la ventana. Se ejecuta automaticamente al abrirse la aplicacion.
        /// </summary>
        public MainWindow()
        {
            // InitializeComponent() es el metodo esencial que lee el XAML, carga
            // los elementos visuales en memoria y conecta los eventos y nombres (x:Name).
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de evento (Event Handler) para cerrar la ventana.
        /// private: Solo se puede llamar desde esta clase.
        /// void: No devuelve ningun valor tras ejecutarse.
        /// object sender: Representa el control que origino el evento (el boton de cerrar).
        /// RoutedEventArgs e: Contiene informacion detallada sobre el evento de enrutamiento.
        /// </summary>
        private void btnClose_click(object sender, RoutedEventArgs e)
        {
            // this.Close() cierra la ventana actual.
            this.Close();
        }

        /// <summary>
        /// Manejador para minimizar la ventana a la barra de tareas.
        /// </summary>
        private void btnminimice_click(object sender, RoutedEventArgs e)
        {
            // WindowState.Minimized oculta la ventana reduciendola a la barra de tareas.
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Manejador para alternar entre Maximizar (pantalla completa) y Normal.
        /// </summary>
        private void btnmaximice_click(object sender, RoutedEventArgs e)
        {
            // Comprobamos si la ventana ya esta maximizada
            if (this.WindowState.Equals(WindowState.Maximized))
            {
                // Si estaba maximizada, la devolvemos a tamaño normal
                this.WindowState = WindowState.Normal;
            }
            else
            {
                // Si estaba en tamaño normal, la maximizamos
                this.WindowState = WindowState.Maximized;
            }
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 2
**Título**: Login "Welcome Folk" - MahApps MetroWindow y Material Design  
**Palabras clave técnicas**: `MahApps.Metro`, `MetroWindow`, `MaterialDesign`, `PackIcon Kind="Google"`, `Grid 2 Columnas`, `PasswordBox`, `CheckBox`, `Hyperlink`, `Separador OR`, `BorderThickness 0,0,0,1`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 2 - Login "Welcome Folk" - MahApps MetroWindow y Material Design
- **Archivo**: `di.unidad2.ejercicio2/di.unidad2.ejercicio2/MainWindow.xaml`
- **Inicio**: Línea 14: <mah:MetroWindow x:Class="di.unidad2.ejercicio2.MainWindow"...
- **Fin**: Línea 115: </mah:MetroWindow>
- **Código**:

```xml
<mah:MetroWindow x:Class="di.unidad2.ejercicio2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio2"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="LOGIN" Height="550" Width="800">

    <!-- <Grid>: Contenedor tipo tabla invisible.                                -->
    <!-- Background="#04113e": Color azul oscuro exigido en el enunciado.        -->
    <Grid Background="#04113e">
        <!-- Dividimos la pantalla en 2 columnas iguales (5* y 5*)               -->
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="5*" /> <!-- Columna 0: Imagen ilustrativa -->
            <ColumnDefinition Width="5*" /> <!-- Columna 1: Formulario login   -->
        </Grid.ColumnDefinitions>

        <!-- Columna 0: Imagen del escudo con efecto tecnológico                 -->
        <!-- Stretch="UniformToFill": La imagen llena toda la columna sin bandas -->
        <Image Source="/resource/iconos/escudologin5.png" Stretch="UniformToFill" />

        <!-- Columna 1: Subcuadricula con los campos del formulario              -->
        <!-- Grid.Column="1": Posiciona este Grid en la segunda columna           -->
        <Grid Grid.Column="1">
            <!-- Definimos 9 filas para colocar cada elemento en su sitio         -->
            <!-- Height="Auto": Cada fila mide exactamente lo que ocupa su texto  -->
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" /> <!-- Fila 0: Titulo Welcome Folk -->
                <RowDefinition Height="Auto" /> <!-- Fila 1: Subtitulo          -->
                <RowDefinition Height="Auto" /> <!-- Fila 2: Boton Google       -->
                <RowDefinition Height="Auto" /> <!-- Fila 3: Separador "OR"     -->
                <RowDefinition Height="Auto" /> <!-- Fila 4: Campo Email        -->
                <RowDefinition Height="Auto" /> <!-- Fila 5: Campo Password     -->
                <RowDefinition Height="Auto" /> <!-- Fila 6: CheckBox y Olvido  -->
                <RowDefinition Height="Auto" /> <!-- Fila 7: Boton Get Start    -->
                <RowDefinition Height="Auto" /> <!-- Fila 8: Boton Register     -->
            </Grid.RowDefinitions>

            <!-- Fila 0: Titulo principal grande en blanco -->
            <TextBlock Text="Welcome Folk" HorizontalAlignment="Center" Foreground="White" Padding="0,30,0,10" FontSize="40"/>

            <!-- Fila 1: Mensaje de bienvenida con salto de linea automatico (TextWrapping) -->
            <TextBlock Text="Welcome. please Login with your personal account information" TextWrapping="WrapWithOverflow" Grid.Row="1" Width="180" Foreground="White" HorizontalAlignment="Center"/>

            <!-- Fila 2: Boton con icono de Google -->
            <!-- Background="#1976D3": Color azul de Material Design para Google -->
            <Button Grid.Row="2" Background="#1976D3" Width="200" BorderBrush="#1976D3" Margin="0,15,0,15">
                <StackPanel Orientation="Horizontal">
                    <!-- mat:PackIcon: Icono vectorial de Google de Material Design -->
                    <mat:PackIcon Kind="Google" Margin="0,0,8,0"/>
                    <TextBlock Text="Sign in with Google" VerticalAlignment="Center"/>
                </StackPanel>
            </Button>

            <!-- Fila 3: Separador con linea a la izquierda, texto "OR" en medio y linea a la derecha -->
            <Grid Grid.Row="3">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>
                <Separator Width="100" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="58,0,0,0"/>
                <TextBlock Text="OR" Grid.Column="1" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="10,0,10,0" Foreground="White"/>
                <Separator Width="100" Grid.Column="2" HorizontalAlignment="Center" VerticalAlignment="Center"/>
            </Grid>

            <!-- Fila 4: Etiqueta y Caja de texto para introducir el Email -->
            <StackPanel Margin="30,10,30,0" Grid.Row="4">
                <TextBlock Text="Email:" Margin="0,0,0,5" Foreground="#A0A0A0"/>
                <TextBox x:Name="txtEmail" BorderThickness="0,0,0,1" BorderBrush="#606060" Background="Transparent" Foreground="White"/>
            </StackPanel>

            <!-- Fila 5: Etiqueta y Caja segura (PasswordBox) para la Contraseña -->
            <StackPanel Margin="30,10,30,0" Grid.Row="5">
                <TextBlock Text="Password:" Margin="0,0,0,5" Foreground="#A0A0A0"/>
                <!-- PasswordBox oculta los caracteres con asteriscos por seguridad -->
                <PasswordBox x:Name="txtPassword" BorderThickness="0,0,0,1" BorderBrush="#606060" Background="Transparent" Foreground="White"/>
            </StackPanel>

            <!-- Fila 6: Casilla 'Remember me' a la izquierda y enlace 'Forgot password?' a la derecha -->
            <Grid Grid.Row="6" Margin="30,15,30,15">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>
                <CheckBox Content="Remember me" Foreground="White" VerticalAlignment="Center"/>
                <TextBlock Grid.Column="1" VerticalAlignment="Center">
                    <Hyperlink NavigateUri="#" Foreground="#64B5F6">Forgot password?</Hyperlink>
                </TextBlock>
            </Grid>

            <!-- Fila 7: Boton principal 'Get Start' -->
            <Button Grid.Row="7" Content="Get Start" Background="#1976D3" BorderBrush="#1976D3" Foreground="White" Width="200" Margin="0,5,0,5" HorizontalAlignment="Center"/>

            <!-- Fila 8: Boton secundario 'Register' -->
            <Button Grid.Row="8" Content="Register" Background="Transparent" BorderBrush="#1976D3" Foreground="White" Width="200" Margin="0,5,0,20" HorizontalAlignment="Center"/>
        </Grid>
    </Grid>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 2 - Login "Welcome Folk" - MahApps MetroWindow y Material Design
- **Archivo**: `di.unidad2.ejercicio2/di.unidad2.ejercicio2/MainWindow.xaml.cs`
- **Inicio**: Línea 21: public partial class MainWindow : MetroWindow
- **Fin**: Línea 31: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Constructor principal. Carga la interfaz visual y recursos de MahApps.
        /// </summary>
        public MainWindow()
        {
            // Inicializa todos los componentes XAML
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 3
**Título**: Sign In To Your Account - Formulario Vertical Limpio con Botones Sociales  
**Palabras clave técnicas**: `WPF Nativo`, `Formulario Vertical`, `BorderThickness="0,0,0,1"`, `PasswordBox`, `CheckBox`, `Botones Sociales Facebook y Google+`, `Hyperlink`, `TextBlock`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 3 - Sign In To Your Account - Formulario Vertical Limpio con Botones Sociales
- **Archivo**: `di.unidad2.ejercicio3/di.unidad2.ejercicio3/MainWindow.xaml`
- **Inicio**: Línea 10: <Window x:Class="di.unidad2.ejercicio3.MainWindow"...
- **Fin**: Línea 79: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio3.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio3"
        mc:Ignorable="d"
        Title="LOGIN" Height="800" Width="400">

    <!-- <Grid>: Cuadricula principal donde se apilan o distribuyen los controles -->
    <Grid>
        <!-- Logo superior centrado horizontalmente con margen superior de 10px -->
        <Image Source="recursos/iconos/eme.png" Height="200" Width="200" VerticalAlignment="Top" Margin="0,10,0,0" />

        <!-- Titulo principal en negrita (FontWeight="Bold") -->
        <TextBlock Text="Sign in to your account" Foreground="Black" HorizontalAlignment="Center" Margin="0,220,0,0" FontSize="25" FontWeight="Bold"/>

        <!-- Grupo para el campo de Email -->
        <StackPanel HorizontalAlignment="Center" Margin="0,290,0,0">
            <TextBlock Text="Email" Foreground="Black" FontWeight="Bold"/>
            <!-- BorderThickness="0,0,0,1": Dibuja solo una linea en la parte inferior para estilo moderno -->
            <TextBox BorderThickness="0,0,0,1" BorderBrush="#999999" Background="Transparent" Foreground="#666666" Padding="0,0,0,5" FontSize="14" Width="350"/>
        </StackPanel>

        <!-- Grupo para el campo de Contraseña -->
        <StackPanel HorizontalAlignment="Center" Margin="0,370,0,0">
            <TextBlock Text="Pasword" Foreground="Black" FontWeight="Bold"/>
            <!-- PasswordBox oculta los caracteres escritos por seguridad -->
            <PasswordBox BorderThickness="0,0,0,1" BorderBrush="#999999" Background="Transparent" Foreground="#666666" Padding="0,0,0,5" FontSize="14" Width="350"/>
        </StackPanel>

        <!-- Casilla 'Remember me' a la izquierda -->
        <CheckBox Content="Remember me" Margin="25,450,0,0"/>

        <!-- Enlace 'Forgot password' a la derecha -->
        <TextBlock Margin="280,450,0,0">
            <Hyperlink NavigateUri="https://www.ejemplo.com/reset_password">Forgot password</Hyperlink>
        </TextBlock>

        <!-- Boton principal 'SIGN IN' en azul Material -->
        <Button Content="SIGN IN" Background="#2196F3" Foreground="White" Height="30" Width="350" Margin="0,230,0,0" />

        <!-- Texto divisor 'OR' -->
        <TextBlock Text="OR" HorizontalAlignment="Center" Margin="0,550,0,0" FontSize="15" FontWeight="Bold"/>

        <!-- Boton de inicio de sesion con Facebook (Azul oscuro #395799) -->
        <Button Background="#395799" Height="30" Width="350" Margin="0,440,0,0">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                <Image Source="/recursos/iconos/facebookblanco.png" Width="20" Height="20" Margin="0,0,10,0" />
                <TextBlock Text="SIGN IN WITH FACEBOOK" VerticalAlignment="Center" Foreground="White" />
            </StackPanel>
        </Button>

        <!-- Boton de inicio de sesion con Google+ (Rojo #E04932) -->
        <Button Background="#E04932" Height="30" Width="350" Margin="0,550,0,0">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                <Image Source="/recursos/iconos/googleplus.png" Width="20" Height="20" Margin="0,0,10,0" />
                <TextBlock Text="SIGN IN WITH GOOGLE +" VerticalAlignment="Center" Foreground="White"/>
            </StackPanel>
        </Button>

        <!-- Texto inferior 'Don't have an account?' -->
        <TextBlock Text="Don't have an account?" Foreground="Black" Margin="25,700,0,0"/>

        <!-- Enlace inferior 'Create an account' -->
        <TextBlock Margin="280,700,0,0">
            <Hyperlink NavigateUri="https://www.ejemplo.com/create_account">Create an account</Hyperlink>
        </TextBlock>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 3 - Sign In To Your Account - Formulario Vertical Limpio con Botones Sociales
- **Archivo**: `di.unidad2.ejercicio3/di.unidad2.ejercicio3/MainWindow.xaml.cs`
- **Inicio**: Línea 20: public partial class MainWindow : Window
- **Fin**: Línea 30: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor: se ejecuta automaticamente al instanciar la ventana.
        /// </summary>
        public MainWindow()
        {
            // Inicializa los componentes declarados en el archivo XAML
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 4
**Título**: Matisse Dark Login - MetroWindow Sin Barra de Título ni Botones de Control  
**Palabras clave técnicas**: `MahApps.Metro`, `MetroWindow`, `ShowTitleBar="False"`, `ShowCloseButton="False"`, `ShowMaxRestoreButton="False"`, `ShowMinButton="False"`, `Tema Dark (#2c2f33)`, `Grid Dividido`, `TextBox`, `PasswordBox`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 4 - Matisse Dark Login - MetroWindow Sin Barra de Título ni Botones de Control
- **Archivo**: `di.unidad2.ejercicio4/di.unidad2.ejercicio4/MainWindow.xaml`
- **Inicio**: Línea 12: <mah:MetroWindow x:Class="di.unidad2.ejercicio4.MainWindow"...
- **Fin**: Línea 84: </mah:MetroWindow>
- **Código**:

```xml
<mah:MetroWindow x:Class="di.unidad2.ejercicio4.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio4"
        mc:Ignorable="d"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        Title="MainWindow" 
        Height="450" 
        Width="600"
        ShowTitleBar="False"
        ShowCloseButton="False"
        ShowMaxRestoreButton="False"
        ShowMinButton="False">

    <!-- Cuadricula principal dividida en 2 columnas: izquierda (imagen) y derecha (login) -->
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="4*"/> <!-- Columna 0: Panel imagen portatil -->
            <ColumnDefinition Width="auto"/> <!-- Columna 1: Panel de formulario oscuro -->
        </Grid.ColumnDefinitions>

        <!-- Columna 0: Imagen de fondo y logo del centro Henri Matisse -->
        <Grid Grid.Column="0" HorizontalAlignment="Left">
            <!-- Imagen de un portatil de fondo -->
            <Image Source="/Recursos/imagenes/portatil.jpg"/>
            <!-- Icono blanco del lagarto de Matisse arriba a la izquierda -->
            <Image Source="/Recursos/iconos/matisse.png" Width="20" Height="20" HorizontalAlignment="Left" VerticalAlignment="Top" Margin="10,10,0,0"/>
            <!-- Titulo "MATISSE" junto al icono -->
            <TextBlock Text="MATISSE" HorizontalAlignment="Left" VerticalAlignment="Top" Margin="35,10,0,0" Foreground="White" FontSize="15"/>
            <!-- Mensaje central en blanco con sombra visual -->
            <TextBlock Text="Aplicación Inventario IES Henri Matisse" Margin="30,200,0,0" Foreground="White" FontSize="18" FontWeight="Bold"/>
        </Grid>

        <!-- Columna 1: Formulario de inicio de sesion con fondo oscuro #2c2f33 -->
        <Grid Grid.Column="1" Background="#2c2f33" Width="260">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto"/> <!-- Titulo Login -->
                <RowDefinition Height="Auto"/> <!-- Campo Username -->
                <RowDefinition Height="Auto"/> <!-- Campo Password -->
                <RowDefinition Height="Auto"/> <!-- Boton Login -->
                <RowDefinition Height="Auto"/> <!-- Enlace Forgot Password -->
                <RowDefinition Height="*"/>    <!-- Enlace Sign Up inferior -->
            </Grid.RowDefinitions>

            <!-- Titulo Login en blanco -->
            <TextBlock Text="Login" FontSize="20" Foreground="White" HorizontalAlignment="Center" Margin="0,30,0,0"/>

            <!-- Campo para el nombre de usuario -->
            <StackPanel Grid.Row="1" Margin="20,20,20,0">
                <TextBlock Text="Username" Foreground="Gray" FontSize="10" Margin="0,0,0,5"/>
                <TextBox Background="#23272a" Foreground="White" BorderThickness="0" Height="25" Padding="5,3,0,0"/>
            </StackPanel>

            <!-- Campo para la contraseña (PasswordBox) -->
            <StackPanel Grid.Row="2" Margin="20,10,20,0">
                <TextBlock Text="Password" Foreground="Gray" FontSize="10" Margin="0,0,0,5"/>
                <PasswordBox Background="#23272a" Foreground="White" BorderThickness="0" Height="25" Padding="5,3,0,0"/>
            </StackPanel>

            <!-- Boton de Login en azul vibrante -->
            <Button Grid.Row="3" Content="Login" Background="#5865F2" Foreground="White" BorderThickness="0" Margin="20,20,20,0" Height="30"/>

            <!-- Enlace para recuperar la contraseña -->
            <TextBlock Grid.Row="4" Text="Forgot Password?" Foreground="#5865F2" FontSize="10" HorizontalAlignment="Center" Margin="0,10,0,0" Cursor="Hand"/>

            <!-- Enlace SIGN UP al pie del formulario -->
            <TextBlock Grid.Row="5" Text="SIGN UP" Foreground="Gray" FontSize="10" HorizontalAlignment="Right" VerticalAlignment="Bottom" Margin="0,0,10,10" Cursor="Hand"/>
        </Grid>
    </Grid>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 4 - Matisse Dark Login - MetroWindow Sin Barra de Título ni Botones de Control
- **Archivo**: `di.unidad2.ejercicio4/di.unidad2.ejercicio4/MainWindow.xaml.cs`
- **Inicio**: Línea 21: public partial class MainWindow : MetroWindow
- **Fin**: Línea 31: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Constructor principal de la ventana de login.
        /// </summary>
        public MainWindow()
        {
            // Inicializa la ventana y los controles XAML
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 5
**Título**: Bienvenido a Inventario Matisse - Cajas Outlined, Redondeadas y Botones Mini  
**Palabras clave técnicas**: `MaterialDesign`, `MaterialDesignOutlinedTextBox`, `MaterialDesignOutlinedPasswordBox`, `TextFieldCornerRadius="25"`, `TextFieldAssist.HasClearButton="True"`, `HintAssist.Hint con PackIcon`, `MaterialDesignFloatingActionMiniLightButton`, `WindowStyle="None"`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 5 - Bienvenido a Inventario Matisse - Cajas Outlined, Redondeadas y Botones Mini
- **Archivo**: `di.unidad2.ejercicio5/di.unidad2.ejercicio5/MainWindow.xaml`
- **Inicio**: Línea 9: <Window x:Class="di.unidad2.ejercicio5.MainWindow"...
- **Fin**: Línea 119: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio5.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio5"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:materialdesign="http://materialdesigninxaml.net/winfx/xaml/themes"        
        mc:Ignorable="d"
        ShowInTaskbar="False"
        WindowStyle="None"
        ResizeMode="NoResize"
        Title="MainWindow" Height="800" Width="800">

    <!-- Cuadricula principal dividida al 50% entre formulario e imagen -->
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="5*"/> <!-- Columna 0: Formulario -->
            <ColumnDefinition Width="5*"/> <!-- Columna 1: Imagen lateral con degradado -->
        </Grid.ColumnDefinitions>

        <!-- Columna 0: Panel vertical para los campos de acceso -->
        <Grid Grid.Column="0">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto"/> <!-- Fila 0: BIENVENIDO A -->
                <RowDefinition Height="Auto"/> <!-- Fila 1: INVENTARIO MATISSE -->
                <RowDefinition Height="Auto"/> <!-- Fila 2: Logo lagarto -->
                <RowDefinition Height="Auto"/> <!-- Fila 3: Descripcion -->
                <RowDefinition Height="Auto"/> <!-- Fila 4: TextBox Username redondeado -->
                <RowDefinition Height="Auto"/> <!-- Fila 5: PasswordBox Clave de acceso -->
                <RowDefinition Height="Auto"/> <!-- Fila 6: Boton LOGIN -->
                <RowDefinition Height="Auto"/> <!-- Fila 7: Enlace de registro -->
                <RowDefinition Height="Auto"/> <!-- Fila 8: Separador OR -->
                <RowDefinition Height="Auto"/> <!-- Fila 9: Texto redes sociales -->
                <RowDefinition Height="Auto"/> <!-- Fila 10: Botones redondos de redes -->
            </Grid.RowDefinitions>

            <!-- Encabezados de bienvenida -->
            <TextBlock Text="BIENVENIDO A" Grid.Row="0" Foreground="Black" HorizontalAlignment="Center" FontSize="20" Margin="0,100,0,0" />
            <TextBlock Text="INVENTARIO MATISSE" Grid.Row="1" Foreground="Red" HorizontalAlignment="Center" FontSize="30" />
            <Image Source="/recursos/matisse-black.png" Width="50" Height="50" Grid.Row="2" HorizontalAlignment="Center"/>
            <TextBlock Text="Para entrar en la aplicacion introduce tu usuario y contraseña. Puedes realizar el inicio de sesion con tus redes sociales" FontSize="10" Foreground="Gray" TextWrapping="WrapWithOverflow" MaxWidth="250" Grid.Row="3" TextAlignment="Center"/>

            <!-- TextBox de usuario con esquinas redondeadas (TextFieldCornerRadius="25") segun el PDF -->
            <TextBox HorizontalAlignment="Center" Width="300" Height="25" Grid.Row="4"
                     Margin="0,30,0,0"
                     Style="{DynamicResource MaterialDesignOutlinedTextBox}"
                     materialdesign:TextFieldAssist.HasClearButton="True"
                     materialdesign:TextFieldAssist.TextFieldCornerRadius="25">
                <materialdesign:HintAssist.Hint>
                    <!-- Icono de usuario dentro de la caja de texto -->
                    <StackPanel Orientation="Horizontal" Margin="-2 0 0 0">
                        <materialdesign:PackIcon Kind="Account" />
                        <TextBlock Text=" Username" />
                    </StackPanel>
                </materialdesign:HintAssist.Hint>
            </TextBox>

            <!-- PasswordBox con la misma estructura y esquina redondeada (25px) -->
            <PasswordBox HorizontalAlignment="Center" Width="300" Height="25" Grid.Row="5"
                         Margin="0,10,0,0"
                         Style="{DynamicResource MaterialDesignOutlinedPasswordBox}"
                         materialdesign:TextFieldAssist.HasClearButton="True"
                         materialdesign:TextFieldAssist.TextFieldCornerRadius="25">
                <materialdesign:HintAssist.Hint>
                    <StackPanel Orientation="Horizontal" Margin="-2 0 0 0">
                        <materialdesign:PackIcon Kind="Key" />
                        <TextBlock Text=" Password" />
                    </StackPanel>
                </materialdesign:HintAssist.Hint>
            </PasswordBox>

            <!-- Boton LOGIN en rojo corporativo -->
            <Button Content="LOGIN" Grid.Row="6" Width="100" HorizontalAlignment="Center" Margin="0,20,0,0" Background="Red" BorderBrush="Red" Foreground="White" />

            <!-- Enlace para registrarse -->
            <StackPanel Grid.Row="7" Orientation="Horizontal" HorizontalAlignment="Center" Margin="0,10,0,0">
                <TextBlock Text="¿No tienes cuenta? " Foreground="Gray" FontSize="12"/>
                <TextBlock Text="Sign in now" Foreground="Red" FontWeight="Bold" FontSize="12" Cursor="Hand"/>
            </StackPanel>

            <!-- Divisor 'OR' -->
            <TextBlock Text="OR" Grid.Row="8" HorizontalAlignment="Center" Foreground="Gray" Margin="0,10,0,0" />
            <TextBlock Text="Inicia sesion con redes sociales" Grid.Row="9" HorizontalAlignment="Center" Foreground="Gray" Margin="0,5,0,0" />

            <!-- Botones redondos flotantes de redes sociales -->
            <!-- Style: MaterialDesignFloatingActionMiniLightButton segun enunciado -->
            <StackPanel Grid.Row="10" Orientation="Horizontal" HorizontalAlignment="Center" Margin="0,15,0,0">
                <Button Margin="5" Style="{DynamicResource MaterialDesignFloatingActionMiniLightButton}">
                    <mat:PackIcon Kind="Facebook" />
                </Button>
                <Button Margin="5" Style="{DynamicResource MaterialDesignFloatingActionMiniLightButton}">
                    <mat:PackIcon Kind="Twitter" />
                </Button>
                <Button Margin="5" Style="{DynamicResource MaterialDesignFloatingActionMiniLightButton}">
                    <mat:PackIcon Kind="Instagram" />
                </Button>
            </StackPanel>
        </Grid>

        <!-- Columna 1: Panel derecho con imagen y degradado -->
        <Grid Grid.Column="1">
            <Image Source="/recursos/Entrada.jpg" Stretch="UniformToFill" />
            <!-- Capa superpuesta con texto informativo -->
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                <TextBlock Text="IES MATISSE" Foreground="White" FontSize="36" FontWeight="Bold" HorizontalAlignment="Center"/>
                <TextBlock Text="Con esta aplicación puedes gestionar la entrada y salida de material, usuarios y el inventario del centro." TextWrapping="Wrap" MaxWidth="280" Foreground="White" TextAlignment="Center" Margin="0,10,0,0"/>
            </StackPanel>
        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 5 - Bienvenido a Inventario Matisse - Cajas Outlined, Redondeadas y Botones Mini
- **Archivo**: `di.unidad2.ejercicio5/di.unidad2.ejercicio5/MainWindow.xaml.cs`
- **Inicio**: Línea 18: public partial class MainWindow : Window
- **Fin**: Línea 27: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor principal. Inicializa componentes XAML.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 6
**Título**: Esquinas Redondeadas con Border y OpacityMask VisualBrush para Imágenes  
**Palabras clave técnicas**: `Border CornerRadius="50"`, `OpacityMask`, `VisualBrush`, `Recorte Curvo de Imágenes`, `AllowsTransparency="True"`, `WindowStyle="None"`, `MaterialDesign HintAssist`, `CheckBox Términos`, `Botones Sociales`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 6 - Esquinas Redondeadas con Border y OpacityMask VisualBrush para Imágenes
- **Archivo**: `di.unidad2.ejercicio6/di.unidad2.ejercicio6/MainWindow.xaml`
- **Inicio**: Línea 12: <Window x:Class="di.unidad2.ejercicio6.MainWindow"...
- **Fin**: Línea 100: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio6.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio6"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        ShowInTaskbar="False"
        WindowStyle="None"
        AllowsTransparency="True"
        Background="Transparent"
        ResizeMode="NoResize"
        Title="MainWindow" Height="700" Width="1100">

    <!-- Cuadricula principal dividida en dos columnas de ancho igual (5* y 5*) -->
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="5*" /> <!-- Columna 0: Imagen con curva -->
            <ColumnDefinition Width="5*" /> <!-- Columna 1: Formulario blanco -->
        </Grid.ColumnDefinitions>

        <!-- Fondo blanco redondeado para toda la ventana (Grid.ColumnSpan="2") -->
        <!-- CornerRadius="50,50,50,50": Redondea las 4 esquinas de la ventana -->
        <Border BorderThickness="1" CornerRadius="50,50,50,50" BorderBrush="White"
                Background="White" Grid.ColumnSpan="2"/>

        <!-- Columna 0: Imagen recortada con mascara de opacidad (OpacityMask) -->
        <Grid>
            <!-- OpacityMask: Recorta la imagen segun la forma del borde 'Mask' -->
            <Grid.OpacityMask>
                <VisualBrush Visual="{Binding ElementName=Mask}" />
            </Grid.OpacityMask>

            <!-- Borde de mascara con solo las 2 esquinas izquierdas redondeadas (50 0 0 50) -->
            <Border Name="Mask" BorderBrush="White" Background="White"
                    CornerRadius="50 0 0 50" />

            <!-- Imagen que queda recortada automaticamente por la mascara -->
            <Image Source="/Recursos/imagenes/office.jpg" Stretch="UniformToFill" />

            <!-- Texto superpuesto sobre la imagen -->
            <TextBlock VerticalAlignment="Center" Text="Inventario Matisse"
                       TextWrapping="WrapWithOverflow" Width="350"
                       Foreground="White" FontSize="64" HorizontalAlignment="Left"
                       Margin="30,0,0,0" FontWeight="Bold"/>
        </Grid>

        <!-- Columna 1: Panel de formulario de acceso a la derecha -->
        <Grid Grid.Column="1" Margin="60">
            <Grid.RowDefinitions>
                <RowDefinition Height="auto"/> <!-- Fila 0: Titulo LOGIN -->
                <RowDefinition Height="auto"/> <!-- Fila 1: Subtitulo -->
                <RowDefinition Height="auto"/> <!-- Fila 2: Nombre de usuario -->
                <RowDefinition Height="auto"/> <!-- Fila 3: Password -->
                <RowDefinition Height="auto"/> <!-- Fila 4: Terminos y condiciones -->
                <RowDefinition Height="auto"/> <!-- Fila 5: Boton Login -->
                <RowDefinition Height="auto"/> <!-- Fila 6: Texto redes -->
                <RowDefinition Height="auto"/> <!-- Fila 7: Botones sociales -->
            </Grid.RowDefinitions>

            <!-- Titulo LOGIN -->
            <TextBlock Text="LOGIN" Foreground="Black" FontSize="25" FontWeight="Bold" />
            <TextBlock Text="Inicia sesión en la aplicación" FontSize="10" Grid.Row="1" Margin="0,20,0,0" Foreground="Gray" />

            <!-- TextBox de usuario con texto de ayuda (Hint) -->
            <TextBox Grid.Row="2" mat:HintAssist.Hint="Nombre de usuario" BorderThickness="0,0,0,1" Margin="0,20,0,0" BorderBrush="Black" />

            <!-- PasswordBox seguro con texto de ayuda -->
            <PasswordBox Grid.Row="3" mat:HintAssist.Hint="Password" BorderThickness="0,0,0,1" Margin="0,20,0,0" BorderBrush="Black" />

            <!-- Casilla de aceptacion de terminos -->
            <CheckBox Grid.Row="4" Content="Acepto los términos de la Política de Privacidad" Foreground="Black" Margin="0,20,0,0" FontSize="10" />

            <!-- Boton de LOGIN redondeado en rojo -->
            <Button Grid.Row="5" Content="LOGIN" Background="#DE243A" Foreground="White" Width="100" HorizontalAlignment="Right" Margin="0,20,0,0" BorderBrush="#DE243A"/>

            <!-- Texto de redes sociales -->
            <TextBlock Grid.Row="6" Text="Login con redes sociales" Foreground="Gray" FontSize="10" Margin="0,30,0,0"/>

            <!-- Botones de Facebook, Twitter y Google -->
            <StackPanel Grid.Row="7" Orientation="Horizontal" Margin="0,10,0,0">
                <Button Content="f Facebook" Background="#3b5998" Foreground="White" Margin="0,0,10,0" Width="100" Height="30"/>
                <Button Content="Twitter" Background="#00acee" Foreground="White" Margin="0,0,10,0" Width="100" Height="30"/>
                <Button Content="G+ Google +" Background="#db4437" Foreground="White" Width="100" Height="30"/>
            </StackPanel>
        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 6 - Esquinas Redondeadas con Border y OpacityMask VisualBrush para Imágenes
- **Archivo**: `di.unidad2.ejercicio6/di.unidad2.ejercicio6/MainWindow.xaml.cs`
- **Inicio**: Línea 18: public partial class MainWindow : Window
- **Fin**: Línea 24: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 7
**Título**: Bienvenidos ! Ventana Flotante Transparente y Tarjetas Superpuestas  
**Palabras clave técnicas**: `AllowsTransparency="True"`, `Background="Transparent"`, `WindowStyle="None"`, `Tarjeta Superpuesta (Border con Margen)`, `MaterialDesign HintAssist`, `Botón Primario y Secundario`, `Contraste Visual Rojo/Blanco`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 7 - Bienvenidos ! Ventana Flotante Transparente y Tarjetas Superpuestas
- **Archivo**: `di.unidad2.ejercicio7/di.unidad2.ejercicio7/MainWindow.xaml`
- **Inicio**: Línea 9: <Window x:Class="di.unidad2.ejercicio7.MainWindow"...
- **Fin**: Línea 56: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio7.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio7"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        WindowStyle="None" AllowsTransparency="True" Background="Transparent"
        ResizeMode="NoResize"
        Title="MainWindow" Height="450" Width="800">

    <!-- Cuadricula principal sobre lienzo transparente -->
    <Grid>
        <!-- Panel izquierdo rojo (#DE243A) que actua como tarjeta flotante -->
        <StackPanel Orientation="Vertical" Background="#DE243A" Height="400" Width="700">
            <!-- Mensaje de bienvenida en blanco y negrita -->
            <TextBlock Text="Bienvenidos !" FontSize="30" Foreground="White" FontWeight="Bold" Margin="20,20,0,0" />
            <TextBlock Text="INVENTARIO MATISSE" Foreground="White" Margin="25,20,0,0" />
            <!-- Logo blanco de Matisse en la parte inferior izquierda -->
            <Image Source="/Recursos/iconos/matisse.png" Width="50" Height="50" Margin="0,200,600,0" />
            <TextBlock Text="IES HENRI MATISSE" Foreground="White" Margin="20,10,0,0" />
        </StackPanel>

        <!-- Tarjeta blanca flotante sobrepuesta en la parte derecha con borde gris -->
        <Border BorderBrush="Gray" BorderThickness="2" Height="450" Width="250" Background="White" Margin="350,0,0,0">
            <StackPanel Orientation="Vertical">
                <!-- Titulo LOGIN en rojo corporativo -->
                <TextBlock Text="LOGIN" FontSize="30" Foreground="#DE243A" HorizontalAlignment="Center" Margin="0,50,0,0"/>

                <!-- Campo de usuario con Hint de Material Design -->
                <TextBox mat:HintAssist.Hint="Nombre de Usuario" BorderThickness="0,0,0,1" BorderBrush="Gray" Width="180" Foreground="Gray" Margin="0,30,0,0"/>

                <!-- Campo de contraseña con Hint de Material Design -->
                <PasswordBox mat:HintAssist.Hint="Clave de Usuario" BorderThickness="0,0,0,1" BorderBrush="Gray" Width="180" Foreground="Gray" Margin="0,30,0,0"/>

                <!-- Boton LOGIN en rojo -->
                <Button Content="LOGIN" Background="#DE243A" Foreground="White" Width="180" Margin="0,30,0,0" BorderBrush="#DE243A" />

                <!-- Boton secundario blanco "¿TIENES CUENTA?" -->
                <Button Content="¿TIENES CUENTA?" Background="White" Foreground="#DE243A" Width="180" Margin="0,30,0,0" BorderBrush="Gray" />

                <!-- Enlace de recuperacion de clave -->
                <TextBlock Text="¿Olvidaste tu Contraseña?" Foreground="#DE243A" HorizontalAlignment="Center" Margin="0,30,0,0" Cursor="Hand"/>
            </StackPanel>
        </Border>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 7 - Bienvenidos ! Ventana Flotante Transparente y Tarjetas Superpuestas
- **Archivo**: `di.unidad2.ejercicio7/di.unidad2.ejercicio7/MainWindow.xaml.cs`
- **Inicio**: Línea 18: public partial class MainWindow : Window
- **Fin**: Línea 24: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 2 - Ejercicio 8
**Título**: IES Matisse con Franja Inclinada Degradada y Arrastre de Ventana (DragMove)  
**Palabras clave técnicas**: `LinearGradientBrush`, `RotateTransform (Ángulo -5)`, `Tirador Decorativo`, `DragMove()`, `Window_MouseDown`, `WindowStyle="None"`, `MaterialDesign HintAssist`, `PasswordBox`, `BorderBrush con Degradado`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 8 - IES Matisse con Franja Inclinada Degradada y Arrastre de Ventana (DragMove)
- **Archivo**: `di.unidad2.ejercicio8/di.unidad2.ejercicio8/MainWindow.xaml`
- **Inicio**: Línea 9: <Window x:Class="di.unidad2.ejercicio8.MainWindow"...
- **Fin**: Línea 142: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio8.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio8"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="#1E1E1E"
        Title="IES Matisse - Login" 
        Height="520" Width="620">

    <Grid ClipToBounds="True">
        <!-- Rectangulo superior decorativo inclinado con degradado rojo a naranja -->
        <Rectangle Height="220" Width="750" 
                   VerticalAlignment="Top" HorizontalAlignment="Left" 
                   Margin="-100,-115,0,0">
            <Rectangle.Fill>
                <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                    <GradientStop Color="#D14235" Offset="0.0"/> <!-- Rojo oscuro -->
                    <GradientStop Color="#EB8643" Offset="1.0"/> <!-- Naranja brillante -->
                </LinearGradientBrush>
            </Rectangle.Fill>
            <Rectangle.LayoutTransform>
                <RotateTransform Angle="-5" />
            </Rectangle.LayoutTransform>
        </Rectangle>

        <!-- Tirador superior decorativo idéntico al PDF -->
        <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                Width="42" Height="14" 
                Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                CornerRadius="0,0,2,2" Panel.ZIndex="10">
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                <Rectangle Width="24" Height="2" Fill="#888888" Margin="0,0,0,2"/>
                <Rectangle Width="24" Height="2" Fill="#888888"/>
            </StackPanel>
        </Border>

        <!-- Titulo superior en la franja inclinada -->
        <TextBlock Text="IES MATISSE" 
                   Foreground="White" 
                   FontWeight="Bold" 
                   Margin="32,32,0,0" 
                   FontSize="28" 
                   HorizontalAlignment="Left" 
                   VerticalAlignment="Top" />

        <!-- Silueta blanca de Matisse en la parte derecha -->
        <Image Source="Recursos/iconos/matisse.png" 
               Width="105" Height="130" 
               Stretch="Uniform" 
               HorizontalAlignment="Right" 
               VerticalAlignment="Center" 
               Margin="0,50,45,0" 
               RenderOptions.BitmapScalingMode="HighQuality" />

        <!-- Contenedor del formulario en el lado izquierdo -->
        <StackPanel VerticalAlignment="Top" 
                    HorizontalAlignment="Left" 
                    Margin="32,175,0,0" 
                    Width="330">

            <TextBlock Text="INVENTARIO MATISSE" 
                       FontSize="21" 
                       FontWeight="Bold" 
                       Foreground="White" 
                       Margin="0,0,0,4" />

            <TextBlock Text="Login" 
                       Foreground="White" 
                       FontSize="16" 
                       Margin="0,0,0,20" />

            <!-- TextBox con borde blanco fino y texto centrado -->
            <Border BorderBrush="#888888" BorderThickness="1" Height="44" Margin="0,0,0,14" Background="#1E1E1E">
                <TextBox mat:HintAssist.Hint="Nombre de usuario" 
                         mat:HintAssist.Foreground="#999999"
                         mat:TextFieldAssist.UnderlineBrush="Transparent"
                         BorderThickness="0" 
                         Background="Transparent" 
                         Foreground="White" 
                         FontSize="12.5" 
                         HorizontalContentAlignment="Left" 
                         VerticalContentAlignment="Center" 
                         Padding="12,0,12,0" />
            </Border>

            <!-- PasswordBox para clave de acceso con borde blanco fino -->
            <Border BorderBrush="#888888" BorderThickness="1" Height="44" Margin="0,0,0,24" Background="#1E1E1E">
                <PasswordBox mat:HintAssist.Hint="Clave de acceso" 
                             mat:HintAssist.Foreground="#999999"
                             mat:TextFieldAssist.UnderlineBrush="Transparent"
                             BorderThickness="0" 
                             Background="Transparent" 
                             Foreground="White" 
                             FontSize="12.5" 
                             HorizontalContentAlignment="Left" 
                             VerticalContentAlignment="Center" 
                             Padding="12,0,12,0" />
            </Border>

            <!-- Boton LOGIN cuyo borde tiene exactamente el degradado superior -->
            <Button Content="LOGIN" 
                    Background="Transparent" 
                    Foreground="#EB8643" 
                    FontWeight="Bold"
                    Width="95" Height="36" 
                    BorderThickness="1.2"
                    HorizontalAlignment="Left" 
                    Cursor="Hand"
                    Margin="0,0,0,24">
                <Button.BorderBrush>
                    <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                        <GradientStop Color="#D14235" Offset="0.0"/>
                        <GradientStop Color="#EB8643" Offset="1.0"/>
                    </LinearGradientBrush>
                </Button.BorderBrush>
            </Button>

            <!-- Enlace de olvido de clave al pie -->
            <TextBlock Text="¿OLVIDASTE LA CONTRASEÑA?" 
                       Foreground="#EB8643" 
                       FontSize="12"
                       FontWeight="SemiBold"
                       Cursor="Hand" />
        </StackPanel>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 8 - IES Matisse con Franja Inclinada Degradada y Arrastre de Ventana (DragMove)
- **Archivo**: `di.unidad2.ejercicio8/di.unidad2.ejercicio8/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 21: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 9
**Título**: Login Dividido Fondo Crema con Iconos PackIcon Integrados en Cajas  
**Palabras clave técnicas**: `WindowStyle="None"`, `DragMove()`, `Fondo Crema (#F7EDE2)`, `PackIcon dentro de Border`, `UnderlineBrush="Transparent"`, `Matisse Arte Lateral`, `Button CornerRadius="3"`, `MaterialDesign`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 9 - Login Dividido Fondo Crema con Iconos PackIcon Integrados en Cajas
- **Archivo**: `di.unidad2.ejercicio9/di.unidad2.ejercicio9/MainWindow.xaml`
- **Inicio**: Línea 8: <Window x:Class="di.unidad2.ejercicio9.MainWindow"...
- **Fin**: Línea 189: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio9.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio9"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        Title="IES Henri Matisse - Login"
        Height="480" Width="760"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="#F7EDE2">

    <Grid>
        <!-- Tirador decorativo central en el borde superior -->
        <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                Width="42" Height="14" 
                Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                CornerRadius="0,0,2,2" Panel.ZIndex="10">
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                <Rectangle Width="24" Height="2" Fill="#888888" Margin="0,0,0,2"/>
                <Rectangle Width="24" Height="2" Fill="#888888"/>
            </StackPanel>
        </Border>

        <Grid Margin="20,25,20,20">
            <Grid.ColumnDefinitions>
                <!-- Columna izquierda: Arte Matisse (48%) -->
                <ColumnDefinition Width="48*" />
                <!-- Columna derecha: Formulario de bienvenida (52%) -->
                <ColumnDefinition Width="52*" />
            </Grid.ColumnDefinitions>

            <!-- ============================================================== -->
            <!-- PANEL IZQUIERDO: LOGO Y ARTE MATISSE                           -->
            <!-- ============================================================== -->
            <Grid Grid.Column="0" Margin="0,0,15,0">
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="*" />
                </Grid.RowDefinitions>

                <!-- Logotipo IES HENRI MATISSE en azul -->
                <Image Grid.Row="0"
                       Source="Recursos/iconos/matisse_azul.png" 
                       Height="26" 
                       Stretch="Uniform" 
                       HorizontalAlignment="Left" 
                       VerticalAlignment="Top"
                       RenderOptions.BitmapScalingMode="HighQuality"
                       Margin="5,0,0,10" />

                <!-- Ilustración artística de Matisse con tarjeta blanca de fondo -->
                <Border Grid.Row="1"
                        Background="White"
                        CornerRadius="2"
                        Padding="10"
                        VerticalAlignment="Center"
                        HorizontalAlignment="Center">
                    <Image Source="Recursos/iconos/matisse_arte.png" 
                           Stretch="Uniform" 
                           MaxWidth="310"
                           MaxHeight="350"
                           RenderOptions.BitmapScalingMode="HighQuality" />
                </Border>
            </Grid>

            <!-- ============================================================== -->
            <!-- PANEL DERECHO: FORMULARIO DE ACCESO                            -->
            <!-- ============================================================== -->
            <Grid Grid.Column="1" VerticalAlignment="Center" HorizontalAlignment="Center" Width="300">
                <StackPanel Orientation="Vertical">
                    
                    <!-- Titulo Principal -->
                    <TextBlock Text="BIENVENIDOS"
                               FontSize="27"
                               FontWeight="Bold"
                               Foreground="#1C1C1E"
                               HorizontalAlignment="Center"
                               Margin="0,0,0,8" />

                    <!-- Mensaje de bienvenida / subtítulo -->
                    <TextBlock Text="Para trabajar con nuestra aplicación, por favor,&#x0a;introducid vuestra credenciales para iniciar sesión"
                               FontSize="11.5"
                               Foreground="#7D828A"
                               TextAlignment="Center"
                               TextWrapping="Wrap"
                               LineHeight="16"
                               HorizontalAlignment="Center"
                               Margin="0,0,0,26" />

                    <!-- Campo: Nombre de usuario -->
                    <Border Background="#EEF4F8"
                            CornerRadius="3"
                            Height="42"
                            Margin="0,0,0,14"
                            Padding="12,0,12,0">
                        <Grid VerticalAlignment="Center">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="Auto" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            
                            <!-- Icono de usuario -->
                            <mat:PackIcon Grid.Column="0" 
                                          Kind="AccountOutline" 
                                          Width="20" 
                                          Height="20" 
                                          Foreground="#6C7A89" 
                                          VerticalAlignment="Center"
                                          Margin="0,0,10,0" />

                            <!-- Entrada de texto con marca de agua -->
                            <TextBox Grid.Column="1"
                                     mat:HintAssist.Hint="Nombre de usuario"
                                     mat:HintAssist.Foreground="#8D9CAE"
                                     mat:TextFieldAssist.UnderlineBrush="Transparent"
                                     BorderThickness="0"
                                     Background="Transparent"
                                     Foreground="#2C3238"
                                     FontSize="12.5"
                                     VerticalAlignment="Center"
                                     VerticalContentAlignment="Center"
                                     Padding="0" />
                        </Grid>
                    </Border>

                    <!-- Campo: Clave de acceso -->
                    <Border Background="#EEF4F8"
                            CornerRadius="3"
                            Height="42"
                            Margin="0,0,0,20"
                            Padding="12,0,12,0">
                        <Grid VerticalAlignment="Center">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="Auto" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>

                            <!-- Icono de candado / clave -->
                            <mat:PackIcon Grid.Column="0" 
                                          Kind="LockOutline" 
                                          Width="20" 
                                          Height="20" 
                                          Foreground="#6C7A89" 
                                          VerticalAlignment="Center"
                                          Margin="0,0,10,0" />

                            <!-- Entrada de contraseña con marca de agua -->
                            <PasswordBox Grid.Column="1"
                                         mat:HintAssist.Hint="Clave de acceso"
                                         mat:HintAssist.Foreground="#8D9CAE"
                                         mat:TextFieldAssist.UnderlineBrush="Transparent"
                                         BorderThickness="0"
                                         Background="Transparent"
                                         Foreground="#2C3238"
                                         FontSize="12.5"
                                         VerticalAlignment="Center"
                                         VerticalContentAlignment="Center"
                                         Padding="0" />
                        </Grid>
                    </Border>

                    <!-- Boton: Inicio de Sesión -->
                    <Button Content="Inicio de Sesión"
                            Background="#17549C"
                            Foreground="White"
                            BorderThickness="0"
                            Height="38"
                            FontSize="12.5"
                            FontWeight="SemiBold"
                            mat:ButtonAssist.CornerRadius="3"
                            HorizontalAlignment="Stretch"
                            Cursor="Hand" />
                </StackPanel>
            </Grid>
        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 9 - Login Dividido Fondo Crema con Iconos PackIcon Integrados en Cajas
- **Archivo**: `di.unidad2.ejercicio9/di.unidad2.ejercicio9/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 21: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 10
**Título**: Login con Fondo Degradado Horizontal Rojo-Azul e Inputs Píldora  
**Palabras clave técnicas**: `LinearGradientBrush Horizontal (#b22d2f a #1b63b8)`, `Tarjeta Oscura (#1A1D20)`, `Inputs Píldora (CornerRadius="21")`, `Bordes de Acento (#254B62)`, `Botón Píldora con Borde Verde (#2D604E)`, `Iconos Sociales`, `DragMove()`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 10 - Login con Fondo Degradado Horizontal Rojo-Azul e Inputs Píldora
- **Archivo**: `di.unidad2.ejercicio10/di.unidad2.ejercicio10/MainWindow.xaml`
- **Inicio**: Línea 15: <Window x:Class="di.unidad2.ejercicio10.MainWindow"...
- **Fin**: Línea 172: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio10.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio10"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        Title="IES Henri Matisse - Login"
        Height="500" Width="780"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown">

    <!-- Fondo de la pantalla con degradado lineal horizontal especificado en el enunciado -->
    <Grid>
        <Grid.Background>
            <LinearGradientBrush StartPoint="0,0.5" EndPoint="1,0.5">
                <GradientStop Color="#b22d2f" Offset="0.0"/>
                <GradientStop Color="#1b63b8" Offset="1.0"/>
            </LinearGradientBrush>
        </Grid.Background>

        <!-- Tirador superior decorativo idéntico al PDF -->
        <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                Width="42" Height="14" 
                Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                CornerRadius="0,0,2,2" Panel.ZIndex="10">
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                <Rectangle Width="24" Height="2" Fill="#888888" Margin="0,0,0,2"/>
                <Rectangle Width="24" Height="2" Fill="#888888"/>
            </StackPanel>
        </Border>

        <!-- Tarjeta central oscura compacta con margen superior visible de degradado -->
        <Border Width="460"
                Background="#1A1D20"
                HorizontalAlignment="Center"
                VerticalAlignment="Stretch"
                Margin="0,44,0,0">
            <StackPanel Orientation="Vertical"
                        VerticalAlignment="Center"
                        HorizontalAlignment="Center">

                <!-- Título principal con espaciado amplio -->
                <TextBlock Text="L O G I N"
                           FontSize="28"
                           FontWeight="Bold"
                           Foreground="#FFFFFF"
                           HorizontalAlignment="Center"
                           Margin="0,0,0,8" />

                <!-- Subtítulo explicativo -->
                <TextBlock Text="Por favor introduce tu usuario y clave"
                           FontSize="12"
                           Foreground="#9DA7B2"
                           HorizontalAlignment="Center"
                           Margin="0,0,0,24" />

                <!-- Campo píldora: Username -->
                <Border Width="300"
                        Height="42"
                        CornerRadius="21"
                        BorderThickness="1.2"
                        BorderBrush="#254B62"
                        Background="#1A1D20"
                        Margin="0,0,0,14"
                        Padding="14,0,14,0">
                    <TextBox mat:HintAssist.Hint="Username"
                             mat:HintAssist.Foreground="#5A6C7D"
                             mat:TextFieldAssist.UnderlineBrush="Transparent"
                             BorderThickness="0"
                             Background="Transparent"
                             Foreground="#B0BEC5"
                             FontSize="12.5"
                             HorizontalContentAlignment="Center"
                             VerticalContentAlignment="Center"
                             Padding="0" />
                </Border>

                <!-- Campo píldora: Contraseña -->
                <Border Width="300"
                        Height="42"
                        CornerRadius="21"
                        BorderThickness="1.2"
                        BorderBrush="#254B62"
                        Background="#1A1D20"
                        Margin="0,0,0,18"
                        Padding="14,0,14,0">
                    <PasswordBox mat:HintAssist.Hint="Contraseña"
                                 mat:HintAssist.Foreground="#5A6C7D"
                                 mat:TextFieldAssist.UnderlineBrush="Transparent"
                                 BorderThickness="0"
                                 Background="Transparent"
                                 Foreground="#B0BEC5"
                                 FontSize="12.5"
                                 HorizontalContentAlignment="Center"
                                 VerticalContentAlignment="Center"
                                 Padding="0" />
                </Border>

                <!-- Enlace: ¿Has olvidado la contraseña? -->
                <TextBlock Text="¿Has olvidado la contraseña?"
                           FontSize="12"
                           FontWeight="Normal"
                           Foreground="#FFFFFF"
                           HorizontalAlignment="Center"
                           Cursor="Hand"
                           Margin="0,0,0,22" />

                <!-- Botón Login píldora con borde verde -->
                <Button Content="Login"
                        Width="135"
                        Height="38"
                        FontSize="12.5"
                        Foreground="#8C98A0"
                        Background="Transparent"
                        BorderBrush="#2D604E"
                        BorderThickness="1.2"
                        mat:ButtonAssist.CornerRadius="19"
                        HorizontalAlignment="Center"
                        Cursor="Hand"
                        Margin="0,0,0,26" />

                <!-- Iconos de redes sociales en blanco -->
                <StackPanel Orientation="Horizontal"
                            HorizontalAlignment="Center"
                            Margin="0,0,0,10">
                    <!-- Facebook -->
                    <Image Source="Recursos/iconos/facebookblanco.png"
                           Width="20" Height="20"
                           Stretch="Uniform"
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Cursor="Hand"
                           Margin="14,0" />

                    <!-- Twitter -->
                    <Image Source="Recursos/iconos/twitter.png"
                           Width="20" Height="20"
                           Stretch="Uniform"
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Cursor="Hand"
                           Margin="14,0" />

                    <!-- Google+ -->
                    <Image Source="Recursos/iconos/googleplus.png"
                           Width="24" Height="24"
                           Stretch="Uniform"
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Cursor="Hand"
                           Margin="14,0" />
                </StackPanel>

            </StackPanel>
        </Border>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 10 - Login con Fondo Degradado Horizontal Rojo-Azul e Inputs Píldora
- **Archivo**: `di.unidad2.ejercicio10/di.unidad2.ejercicio10/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 21: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 11
**Título**: Login con Semicírculo Degradado Naranja y Avatar Circular  
**Palabras clave técnicas**: `Ellipse Lateral (Semicírculo)`, `LinearGradientBrush (#FF9823 a #FEB53B)`, `Avatar Circular con PackIcon Kind="Account"`, `Entradas Píldora (#F1F4F6)`, `Botón con Degradado Naranja-Rojizo`, `DropShadowEffect`, `DragMove()`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 11 - Login con Semicírculo Degradado Naranja y Avatar Circular
- **Archivo**: `di.unidad2.ejercicio11/di.unidad2.ejercicio11/MainWindow.xaml`
- **Inicio**: Línea 14: <Window x:Class="di.unidad2.ejercicio11.MainWindow"...
- **Fin**: Línea 197: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio11.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio11"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        Title="IES Henri Matisse - Login"
        Height="480" Width="780"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="White">

    <Grid ClipToBounds="True">
        <!-- Tirador superior decorativo idéntico al PDF -->
        <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                Width="42" Height="14" 
                Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                CornerRadius="0,0,2,2" Panel.ZIndex="10">
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                <Rectangle Width="24" Height="2" Fill="#888888" Margin="0,0,0,2"/>
                <Rectangle Width="24" Height="2" Fill="#888888"/>
            </StackPanel>
        </Border>

        <!-- ============================================================== -->
        <!-- PARTE IZQUIERDA: SEMICÍRCULO CON DEGRADADO NARANJA             -->
        <!-- ============================================================== -->
        <Ellipse Width="760" Height="760" 
                 HorizontalAlignment="Left" 
                 VerticalAlignment="Center" 
                 Margin="-380,0,0,0">
            <Ellipse.Fill>
                <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                    <GradientStop Color="#FF9823" Offset="0.0"/>
                    <GradientStop Color="#FEB53B" Offset="1.0"/>
                </LinearGradientBrush>
            </Ellipse.Fill>
        </Ellipse>

        <!-- Texto dentro de la zona naranja -->
        <StackPanel HorizontalAlignment="Left" 
                    VerticalAlignment="Center" 
                    Margin="45,0,0,0" 
                    Width="320">
            <TextBlock Text="IES HENRI MATISSE"
                       FontSize="25"
                       FontWeight="Bold"
                       Foreground="White"
                       Margin="0,0,0,6" />
            <TextBlock Text="Aplicación de Inventario"
                       FontSize="17"
                       FontWeight="Normal"
                       Foreground="White" />
        </StackPanel>

        <!-- ============================================================== -->
        <!-- PARTE DERECHA: FORMULARIO DE ACCESO Y AVATAR                   -->
        <!-- ============================================================== -->
        <Grid HorizontalAlignment="Right" Width="400" Margin="0,0,20,0">
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center" Width="290">

                <!-- Avatar de usuario circular gris con silueta blanca -->
                <Grid Width="66" Height="66" HorizontalAlignment="Center" Margin="0,0,0,14">
                    <Ellipse Fill="#8D9CA3" />
                    <mat:PackIcon Kind="Account" 
                                  Width="44" Height="44" 
                                  Foreground="White" 
                                  HorizontalAlignment="Center" 
                                  VerticalAlignment="Center" />
                </Grid>

                <!-- Subtítulo: Introduce los datos -->
                <TextBlock Text="Introduce los datos"
                           FontSize="12"
                           Foreground="#A8B0B7"
                           HorizontalAlignment="Center"
                           Margin="0,0,0,26" />

                <!-- Campo píldora: Cuenta de Correo -->
                <Border Background="#F1F4F6"
                        Height="42"
                        CornerRadius="21"
                        Margin="0,0,0,14"
                        Padding="14,0,14,0">
                    <Grid VerticalAlignment="Center">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="Auto" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>

                        <!-- Icono de sobre / correo -->
                        <mat:PackIcon Grid.Column="0" 
                                      Kind="Email" 
                                      Width="18" Height="18" 
                                      Foreground="#6C7A86" 
                                      VerticalAlignment="Center" 
                                      Margin="0,0,10,0" />

                        <!-- Entrada de texto con marca de agua -->
                        <TextBox Grid.Column="1" 
                                 mat:HintAssist.Hint="Cuenta de Correo" 
                                 mat:HintAssist.Foreground="#8E9BA5" 
                                 mat:TextFieldAssist.UnderlineBrush="Transparent" 
                                 BorderThickness="0" 
                                 Background="Transparent" 
                                 Foreground="#2C3238" 
                                 FontSize="12.5" 
                                 VerticalAlignment="Center" 
                                 VerticalContentAlignment="Center" 
                                 Padding="0" />
                    </Grid>
                </Border>

                <!-- Campo píldora: Clave de Acceso -->
                <Border Background="#F1F4F6"
                        Height="42"
                        CornerRadius="21"
                        Margin="0,0,0,24"
                        Padding="14,0,14,0">
                    <Grid VerticalAlignment="Center">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="Auto" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>

                        <!-- Icono de candado -->
                        <mat:PackIcon Grid.Column="0" 
                                      Kind="Lock" 
                                      Width="18" Height="18" 
                                      Foreground="#6C7A86" 
                                      VerticalAlignment="Center" 
                                      Margin="0,0,10,0" />

                        <!-- Entrada de contraseña con marca de agua -->
                        <PasswordBox Grid.Column="1" 
                                     mat:HintAssist.Hint="Clave de Acceso" 
                                     mat:HintAssist.Foreground="#8E9BA5" 
                                     mat:TextFieldAssist.UnderlineBrush="Transparent" 
                                     BorderThickness="0" 
                                     Background="Transparent" 
                                     Foreground="#2C3238" 
                                     FontSize="12.5" 
                                     VerticalAlignment="Center" 
                                     VerticalContentAlignment="Center" 
                                     Padding="0" />
                    </Grid>
                </Border>

                <!-- Botón Login con degradado y sombra -->
                <Button Content="Login"
                        Width="195" Height="38"
                        Foreground="White"
                        FontWeight="SemiBold"
                        FontSize="13"
                        mat:ButtonAssist.CornerRadius="19"
                        BorderThickness="0"
                        HorizontalAlignment="Center"
                        Cursor="Hand"
                        Margin="0,0,0,18">
                    <Button.Background>
                        <LinearGradientBrush StartPoint="0,0.5" EndPoint="1,0.5">
                            <GradientStop Color="#FF911E" Offset="0.0"/>
                            <GradientStop Color="#FF5F07" Offset="1.0"/>
                        </LinearGradientBrush>
                    </Button.Background>
                    <Button.Effect>
                        <DropShadowEffect Color="#FF7810" BlurRadius="12" Opacity="0.35" ShadowDepth="3" Direction="270"/>
                    </Button.Effect>
                </Button>

                <!-- Enlace inferior: Nuevo Usuario? Registrate -->
                <TextBlock HorizontalAlignment="Center" FontSize="12">
                    <Run Text="Nuevo Usuario? " Foreground="#8A959E"/>
                    <Run Text="Registrate" Foreground="#FF7C08" FontWeight="SemiBold" Cursor="Hand"/>
                </TextBlock>

            </StackPanel>
        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 11 - Login con Semicírculo Degradado Naranja y Avatar Circular
- **Archivo**: `di.unidad2.ejercicio11/di.unidad2.ejercicio11/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 21: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 12
**Título**: Formulario Insertar Artículo Material Design con Controles Personalizados  
**Palabras clave técnicas**: `Barra de Título Personalizada Roja`, `Botones Minimizar/Maximizar/Cerrar`, `MaterialDesignFloatingHintComboBox`, `MaterialDesignFloatingHintDatePicker`, `MaterialDesignFloatingHintTextBox`, `Contador Caracteres (0 / 45)`, `Separator Secciones`, `DropShadowEffect en Botón Cancelar/Guardar`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 12 - Formulario Insertar Artículo Material Design con Controles Personalizados
- **Archivo**: `di.unidad2.ejercicio12/di.unidad2.ejercicio12/MainWindow.xaml`
- **Inicio**: Línea 13: <Window x:Class="di.unidad2.ejercicio12.MainWindow"...
- **Fin**: Línea 265: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio12.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio12"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="GESTIÓN ARTÍCULOS"
        Height="600" Width="600"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="White">

    <Grid>
        <Grid.RowDefinitions>
            <!-- Fila 0: Barra superior roja con tirador y botones de control -->
            <RowDefinition Height="38" />
            <!-- Fila 1: Subencabezado oscuro INSERTAR ARTICULO -->
            <RowDefinition Height="46" />
            <!-- Fila 2: Formulario principal -->
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <!-- ============================================================== -->
        <!-- FILA 0: BARRA DE TÍTULO ROJA PERSONALIZADA                     -->
        <!-- ============================================================== -->
        <Border Grid.Row="0" Background="#E5302E">
            <Grid>
                <!-- Logotipo blanco y título de la ventana -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Left" VerticalAlignment="Center" Margin="10,0,0,0">
                    <Image Source="Recursos/iconos/matisse.png" 
                           Height="24" 
                           Stretch="Uniform" 
                           VerticalAlignment="Center" 
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Margin="0,0,8,0" />
                    <TextBlock Text="GESTIÓN ARTÍCULOS" 
                               Foreground="White" 
                               FontSize="14.5" 
                               FontWeight="SemiBold" 
                               VerticalAlignment="Center" />
                </StackPanel>

                <!-- Tirador superior decorativo idéntico al PDF -->
                <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                        Width="40" Height="12" 
                        Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                        CornerRadius="0,0,2,2">
                    <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                        <Rectangle Width="22" Height="1.5" Fill="#888888" Margin="0,0,0,2"/>
                        <Rectangle Width="22" Height="1.5" Fill="#888888"/>
                    </StackPanel>
                </Border>

                <!-- Botones de minimizar, maximizar y cerrar -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Center" Margin="0,0,12,0">
                    <!-- Minimizar -->
                    <Button Click="Minimize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <TextBlock Text="—" Foreground="White" FontSize="12" FontWeight="Bold" />
                    </Button>
                    <!-- Maximizar -->
                    <Button Click="Maximize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <mat:PackIcon Kind="WindowMaximize" Foreground="White" Width="14" Height="14" VerticalAlignment="Center" />
                    </Button>
                    <!-- Cerrar -->
                    <Button Click="Close_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand">
                        <mat:PackIcon Kind="Close" Foreground="White" Width="16" Height="16" VerticalAlignment="Center" />
                    </Button>
                </StackPanel>
            </Grid>
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 1: BANNER OSCURO INSERTAR ARTICULO                        -->
        <!-- ============================================================== -->
        <Border Grid.Row="1" Background="#3E3E3E">
            <TextBlock Text="INSERTAR ARTICULO" 
                       Foreground="White" 
                       FontSize="17" 
                       FontWeight="Normal" 
                       HorizontalAlignment="Center" 
                       VerticalAlignment="Center" />
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 2: CONTENIDO DEL FORMULARIO                               -->
        <!-- ============================================================== -->
        <Grid Grid.Row="2" Margin="24,14,24,16">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" /> <!-- Texto campos obligatorios -->
                <RowDefinition Height="Auto" /> <!-- Sección DATOS DEL ARTICULO -->
                <RowDefinition Height="Auto" /> <!-- Filas de datos del artículo -->
                <RowDefinition Height="Auto" /> <!-- Sección UBICACIÓN -->
                <RowDefinition Height="Auto" /> <!-- Filas de ubicación y observaciones -->
                <RowDefinition Height="*" />    <!-- Espacio y botones -->
            </Grid.RowDefinitions>

            <!-- Nota obligatorios -->
            <TextBlock Grid.Row="0"
                       Text="Los campos con asterisco son obligatorios" 
                       FontWeight="Bold" 
                       FontSize="11.5" 
                       Foreground="#1A1A1A" 
                       Margin="0,0,0,10" />

            <!-- Sección: DATOS DEL ARTICULO -->
            <StackPanel Grid.Row="1">
                <TextBlock Text="DATOS DEL ARTICULO" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="16.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,10" />
            </StackPanel>

            <!-- Formulario Datos del Artículo -->
            <Grid Grid.Row="2" Margin="0,0,0,10">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="28" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: Modelo y Fecha -->
                <ComboBox Grid.Row="0" Grid.Column="0" 
                          mat:HintAssist.Hint="Selecciona un modelo*" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,10" />

                <DatePicker Grid.Row="0" Grid.Column="2" 
                            mat:HintAssist.Hint="Selecciona una fecha" 
                            Style="{StaticResource MaterialDesignFloatingHintDatePicker}" 
                            FontSize="12.5" 
                            Margin="0,0,0,10" />

                <!-- Fila 2: Estado y Usuario -->
                <ComboBox Grid.Row="1" Grid.Column="0" 
                          mat:HintAssist.Hint="Selecciona un estado" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,10" />

                <ComboBox Grid.Row="1" Grid.Column="2" 
                          mat:HintAssist.Hint="Selecciona un usuario" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,10" />

                <!-- Fila 3: Número de Serie a ancho completo -->
                <StackPanel Grid.Row="2" Grid.Column="0" Grid.ColumnSpan="3" Margin="0,2,0,0">
                    <TextBox mat:HintAssist.Hint="Numero de Serie* (Debe de ser único)" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="45" 
                             FontSize="12.5" />
                    <TextBlock Text="0 / 45" 
                               HorizontalAlignment="Right" 
                               FontSize="11" 
                               Foreground="#757575" 
                               Margin="0,2,0,0" />
                </StackPanel>
            </Grid>

            <!-- Sección: UBICACIÓN -->
            <StackPanel Grid.Row="3" Margin="0,6,0,0">
                <TextBlock Text="UBICACIÓN" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="16.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,10" />
            </StackPanel>

            <!-- Formulario Ubicación -->
            <Grid Grid.Row="4">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="28" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: Departamento y Espacio -->
                <ComboBox Grid.Row="0" Grid.Column="0" 
                          mat:HintAssist.Hint="Selecciona un departamento*" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,12" />

                <ComboBox Grid.Row="0" Grid.Column="2" 
                          mat:HintAssist.Hint="Selecciona un espacio*" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,12" />

                <!-- Fila 2: Observaciones a ancho completo -->
                <TextBox Grid.Row="1" Grid.Column="0" Grid.ColumnSpan="3" 
                         mat:HintAssist.Hint="Observaciones" 
                         Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                         FontSize="12.5" 
                         Margin="0,4,0,0" />
            </Grid>

            <!-- Botones Cancelar y Guardar -->
            <StackPanel Grid.Row="5" 
                        Orientation="Horizontal" 
                        HorizontalAlignment="Right" 
                        VerticalAlignment="Bottom" 
                        Margin="0,15,0,4">
                <!-- Botón Cancelar en rojo -->
                <Button Content="Cancelar" 
                        Width="98" Height="36" 
                        Background="#E5302E" 
                        Foreground="White" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        BorderThickness="0" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" 
                        Margin="0,0,14,0">
                    <Button.Effect>
                        <DropShadowEffect Color="#777777" BlurRadius="6" ShadowDepth="2" Opacity="0.4" />
                    </Button.Effect>
                </Button>

                <!-- Botón Guardar blanco con borde rojo -->
                <Button Content="Guardar" 
                        Width="98" Height="36" 
                        Background="White" 
                        Foreground="#E5302E" 
                        BorderBrush="#E5302E" 
                        BorderThickness="1.2" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" />
            </StackPanel>

        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 12 - Formulario Insertar Artículo Material Design con Controles Personalizados
- **Archivo**: `di.unidad2.ejercicio12/di.unidad2.ejercicio12/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 36: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 13
**Título**: Formulario Añadir Usuario Material Design con Múltiples Secciones  
**Palabras clave técnicas**: `Formulario Gestión Usuarios`, `Barra Roja Personalizada con Controles`, `Secciones Datos Personales y Datos de Usuario`, `ComboBox Rol, Departamento, Grupo`, `Contador Caracteres`, `Formato Teléfono y Código Postal`, `DragMove()`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 13 - Formulario Añadir Usuario Material Design con Múltiples Secciones
- **Archivo**: `di.unidad2.ejercicio13/di.unidad2.ejercicio13/MainWindow.xaml`
- **Inicio**: Línea 15: <Window x:Class="di.unidad2.ejercicio13.MainWindow"...
- **Fin**: Línea 318: </Window>
- **Código**:

```xml
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio13"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        Title="GESTIÓN USUARIOS"
        Height="620" Width="780"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="White">

    <Grid>
        <Grid.RowDefinitions>
            <!-- Fila 0: Barra superior roja con tirador y controles -->
            <RowDefinition Height="38" />
            <!-- Fila 1: Banner oscuro AÑADIR UN USUARIO -->
            <RowDefinition Height="46" />
            <!-- Fila 2: Formulario principal -->
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <!-- ============================================================== -->
        <!-- FILA 0: BARRA DE TÍTULO ROJA PERSONALIZADA                     -->
        <!-- ============================================================== -->
        <Border Grid.Row="0" Background="#E5302E">
            <Grid>
                <!-- Logotipo blanco y título de la ventana -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Left" VerticalAlignment="Center" Margin="10,0,0,0">
                    <Image Source="Recursos/iconos/matisse.png" 
                           Height="24" 
                           Stretch="Uniform" 
                           VerticalAlignment="Center" 
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Margin="0,0,8,0" />
                    <TextBlock Text="GESTIÓN USUARIOS" 
                               Foreground="White" 
                               FontSize="14.5" 
                               FontWeight="SemiBold" 
                               VerticalAlignment="Center" />
                </StackPanel>

                <!-- Tirador superior decorativo idéntico al PDF -->
                <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                        Width="40" Height="12" 
                        Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                        CornerRadius="0,0,2,2">
                    <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                        <Rectangle Width="22" Height="1.5" Fill="#888888" Margin="0,0,0,2"/>
                        <Rectangle Width="22" Height="1.5" Fill="#888888"/>
                    </StackPanel>
                </Border>

                <!-- Botones de minimizar, maximizar y cerrar -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Center" Margin="0,0,12,0">
                    <Button Click="Minimize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <TextBlock Text="—" Foreground="White" FontSize="12" FontWeight="Bold" />
                    </Button>
                    <Button Click="Maximize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <mat:PackIcon Kind="WindowMaximize" Foreground="White" Width="14" Height="14" VerticalAlignment="Center" />
                    </Button>
                    <Button Click="Close_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand">
                        <mat:PackIcon Kind="Close" Foreground="White" Width="16" Height="16" VerticalAlignment="Center" />
                    </Button>
                </StackPanel>
            </Grid>
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 1: BANNER OSCURO AÑADIR UN USUARIO                        -->
        <!-- ============================================================== -->
        <Border Grid.Row="1" Background="#3E3E3E">
            <TextBlock Text="AÑADIR UN USUARIO" 
                       Foreground="White" 
                       FontSize="17" 
                       FontWeight="Normal" 
                       HorizontalAlignment="Center" 
                       VerticalAlignment="Center" />
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 2: CONTENIDO DEL FORMULARIO                               -->
        <!-- ============================================================== -->
        <Grid Grid.Row="2" Margin="26,12,26,16">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" /> <!-- Sección Datos Personales -->
                <RowDefinition Height="Auto" /> <!-- Filas de datos personales -->
                <RowDefinition Height="Auto" /> <!-- Sección Datos de Usuario -->
                <RowDefinition Height="Auto" /> <!-- Filas de datos de usuario -->
                <RowDefinition Height="*" />    <!-- Espacio y botones -->
            </Grid.RowDefinitions>

            <!-- ========================================================== -->
            <!-- 1. SECCIÓN: DATOS PERSONALES                               -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="0">
                <TextBlock Text="Datos Personales" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="16.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,10" />
            </StackPanel>

            <Grid Grid.Row="1" Margin="0,0,0,12">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="32" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: Nombre y Primer Apellido -->
                <StackPanel Grid.Row="0" Grid.Column="0" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Nombre" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="45" FontSize="12.5" />
                    <TextBlock Text="0 / 45" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <StackPanel Grid.Row="0" Grid.Column="2" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Primer Apellido" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="45" FontSize="12.5" />
                    <TextBlock Text="0 / 45" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <!-- Fila 2: Segundo Apellido y Email -->
                <StackPanel Grid.Row="1" Grid.Column="0" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Segundo Apellido" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="45" FontSize="12.5" />
                    <TextBlock Text="0 / 45" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <StackPanel Grid.Row="1" Grid.Column="2" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Email" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             FontSize="12.5" />
                </StackPanel>

                <!-- Fila 3: Domicilio a ancho completo -->
                <StackPanel Grid.Row="2" Grid.Column="0" Grid.ColumnSpan="3" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Domicilio" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="45" FontSize="12.5" />
                    <TextBlock Text="0 / 45" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <!-- Fila 4: Poblacion y (Telefono + Codigo Postal) -->
                <StackPanel Grid.Row="3" Grid.Column="0">
                    <TextBox mat:HintAssist.Hint="Poblacion" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="45" FontSize="12.5" />
                    <TextBlock Text="0 / 45" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <Grid Grid.Row="3" Grid.Column="2">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="1.3*" />
                        <ColumnDefinition Width="16" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>

                    <!-- Telefono con máscara -->
                    <StackPanel Grid.Column="0">
                        <TextBlock Text="Telefono" FontSize="10.5" Foreground="#757575" Margin="0,0,0,2" />
                        <TextBox Text="+34 - ___ ___ ___" 
                                 FontWeight="SemiBold" 
                                 FontSize="12.5" 
                                 Foreground="#212121" 
                                 BorderThickness="0,0,0,1" 
                                 BorderBrush="#9E9E9E" 
                                 Padding="0,0,0,4" />
                    </StackPanel>

                    <!-- Codigo Postal -->
                    <StackPanel Grid.Column="2">
                        <TextBlock Text="Codigo Postal" FontSize="10.5" Foreground="#757575" Margin="0,0,0,2" />
                        <TextBox Text="_____" 
                                 FontSize="12.5" 
                                 Foreground="#757575" 
                                 BorderThickness="0,0,0,1" 
                                 BorderBrush="#9E9E9E" 
                                 Padding="0,0,0,4" />
                    </StackPanel>
                </Grid>
            </Grid>

            <!-- ========================================================== -->
            <!-- 2. SECCIÓN: DATOS DE USUARIO                               -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="2" Margin="0,4,0,0">
                <TextBlock Text="Datos de Usuario" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="16.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,10" />
            </StackPanel>

            <Grid Grid.Row="3">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="32" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: (Nombre de usuario + Contraseña) y Tipo de usuario -->
                <Grid Grid.Row="0" Grid.Column="0" Margin="0,0,0,10">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="14" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <TextBox Grid.Column="0" mat:HintAssist.Hint="Nombre de usuario" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             FontSize="12.5" />
                    <PasswordBox Grid.Column="2" mat:HintAssist.Hint="Contraseña" 
                                 Style="{StaticResource MaterialDesignFloatingHintPasswordBox}" 
                                 FontSize="12.5" />
                </Grid>

                <ComboBox Grid.Row="0" Grid.Column="2" 
                          mat:HintAssist.Hint="Selecciona un tipo de usuario" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,10" />

                <!-- Fila 2: Rol de usuario y (Departamento + Grupo) -->
                <ComboBox Grid.Row="1" Grid.Column="0" 
                          mat:HintAssist.Hint="Selecciona un rol de usuario" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" />

                <Grid Grid.Row="1" Grid.Column="2">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="12" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <ComboBox Grid.Column="0" 
                              mat:HintAssist.Hint="Selecciona un departamento" 
                              Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                              FontSize="12.5" />
                    <ComboBox Grid.Column="2" 
                              mat:HintAssist.Hint="Selecciona un grupo" 
                              Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                              FontSize="12.5" />
                </Grid>
            </Grid>

            <!-- ========================================================== -->
            <!-- BOTONES INFERIORES: GUARDAR (ROJO) Y CANCELAR (BLANCO)     -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="4" 
                        Orientation="Horizontal" 
                        HorizontalAlignment="Right" 
                        VerticalAlignment="Bottom" 
                        Margin="0,15,0,0">
                <!-- Botón Guardar en rojo con sombra (izquierda) -->
                <Button Content="Guardar" 
                        Width="98" Height="36" 
                        Background="#E5302E" 
                        Foreground="White" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        BorderThickness="0" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" 
                        Margin="0,0,14,0">
                    <Button.Effect>
                        <DropShadowEffect Color="#777777" BlurRadius="6" ShadowDepth="2" Opacity="0.4" />
                    </Button.Effect>
                </Button>

                <!-- Botón Cancelar blanco con borde rojo (derecha) -->
                <Button Content="Cancelar" 
                        Width="98" Height="36" 
                        Background="White" 
                        Foreground="#E5302E" 
                        BorderBrush="#E5302E" 
                        BorderThickness="1.2" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" />
            </StackPanel>

        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 13 - Formulario Añadir Usuario Material Design con Múltiples Secciones
- **Archivo**: `di.unidad2.ejercicio13/di.unidad2.ejercicio13/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 36: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 14
**Título**: Formulario Gestión Productos con NumericUpDown de MahApps  
**Palabras clave técnicas**: `MahApps.Metro`, `mah:NumericUpDown`, `StringFormat="{}{0:N2} €"`, `Interval="0.50"`, `Minimum="0"`, `Stock Entero`, `Precios Decimales`, `MaterialDesignFloatingHintComboBox`, `Barra Roja Personalizada`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 14 - Formulario Gestión Productos con NumericUpDown de MahApps
- **Archivo**: `di.unidad2.ejercicio14/di.unidad2.ejercicio14/MainWindow.xaml`
- **Inicio**: Línea 15: <Window x:Class="di.unidad2.ejercicio14.MainWindow"...
- **Fin**: Línea 275: </Window>
- **Código**:

```xml
<Window x:Class="di.unidad2.ejercicio14.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio14"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="GESTIÓN PRODUCTOS"
        Height="620" Width="780"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="White">

    <Grid>
        <Grid.RowDefinitions>
            <!-- Fila 0: Barra superior roja con tirador y controles -->
            <RowDefinition Height="38" />
            <!-- Fila 1: Banner oscuro INSERTAR PRODUCTO -->
            <RowDefinition Height="46" />
            <!-- Fila 2: Formulario principal -->
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <!-- ============================================================== -->
        <!-- FILA 0: BARRA DE TÍTULO ROJA PERSONALIZADA                     -->
        <!-- ============================================================== -->
        <Border Grid.Row="0" Background="#E5302E">
            <Grid>
                <!-- Logotipo blanco y título de la ventana -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Left" VerticalAlignment="Center" Margin="10,0,0,0">
                    <Image Source="Recursos/iconos/matisse.png" 
                           Height="24" 
                           Stretch="Uniform" 
                           VerticalAlignment="Center" 
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Margin="0,0,8,0" />
                    <TextBlock Text="GESTIÓN PRODUCTOS" 
                               Foreground="White" 
                               FontSize="14.5" 
                               FontWeight="SemiBold" 
                               VerticalAlignment="Center" />
                </StackPanel>

                <!-- Tirador superior decorativo idéntico al PDF -->
                <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                        Width="40" Height="12" 
                        Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                        CornerRadius="0,0,2,2">
                    <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                        <Rectangle Width="22" Height="1.5" Fill="#888888" Margin="0,0,0,2"/>
                        <Rectangle Width="22" Height="1.5" Fill="#888888"/>
                    </StackPanel>
                </Border>

                <!-- Botones de minimizar, maximizar y cerrar -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Center" Margin="0,0,12,0">
                    <Button Click="Minimize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <TextBlock Text="—" Foreground="White" FontSize="12" FontWeight="Bold" />
                    </Button>
                    <Button Click="Maximize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <mat:PackIcon Kind="WindowMaximize" Foreground="White" Width="14" Height="14" VerticalAlignment="Center" />
                    </Button>
                    <Button Click="Close_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand">
                        <mat:PackIcon Kind="Close" Foreground="White" Width="16" Height="16" VerticalAlignment="Center" />
                    </Button>
                </StackPanel>
            </Grid>
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 1: BANNER OSCURO INSERTAR PRODUCTO                        -->
        <!-- ============================================================== -->
        <Border Grid.Row="1" Background="#3E3E3E">
            <TextBlock Text="INSERTAR PRODUCTO" 
                       Foreground="White" 
                       FontSize="17" 
                       FontWeight="Normal" 
                       HorizontalAlignment="Center" 
                       VerticalAlignment="Center" />
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 2: CONTENIDO DEL FORMULARIO                               -->
        <!-- ============================================================== -->
        <Grid Grid.Row="2" Margin="26,14,26,16">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" /> <!-- Texto campos obligatorios -->
                <RowDefinition Height="Auto" /> <!-- Sección DATOS DEL PRODUCTO -->
                <RowDefinition Height="Auto" /> <!-- Filas de datos del producto -->
                <RowDefinition Height="Auto" /> <!-- Sección VALORES Y STOCK -->
                <RowDefinition Height="Auto" /> <!-- Filas numéricas con NumericUpDown -->
                <RowDefinition Height="*" />    <!-- Espacio y botones -->
            </Grid.RowDefinitions>

            <!-- Nota obligatorios -->
            <TextBlock Grid.Row="0"
                       Text="Los campos con asterisco son obligatorios" 
                       FontWeight="Bold" 
                       FontSize="11.5" 
                       Foreground="#1A1A1A" 
                       Margin="0,0,0,10" />

            <!-- ========================================================== -->
            <!-- 1. SECCIÓN: DATOS DEL PRODUCTO                             -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="1">
                <TextBlock Text="DATOS DEL PRODUCTO" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="16.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,10" />
            </StackPanel>

            <Grid Grid.Row="2" Margin="0,0,0,10">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="32" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: Nombre (VARCHAR 70) y Gama (FK ComboBox) -->
                <StackPanel Grid.Row="0" Grid.Column="0" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Nombre del Producto*" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="70" FontSize="12.5" />
                    <TextBlock Text="0 / 70" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <!-- Clave ajena como ComboBox -->
                <ComboBox Grid.Row="0" Grid.Column="2" 
                          mat:HintAssist.Hint="Selecciona una gama*" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12.5" 
                          Margin="0,0,0,10" />

                <!-- Fila 2: Proveedor y Dimensiones -->
                <StackPanel Grid.Row="1" Grid.Column="0" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Proveedor" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="50" FontSize="12.5" />
                </StackPanel>

                <StackPanel Grid.Row="1" Grid.Column="2" Margin="0,0,0,6">
                    <TextBox mat:HintAssist.Hint="Dimensiones" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="25" FontSize="12.5" />
                    <TextBlock Text="0 / 25" HorizontalAlignment="Right" FontSize="10.5" Foreground="#757575" Margin="0,2,0,0" />
                </StackPanel>

                <!-- Fila 3: Descripción (TEXT) a ancho completo -->
                <TextBox Grid.Row="2" Grid.Column="0" Grid.ColumnSpan="3" 
                         mat:HintAssist.Hint="Descripción del Producto" 
                         Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                         FontSize="12.5" 
                         Margin="0,4,0,0" />
            </Grid>

            <!-- ========================================================== -->
            <!-- 2. SECCIÓN: VALORES Y STOCK (NumericUpDown MahApps)        -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="3" Margin="0,6,0,0">
                <TextBlock Text="VALORES Y STOCK" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="16.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,3,0,10" />
            </StackPanel>

            <Grid Grid.Row="4" Margin="0,4,0,0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="24" />
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="24" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>

                <!-- Cantidad en Stock (SMALLINT NN) con NumericUpDown de MahApps -->
                <StackPanel Grid.Column="0">
                    <TextBlock Text="Cantidad en Stock*" FontSize="11" Foreground="#757575" Margin="0,0,0,4" />
                    <mah:NumericUpDown Minimum="0" 
                                       Value="0" 
                                       Interval="1" 
                                       FontSize="12.5" 
                                       Height="36" />
                </StackPanel>

                <!-- Precio Venta (DECIMAL 15,2 NN) con NumericUpDown de MahApps -->
                <StackPanel Grid.Column="2">
                    <TextBlock Text="Precio de Venta*" FontSize="11" Foreground="#757575" Margin="0,0,0,4" />
                    <mah:NumericUpDown Minimum="0" 
                                       Value="0.00" 
                                       Interval="0.50" 
                                       StringFormat="{}{0:N2} €" 
                                       FontSize="12.5" 
                                       Height="36" />
                </StackPanel>

                <!-- Precio Proveedor (DECIMAL 15,2 NULL) con NumericUpDown de MahApps -->
                <StackPanel Grid.Column="4">
                    <TextBlock Text="Precio de Proveedor" FontSize="11" Foreground="#757575" Margin="0,0,0,4" />
                    <mah:NumericUpDown Minimum="0" 
                                       Value="0.00" 
                                       Interval="0.50" 
                                       StringFormat="{}{0:N2} €" 
                                       FontSize="12.5" 
                                       Height="36" />
                </StackPanel>
            </Grid>

            <!-- ========================================================== -->
            <!-- BOTONES DE ACCIÓN: GUARDAR Y CANCELAR                      -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="5" 
                        Orientation="Horizontal" 
                        HorizontalAlignment="Right" 
                        VerticalAlignment="Bottom" 
                        Margin="0,15,0,0">
                <!-- Botón Guardar en rojo con sombra -->
                <Button Content="Guardar" 
                        Width="98" Height="36" 
                        Background="#E5302E" 
                        Foreground="White" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        BorderThickness="0" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" 
                        Margin="0,0,14,0">
                    <Button.Effect>
                        <DropShadowEffect Color="#777777" BlurRadius="6" ShadowDepth="2" Opacity="0.4" />
                    </Button.Effect>
                </Button>

                <!-- Botón Cancelar blanco con borde rojo -->
                <Button Content="Cancelar" 
                        Width="98" Height="36" 
                        Background="White" 
                        Foreground="#E5302E" 
                        BorderBrush="#E5302E" 
                        BorderThickness="1.2" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" />
            </StackPanel>

        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 14 - Formulario Gestión Productos con NumericUpDown de MahApps
- **Archivo**: `di.unidad2.ejercicio14/di.unidad2.ejercicio14/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 36: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 2 - Ejercicio 15
**Título**: Formulario Gestión Clientes con NumericUpDown para Límite de Crédito  
**Palabras clave técnicas**: `MahApps.Metro`, `mah:NumericUpDown`, `Interval="100"`, `StringFormat="{}{0:N2} €"`, `MaterialDesign ComboBox`, `DatePicker`, `TextBox Floating Hint`, `Controles de Ventana Minimizar/Maximizar/Cerrar`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 2 - Ejercicio 15 - Formulario Gestión Clientes con NumericUpDown para Límite de Crédito
- **Archivo**: `di.unidad2.ejercicio15/di.unidad2.ejercicio15/MainWindow.xaml`
- **Inicio**: Línea 15: <Window x:Class="di.unidad2.ejercicio15.MainWindow"...
- **Fin**: Línea 330: </Window>
- **Código**:

```xml
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad2.ejercicio15"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="GESTIÓN CLIENTES"
        Height="630" Width="820"
        WindowStyle="None"
        ResizeMode="NoResize"
        WindowStartupLocation="CenterScreen"
        MouseDown="Window_MouseDown"
        Background="White">

    <Grid>
        <Grid.RowDefinitions>
            <!-- Fila 0: Barra superior roja con tirador y controles -->
            <RowDefinition Height="38" />
            <!-- Fila 1: Banner oscuro INSERTAR CLIENTE -->
            <RowDefinition Height="46" />
            <!-- Fila 2: Formulario principal -->
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <!-- ============================================================== -->
        <!-- FILA 0: BARRA DE TÍTULO ROJA PERSONALIZADA                     -->
        <!-- ============================================================== -->
        <Border Grid.Row="0" Background="#E5302E">
            <Grid>
                <!-- Logotipo blanco y título de la ventana -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Left" VerticalAlignment="Center" Margin="10,0,0,0">
                    <Image Source="Recursos/iconos/matisse.png" 
                           Height="24" 
                           Stretch="Uniform" 
                           VerticalAlignment="Center" 
                           RenderOptions.BitmapScalingMode="HighQuality"
                           Margin="0,0,8,0" />
                    <TextBlock Text="GESTIÓN CLIENTES" 
                               Foreground="White" 
                               FontSize="14.5" 
                               FontWeight="SemiBold" 
                               VerticalAlignment="Center" />
                </StackPanel>

                <!-- Tirador superior decorativo idéntico al PDF -->
                <Border HorizontalAlignment="Center" VerticalAlignment="Top" 
                        Width="40" Height="12" 
                        Background="#E5E5E5" BorderBrush="#AAAAAA" BorderThickness="1,0,1,1" 
                        CornerRadius="0,0,2,2">
                    <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                        <Rectangle Width="22" Height="1.5" Fill="#888888" Margin="0,0,0,2"/>
                        <Rectangle Width="22" Height="1.5" Fill="#888888"/>
                    </StackPanel>
                </Border>

                <!-- Botones de minimizar, maximizar y cerrar -->
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Right" VerticalAlignment="Center" Margin="0,0,12,0">
                    <Button Click="Minimize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <TextBlock Text="—" Foreground="White" FontSize="12" FontWeight="Bold" />
                    </Button>
                    <Button Click="Maximize_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand" Margin="0,0,12,0">
                        <mat:PackIcon Kind="WindowMaximize" Foreground="White" Width="14" Height="14" VerticalAlignment="Center" />
                    </Button>
                    <Button Click="Close_Click" Background="Transparent" BorderThickness="0" Padding="0" Cursor="Hand">
                        <mat:PackIcon Kind="Close" Foreground="White" Width="16" Height="16" VerticalAlignment="Center" />
                    </Button>
                </StackPanel>
            </Grid>
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 1: BANNER OSCURO INSERTAR CLIENTE                         -->
        <!-- ============================================================== -->
        <Border Grid.Row="1" Background="#3E3E3E">
            <TextBlock Text="INSERTAR CLIENTE" 
                       Foreground="White" 
                       FontSize="17" 
                       FontWeight="Normal" 
                       HorizontalAlignment="Center" 
                       VerticalAlignment="Center" />
        </Border>

        <!-- ============================================================== -->
        <!-- FILA 2: CONTENIDO DEL FORMULARIO                               -->
        <!-- ============================================================== -->
        <Grid Grid.Row="2" Margin="26,12,26,14">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" /> <!-- Nota campos obligatorios -->
                <RowDefinition Height="Auto" /> <!-- Sección DATOS DEL CLIENTE -->
                <RowDefinition Height="Auto" /> <!-- Filas de datos del cliente -->
                <RowDefinition Height="Auto" /> <!-- Sección DIRECCIÓN Y LOCALIZACIÓN -->
                <RowDefinition Height="Auto" /> <!-- Filas de dirección -->
                <RowDefinition Height="Auto" /> <!-- Sección DATOS COMERCIALES -->
                <RowDefinition Height="Auto" /> <!-- Filas datos comerciales -->
                <RowDefinition Height="*" />    <!-- Espacio y botones -->
            </Grid.RowDefinitions>

            <!-- Nota obligatorios -->
            <TextBlock Grid.Row="0"
                       Text="Los campos con asterisco son obligatorios" 
                       FontWeight="Bold" 
                       FontSize="11" 
                       Foreground="#1A1A1A" 
                       Margin="0,0,0,8" />

            <!-- ========================================================== -->
            <!-- 1. SECCIÓN: DATOS DEL CLIENTE                              -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="1">
                <TextBlock Text="DATOS DEL CLIENTE" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="15.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,2,0,8" />
            </StackPanel>

            <Grid Grid.Row="2" Margin="0,0,0,8">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="28" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: Nombre del Cliente (VARCHAR 50 NN) y Nombre de Contacto (VARCHAR 30) -->
                <StackPanel Grid.Row="0" Grid.Column="0" Margin="0,0,0,4">
                    <TextBox mat:HintAssist.Hint="Nombre del Cliente*" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="50" FontSize="12" />
                    <TextBlock Text="0 / 50" HorizontalAlignment="Right" FontSize="10" Foreground="#757575" Margin="0,1,0,0" />
                </StackPanel>

                <StackPanel Grid.Row="0" Grid.Column="2" Margin="0,0,0,4">
                    <TextBox mat:HintAssist.Hint="Nombre del Contacto" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="30" FontSize="12" />
                    <TextBlock Text="0 / 30" HorizontalAlignment="Right" FontSize="10" Foreground="#757575" Margin="0,1,0,0" />
                </StackPanel>

                <!-- Fila 2: Apellido del Contacto (VARCHAR 30) y (Teléfono + Fax) -->
                <StackPanel Grid.Row="1" Grid.Column="0">
                    <TextBox mat:HintAssist.Hint="Apellido del Contacto" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="30" FontSize="12" />
                    <TextBlock Text="0 / 30" HorizontalAlignment="Right" FontSize="10" Foreground="#757575" Margin="0,1,0,0" />
                </StackPanel>

                <Grid Grid.Row="1" Grid.Column="2">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="14" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <TextBox Grid.Column="0" 
                             mat:HintAssist.Hint="Teléfono*" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="15" FontSize="12" />
                    <TextBox Grid.Column="2" 
                             mat:HintAssist.Hint="Fax*" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="15" FontSize="12" />
                </Grid>
            </Grid>

            <!-- ========================================================== -->
            <!-- 2. SECCIÓN: DIRECCIÓN Y LOCALIZACIÓN                       -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="3" Margin="0,2,0,0">
                <TextBlock Text="DIRECCIÓN Y LOCALIZACIÓN" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="15.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,2,0,8" />
            </StackPanel>

            <Grid Grid.Row="4" Margin="0,0,0,8">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="28" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>

                <!-- Fila 1: Línea Dirección 1 (VARCHAR 50 NN) y Línea Dirección 2 (VARCHAR 50) -->
                <TextBox Grid.Row="0" Grid.Column="0" 
                         mat:HintAssist.Hint="Línea Dirección 1*" 
                         Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                         MaxLength="50" FontSize="12" Margin="0,0,0,6" />

                <TextBox Grid.Row="0" Grid.Column="2" 
                         mat:HintAssist.Hint="Línea Dirección 2" 
                         Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                         MaxLength="50" FontSize="12" Margin="0,0,0,6" />

                <!-- Fila 2: Ciudad, Región, País y Código Postal -->
                <Grid Grid.Row="1" Grid.Column="0">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="14" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <TextBox Grid.Column="0" 
                             mat:HintAssist.Hint="Ciudad*" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="50" FontSize="12" />
                    <TextBox Grid.Column="2" 
                             mat:HintAssist.Hint="Región / Provincia" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="50" FontSize="12" />
                </Grid>

                <Grid Grid.Row="1" Grid.Column="2">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="14" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <TextBox Grid.Column="0" 
                             mat:HintAssist.Hint="País" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="50" FontSize="12" />
                    <TextBox Grid.Column="2" 
                             mat:HintAssist.Hint="Código Postal" 
                             Style="{StaticResource MaterialDesignFloatingHintTextBox}" 
                             MaxLength="10" FontSize="12" />
                </Grid>
            </Grid>

            <!-- ========================================================== -->
            <!-- 3. SECCIÓN: DATOS COMERCIALES (FK ComboBox + NumericUpDown)-->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="5" Margin="0,2,0,0">
                <TextBlock Text="DATOS COMERCIALES" 
                           FontStyle="Italic" 
                           FontWeight="SemiBold" 
                           FontSize="15.5" 
                           Foreground="#E5302E" />
                <Separator Background="#C8D0D6" Height="1" Margin="0,2,0,8" />
            </StackPanel>

            <Grid Grid.Row="6" Margin="0,0,0,4">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="28" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>

                <!-- Clave ajena: CodigoEmpleadoRepVentas como ComboBox -->
                <ComboBox Grid.Column="0" 
                          mat:HintAssist.Hint="Representante de Ventas (Empleado)" 
                          Style="{StaticResource MaterialDesignFloatingHintComboBox}" 
                          FontSize="12" 
                          VerticalAlignment="Center" />

                <!-- Valor numérico: LimiteCredito con NumericUpDown de MahApps -->
                <StackPanel Grid.Column="2">
                    <TextBlock Text="Límite de Crédito" FontSize="10.5" Foreground="#757575" Margin="0,0,0,2" />
                    <mah:NumericUpDown Minimum="0" 
                                       Value="0.00" 
                                       Interval="500.00" 
                                       StringFormat="{}{0:N2} €" 
                                       FontSize="12" 
                                       Height="34" />
                </StackPanel>
            </Grid>

            <!-- ========================================================== -->
            <!-- BOTONES DE ACCIÓN: GUARDAR Y CANCELAR                      -->
            <!-- ========================================================== -->
            <StackPanel Grid.Row="7" 
                        Orientation="Horizontal" 
                        HorizontalAlignment="Right" 
                        VerticalAlignment="Bottom" 
                        Margin="0,10,0,2">
                <!-- Botón Guardar en rojo con sombra -->
                <Button Content="Guardar" 
                        Width="98" Height="36" 
                        Background="#E5302E" 
                        Foreground="White" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        BorderThickness="0" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" 
                        Margin="0,0,14,0">
                    <Button.Effect>
                        <DropShadowEffect Color="#777777" BlurRadius="6" ShadowDepth="2" Opacity="0.4" />
                    </Button.Effect>
                </Button>

                <!-- Botón Cancelar blanco con borde rojo -->
                <Button Content="Cancelar" 
                        Width="98" Height="36" 
                        Background="White" 
                        Foreground="#E5302E" 
                        BorderBrush="#E5302E" 
                        BorderThickness="1.2" 
                        FontWeight="SemiBold" 
                        FontSize="12.5" 
                        mat:ButtonAssist.CornerRadius="3" 
                        Cursor="Hand" />
            </StackPanel>

        </Grid>
    </Grid>
</Window>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 2 - Ejercicio 15 - Formulario Gestión Clientes con NumericUpDown para Límite de Crédito
- **Archivo**: `di.unidad2.ejercicio15/di.unidad2.ejercicio15/MainWindow.xaml.cs`
- **Inicio**: Línea 9: public partial class MainWindow : Window
- **Fin**: Línea 36: } (Fin de clase MainWindow)
- **Código**:

```csharp
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
```

---

## Ejercicio: Unidad 3 - Ejercicio 1
**Título**: Inventario Matisse con Menu Jerárquico y Barra de Herramientas ToolBar  
**Palabras clave técnicas**: `MahApps.Metro`, `MetroWindow.RightWindowCommands`, `Menu Jerárquico (IsMainMenu="True")`, `MenuItem con Iconos (PackIcon)`, `Separator`, `ToolBar con Botones y ToolTips`, `Buscador Integrado`, `Application.Current.Shutdown()`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 3 - Ejercicio 1 - Inventario Matisse con Menu Jerárquico y Barra de Herramientas ToolBar
- **Archivo**: `di.unidad3.ejercicio1/di.unidad3.ejercicio1/MainWindow.xaml`
- **Inicio**: Línea 11: <mah:MetroWindow x:Class="di.unidad3.ejercicio1.MainWindow"...
- **Fin**: Línea 231: </mah:MetroWindow>
- **Código**:

```xml
<mah:MetroWindow x:Class="di.unidad3.ejercicio1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad3.ejercicio1"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
        mc:Ignorable="d"
        Icon="/recursos/matisse.png"
        Title="INVENTARIO MATISSE" Height="450" Width="800">

    <!-- Comandos en la esquina superior derecha de la ventana (RightWindowCommands) -->
    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands ShowSeparators="True">
            <!-- Boton de perfil de usuario con ToolTip explicativo -->
            <Button ToolTip="Usuario">
                <mat:PackIcon Kind="AccountArrowRight" Width="22" Height="22" Foreground="White" />
            </Button>
            <!-- Boton de Salir: al hacer clic llama a salir_Click (Application.Current.Shutdown()) -->
            <Button ToolTip="Cerrar Sesión" x:Name="salir" Click="salir_Click">
                <mat:PackIcon Kind="Logout" Width="22" Height="22" Foreground="White" />
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <Grid>
        <!-- ==================================================================== -->
        <!-- BARRA DE MENU PRINCIPAL: Menu jerarquico                             -->
        <!-- IsMainMenu="True": Le indica a WPF que es la barra principal         -->
        <!-- ==================================================================== -->
        <Menu x:Name="menuPrueba" HorizontalAlignment="Left" Height="Auto"
              VerticalAlignment="Top" Width="550" IsMainMenu="True">

            <!-- 1. SECCION: Prestamos -->
            <MenuItem Header="Prestamos">
                <MenuItem Header="Salidas">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="Output"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Entradas">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="Input"/>
                    </MenuItem.Icon>
                </MenuItem>
                <Separator /> <!-- Separador horizontal entre opciones -->
                <MenuItem Header="Listado Pendientes">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="Clipboard"/>
                    </MenuItem.Icon>
                </MenuItem>
            </MenuItem>

            <!-- 2. SECCION: Articulos -->
            <MenuItem Header="Articulos">
                <MenuItem Header="Articulo Nuevo">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="ContentSaveAll"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Editar">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="BoxRefresh"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Lista">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="ListBox"/>
                    </MenuItem.Icon>
                </MenuItem>
                <Separator />
                <MenuItem Header="Modelo Articulo Nuevo">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="BoxCutter"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Modelo Articulo Editar">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="BoxEdit"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Lista Modelo Articulo">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="ClipboardList"/>
                    </MenuItem.Icon>
                </MenuItem>
            </MenuItem>

            <!-- 3. SECCION: Administracion -->
            <MenuItem Header="Administracion">
                <!-- Submenu jerarquico: Gestion Usuarios -->
                <MenuItem Header="Gestion Usuarios">
                    <MenuItem Header="Nuevo">
                        <MenuItem.Icon>
                            <mat:PackIcon Kind="AccountMultiplePlus"/>
                        </MenuItem.Icon>
                    </MenuItem>
                    <MenuItem Header="Editar">
                        <MenuItem.Icon>
                            <mat:PackIcon Kind="AccountEdit"/>
                        </MenuItem.Icon>
                    </MenuItem>
                    <MenuItem Header="Lista">
                        <MenuItem.Icon>
                            <mat:PackIcon Kind="AccountMultiple"/>
                        </MenuItem.Icon>
                    </MenuItem>
                </MenuItem>
                <MenuItem Header="Contraseñas">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="KeyChain"/>
                    </MenuItem.Icon>
                </MenuItem>
                <!-- Submenu jerarquico: Mantenimiento -->
                <MenuItem Header="Mantenimiento">
                    <MenuItem Header="Eliminar Articulo">
                        <MenuItem.Icon>
                            <mat:PackIcon Kind="Delete"/>
                        </MenuItem.Icon>
                    </MenuItem>
                    <MenuItem Header="Eliminar Modelo Articulo">
                        <MenuItem.Icon>
                            <mat:PackIcon Kind="DeleteSweep"/>
                        </MenuItem.Icon>
                    </MenuItem>
                    <MenuItem Header="Eliminar Usuario">
                        <MenuItem.Icon>
                            <mat:PackIcon Kind="AccountRemove"/>
                        </MenuItem.Icon>
                    </MenuItem>
                </MenuItem>
                <Separator />
                <MenuItem Header="Stock">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="ArchiveArrowDown"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Listado Usuarios">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="AccountDetails"/>
                    </MenuItem.Icon>
                </MenuItem>
            </MenuItem>

            <!-- 4. SECCION: Inventario -->
            <MenuItem Header="Inventario">
                <MenuItem Header="Listado de Espacios">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="MapMarkerMultiple"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Chequear Inventario">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="CheckAll"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Inventario Nuevo">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="PlaylistPlus"/>
                    </MenuItem.Icon>
                </MenuItem>
            </MenuItem>

            <!-- 5. SECCION: Informacion -->
            <MenuItem Header="Informacion">
                <MenuItem Header="Informes">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="ClipboardList"/>
                    </MenuItem.Icon>
                </MenuItem>
                <MenuItem Header="Gráficos">
                    <MenuItem.Icon>
                        <mat:PackIcon Kind="GraphLine"/>
                    </MenuItem.Icon>
                </MenuItem>
            </MenuItem>
        </Menu>

        <!-- ==================================================================== -->
        <!-- BARRA DE HERRAMIENTAS (ToolBar): Botones de acceso rapido            -->
        <!-- Cada boton incluye su ToolTip explicativo segun exige el enunciado   -->
        <!-- ==================================================================== -->
        <DockPanel Margin="0,50,0,0">
            <ToolBar DockPanel.Dock="Top">
                <!-- Boton 1: Salidas (ToolTip: "Salidas de material") -->
                <Button Command="Cut" ToolTip="Salidas de material">
                    <Button.Content>
                        <mat:PackIcon Kind="Output"/>
                    </Button.Content>
                </Button>
                <!-- Boton 2: Entradas (ToolTip: "Entradas de material") -->
                <Button Command="Copy" ToolTip="Entradas de material">
                    <Button.Content>
                        <mat:PackIcon Kind="Input"/>
                    </Button.Content>
                </Button>
                <!-- Boton 3: Guardar (ToolTip: "Guardar registros") -->
                <Button Command="Paste" ToolTip="Guardar registros">
                    <Button.Content>
                        <mat:PackIcon Kind="ContentSave"/>
                    </Button.Content>
                </Button>
                <!-- Boton 4: Listado rapido (ToolTip: "Listado de inventario") -->
                <Button ToolTip="Listado de inventario">
                    <Button.Content>
                        <mat:PackIcon Kind="ListBox"/>
                    </Button.Content>
                </Button>
                <Separator Height="40"/>
                <!-- Buscador integrado en la barra de herramientas -->
                <TextBlock Text="Busca un artículo" Foreground="White" VerticalAlignment="Center" Margin="10,0,0,0" />
                <TextBox Height="30" Width="120" BorderBrush="White" BorderThickness="1" Margin="5,0,0,0" />
            </ToolBar>
            <!-- Area de trabajo central disponible -->
            <Grid>
            </Grid>
        </DockPanel>
    </Grid>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 3 - Ejercicio 1 - Inventario Matisse con Menu Jerárquico y Barra de Herramientas ToolBar
- **Archivo**: `di.unidad3.ejercicio1/di.unidad3.ejercicio1/MainWindow.xaml.cs`
- **Inicio**: Línea 19: public partial class MainWindow : MetroWindow
- **Fin**: Línea 36: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador para el boton de salir de la barra de herramientas.
        /// Exigido en el enunciado: "Al apretar el botón de salir se cerrará el programa.
        /// Para ello utilizar Application.Current.Shutdown()."
        /// </summary>
        private void salir_Click(object sender, RoutedEventArgs e)
        {
            // Cierra la aplicacion entera de forma limpia
            Application.Current.Shutdown();
        }
    }
```

---

## Ejercicio: Unidad 3 - Ejercicio 2
**Título**: Cinta de Opciones Fluent Ribbon Estilo Office  
**Palabras clave técnicas**: `Fluent:Ribbon`, `Fluent:Backstage`, `Fluent:BackstageTabControl`, `Fluent:BackstageTabItem`, `Fluent:RibbonTabItem`, `Fluent:RibbonGroupBox`, `Fluent:Button con Icon y LargeIcon`, `Buscador en RibbonGroupBox`, `MetroWindow`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 3 - Ejercicio 2 - Cinta de Opciones Fluent Ribbon Estilo Office
- **Archivo**: `di.unidad3.ejercicio2/di.unidad3.ejercicio2/MainWindow.xaml`
- **Inicio**: Línea 9: <mah:MetroWindow x:Class="di.unidad3.ejercicio2.MainWindow"...
- **Fin**: Línea 115: </mah:MetroWindow>
- **Código**:

```xml
<mah:MetroWindow x:Class="di.unidad3.ejercicio2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:Fluent="urn:fluent-ribbon"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"                    
        xmlns:man="clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro"   
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"                
        mc:Ignorable="d"
        Icon="/recursos/Iconos/matisse.png"        
        Title="INVENTARIO MATISSE" Height="450" Width="800">

    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands>
            <!-- Boton de usuario en la barra superior -->
            <Button>
                <mat:PackIcon Kind="Account"/>
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <Grid>
        <!-- ==================================================================== -->
        <!-- CONTROL FLUENT:RIBBON: Cinta de opciones estilo Microsoft Office     -->
        <!-- ==================================================================== -->
        <Fluent:Ribbon>
            <!-- Menu Archivo / Backstage desplegable -->
            <Fluent:Ribbon.Menu>
                <Fluent:Backstage>
                    <Fluent:BackstageTabControl>
                        <Fluent:BackstageTabItem Header="Opciones" />
                        <Fluent:Button Header="Cerrar" LargeIcon="recursos/Iconos/cerrar.png" />
                    </Fluent:BackstageTabControl>
                </Fluent:Backstage>
            </Fluent:Ribbon.Menu>

            <!-- PESTAÑA 1: Prestamos -->
            <Fluent:RibbonTabItem Header="Prestamos">
                <Fluent:RibbonGroupBox Header="Operaciones" Margin="20,0,0,0">
                    <Fluent:Button Header="Salida" Icon="recursos/Iconos/addarticulo.png" />
                    <Fluent:Button Header="Devolución" Icon="recursos/Iconos/gesarticulo.png" Margin="20,0,0,0" />
                </Fluent:RibbonGroupBox>
                <Fluent:RibbonGroupBox Header="Búsquedas">
                    <StackPanel>
                        <TextBlock Text="Por número de serie" FontWeight="Bold" HorizontalAlignment="Center" Margin="20,0,20,0" />
                        <TextBox Margin="0,10,0,0" Width="150" BorderThickness="0,0,0,1" />
                    </StackPanel>
                </Fluent:RibbonGroupBox>
                <Fluent:RibbonGroupBox Header="Listados">
                    <Fluent:Button Header="Pendientes" Icon="recursos/Iconos/iconmodelo.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
            </Fluent:RibbonTabItem>

            <!-- PESTAÑA 2: ARTÍCULOS -->
            <Fluent:RibbonTabItem Header="ARTÍCULOS">
                <Fluent:RibbonGroupBox x:Name="ClipboardGroup" Header="Articulos" Margin="20,0,0,0">
                    <Fluent:Button Header="Nuevo" Icon="recursos/Iconos/addarticulo.png" />
                    <Fluent:Button Header="Editar" Icon="recursos/Iconos/gesarticulo.png" Margin="20,0,0,0" />
                    <Fluent:Button Header="Listado" Icon="recursos/Iconos/informe.png" Margin="20,0,0,0" />
                </Fluent:RibbonGroupBox>
                <Fluent:RibbonGroupBox Header="Modelo Artículos">
                    <Fluent:Button Header="Nuevo" Icon="recursos/Iconos/iconmodelo.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Editar" Icon="recursos/Iconos/iconmodelo.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Listado" Icon="recursos/Iconos/listamodelos.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
            </Fluent:RibbonTabItem>

            <!-- PESTAÑA 3: ADMINISTRACION -->
            <Fluent:RibbonTabItem Header="ADMINISTRACION">
                <Fluent:RibbonGroupBox Header="Gestionar Usuarios">
                    <Fluent:Button Header="Nuevo" Icon="recursos/Iconos/adduser.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Editar" Icon="recursos/Iconos/gesusuario.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Contraseñas" Icon="recursos/Iconos/resetclave.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Listado" Icon="recursos/Iconos/listausuarios.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
                <Fluent:RibbonGroupBox Header="Mantenimiento">
                    <Fluent:Button Header="Articulo" Icon="recursos/Iconos/borrar.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Modelo" Icon="recursos/Iconos/borrar.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Usuario" Icon="recursos/Iconos/borrar.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
                <Fluent:RibbonGroupBox Header="Stock">
                    <Fluent:Button Header="Stock" Icon="recursos/Iconos/stock.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
            </Fluent:RibbonTabItem>

            <!-- PESTAÑA 4: INVENTARIO -->
            <Fluent:RibbonTabItem Header="INVENTARIO">
                <Fluent:RibbonGroupBox Header="Espacios">
                    <Fluent:Button Header="Espacios" Icon="recursos/Iconos/espacios.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Chequeo" Icon="recursos/Iconos/espacios.png" Margin="20,0,0,0"/>
                    <Fluent:Button Header="Inventario" Icon="recursos/Iconos/addinventario.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
            </Fluent:RibbonTabItem>

            <!-- PESTAÑA 5: INFORMACION -->
            <Fluent:RibbonTabItem Header="INFORMACION">
                <Fluent:RibbonGroupBox Header="Informes">
                    <Fluent:Button Header="Informe" Icon="recursos/Iconos/informe.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
                <Fluent:RibbonGroupBox Header="Gráficos">
                    <Fluent:Button Header="Charts" Icon="recursos/Iconos/charts.png" Margin="20,0,0,0"/>
                </Fluent:RibbonGroupBox>
            </Fluent:RibbonTabItem>
        </Fluent:Ribbon>
    </Grid>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 3 - Ejercicio 2 - Cinta de Opciones Fluent Ribbon Estilo Office
- **Archivo**: `di.unidad3.ejercicio2/di.unidad3.ejercicio2/MainWindow.xaml.cs`
- **Inicio**: Línea 12: public partial class MainWindow : MetroWindow
- **Fin**: Línea 16: } (Fin de clase MainWindow)
- **Código**:

```csharp
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 3 - Ejercicio 3
**Título**: Menú Desplegable Lateral con Expander y ListView  
**Palabras clave técnicas**: `Expander (IsExpanded="False")`, `MaterialDesignExpander`, `ListView con ListViewItem`, `DockPanel.Dock="Left"`, `MaterialDesignListBoxItem`, `RightWindowCommands`, `PackIcon en Cabecera`, `Panel Oscuro Lateral (#E5303030)`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 3 - Ejercicio 3 - Menú Desplegable Lateral con Expander y ListView
- **Archivo**: `di.unidad3.ejercicio3/di.unidad3.ejercicio3/MainWindow.xaml`
- **Inicio**: Línea 9: <mah:MetroWindow x:Class="di.unidad3.ejercicio3.MainWindow"...
- **Fin**: Línea 83: </mah:MetroWindow>
- **Código**:

```xml
<mah:MetroWindow  
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls" x:Class="di.unidad3.ejercicio3.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:di.unidad3.ejercicio3"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:material="http://materialdesigninxaml.net/winfx/xaml/themes"
        mc:Ignorable="d"
        Title="INVENTARIO MATISSE" Height="450" Width="800">

    <!-- Boton de usuario en la barra superior derecha -->
    <mah:MetroWindow.RightWindowCommands>
        <mah:WindowCommands>
            <Button ToolTip="Perfil">
                <mat:PackIcon Kind="Account"/>
            </Button>
        </mah:WindowCommands>
    </mah:MetroWindow.RightWindowCommands>

    <!-- DockPanel: Contenedor para anclar el menu a la izquierda -->
    <DockPanel>
        <!-- Panel lateral izquierdo con fondo oscuro semi-transparente -->
        <Grid DockPanel.Dock="Left" Background="#E5303030" Width="250">
            <StackPanel x:Name="Menu" Margin="10">

                <!-- Elemento 1: Titulo/Opcion Dashboard -->
                <Grid>
                    <material:PackIcon Kind="ViewDashboard" Width="15" Height="15" Margin="10 16" Foreground="White"/>
                    <ListBoxItem x:Name="ListViewItemMenu" Content="Dashboard" Padding="37 14" FontSize="15" Foreground="White" Style="{StaticResource MaterialDesignListBoxItem}"/>
                </Grid>

                <!-- Elemento 2: Expander "Settings" que se despliega hacia abajo -->
                <Grid>
                    <material:PackIcon Kind="Settings" Width="15" Height="15" Margin="10 16" Foreground="White" />
                    <!-- Expander con IsExpanded="False" para que arranque cerrado -->
                    <Expander IsExpanded="False" Width="210" HorizontalAlignment="Right" 
                              Style="{StaticResource MaterialDesignExpander}" 
                              Header="Settings" Background="{x:Null}" Foreground="White">
                        <!-- Lista interior con las sub-opciones -->
                        <ListView x:Name="ListViewMenu" ItemsSource="{Binding Path=SubItems}" 
                                  Foreground="White" Style="{StaticResource MaterialDesignListView}" 
                                  ScrollViewer.HorizontalScrollBarVisibility="Disabled">
                            <ListViewItem Content="Users" Padding="20 5" />
                            <ListViewItem Content="Hardware" Padding="20 5" />
                            <ListViewItem Content="Software" Padding="20 5" />
                        </ListView>
                    </Expander>
                </Grid>

                <!-- Elemento 3: Expander "Personal" -->
                <Grid>
                    <material:PackIcon Kind="UserAlert" Width="15" Height="15" Margin="10 16" Foreground="White" />
                    <Expander IsExpanded="False" Width="210" HorizontalAlignment="Right" 
                              Header="Personal" Style="{StaticResource MaterialDesignExpander}" 
                              Background="{x:Null}" Foreground="White">
                        <ListView ItemsSource="{Binding Path=SubItems}" 
                                  Foreground="White" Style="{StaticResource MaterialDesignListView}" 
                                  ScrollViewer.HorizontalScrollBarVisibility="Disabled">
                            <ListViewItem Content="Profile" Padding="20 5" />
                            <ListViewItem Content="Password" Padding="20 5" />
                            <ListViewItem Content="Twitter" Padding="20 5" />
                        </ListView>
                    </Expander>
                </Grid>

            </StackPanel>
        </Grid>

        <!-- Area central principal donde se muestra el contenido seleccionado -->
        <Grid x:Name="gridCentral">
        </Grid>
    </DockPanel>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 3 - Ejercicio 3 - Menú Desplegable Lateral con Expander y ListView
- **Archivo**: `di.unidad3.ejercicio3/di.unidad3.ejercicio3/MainWindow.xaml.cs`
- **Inicio**: Línea 19: public partial class MainWindow : MetroWindow
- **Fin**: Línea 25: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Unidad 3 - Ejercicio 4
**Título**: Menú Hamburguesa con HamburgerMenu de MahApps  
**Palabras clave técnicas**: `mah:HamburgerMenu`, `DataTemplate MenuItemTemplateIcon`, `HamburgerMenuIconItem`, `HamburgerMenuItemCollection`, `ItemsSource (Items Principales)`, `OptionsItemsSource (Configuración/Ayuda)`, `DisplayMode="CompactInline"`

### Bloque 1: Diseño de Interfaz (XAML)
- **Ejercicio**: Unidad 3 - Ejercicio 4 - Menú Hamburguesa con HamburgerMenu de MahApps
- **Archivo**: `di.unidad3.ejercicio4/di.unidad3.ejercicio4/MainWindow.xaml`
- **Inicio**: Línea 1: <mah:MetroWindow x:Class="di.unidad3.ejercicio4.MainWindow"...
- **Fin**: Línea 68: </mah:MetroWindow>
- **Código**:

```xml
﻿<mah:MetroWindow x:Class="di.unidad3.ejercicio4.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:Fluent="urn:fluent-ribbon"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"                    
        xmlns:man="clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro"   
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"                
        mc:Ignorable="d"       
        Title="INVENTARIO MATISSE" Height="450" Width="800">

    <!-- RESOURCES: Este es el "cajón de sastre". Aquí guardamos moldes y cosas que queremos reutilizar sin escribir el código mil veces. -->
    <mah:MetroWindow.Resources>

        <!-- DATATEMPLATE: Este es el "molde" que le dice al programa cómo tiene que dibujar CADA botón del menú. -->
        <DataTemplate x:Key="MenuItemTemplateIcon" DataType="{x:Type mah:HamburgerMenuIconItem}">

            <!-- GRID: Es una tabla invisible para ordenar las cosas. Le damos 48 píxeles de alto. -->
            <Grid Height="48">
                <!-- Partimos la tabla en dos columnas: una pequeña para el dibujito y el resto para las palabras. -->
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="48" />
                    <ColumnDefinition />
                </Grid.ColumnDefinitions>

                <!-- Columna 0: Aquí se pinta el dibujito (el icono). Lo centramos y lo ponemos de color blanco. -->
                <ContentControl Grid.Column="0" Content="{Binding Icon}"  HorizontalAlignment="Center" VerticalAlignment="Center" Foreground="White" />

                <!-- Columna 1: Aquí se pinta el texto (el nombre del botón). Le ponemos tamaño 16 y color blanco. -->
                <TextBlock Grid.Column="1"  Text="{Binding Label}" VerticalAlignment="Center" FontSize="16"  Foreground="White" />
            </Grid>

        </DataTemplate>
    </mah:MetroWindow.Resources>

    <!-- GRID PRINCIPAL: La caja grande donde metemos el menú para que se vea en la pantalla. -->
    <Grid>

        <!-- EL MENÚ HAMBURGUESA: El jefe. El que dibuja la barra lateral oscura y las tres rayitas. -->
        <!-- Le decimos que el fondo es gris oscuro (#3B3B3B) y que use el "molde" que creamos arriba tanto para los botones de arriba (ItemTemplate) como para los de abajo (OptionsItemTemplate). -->
        <mah:HamburgerMenu x:Name="hamMenuPrincipal" 
                           Foreground="White" PaneBackground="#3B3B3B" 
                           DisplayMode="CompactInline" 
                           ItemTemplate="{StaticResource MenuItemTemplateIcon}" 
                           OptionsItemTemplate="{StaticResource MenuItemTemplateIcon}">

            <!-- ITEMS SOURCE: Aquí metemos la lista de los botones IMPORTANTES. Estos se van a pegar en la parte de ARRIBA del menú. -->
            <mah:HamburgerMenu.ItemsSource>
                <mah:HamburgerMenuItemCollection>
                    <mah:HamburgerMenuIconItem Label="Préstamos" Icon="{mat:PackIcon Kind=Sync}" />
                    <mah:HamburgerMenuIconItem Label="Búsquedas" Icon="{mat:PackIcon Kind=Magnify}" />
                    <mah:HamburgerMenuIconItem Label="Artículos" Icon="{mat:PackIcon Kind=Magnify}" />
                    <mah:HamburgerMenuIconItem Label="Administración" Icon="{mat:PackIcon Kind=Magnify}" />
                    <mah:HamburgerMenuIconItem Label="Inventario" Icon="{mat:PackIcon Kind=Magnify}" />
                </mah:HamburgerMenuItemCollection>
            </mah:HamburgerMenu.ItemsSource>

            <!-- OPTIONS ITEMS SOURCE: Aquí metemos la lista de los botones SECUNDARIOS. El menú los empuja automáticamente a la parte de ABAJO. -->
            <mah:HamburgerMenu.OptionsItemsSource>
                <mah:HamburgerMenuItemCollection>
                    <mah:HamburgerMenuIconItem Label="ayuda" Icon="{mat:PackIcon Kind=Help}"  />
                </mah:HamburgerMenuItemCollection>
            </mah:HamburgerMenu.OptionsItemsSource>

        </mah:HamburgerMenu>
    </Grid>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Control (C#)
- **Ejercicio**: Unidad 3 - Ejercicio 4 - Menú Hamburguesa con HamburgerMenu de MahApps
- **Archivo**: `di.unidad3.ejercicio4/di.unidad3.ejercicio4/MainWindow.xaml.cs`
- **Inicio**: Línea 7: public partial class MainWindow : MetroWindow
- **Fin**: Línea 12: } (Fin de clase MainWindow)
- **Código**:

```csharp
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

---

## Ejercicio: Proyecto Definitivo
**Título**: Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow  
**Palabras clave técnicas**: `Viewbox Adaptativo`, `Efecto Cristal (Border con DropShadowEffect)`, `MaterialDesignOutlinedTextBox y PasswordBox con Triggers`, `MahApps ShowMessageAsync Diálogo Asíncrono`, `Navegación entre Ventanas (Show y Close)`, `Menu Superior con Cerrar Sesión`, `App.xaml Diccionarios Fusionados`

### Bloque 1: Diseño de Pantalla Login (XAML)
- **Ejercicio**: Proyecto Definitivo - Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow
- **Archivo**: `proyectoDefinitivo/proyectoDefinitivo/Vista/Dialogo/PantallaLogin.xaml`
- **Inicio**: Línea 1: <mah:MetroWindow x:Class="proyectoDefinitivo.Vista.Dialogo.PantallaLogin"...
- **Fin**: Línea 193: </mah:MetroWindow>
- **Código**:

```xml
﻿<mah:MetroWindow x:Class="proyectoDefinitivo.Vista.Dialogo.PantallaLogin"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:proyectoDefinitivo.Vista.Dialogo"
        xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        mc:Ignorable="d"
        Title="PantallaLogin" Height="450" Width="800"
        ResizeMode="CanResize"
        WindowStartupLocation="CenterScreen">

    <mah:MetroWindow.Resources>
        <SolidColorBrush x:Key="PrimaryHueMidBrush" Color="#C79F86" />
        <SolidColorBrush x:Key="PrimaryHueMidForegroundBrush" Color="White" />
        <SolidColorBrush x:Key="MaterialDesignBody" Color="#C79F86" />
    </mah:MetroWindow.Resources>

    
    <Grid>
        <!-- Fondo base adaptativo -->
        <Image Source="/Recursos/Imagenes/Onades de seda blava i daurada.png" Stretch="Fill"/>

        <!-- EL VIEWBOX: StretchDirection="DownOnly" evita que se vuelva gigante en 1080p -->
        <Viewbox Stretch="Uniform" StretchDirection="DownOnly" Margin="20">

            <!-- PANEL EFECTO CRISTAL -->
            <!-- Medidas ajustadas a las proporciones exactas de tu captura en 720p -->
            <Border Width="750" Height="580" 
                BorderBrush="#C79F86" 
                BorderThickness="2" 
                CornerRadius="25" 
                Background="#B3101826"
                Padding="60,40,60,10">

                <Border.Effect>
                    <DropShadowEffect BlurRadius="40" ShadowDepth="10" Direction="270" Color="Black" Opacity="0.5" />
                </Border.Effect>

                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                        <!-- Logo -->
                        <RowDefinition Height="Auto"/>
                        <!-- Email -->
                        <RowDefinition Height="Auto"/>
                        <!-- Password -->
                        <RowDefinition Height="Auto"/>
                        <!-- CheckBox -->
                        <RowDefinition Height="Auto"/>
                        <!-- Botón -->
                        <RowDefinition Height="*"/>
                        <!-- Olvidar pass -->
                    </Grid.RowDefinitions>

                    <!-- Logo -->
                    <Image Grid.Row="0" Source="/Recursos/Imagenes/LogoOscur.jpg" 
           Stretch="Uniform" HorizontalAlignment="Center" 
           Height="140" Margin="0,0,0,30" />

                    <!-- Input: Correo Electrónico -->
                    <!-- Input: Correo Electrónico -->
                    <TextBox Grid.Row="1" 
         x:Name="txtcorreo"
         Margin="60,15,60,15"
         HorizontalAlignment="Stretch" 
         VerticalAlignment="Center"
         FontSize="18"
         Padding="16"
         Foreground="White"
         TextElement.Foreground="White"
         CaretBrush="White"
         materialDesign:HintAssist.Foreground="#99C79F86"
         materialDesign:HintAssist.Background="Transparent"
         materialDesign:TextFieldAssist.UnderlineBrush="#000C38"
         materialDesign:TextFieldAssist.HasClearButton="False"
         materialDesign:TextFieldAssist.TextFieldCornerRadius="15">
                        <TextBox.Style>
                            <Style TargetType="TextBox" BasedOn="{StaticResource MaterialDesignOutlinedTextBox}">
                                <Setter Property="Background" Value="#40000000" />
                                <Setter Property="BorderBrush" Value="#C79F86" />
                                <Style.Triggers>
                                    <Trigger Property="IsKeyboardFocused" Value="True">
                                        <Setter Property="Background" Value="#80000000" />
                                        <Setter Property="BorderBrush" Value="#000C38" />
                                    </Trigger>
                                </Style.Triggers>
                            </Style>
                        </TextBox.Style>

                        <materialDesign:HintAssist.Hint>
                            <StackPanel Orientation="Horizontal" Margin="-2,0,0,0">
                                <materialDesign:PackIcon Kind="User" Margin="0,0,8,0" VerticalAlignment="Center" Foreground="#C79F86" />
                                <TextBlock Text="Correo electrónico" VerticalAlignment="Center" Foreground="#C79F86" />
                            </StackPanel>
                        </materialDesign:HintAssist.Hint>
                    </TextBox>

                    <!-- Input: Contraseña -->
                    <PasswordBox Grid.Row="2" 
             x:Name="passClaveAcceso"
             Margin="60,15,60,30"
             HorizontalAlignment="Stretch" 
             VerticalAlignment="Center"
             FontSize="18"
             Padding="16"
             Foreground="White"
             TextElement.Foreground="White"
             CaretBrush="White"
             materialDesign:HintAssist.Foreground="#99C79F86"
             materialDesign:TextFieldAssist.HasClearButton="False"
             materialDesign:TextFieldAssist.TextFieldCornerRadius="15"
             materialDesign:PasswordBoxAssist.IsPasswordRevealed="False">
                        <PasswordBox.Style>
                            <Style TargetType="PasswordBox" BasedOn="{StaticResource MaterialDesignOutlinedPasswordBox}">
                                <Setter Property="Background" Value="#40000000" />
                                <Setter Property="BorderBrush" Value="#C79F86" />
                                <Style.Triggers>
                                    <Trigger Property="IsKeyboardFocused" Value="True">
                                        <Setter Property="Background" Value="#80000000" />
                                        <Setter Property="BorderBrush" Value="#000C38" />
                                    </Trigger>
                                </Style.Triggers>
                            </Style>
                        </PasswordBox.Style>

                        <materialDesign:HintAssist.Hint>
                            <StackPanel Orientation="Horizontal" Margin="-2,0,0,0">
                                <materialDesign:PackIcon Kind="LockOutline" Margin="0,0,8,0" VerticalAlignment="Center" Foreground="#C79F86" />
                                <TextBlock Text="Contraseña" VerticalAlignment="Center" Foreground="#C79F86" />
                            </StackPanel>
                        </materialDesign:HintAssist.Hint>
                    </PasswordBox>

                    <!-- Input: Contraseña -->
                    

                    <!-- CheckBox Recordarme -->
                    <CheckBox Grid.Row="3"
                          VerticalAlignment="Center"
                          HorizontalAlignment="Center"
                          FocusVisualStyle="{x:Null}"
                          Margin="0,0,0,25"
                          BorderBrush="#C79F86">
                        <TextBlock Text="¿Recordarme?"
                               Foreground="#C79F86"
                               TextElement.Foreground="#C79F86"/>
                        <CheckBox.Resources>
                            <SolidColorBrush x:Key="MaterialDesign.Brush.Primary" Color="#C79F86"/>
                            <SolidColorBrush x:Key="MaterialDesign.Brush.Secondary" Color="#C79F86"/>
                            <SolidColorBrush x:Key="MaterialDesignCheckBoxOff" Color="AliceBlue"/>
                        </CheckBox.Resources>
                    </CheckBox>

                    <!-- Botón Iniciar Sesión -->
                    <Button Grid.Row="4" Content="Iniciar Sesión" 
                        FontSize="20" Height="48"
                        Margin="80,0,80,0"
                        HorizontalAlignment="Stretch" 
                        VerticalAlignment="Center"
                        materialDesign:ButtonAssist.CornerRadius="35"
                        Foreground="Black"
                        FontWeight="Bold"
                            x:Name="btnLogin"
                            Click="btnLogin_Click">
                        <Button.BorderBrush>
                            <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                                <GradientStop Color="#8B5D50" Offset="0.0"/>
                                <GradientStop Color="#E7B8A0" Offset="1.0"/>
                            </LinearGradientBrush>
                        </Button.BorderBrush>
                        <Button.Background>
                            <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                                <GradientStop Color="#8B5D50" Offset="0.0"/>
                                <GradientStop Color="#E7B8A0" Offset="1.0"/>
                            </LinearGradientBrush>
                        </Button.Background>
                    </Button>

                    <!-- Texto Olvidar Contraseña -->
                    <TextBlock Grid.Row="5"
                               Text="¿Olvidaste tu contraseña?" 
                               Foreground="#C79F86" 
                               Cursor="Hand"
                               Margin="0,0,0,15"
                               HorizontalAlignment="Center" 
                               VerticalAlignment="Bottom" />
                </Grid>
            </Border>
        </Viewbox>
    </Grid>
</mah:MetroWindow>
```

### Bloque 2: Lógica de Validación y Login (C#)
- **Ejercicio**: Proyecto Definitivo - Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow
- **Archivo**: `proyectoDefinitivo/proyectoDefinitivo/Vista/Dialogo/PantallaLogin.xaml.cs`
- **Inicio**: Línea 22: public partial class PantallaLogin : MetroWindow
- **Fin**: Línea 41: } (Fin de clase PantallaLogin)
- **Código**:

```csharp
    public partial class PantallaLogin : MetroWindow
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(passClaveAcceso.Password))
            {
                await this.ShowMessageAsync("Error de inicio de sesión", "Por favor, ingrese su correo y contraseña.");
            }
            else {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
```

### Bloque 3: Diseño de Ventana Principal MainWindow (XAML)
- **Ejercicio**: Proyecto Definitivo - Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow
- **Archivo**: `proyectoDefinitivo/proyectoDefinitivo/MainWindow.xaml`
- **Inicio**: Línea 1: <Window x:Class="proyectoDefinitivo.MainWindow"...
- **Fin**: Línea 25: </Window>
- **Código**:

```xml
﻿<Window x:Class="proyectoDefinitivo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:proyectoDefinitivo"
        mc:Ignorable="d"
        xmlns:mat="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
        ShowInTaskbar="True"
        WindowState="Maximized"
        Title="Pantalla Principal" Height="450" Width="800">
    <Grid>
        <Image Source="/Recursos/Imagenes/LocoClaro.jpg"
               Stretch="Fill"/>

        <Menu HorizontalAlignment="Left" Height="Auto"
              VerticalAlignment="Top" Width="550" IsMainMenu="True">
            <MenuItem Header="kktua"></MenuItem>
            <MenuItem Header="usuario">
                <MenuItem Header="Cerrar Sesion" x:Name="btmcerrarsesion" Click="btmcerrarsesion_Click" />
            </MenuItem>
        </Menu>
    </Grid>
</Window>
```

### Bloque 4: Lógica de Cierre de Sesión MainWindow (C#)
- **Ejercicio**: Proyecto Definitivo - Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow
- **Archivo**: `proyectoDefinitivo/proyectoDefinitivo/MainWindow.xaml.cs`
- **Inicio**: Línea 19: public partial class MainWindow : Window
- **Fin**: Línea 32: } (Fin de clase MainWindow)
- **Código**:

```csharp
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btmcerrarsesion_Click(object sender, RoutedEventArgs e)
        {
            PantallaLogin pantallaLogin = new PantallaLogin();
            pantallaLogin.Show();
            this.Close();
        }
    }
```

### Bloque 5: Configuración Global y Estilos (App.xaml)
- **Ejercicio**: Proyecto Definitivo - Login Modal con Efecto Cristal, Diálogo Asíncrono y Navegación a MainWindow
- **Archivo**: `proyectoDefinitivo/proyectoDefinitivo/App.xaml`
- **Inicio**: Línea 1: <Application x:Class="proyectoDefinitivo.App"...
- **Fin**: Línea 27: </Application>
- **Código**:

```xml
﻿<Application x:Class="proyectoDefinitivo.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:proyectoDefinitivo"
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             StartupUri="/Vista/Dialogo/PantallaLogin.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <materialDesign:BundledTheme BaseTheme="Light" 
                                             PrimaryColor="LightBlue" 
                                             SecondaryColor="Indigo" />

                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />


                <!-- MahApps.Metro resource dictionaries. Make sure that all file names are Case Sensitive! -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <!-- Accent and AppTheme setting -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml" />


            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

---

## Configuración Global: App.xaml (MahApps + Material Design)
**Palabras clave técnicas**: `App.xaml`, `ResourceDictionary`, `MergedDictionaries`, `BundledTheme`, `MaterialDesignThemes`, `MahApps.Metro`, `Styles/Controls.xaml`

### Bloque Resumen: Configuración universal de recursos en App.xaml para exámenes
- **Ejercicio**: Configuración Base de Proyecto (Todos los ejercicios con MahApps / MaterialDesign)
- **Archivo**: `App.xaml`
- **Inicio**: Línea 1: `<Application x:Class="...App"...`
- **Fin**: Línea de cierre: `</Application>`
- **Código**:

```xml
<Application x:Class="MiProyecto.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             xmlns:mah="http://metro.mahapps.com/winfx/xaml/controls"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- 1. Paleta de colores y tema Material Design -->
                <materialDesign:BundledTheme BaseTheme="Light" 
                                             PrimaryColor="DeepPurple" 
                                             SecondaryColor="Amber" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesign2.Defaults.xaml" />

                <!-- 2. Diccionarios de controles y fuentes MahApps.Metro (Case-Sensitive) -->
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

