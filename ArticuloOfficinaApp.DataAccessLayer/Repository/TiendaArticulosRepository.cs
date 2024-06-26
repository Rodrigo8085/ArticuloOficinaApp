using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public class TiendaArticulosRepository : IGenericRepository<Tienda_Articulos>
    {
        private readonly AppDbContext _appDbContext;
        public TiendaArticulosRepository(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<bool> Actualizar(Tienda_Articulos modelo)
        {
            _appDbContext.Tienda_Articulos.Update(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Tienda_Articulos modelo = _appDbContext.Tienda_Articulos.First(c => c.IdTiendaArticulos == id);
            _appDbContext.Tienda_Articulos.Remove(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Tienda_Articulos modelo)
        {
            _appDbContext.Tienda_Articulos.Add(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<Tienda_Articulos> Obtener(int id)
        {
            return Obtener(id, _appDbContext);
        }

        public async Task<Tienda_Articulos> Obtener(int id, AppDbContext _appDbContext)
        {
            return await _appDbContext.Tienda_Articulos.FindAsync(id);

        }

        public async Task<IQueryable<Tienda_Articulos>> ObtenerTodos()
        {
            IQueryable<Tienda_Articulos> querySQL = _appDbContext.Tienda_Articulos;
            return querySQL.AsQueryable();
        }
    }
}
