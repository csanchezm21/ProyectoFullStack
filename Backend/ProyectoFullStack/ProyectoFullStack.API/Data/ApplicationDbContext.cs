using Microsoft.EntityFrameworkCore;
using ProyectoFullStack.API.Models;

namespace ProyectoFullStack.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) 
        : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
