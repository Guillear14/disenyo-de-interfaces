using System.Windows.Input;
using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;
        private string _correo = string.Empty;
        private string _password = string.Empty;
        private bool _recordarme;

        public string Correo
        {
            get => _correo;
            set => SetProperty(ref _correo, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public bool Recordarme
        {
            get => _recordarme;
            set => SetProperty(ref _recordarme, value);
        }

        public ICommand IniciarSesionCommand { get; }

        public LoginViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
            IniciarSesionCommand = new RelayCommand(_ => IniciarSesion(Password));
        }

        public ResultadoOperacion IniciarSesion(string? passwordOverride = null)
        {
            string clave = string.IsNullOrEmpty(passwordOverride) ? Password : passwordOverride;
            return _autenticacionServicio.IniciarSesion(Correo, clave);
        }
    }
}
