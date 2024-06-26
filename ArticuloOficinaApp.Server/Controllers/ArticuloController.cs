using ArticuloOficinaApp.Server.Models.ViewModels;
using ArticuloOficinaApp.Models;
using Microsoft.AspNetCore.Mvc;
using ArticuloOficinaApp.BusinessLogicLayer.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArticuloOficinaApp.Server.Controllers
{
    [Route("api/articulos")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly IArticulosService _articuloService;
        public ArticuloController(IArticulosService articuloServ)
        {
            _articuloService = articuloServ;
        }

        // GET: api/<ArticuloController>
        [HttpGet]
        [Route("obtenerTodos")]
        public async Task<IActionResult> Lista()
        {
            IQueryable<Articulos> queryArticulosSql = await _articuloService.ObtenerTodos();
            List<VMArticulo> lista = queryArticulosSql.Select(a => new VMArticulo() {
                IdArticulos = a.IdArticulos,
                Codigo = a.Codigo,
                Descripcion = a.Descripcion,
                Precio = a.Precio,
                Imagen = a.Imagen,
                Stock = a.Stock
            }).ToList();

            return StatusCode(StatusCodes.Status200OK, lista);
        }

        [HttpPost]
        [Route("ver")]
        public async Task<IActionResult> Ver(int id)
        {
 
            Articulos respuesta = await _articuloService.Obtener(id);
            return StatusCode(StatusCodes.Status200OK, new
            {
                value = respuesta
            });
        }

        [HttpPost]
        [Route("agregar")]
        public async Task<IActionResult> Agregar([FromBody]VMArticulo modelo)
        {
            Articulos nuevoArticulo = new Articulos()
            {
                Descripcion = modelo.Descripcion,
                Codigo = modelo.Codigo,
                Precio = (double)modelo.Precio,
                Imagen = modelo.Imagen,
                Stock = (int)modelo.Stock
            };
            bool respuesta = await _articuloService.Insertar(nuevoArticulo);
            return StatusCode(StatusCodes.Status200OK, new
            {
                value = respuesta
            });
        }

        [HttpPut]
        [Route("actualizar")]
        public async Task<IActionResult> Actualizar([FromBody] VMArticulo modelo)
        {
            Articulos nuevoArticulo = new Articulos()
            {
                Descripcion = modelo.Descripcion,
                Codigo = modelo.Codigo,
                Precio = (double)modelo.Precio,
                Imagen = modelo.Imagen,
                Stock = (int)modelo.Stock
            };
            bool respuesta = await _articuloService.Actualizar(nuevoArticulo);
            return StatusCode(StatusCodes.Status200OK, new
            {
                value = respuesta
            });
        }

        [HttpDelete]
        [Route("borrar")]
        public async Task<IActionResult> Borrar(int id)
        {
 
            bool respuesta = await _articuloService.Eliminar(id);
            return StatusCode(StatusCodes.Status200OK, new
            {
                value = respuesta
            });
        }
    }
}
