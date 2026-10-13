using System.ComponentModel.DataAnnotations;

namespace ProyectoFullStack.API.DTOs
{
    public class UsuarioCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
        [StringLength(150, ErrorMessage = "El correo no puede superar los 150 caracteres.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener mínimo 6 caracteres.")]
        public string Password { get; set; } = string.Empty;

    }
}
