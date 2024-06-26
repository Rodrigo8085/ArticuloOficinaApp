using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public class VentaRepository : IGenericRepository<Venta>
    {
        private readonly AppDbContext _appDbContext;
        public VentaRepository(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<bool> Actualizar(Venta modelo)
        {
            _appDbContext.Ventas.Update(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Venta modelo = _appDbContext.Ventas.First(c => c.IdVenta == id);
            _appDbContext.Ventas.Remove(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Venta modelo)
        {
            _appDbContext.Ventas.Add(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<Venta> Obtener(int id)
        {
            return Obtener(id, _appDbContext);
        }

        public async Task<Venta> Obtener(int id, AppDbContext _appDbContext)
        {
            return await _appDbContext.Ventas.FindAsync(id);

        }

        public async Task<IQueryable<Venta>> ObtenerTodos()
        {
            IQueryable<Venta> querySQL = _appDbContext.Ventas;
            return querySQL.AsQueryable();
        }
    }
}
