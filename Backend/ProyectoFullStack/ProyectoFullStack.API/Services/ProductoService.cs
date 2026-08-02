using Microsoft.EntityFrameworkCore;
using ProyectoFullStack.API.Data;
using ProyectoFullStack.API.DTOs;
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
        public IEnumerable<ProductoResponseDto> ObtenerProductos()
        {
            return _context.Productos.Select(p => new ProductoResponseDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio,
                Stock = p.Stock,
            })
                .ToList();
        }
        public ProductoResponseDto CrearProducto(ProductoCreateDto productoDto)
        {
            var producto = new Producto
            {
                Nombre = productoDto.Nombre,
                Precio = productoDto.Precio,
                Stock = productoDto.Stock,
            };
            _context.Productos.Add(producto);   
            _context.SaveChanges();

            return new ProductoResponseDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock,
            };
        }
        public ProductoResponseDto? ObtenerProductoPorId(int id)
        {
            var producto = _context.Productos.Find(id);

            if (producto == null)
            {
                return null;
            }

            return new ProductoResponseDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock,
            };

        }
        public void ActualizarProducto(int id, ProductoUpdateDto productoDto)
        {
            var productoExistente = _context.Productos.Find(id);
            if (productoExistente == null)

            {
                return;
            }
            productoExistente.Nombre = productoDto.Nombre;
            productoExistente.Precio = productoDto.Precio;
            productoExistente.Stock = productoDto.Stock;

            _context.SaveChanges();
        }
        public void EliminarProducto (int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
            {
                throw new Exception("Producto no encontrado.");
            }
            
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }
}
