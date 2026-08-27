using Microsoft.AspNetCore.Mvc;
using ProyectoFullStack.API.DTOs;
using ProyectoFullStack.API.Interfaces;

namespace ProyectoFullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult CrearUsuario([FromBody] UsuarioCreateDto usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var nuevoUsuario = _usuarioService.CrearUsuario(usuarioDto);

            return Ok(nuevoUsuario);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioLoginDto usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = _usuarioService.Login(usuarioDto);

            if (usuario == null)
            {
                return Unauthorized(new
                {
                    Success = false,
                    Message = "Email o contraseña incorrectos.",
                    Data = (object?)null
                });
            }

            return Ok(new
            {
                Success = true,
                Message = "Inicio de sesión correcto.",
                Data = usuario
            });
        }
    }
}