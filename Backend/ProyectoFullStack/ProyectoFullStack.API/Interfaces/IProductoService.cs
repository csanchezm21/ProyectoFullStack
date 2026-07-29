using ProyectoFullStack.API.Models;

namespace ProyectoFullStack.API.Interfaces
{
    public interface IProductoService
    {
        List<Producto> ObtenerProductos();
        Producto CrearProducto(Producto producto);
    }
}
