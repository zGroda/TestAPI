using Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base
            (options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
    }
}
