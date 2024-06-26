using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public class LoginRepository : ILoginRepository<Login>
    {
        private readonly AppDbContext _appDbContext;
        public LoginRepository(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<bool> Actualizar(Login modelo)
        {
            _appDbContext.Logins.Update(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Login modelo = _appDbContext.Logins.First(c => c.IdLogin == id);
            _appDbContext.Logins.Remove(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Login modelo)
        {
            _appDbContext.Logins.Add(modelo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public Task<Login> Obtener(int id)
        {
            return Obtener(id, _appDbContext);
        }

        public async Task<Login> Obtener(int id, AppDbContext _appDbContext)
        {
            return await _appDbContext.Logins.Include(i => i.Cliente).Where(r => r.IdLogin == id).FirstAsync();

        }

        public async Task<IQueryable<Login>> ObtenerTodos()
        {
            IQueryable<Login> querySQL = _appDbContext.Logins;
            return querySQL.AsQueryable();
        }

        public async Task<Login> buscarPorEmailPass(string mail, string pass)
        {
            return await _appDbContext.Logins.Include(i => i.Cliente).Where(r => r.Email == mail && r.Password == pass).FirstAsync();
        }
    }
}
