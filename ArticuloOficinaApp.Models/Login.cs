using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArticuloOficinaApp.Models
{
    public class Login
    {
        [Key]
        public int IdLogin { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }


        //public virtual Conductor Conductor { get; set; }

        //[Key, ForeignKey("Cliente")]
        //public int ClienteId { get; set; }

        //public virtual required Cliente Cliente { get; set; }


        //public required Cliente Cliente { get; set; }
        //[Key]
        ////[Column(Order = 1)]
        //public int IdClientes { get; set; }

        //[ForeignKey("IdClientes")]
        //public required Cliente Cliente { get; set; }


        [ForeignKey("Cliente")]
        public int IdClientes { get; set; }

        public virtual required Cliente Cliente { get; set; }
    }
}
