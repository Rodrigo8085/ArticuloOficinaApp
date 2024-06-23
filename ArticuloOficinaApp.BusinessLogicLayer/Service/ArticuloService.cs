using ArticuloOfficinaApp.DataAccessLayer.Repository;
using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOficinaApp.BusinessLogicLayer.Service
{
    public class ArticuloService : IArticulosService
    {
        private readonly IGenericRepository<Articulos> _articuloRepo;
        public ArticuloService(IGenericRepository<Articulos> articuloRepo)
        {
            _articuloRepo = articuloRepo;
        }
        public async Task<bool> Actualizar(Articulos modelo)
        {
            return await _articuloRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _articuloRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Articulos modelo)
        {
            return await _articuloRepo.Insertar(modelo);
        }

        public async Task<Articulos> Obtener(int id)
        {
            return await _articuloRepo.Obtener(id);
        }

        public async Task<IQueryable<Articulos>> ObtenerTodos()
        {
            return await _articuloRepo.ObtenerTodos();
        }
    }
}
