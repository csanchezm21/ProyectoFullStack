using ProyectoFullStack.API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFullStack.API.Models;
using ProyectoFullStack.API.Interfaces;
using ProyectoFullStack.API.Services;

namespace ProyectoFullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;
        private readonly ILogger<ProductosController> _logger;

        public ProductosController(IProductoService productoService, ILogger <ProductosController> logger)
        {
            _productoService = productoService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            _logger.LogInformation("Se solicitó la lista de productos.");
            var productos = _productoService.ObtenerProductos();
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult CrearProducto([FromBody] ProductoCreateDto productoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var nuevoProducto = _productoService.CrearProducto(productoDto);

            return CreatedAtAction(
                nameof(ObtenerProductoPorId),
                new
                {
                    id = nuevoProducto.Id
                },
                nuevoProducto);
        }
        [HttpGet("{id}")]
        public IActionResult ObtenerProductoPorId(int id)
        {
            var producto = _productoService.ObtenerProductoPorId(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarProducto(int id, [FromBody] ProductoUpdateDto productoDto)
        {
            var productoExistente = _productoService.ObtenerProductoPorId(id);
            if (productoExistente == null)
            {
                _logger.LogWarning("Producto con ID {Id} no encontrado.", id);
                return NotFound();
            }
            _productoService.ActualizarProducto(id, productoDto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            var producto = _productoService.ObtenerProductoPorId(id);

            if (producto ==null)
            {
                return NotFound("Producto no encontrado. ");
            }
            _productoService.EliminarProducto(id);
            return NoContent();
        }
        
    }   
}

