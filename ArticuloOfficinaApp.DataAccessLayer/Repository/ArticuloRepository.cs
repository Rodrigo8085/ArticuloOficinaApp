using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;



namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public class ArticuloRepository : IGenericRepository<Articulos>
    {
        private readonly AppDbContext _appDbContext;
        public ArticuloRepository(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<bool> Actualizar(Articulos modelo)
        {
            _appDbContext.Articulos.Update(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Articulos modelo = _appDbContext.Articulos.First(c => c.IdArticulos == id);
            _appDbContext.Articulos.Remove(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
            //throw new NotImplementedException();
        }

        public async Task<bool> Insertar(Articulos modelo)
        {
            _appDbContext.Articulos.Add(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<Articulos> Obtener(int id)
        {
            return Obtener(id, _appDbContext);
        }

        public async Task<Articulos> Obtener(int id, AppDbContext _appDbContext)
        {
            return await _appDbContext.Articulos.FindAsync(id);

        }

        public async Task<IQueryable<Articulos>> ObtenerTodos()
        {
            IQueryable<Articulos> queryArticulosSQL = _appDbContext.Articulos;
            return queryArticulosSQL.AsQueryable();
        }
    }
}
