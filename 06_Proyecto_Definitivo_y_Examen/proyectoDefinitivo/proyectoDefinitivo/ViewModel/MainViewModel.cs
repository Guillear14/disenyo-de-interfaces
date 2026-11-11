using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;

        public string CorreoUsuarioActual =>
            _autenticacionServicio.UsuarioActual?.Correo ?? "Usuario";

        public MainViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
        }

        public void CerrarSesion()
        {
            _autenticacionServicio.CerrarSesion();
        }
    }
}
