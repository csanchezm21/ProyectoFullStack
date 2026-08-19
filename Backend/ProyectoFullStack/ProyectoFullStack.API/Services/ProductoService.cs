using Microsoft.EntityFrameworkCore;
using ProyectoFullStack.API.Data;
using ProyectoFullStack.API.DTOs;
using ProyectoFullStack.API.Interfaces;
using ProyectoFullStack.API.Models;
using AutoMapper;


namespace ProyectoFullStack.API.Services
{
    public class ProductoService : IProductoService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductoService> _logger;
        public ProductoService(ApplicationDbContext context, IMapper mapper, ILogger<ProductoService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public IEnumerable<ProductoResponseDto> ObtenerProductos()
        {
            _logger.LogInformation("Consultando todos los productos.");

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
            var producto = _mapper.Map<Producto>(productoDto);

            _context.Productos.Add(producto);   
            _context.SaveChanges();

            _logger.LogInformation("Producto creado correctamente. ID: {Id}, Nombre: {Nombre}.",
                producto.Id,
                producto.Nombre);

            return _mapper.Map<ProductoResponseDto>(producto);
        }
        public ProductoResponseDto? ObtenerProductoPorId(int id)
        {
            var producto = _context.Productos.Find(id);

            if (producto == null)
            {
                _logger.LogWarning(
                    "No se encontró el producto con ID {Id}", id);

                return null;
            }

            return _mapper.Map<ProductoResponseDto>(producto);

        }
        public void ActualizarProducto(int id, ProductoUpdateDto productoDto)
        {
            var productoExistente = _context.Productos.Find(id);
            if (productoExistente == null)

            {
                _logger.LogWarning("No se pudo actualizar el producto con ID {Id} porque no existe.",
                    id);
                return;
            }
            _mapper.Map(productoDto, productoExistente);

            _context.SaveChanges();
            _logger.LogInformation(    "Producto actualizado correctamente. ID: {Id}.",
    id);
        }
        public void EliminarProducto (int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
            {
                return;
            }
            
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }
}
