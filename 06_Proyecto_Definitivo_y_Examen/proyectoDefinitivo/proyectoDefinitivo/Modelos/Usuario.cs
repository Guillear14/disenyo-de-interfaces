using System;

namespace proyectoDefinitivo.Modelos
{
    public class Usuario
    {
        public string Correo { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
