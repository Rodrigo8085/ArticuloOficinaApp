using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public class ClienteRepository : IGenericRepository<Cliente>
    {
        private readonly AppDbContext _appDbContext;
        public ClienteRepository(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<bool> Actualizar(Cliente modelo)
        {
            _appDbContext.Clientes.Update(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Cliente modelo = _appDbContext.Clientes.First(c => c.IdClientes == id);
            _appDbContext.Clientes.Remove(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Cliente modelo)
        {
            _appDbContext.Clientes.Add(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<Cliente> Obtener(int id)
        {
            return Obtener(id, _appDbContext);
        }

        public async Task<Cliente> Obtener(int id, AppDbContext _appDbContext)
        {
            return await _appDbContext.Clientes.FindAsync(id);

        }

        public async Task<IQueryable<Cliente>> ObtenerTodos()
        {
            IQueryable<Cliente> queryClienteSQL = _appDbContext.Clientes;
            return queryClienteSQL.AsQueryable();
        }
    }
}
