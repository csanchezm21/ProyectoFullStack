using System.ComponentModel.DataAnnotations;

namespace ProyectoFullStack.API.DTOs
{
    public class UsuarioCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El emanil no tiene un formato valido. ")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria. ")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener minimo 6 caracteres.")]
        public string Password { get; set; } = string.Empty;
    }
}
