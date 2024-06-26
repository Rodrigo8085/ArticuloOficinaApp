using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArticuloOficinaApp.Models
{
    [Table("login")]
    public class Login
    {
        [Key]
        [Column("idLogin")]
        public int IdLogin { get; set; }

        [Column("eMail")]
        public required string Email { get; set; }

        [Column("password")]
        public required string Password { get; set; }


        [Column("idClientes")]
        [ForeignKey("Cliente")]
        public int IdClientes { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
