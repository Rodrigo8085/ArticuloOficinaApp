using System.ComponentModel.DataAnnotations;

namespace ArticuloOficinaApp.Models
{
    public class Articulos
    {
        [Key]
        public int IdArticulos { get; set; }

        public required string Codigo { get; set; }

        public string? Descripcion { get; set; }

        public required double Precio { get; set; }

        public string? Imagen { get; set; }

        public required int Stock { get; set; }
    }
}
