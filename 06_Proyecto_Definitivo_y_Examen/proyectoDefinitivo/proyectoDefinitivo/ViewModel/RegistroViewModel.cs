using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class RegistroViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;
        private string _correo = string.Empty;

        public string Correo
        {
            get => _correo;
            set => SetProperty(ref _correo, value);
        }

        public RegistroViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
        }

        public ResultadoOperacion Registrar(string password, string confirmarPassword)
        {
            return _autenticacionServicio.RegistrarUsuario(Correo, password, confirmarPassword);
        }
    }
}
