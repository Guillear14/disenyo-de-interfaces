namespace PlantillaExamen.Modelos
{
    public class RegistroItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Fecha { get; set; } = string.Empty;
        public double Importe { get; set; }
        public bool Activo { get; set; } = true;
    }
}
