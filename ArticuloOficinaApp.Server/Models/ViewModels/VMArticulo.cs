namespace ArticuloOficinaApp.Server.Models.ViewModels
{
    public class VMArticulo
    {
        public int IdArticulos { get; set; }

        public string? Codigo { get; set; }

        public string? Descripcion { get; set; }

        public double? Precio { get; set; }

        public string? Imagen { get; set; }

        public int? Stock { get; set; }
    }
}
