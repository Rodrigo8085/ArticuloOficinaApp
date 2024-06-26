using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public class TiendaRepository : IGenericRepository<Tienda>
    {
        private readonly AppDbContext _appDbContext;
        public TiendaRepository(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<bool> Actualizar(Tienda modelo)
        {
            _appDbContext.Tiendas.Update(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Tienda modelo = _appDbContext.Tiendas.First(c => c.IdTienda == id);
            _appDbContext.Tiendas.Remove(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Tienda modelo)
        {
            _appDbContext.Tiendas.Add(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<Tienda> Obtener(int id)
        {
            return Obtener(id, _appDbContext);
        }

        public async Task<Tienda> Obtener(int id, AppDbContext _appDbContext)
        {
            return await _appDbContext.Tiendas.FindAsync(id);

        }

        public async Task<IQueryable<Tienda>> ObtenerTodos()
        {
            IQueryable<Tienda> queryTiendaSQL = _appDbContext.Tiendas;
            return queryTiendaSQL.AsQueryable();
        }
    }
}
