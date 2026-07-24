using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFullStack.API.Models;

namespace ProyectoFullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            var productos = new List<Producto>()
            {
                new Producto
                {
                    Id = 1,
                    Nombre = "Mouse Gamer",
                    Precio = 85000,
                    Stock = 10
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Teclado mecanico",
                    Precio = 100000,
                    Stock = 5
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Monitor Samsung",
                    Precio = 950000,
                    Stock = 3
                }
                };
            return Ok(productos);
            }
        }
    }

