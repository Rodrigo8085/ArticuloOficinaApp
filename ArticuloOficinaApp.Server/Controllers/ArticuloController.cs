using ArticuloOficinaApp.Server.Models.ViewModels;
using ArticuloOficinaApp.Models;
using Microsoft.AspNetCore.Mvc;
using ArticuloOficinaApp.BusinessLogicLayer.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArticuloOficinaApp.Server.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<IActionResult> Lista()
        {
            IQueryable<Articulos> queryArticulosSql = await _articuloService.ObtenerTodos();
            List<VMArticulo> lista = queryArticulosSql.Select(a => new VMArticulo() {
                IdArticulos = a.IdArticulos,
                Codigo = a.Codigo,
            }).ToList();

            return StatusCode(StatusCodes.Status200OK, lista);
        }

        // GET api/<ArticuloController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticuloController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticuloController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticuloController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
