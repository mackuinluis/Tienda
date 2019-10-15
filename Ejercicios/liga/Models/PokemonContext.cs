using Microsoft.EntityFrameworkCore;

namespace liga.Models
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemones { get; set; }
        public PokemonContext(DbContextOptions<PokemonContext> o) : base(o) {

        }
    }
}