using ArticuloOfficinaApp.DataAccessLayer.Repository;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOficinaApp.BusinessLogicLayer.Service
{
    public class LoginService : ILoginService
    {
        private readonly IGenericRepository<Login> _loginRepoG;

        private readonly ILoginRepository<Login> _loginRepo;

        public LoginService(IGenericRepository<Login> clienteRepoG)
        {
            _loginRepoG = clienteRepoG;
            _loginRepo = (ILoginRepository<Login>?)clienteRepoG;
        }
        public async Task<bool> Actualizar(Login modelo)
        {
            return await _loginRepoG.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _loginRepoG.Eliminar(id);
        }

        public async Task<bool> Insertar(Login modelo)
        {
            return await _loginRepoG.Insertar(modelo);
        }

        public async Task<Login> Obtener(int id)
        {
            return await _loginRepoG.Obtener(id);
        }

        public async Task<Login> validarSesion(string email, string password)
        {
            return await _loginRepo.buscarPorEmailPass(email, password);
        }
    }
}
