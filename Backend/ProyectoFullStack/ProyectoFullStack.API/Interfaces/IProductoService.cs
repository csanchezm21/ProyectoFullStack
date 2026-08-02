using ProyectoFullStack.API.Models;
using ProyectoFullStack.API.DTOs;
namespace ProyectoFullStack.API.Interfaces
{
    public interface IProductoService
    {
        IEnumerable<ProductoResponseDto> ObtenerProductos();
        
        ProductoResponseDto? ObtenerProductoPorId(int id);
        ProductoResponseDto CrearProducto(ProductoCreateDto productoDto);

        void ActualizarProducto(int id, ProductoUpdateDto productoDto);
        void EliminarProducto(int id);
        
        
    }
}
