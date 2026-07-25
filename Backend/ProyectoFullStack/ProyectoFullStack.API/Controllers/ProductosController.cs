using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFullStack.API.Models;
using ProyectoFullStack.API.Interfaces;

namespace ProyectoFullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            var productos = _productoService.ObtenerProductos();
            return Ok(productos);
            }
        }
    }

