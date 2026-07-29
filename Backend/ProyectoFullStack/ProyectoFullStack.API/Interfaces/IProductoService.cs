using ProyectoFullStack.API.Models;

namespace ProyectoFullStack.API.Interfaces
{
    public interface IProductoService
    {
        List<Producto> ObtenerProductos();
        
        Producto? ObtenerProductoPorId(int id);
        Producto CrearProducto(Producto producto);

        void ActualizarProducto(int id, Producto producto);    
    }
}
