using System.Windows.Input;
using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class RegistroViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;
        private string _correo = string.Empty;
        private string _password = string.Empty;
        private string _confirmarPassword = string.Empty;

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

        public string ConfirmarPassword
        {
            get => _confirmarPassword;
            set => SetProperty(ref _confirmarPassword, value);
        }

        public ICommand RegistrarCommand { get; }

        public RegistroViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
            RegistrarCommand = new RelayCommand(_ => Registrar(Password, ConfirmarPassword));
        }

        public ResultadoOperacion Registrar(string? passwordOverride = null, string? confirmarOverride = null)
        {
            string p1 = string.IsNullOrEmpty(passwordOverride) ? Password : passwordOverride;
            string p2 = string.IsNullOrEmpty(confirmarOverride) ? ConfirmarPassword : confirmarOverride;
            return _autenticacionServicio.RegistrarUsuario(Correo, p1, p2);
        }
    }
}
