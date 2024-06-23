using System.ComponentModel.DataAnnotations;

namespace ArticuloOficinaApp.Models
{
    public class Cliente
    {
        [Key]
        public int IdClientes { get; set; }

        public required string Nombre { get; set; }

        public required string Apellidos { get; set; }

        public required string Direccion { get; set; }

        //public virtual Login? Login { get; set; }

        public virtual required ICollection<Login> Login { get; set; }

    }
}
