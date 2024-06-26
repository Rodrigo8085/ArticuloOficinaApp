using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticuloOficinaApp.Models
{
    [Table("tiendaArticulos")]
    public class Tienda_Articulos
    {
        [Key]
        [Column("idTiendaArticulos")]
        public int IdTiendaArticulos{ get; set; }

        [Column("fecha")]
        public required DateTime Fecha { get; set; }

        [Column("idArticulos")]
        [ForeignKey("Articulos")]
        public int IdArticulos { get; set; }

        public virtual Articulos Articulos { get; set; }

        [Column("idTienda")]
        [ForeignKey("Tienda")]
        public int IdTienda { get; set; }

        public virtual Tienda Tienda { get; set; }
    }
}
