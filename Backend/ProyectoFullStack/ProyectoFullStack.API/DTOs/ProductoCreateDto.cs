using System.ComponentModel.DataAnnotations;

namespace ProyectoFullStack.API.DTOs
{
    public class ProductoCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage ="el nombre no puede superar los 100 caracteres. ")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 100000000, ErrorMessage = "El precio debe ser mayor a cero")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio.")]
        [Range(0.01, 100000000, ErrorMessage = "El stock no puede ser negativo.")]
        public int Stock {  get; set; }
    }
}
