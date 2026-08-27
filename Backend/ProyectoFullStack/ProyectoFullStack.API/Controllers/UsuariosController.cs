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
    }
}
