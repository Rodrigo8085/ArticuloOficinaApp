using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticuloOficinaApp.Models
{
    [Table("venta")]
    public class Venta
    {
        [Key]
        [Column("idVenta")]
        public int IdVenta { get; set; }

        [Column("cantidad")]
        public required int Cantidad { get; set; }

        [Column("fecha")]
        public required DateTime Fecha { get; set; }

        [Column("idArticulo")]
        [ForeignKey("Articulos")]
        public int IdArticulo { get; set; }

        public virtual Articulos Articulos { get; set; }

        [Column("idCliente")]
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
