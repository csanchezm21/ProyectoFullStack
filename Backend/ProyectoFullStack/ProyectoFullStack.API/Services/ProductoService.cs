using Microsoft.EntityFrameworkCore;
using ProyectoFullStack.API.Data;
using ProyectoFullStack.API.Interfaces;
using ProyectoFullStack.API.Models;

namespace ProyectoFullStack.API.Services
{
    public class ProductoService : IProductoService
    {
        private readonly ProyectoFullStack.API.Data.ApplicationDbContext _context;
        public ProductoService(ProyectoFullStack.API.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Producto> ObtenerProductos()
        {
           return _context.Productos.ToList();
        }
        public Producto CrearProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return producto;
        }
        public Producto? ObtenerProductoPorId(int id)
        {
            return _context.Productos.FirstOrDefault(p => p.Id == id);

        }
    }
}
