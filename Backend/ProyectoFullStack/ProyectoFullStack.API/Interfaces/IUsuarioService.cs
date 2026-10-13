
using ProyectoFullStack.API.DTOs;

namespace ProyectoFullStack.API.Interfaces
{
    public interface IUsuarioService
    {
        (UsuarioResponseDto? Usuario, bool EmailExiste) CrearUsuario(
            UsuarioCreateDto usuarioDto
        );

        LoginResponseDto? Login(UsuarioLoginDto usuarioDto);
    }
}

