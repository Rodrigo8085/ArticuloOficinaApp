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
        private readonly ILoginRepository<Login> _loginRepo;
        public LoginService(ILoginRepository<Login> clienteRepo)
        {
            _loginRepo = clienteRepo;
        }
        public async Task<bool> Actualizar(Login modelo)
        {
            return await _loginRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _loginRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Login modelo)
        {
            return await _loginRepo.Insertar(modelo);
        }

        public async Task<Login> Obtener(int id)
        {
            return await _loginRepo.Obtener(id);
        }

        public async Task<Login> validarSesion(string email, string password)
        {
            return await _loginRepo.buscarPorEmailPass(email, password);
        }
    }
}
