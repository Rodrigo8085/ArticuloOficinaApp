using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOficinaApp.BusinessLogicLayer.Service
{
    public interface IVentaService
    {
        Task<bool> Insertar(Venta modelo);

        Task<bool> Actualizar(Venta modelo);

        Task<bool> Eliminar(int id);

        Task<Venta> Obtener(int id);

        Task<IQueryable<Venta>> ObtenerTodos();

    }
}
