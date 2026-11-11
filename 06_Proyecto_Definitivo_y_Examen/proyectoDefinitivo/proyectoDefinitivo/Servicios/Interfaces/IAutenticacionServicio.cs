using proyectoDefinitivo.Modelos;

namespace proyectoDefinitivo.Servicios.Interfaces
{
    public record ResultadoOperacion(bool Exito, string Titulo, string Mensaje);

    public interface IAutenticacionServicio
    {
        Usuario? UsuarioActual { get; }
        ResultadoOperacion IniciarSesion(string correo, string password);
        ResultadoOperacion RegistrarUsuario(string correo, string password, string repetirPassword);
        ResultadoOperacion SolicitarRecuperacionClave(string correo);
        void CerrarSesion();
    }
}
