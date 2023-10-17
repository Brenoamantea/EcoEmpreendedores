using EcoEmpreendedores.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoEmpreendedores.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empreendedor> Empreendedores { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
