namespace ProyectoFullStack.API.DTOs
{
    public class ProductoUpdateDto
    {
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
