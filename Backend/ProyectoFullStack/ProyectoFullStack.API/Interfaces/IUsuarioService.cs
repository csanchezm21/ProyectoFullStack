using ProyectoFullStack.API.DTOs;

namespace ProyectoFullStack.API.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioResponseDto CrearUsuario (UsuarioCreateDto usuarioDto);
    }
}
