using ArticuloOficinaApp.Models;
using Microsoft.EntityFrameworkCore;


namespace ArticuloOficinaApp.DataAccessLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Articulos> Articulos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }


        public DbSet<Login> Logins { get; set; }


        public DbSet<Tienda> Tiendas { get; set; }


        public DbSet<Tienda_Articulos> Tienda_Articulos { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=localhost.\\SQLEXPRESS;Database=ArticuloOficina;Trusted_Connection=True;TrustServerCertificate=True",
        //        x => x.MigrationsAssembly("ArticuloOficinaApp.DataAccessLayer"));
        //}
 
    }
}
