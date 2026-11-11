using System.Windows.Input;
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

        public ICommand RecuperarClaveCommand { get; }

        public RecuperarClaveViewModel(IAutenticacionServicio autenticacionServicio)
        {
            _autenticacionServicio = autenticacionServicio;
            RecuperarClaveCommand = new RelayCommand(_ => SolicitarRecuperacion());
        }

        public ResultadoOperacion SolicitarRecuperacion()
        {
            return _autenticacionServicio.SolicitarRecuperacionClave(Correo);
        }
    }
}
