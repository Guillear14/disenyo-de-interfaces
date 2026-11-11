using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class RecuperarClaveViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;
        private string _correo = string.Empty;

        public string Correo
        {
            get => _correo;
            set => SetProperty(ref _correo, value);
        }

        public RecuperarClaveViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
        }

        public ResultadoOperacion SolicitarRecuperacion()
        {
            return _autenticacionServicio.SolicitarRecuperacionClave(Correo);
        }
    }
}
