using ArticuloOficinaApp.BusinessLogicLayer.Service;
using ArticuloOficinaApp.Models;
using ArticuloOficinaApp.Server.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ArticuloOficinaApp.Server.Controllers
{
    [Route("api/venta")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaService _ventaService;
        public VentaController(IVentaService ventaService)
        {
            _ventaService = ventaService;
        }

        // GET: api/<ArticuloController>
        [HttpPost]
        [Route("comprar")]
        public async Task<IActionResult> AgregarVenta([FromBody]VMVenta dataAdd)
        {
            DateTime localDate = DateTime.Now;
            Venta nuevoVenta = new Venta()
            {
                Cantidad = dataAdd.Cantidad,
                Fecha = localDate,
                IdArticulo = dataAdd.idArticulo,
                IdCliente = dataAdd.idCliente
            };
            bool respuesta = await _ventaService.Insertar(nuevoVenta);
            return StatusCode(StatusCodes.Status200OK, respuesta);
        }
    }
}
