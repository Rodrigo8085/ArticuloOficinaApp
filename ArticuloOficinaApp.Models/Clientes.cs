using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticuloOficinaApp.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [Column("idClientes")]
        public int IdClientes { get; set; }

        [Column("nombre")]
        public required string Nombre { get; set; }

        [Column("apellidos")]
        public required string Apellidos { get; set; }

        [Column("direccion")]
        public required string Direccion { get; set; }

        public virtual ICollection<Login> Login { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }


    }
}
