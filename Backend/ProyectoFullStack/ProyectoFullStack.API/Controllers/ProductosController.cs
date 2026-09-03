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
            var respuesta = new ApiResponseDto<IEnumerable<ProductoResponseDto>>
            {
                Success = true,
                Message = "Productos consultados correctamente.",
                Data = productos
            };
            return Ok(respuesta);
        }

        [HttpPost]
        public IActionResult CrearProducto([FromBody] ProductoCreateDto productoDto)
        {
            if (!ModelState.IsValid)
            {
                var respuestaError = new ApiResponseDto<object> 
                { 
                    Success = false, 
                    Message = "Los datos enviados no son válidos.", 
                    Data = ModelState };

                return BadRequest(respuestaError);
            }
            var nuevoProducto = _productoService.CrearProducto(productoDto);

            var respuesta = new ApiResponseDto<ProductoResponseDto>
            {
                Success = true,
                Message = "Producto creado correctamente. ",
                Data = nuevoProducto
            };

            return CreatedAtAction(
                nameof(ObtenerProductoPorId),
                new
                {
                    id = nuevoProducto.Id
                },
                respuesta);
        }
        [HttpGet("{id}")]
        public IActionResult ObtenerProductoPorId(int id)
        {
            
            var producto = _productoService.ObtenerProductoPorId(id);
            if (producto == null)
            {
                var respuesta = new ApiResponseDto<object>
                {
                    Success = false,
                    Message = " Producto no encontrado. ",
                    Data = null
                };
                return NotFound(respuesta);
            }

            var respuestaProducto = new ApiResponseDto<ProductoResponseDto>
            {
                Success = true,
                Message = "Producto consultado correctamente.",
                Data = producto
            };

            return Ok(respuestaProducto);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarProducto(int id, [FromBody] ProductoUpdateDto productoDto)
        {
            var productoExistente = _productoService.ObtenerProductoPorId(id);
            if (productoExistente == null)
            {
                _logger.LogWarning("Producto con ID {Id} no encontrado.", id);
               
                var respuestaError = new ApiResponseDto<object>
                {
                    Success = false,
                    Message = "Producto no encontrado.",
                    Data = null
                };
                return NotFound(respuestaError);
            }
            _productoService.ActualizarProducto(id, productoDto);

            var productoActualizado = _productoService.ObtenerProductoPorId(id);

            var respuesta = new ApiResponseDto<ProductoResponseDto>
            {
                Success = true,
                Message = "Producto actualizado correctamente. ",
                Data = productoActualizado
            };
            return Ok(respuesta);

        }
        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            

            var producto = _productoService.ObtenerProductoPorId(id);

            if (producto == null)
            {
                var respuestaError = new ApiResponseDto<object>
                {
                    Success = false,
                    Message = "Producto no encontrado.",
                    Data = null
                };

                return NotFound(respuestaError);
            }

            _productoService.EliminarProducto(id);

            var respuesta = new ApiResponseDto<object>
            {
                Success = true,
                Message = "Producto eliminado correctamente.",
                Data = null
            };

            return Ok(respuesta);
        }

    }   
}

