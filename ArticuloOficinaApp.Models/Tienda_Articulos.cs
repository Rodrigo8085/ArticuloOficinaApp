using System.ComponentModel.DataAnnotations;

namespace ArticuloOficinaApp.Models
{
    public class Tienda_Articulos
    {
        [Key]
        public int IdTiendaArticulos{ get; set; }

        public required DateTime Fecha { get; set; }
    }
}
