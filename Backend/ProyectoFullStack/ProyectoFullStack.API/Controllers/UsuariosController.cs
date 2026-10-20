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
                return BadRequest(new ApiResponseDto<object>
                {
                    Success = false,
                    Message = "Los datos enviados no son válidos.",
                    Data = ModelState
                });
            }

            var resultado = _usuarioService.CrearUsuario(usuarioDto);

            if (resultado.EmailExiste)
            {
                return Conflict(new ApiResponseDto<object>
                {
                    Success = false,
                    Message = "Ya existe un usuario registrado con ese correo electrónico.",
                    Data = null
                });
            }

            return CreatedAtAction(
                nameof(CrearUsuario),
                new ApiResponseDto<UsuarioResponseDto>
                {
                    Success = true,
                    Message = "Usuario registrado correctamente.",
                    Data = resultado.Usuario
                }
            );
        }



        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioLoginDto usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponseDto<object>
                {
                    Success = false,
                    Message = "Los datos enviados no son válidos.",
                    Data = ModelState
                });
            }

            var usuario = _usuarioService.Login(usuarioDto);

            if (usuario == null)
            {
                return Unauthorized(new ApiResponseDto<object>
                {
                    Success = false,
                    Message = "Email o contraseña incorrectos.",
                    Data = null
                });
            }

            return Ok(new ApiResponseDto<LoginResponseDto>
            {
                Success = true,
                Message = "Inicio de sesión correcto.",
                Data = usuario
            });
        }

    }

}