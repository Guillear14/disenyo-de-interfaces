using System;
using System.Text.RegularExpressions;
using proyectoDefinitivo.Datos.Repositorios;
using proyectoDefinitivo.Modelos;
using proyectoDefinitivo.Servicios.Interfaces;

namespace proyectoDefinitivo.Servicios
{
    public class AutenticacionServicio : IAutenticacionServicio
    {
        private static readonly Regex EmailRegex = new(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public Usuario? UsuarioActual { get; private set; }

        public AutenticacionServicio(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public ResultadoOperacion IniciarSesion(string correo, string password)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(password))
            {
                return new ResultadoOperacion(false, "Campos obligatorios", "Por favor, ingrese su correo electrónico y contraseña.");
            }

            if (!EsCorreoValido(correo))
            {
                return new ResultadoOperacion(false, "Formato inválido", "El correo electrónico introducido no tiene un formato válido (ejemplo: usuario@dominio.com).");
            }

            Usuario? usuario = _usuarioRepositorio.ObtenerPorCorreo(correo);
            if (usuario == null || usuario.Password != password)
            {
                return new ResultadoOperacion(false, "Credenciales incorrectas", "El correo o la contraseña no son correctos. (Usuario de prueba: admin@degradapp.com / 1234)");
            }

            UsuarioActual = usuario;
            return new ResultadoOperacion(true, "Bienvenido", $"Sesión iniciada correctamente como {usuario.Correo}.");
        }

        public ResultadoOperacion RegistrarUsuario(string correo, string password, string repetirPassword)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repetirPassword))
            {
                return new ResultadoOperacion(false, "Campos incompletos", "Todos los campos son obligatorios para completar el registro.");
            }

            if (!EsCorreoValido(correo))
            {
                return new ResultadoOperacion(false, "Correo inválido", "Introduce una dirección de correo electrónico válida (ejemplo: nombre@correo.com).");
            }

            if (password.Length < 4)
            {
                return new ResultadoOperacion(false, "Contraseña demasiado corta", "La contraseña debe tener al menos 4 caracteres.");
            }

            if (password != repetirPassword)
            {
                return new ResultadoOperacion(false, "Las contraseñas no coinciden", "La contraseña y su confirmación deben ser idénticas.");
            }

            if (_usuarioRepositorio.ExisteCorreo(correo))
            {
                return new ResultadoOperacion(false, "Usuario ya registrado", "Ya existe una cuenta asociada a ese correo electrónico.");
            }

            _usuarioRepositorio.GuardarUsuario(new Usuario
            {
                Correo = correo.Trim(),
                Password = password,
                FechaRegistro = DateTime.Now
            });

            return new ResultadoOperacion(true, "Registro completado", "Tu cuenta ha sido creada y guardada correctamente. Ahora puedes iniciar sesión.");
        }

        public ResultadoOperacion SolicitarRecuperacionClave(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                return new ResultadoOperacion(false, "Campo obligatorio", "Por favor, introduce tu dirección de correo electrónico.");
            }

            if (!EsCorreoValido(correo))
            {
                return new ResultadoOperacion(false, "Correo inválido", "El formato del correo electrónico no es válido.");
            }

            if (!_usuarioRepositorio.ExisteCorreo(correo))
            {
                return new ResultadoOperacion(false, "Correo no encontrado", "No existe ninguna cuenta registrada con ese correo electrónico.");
            }

            return new ResultadoOperacion(true, "Enlace enviado", $"Se han enviado las instrucciones de recuperación a {correo.Trim()}.");
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        private static bool EsCorreoValido(string correo) => EmailRegex.IsMatch(correo.Trim());
    }
}
