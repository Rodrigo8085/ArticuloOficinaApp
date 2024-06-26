using ArticuloOficinaApp.BusinessLogicLayer.Service;
using ArticuloOficinaApp.Models;
using ArticuloOficinaApp.Server.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ArticuloOficinaApp.Server.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("iniciar")]
        public async Task<IActionResult> ValidarLogin(string mail, string pass)
        {
            Login persona = await _loginService.validarSesion(mail, pass);
            return StatusCode(StatusCodes.Status200OK, persona);
        }
        }
    }
