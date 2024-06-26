using ArticuloOfficinaApp.DataAccessLayer.Repository;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOficinaApp.BusinessLogicLayer.Service
{
    public class VentaService : IVentaService
    {
        private readonly IGenericRepository<Venta> _ventaRepo;
        public VentaService(IGenericRepository<Venta> ventaRepo)
        {
            _ventaRepo = ventaRepo;
        }
        public async Task<bool> Actualizar(Venta modelo)
        {
            return await _ventaRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _ventaRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Venta modelo)
        {
            return await _ventaRepo.Insertar(modelo);
        }

        public async Task<Venta> Obtener(int id)
        {
            return await _ventaRepo.Obtener(id);
        }

        public async Task<IQueryable<Venta>> ObtenerTodos()
        {
            return await _ventaRepo.ObtenerTodos();
        }
    }
}

