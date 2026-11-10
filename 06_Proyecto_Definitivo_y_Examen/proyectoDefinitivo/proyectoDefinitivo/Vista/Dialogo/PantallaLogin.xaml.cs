// =========================================================================
// LÓGICA C# DE PANTALLA LOGIN (VALIDACIÓN + DIÁLOGO MAHAPPS + NAVEGACIÓN)
// =========================================================================
// QUÉ HACE ESTE ARCHIVO:
//   1. Hereda de MetroWindow (MahApps.Metro) en lugar de Window normal.
//   2. Recibe la ventana principal (MainWindow) por Inyección de Dependencias en el constructor.
//   3. En btnLogin_Click:
//      - Si el correo o la contraseña están vacíos, muestra un diálogo modal moderno
//        integrado en la ventana usando await this.ShowMessageAsync(...).
//      - Si están rellenos, asigna MainWindow como ventana principal de la app,
//        la muestra (_mainWindow.Show()) y cierra el login (this.Close()).
// =========================================================================

using System;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace proyectoDefinitivo.Vista.Dialogo
{
    public partial class PantallaLogin : MetroWindow
    {
        private readonly MainWindow _mainWindow;

        // Constructor con Inyección de Dependencias (recibe MainWindow desde App.xaml.cs)
        public PantallaLogin(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        // Evento Click asíncrono del botón "Iniciar Sesión"
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // 1. Validar que el TextBox de correo y el PasswordBox no estén vacíos
            if (string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(passClaveAcceso.Password))
            {
                // Muestra diálogo modal embebido de MahApps.Metro
                await this.ShowMessageAsync("Error de inicio de sesión", "Por favor, ingrese su correo y contraseña.");
            }
            else
            {
                // 2. Cambiar la ventana principal de la aplicación y abrirla
                Application.Current.MainWindow = _mainWindow;
                _mainWindow.Show();

                // 3. Cerrar la ventana de Login actual
                this.Close();
            }
        }
    }
}
