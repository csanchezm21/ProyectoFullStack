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
        public ProductoService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            var producto = _mapper.Map<Producto>(productoDto);

            _context.Productos.Add(producto);   
            _context.SaveChanges();

            return _mapper.Map<ProductoResponseDto>(producto);
        }
        public ProductoResponseDto? ObtenerProductoPorId(int id)
        {
            var producto = _context.Productos.Find(id);

            if (producto == null)
            {
                return null;
            }

            return _mapper.Map<ProductoResponseDto>(producto);

        }
        public void ActualizarProducto(int id, ProductoUpdateDto productoDto)
        {
            var productoExistente = _context.Productos.Find(id);
            if (productoExistente == null)

            {
                return;
            }
            _mapper.Map(productoDto, productoExistente);

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
