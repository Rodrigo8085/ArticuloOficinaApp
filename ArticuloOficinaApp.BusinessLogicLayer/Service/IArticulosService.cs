using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloOficinaApp.Models;

namespace ArticuloOficinaApp.BusinessLogicLayer.Service
{
    public interface IArticulosService
    {
        Task<bool> Insertar(Articulos modelo);

        Task<bool> Actualizar(Articulos modelo);

        Task<bool> Eliminar(int id);

        Task<Articulos> Obtener(int id);

        Task<IQueryable<Articulos>> ObtenerTodos();
    }
}
