using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using proyectoDefinitivo.Datos.Repositorios;
using proyectoDefinitivo.Modelos;
using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IAutenticacionServicio _autenticacionServicio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ObservableCollection<Usuario> UsuariosRegistrados { get; } = new();

        public string CorreoUsuarioActual =>
            _autenticacionServicio.UsuarioActual?.Correo ?? "admin@degradapp.com";

        public int TotalUsuarios => UsuariosRegistrados.Count;

        public string FechaSesionActual => DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        public ICommand CerrarSesionCommand { get; }

        public event Action? SesionCerrada;

        public MainViewModel(
            IAutenticacionServicio autenticacionServicio,
            IUsuarioRepositorio usuarioRepositorio)
        {
            _autenticacionServicio = autenticacionServicio;
            _usuarioRepositorio = usuarioRepositorio;

            CargarUsuarios();
            CerrarSesionCommand = new RelayCommand(_ => EjecutarCerrarSesion());
        }

        private void CargarUsuarios()
        {
            UsuariosRegistrados.Clear();
            foreach (Usuario u in _usuarioRepositorio.ObtenerTodos())
            {
                UsuariosRegistrados.Add(u);
            }
            OnPropertyChanged(nameof(TotalUsuarios));
        }

        public void CerrarSesion()
        {
            EjecutarCerrarSesion();
        }

        private void EjecutarCerrarSesion()
        {
            _autenticacionServicio.CerrarSesion();
            SesionCerrada?.Invoke();
        }
    }
}
