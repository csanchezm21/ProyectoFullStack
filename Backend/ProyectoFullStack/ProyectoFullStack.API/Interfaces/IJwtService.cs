using ProyectoFullStack.API.Models;

namespace ProyectoFullStack.API.Interfaces
{
    public interface IJwtService
    {
        string GenerarToken(Usuario usuario);
    }
}