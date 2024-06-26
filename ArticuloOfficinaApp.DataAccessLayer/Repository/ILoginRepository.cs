using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public interface ILoginRepository<TEntityModel> where TEntityModel : class
    {
        Task<bool> Insertar(TEntityModel modelo);

        Task<bool> Actualizar(TEntityModel modelo);

        Task<bool> Eliminar(int id);

        Task<TEntityModel> Obtener(int id);

        Task<IQueryable<TEntityModel>> ObtenerTodos();
        Task<Login> buscarPorEmailPass(string email, string password);
    }
}
