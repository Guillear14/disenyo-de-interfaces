using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using proyectoDefinitivo.Modelos;

namespace proyectoDefinitivo.Datos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly string _rutaArchivo;
        private readonly List<Usuario> _usuarios;

        public UsuarioRepositorio()
        {
            _rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.json");
            _usuarios = CargarDesdeDisco();

            // Usuario por defecto para poder iniciar sesión directamente en pruebas/examen
            if (_usuarios.Count == 0)
            {
                _usuarios.Add(new Usuario
                {
                    Correo = "admin@degradapp.com",
                    Password = "1234",
                    FechaRegistro = DateTime.Now
                });
                PersistirEnDisco();
            }
        }

        public IReadOnlyList<Usuario> ObtenerTodos() => _usuarios.AsReadOnly();

        public Usuario? ObtenerPorCorreo(string correo)
        {
            return _usuarios.FirstOrDefault(u =>
                string.Equals(u.Correo, correo.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public bool ExisteCorreo(string correo) => ObtenerPorCorreo(correo) != null;

        public void GuardarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
            PersistirEnDisco();
        }

        private List<Usuario> CargarDesdeDisco()
        {
            try
            {
                if (!File.Exists(_rutaArchivo))
                    return new List<Usuario>();

                string json = File.ReadAllText(_rutaArchivo);
                return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
            }
            catch
            {
                return new List<Usuario>();
            }
        }

        private void PersistirEnDisco()
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(_usuarios, opciones);
            File.WriteAllText(_rutaArchivo, json);
        }
    }
}
