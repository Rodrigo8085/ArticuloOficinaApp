using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticuloOficinaApp.Models
{
    [Table("articulos")]
    public class Articulos
    {
        [Key]
        [Column("idArticulo")]
        public int IdArticulos { get; set; }

        [Column("codigo", TypeName = "varchar")]
        public required string Codigo { get; set; }

        [Column("descripcion", TypeName = "varchar")]
        public string? Descripcion { get; set; }

        [Column("precio")]
        public required double Precio { get; set; }

        [Column("imagen", TypeName = "varchar")]
        public string? Imagen { get; set; }

        [Column("stock")]
        public required int Stock { get; set; }

        public virtual ICollection<Tienda_Articulos> Tienda_Articulos { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }


    }
}