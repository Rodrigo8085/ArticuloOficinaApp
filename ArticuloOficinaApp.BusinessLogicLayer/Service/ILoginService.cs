using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloOficinaApp.Models;

namespace ArticuloOficinaApp.BusinessLogicLayer.Service
{
    public interface ILoginService
    {
        Task<bool> Insertar(Login modelo);

        Task<bool> Actualizar(Login modelo);

        Task<bool> Eliminar(int id);

        Task<Login> Obtener(int id);

        Task<Login> validarSesion(string mail, string password);
    }
}
