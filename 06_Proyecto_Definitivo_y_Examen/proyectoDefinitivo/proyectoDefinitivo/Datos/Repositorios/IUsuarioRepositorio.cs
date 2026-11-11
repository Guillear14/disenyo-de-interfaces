using System.Collections.Generic;
using proyectoDefinitivo.Modelos;

namespace proyectoDefinitivo.Datos.Repositorios
{
    public interface IUsuarioRepositorio
    {
        IReadOnlyList<Usuario> ObtenerTodos();
        Usuario? ObtenerPorCorreo(string correo);
        bool ExisteCorreo(string correo);
        void GuardarUsuario(Usuario usuario);
    }
}
