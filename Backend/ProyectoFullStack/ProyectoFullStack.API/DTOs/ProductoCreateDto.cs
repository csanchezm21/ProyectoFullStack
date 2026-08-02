namespace ProyectoFullStack.API.DTOs
{
    public class ProductoCreateDto
    {
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock {  get; set; }
    }
}
