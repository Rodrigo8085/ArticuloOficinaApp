using System.ComponentModel.DataAnnotations;

namespace ArticuloOficinaApp.Models
{
    public class Tienda
    {
        [Key]
        public int IdTienda{ get; set; }

        public required string Sucursal { get; set; }

        public required string Direccion { get; set; }
    }
}
