using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;
        private string _correo = string.Empty;

        public string Correo
        {
            get => _correo;
            set => SetProperty(ref _correo, value);
        }

        public LoginViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
        }

        public ResultadoOperacion IniciarSesion(string password)
        {
            return _autenticacionServicio.IniciarSesion(Correo, password);
        }
    }
}
