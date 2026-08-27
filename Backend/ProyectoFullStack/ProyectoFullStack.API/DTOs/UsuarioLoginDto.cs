using System.ComponentModel.DataAnnotations;

namespace ProyectoFullStack.API.DTOs
{
    public class UsuarioLoginDto
    {
        [Required(ErrorMessage ="El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no tiene formato valido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Password { get; set; } = string.Empty;
    }
}
