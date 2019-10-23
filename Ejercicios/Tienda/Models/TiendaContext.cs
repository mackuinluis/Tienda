using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tienda.Models
{
    public class TiendaContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public TiendaContext(DbContextOptions<TiendaContext> o) : base(o)
        {

        }
    }
}