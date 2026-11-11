# 🎨 Diseño de Interfaces — WPF (.NET 8), Material Design, MahApps.Metro & MVVM

Repositorio completo de **Diseño de Interfaces (DAM)** en **C# y WPF (.NET 8.0)** preparado tanto para consulta ultrarrápida durante exámenes prácticos como para desarrollo profesional con arquitectura limpia por capas (**MVVM + Inyección de Dependencias + Repositorios + Estilos Centralizados**).

---

## 🚀 Herramientas Rápidas para el Examen

| Recurso | Descripción |
| :--- | :--- |
| **[`00_Plantilla_Examen/`](./00_Plantilla_Examen/)** | **Plantilla base lista para clonar**: Proyecto WPF (.NET 8) preconfigurado con `MaterialDesignThemes`, `MahApps.Metro`, `Microsoft.Data.Sqlite`, `DependencyInjection`, ventana redondeada sin bordes, KPIs, formulario, `DataGrid` (`ObservableCollection`) y diálogo modal secundario. |
| **[`CHULETA_EXAMEN.html`](./CHULETA_EXAMEN.html)** | **Chuleta interactiva 100% offline** (tema oscuro compacto 720p) con buscador en tiempo real (`Ctrl+K`), filtros por categoría y botones de copiado en 1 clic (`Copiar XAML` / `Copiar C#`). |
| **[`CHULETA_EXAMEN.md`](./CHULETA_EXAMEN.md)** | **Guía técnica indexada en Markdown** con todos los patrones de configuración, layouts, controles, validaciones, SQLite y MVVM extraídos de los proyectos del repositorio. |
| **[`IndiceExamen.html`](./IndiceExamen.html)** | **Índice visual 720p** de todos los PDFs de teoría, vistas `.xaml`, lógica `.cs` y bloques de componentes del repositorio. |

---

## 🏛️ Estructura del Repositorio

```text
disenyo-de-interfaces/
├── 00_Plantilla_Examen/                  # Plantilla base unificada y reutilizable (.NET 8)
│   ├── PlantillaExamen.sln
│   └── PlantillaExamen/
│       ├── Datos/                        # Acceso a datos y SQLite
│       ├── Modelos/                      # Entidades de dominio (RegistroItem.cs)
│       ├── Recursos/                     # Estilos, Iconos e Imágenes (Build Action: Resource automático)
│       ├── Servicios/                    # Lógica de negocio
│       ├── ViewModel/                    # ViewModels y Commands
│       └── Vista/Dialogo/                # Ventanas modales secundarias (VentanaSecundaria.xaml)
├── 01_Teoria_y_Enunciados_PDF/           # Temario oficial (Temas 1, 2, 3) y enunciado de examen
├── 02_Cheatsheets_y_Chuletas/            # Resúmenes en PDF por bloques de ejercicios
├── 03_Unidad2_Dashboards_y_Logins/       # Ejercicios 1 a 11 (Logins, Perfiles, Degradados, RotateTransform)
├── 04_Unidad2_Formularios_MaterialDesign/# Ejercicios 12 a 15 (FloatingHint, Validaciones, NumericUpDown)
├── 05_Unidad3_Menus_Ribbon_y_Navegacion/ # Ejercicios 1 a 5 (Menu/ToolBar, Fluent.Ribbon, Expander, HamburgerMenu)
├── 06_Proyecto_Definitivo_y_Examen/      # Solución de Examen y Proyecto Definitivo refactorizado con MVVM
│   ├── Examen_DI_19_11_2025/             # Dashboard empresarial con ventana modal y SQLite
│   └── proyectoDefinitivo/               # Aplicación DegradApp con arquitectura MVVM completa
├── CHULETA_EXAMEN.html                   # Buscador interactivo offline de snippets XAML + C#
├── CHULETA_EXAMEN.md                     # Documentación de patrones y fragmentos listos para copiar
└── IndiceExamen.html                     # Explorador compacto 720p de todo el repositorio
```

---

## 🧱 Arquitectura por Capas (`proyectoDefinitivo`)

El proyecto [`06_Proyecto_Definitivo_y_Examen/proyectoDefinitivo`](./06_Proyecto_Definitivo_y_Examen/proyectoDefinitivo/proyectoDefinitivo/) implementa una arquitectura desacoplada y escalable en 6 capas:

```text
proyectoDefinitivo/
├── Modelos/                              # Entidades de dominio
│   └── Usuario.cs                        # Correo, Password, FechaRegistro
├── Datos/Repositorios/                   # Persistencia desacoplada mediante interfaces
│   ├── IUsuarioRepositorio.cs
│   └── UsuarioRepositorio.cs             # Persistencia JSON en disco + usuario semilla (admin@degradapp.com / 1234)
├── Servicios/                            # Lógica de negocio, validación Regex y sesión activa
│   ├── Interfaces/IAutenticacionServicio.cs
│   └── AutenticacionServicio.cs
├── ViewModel/                            # Estado de presentación y comandos (MVVM)
│   ├── BaseViewModel.cs                  # Implementación de INotifyPropertyChanged (SetProperty)
│   ├── RelayCommand.cs                   # Implementación reutilizable de ICommand
│   ├── LoginViewModel.cs
│   ├── RegistroViewModel.cs
│   ├── RecuperarClaveViewModel.cs
│   └── MainViewModel.cs
├── Helpers/                              # Utilidades y Attached Properties de WPF
│   └── PasswordBoxHelper.cs              # Permite hacer TwoWay Binding de PasswordBox.Password en MVVM
├── Recursos/
│   ├── Estilos/EstilosGlobales.xaml      # Diccionario centralizado (Glassmorphism, colores, botones y triggers)
│   └── Imagenes/                         # Fondos y logotipos empaquetados como Resource
└── Vista/Dialogo/                        # Vistas XAML responsivas (Viewbox DownOnly para 720p/1080p)
    ├── PantallaLogin.xaml
    ├── PantallaRegistro.xaml
    └── PantallaRecuperarClave.xaml
```

### Patrones de Diseño Aplicados
1. **MVVM (Model-View-ViewModel)**: Separación entre las vistas XAML y el estado/comandos (`INotifyPropertyChanged`, `RelayCommand` y `ObservableCollection<T>`).
2. **Inyección de Dependencias (`Microsoft.Extensions.DependencyInjection`)**: Configurada en `App.xaml.cs` registrando repositorios y servicios como `Singleton` y vistas/factorías `Func<T>` como `Transient`.
3. **Patrón Repositorio (`IUsuarioRepositorio`)**: Abstrae el almacenamiento en `usuarios.json` o `SQLite` del resto de la aplicación.
4. **Attached Properties (`PasswordBoxHelper`)**: Soluciona la limitación nativa de seguridad de WPF permitiendo enlazar `PasswordBox` directamente al `ViewModel`.
5. **Recursos y Estilos Centralizados (`EstilosGlobales.xaml`)**: Evita duplicar código XAML unificando pinceles, sombras `DropShadowEffect`, bordes `GlassCardBorderStyle` y `Style.Triggers` (`IsKeyboardFocused`).

---

## ⚙️ Requisitos e Instrucciones de Ejecución

### Requisitos Previos
* **.NET 8.0 SDK** (o superior, compatible también con .NET 9.0 SDK) en Windows.
* **Visual Studio 2022** con la carga de trabajo *Desarrollo de escritorio de .NET* (WPF).

### Compilar y Ejecutar por Consola (CLI)
```powershell
# 1. Compilar y ejecutar la Plantilla Base de Examen
dotnet build 00_Plantilla_Examen/PlantillaExamen/PlantillaExamen.csproj
dotnet run --project 00_Plantilla_Examen/PlantillaExamen/PlantillaExamen.csproj

# 2. Compilar y ejecutar el Proyecto Definitivo (DegradApp)
dotnet build 06_Proyecto_Definitivo_y_Examen/proyectoDefinitivo/proyectoDefinitivo/proyectoDefinitivo.csproj
dotnet run --project 06_Proyecto_Definitivo_y_Examen/proyectoDefinitivo/proyectoDefinitivo/proyectoDefinitivo.csproj
```
> **Credenciales por defecto en `proyectoDefinitivo`**:
> - **Correo**: `admin@degradapp.com`
> - **Contraseña**: `1234`
> *(También puedes registrar cualquier cuenta nueva desde la pantalla de Registro y quedará guardada en `usuarios.json`).*
