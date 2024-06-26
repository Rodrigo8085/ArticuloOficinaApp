using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticuloOficinaApp.Models
{
    [Table("tienda")]
    public class Tienda
    {
        [Key]
        [Column("idTienda")]
        public int IdTienda{ get; set; }

        [Column("sucursal")]
        public required string Sucursal { get; set; }

        [Column("direccion")]
        public required string Direccion { get; set; }

        public virtual ICollection<Tienda_Articulos> Tienda_Articulos { get; set; }

    }
}
