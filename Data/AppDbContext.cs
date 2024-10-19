using Microsoft.EntityFrameworkCore;

namespace ProyectoDeVideoJuegos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<VideoJuego> VideoJuegos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
    }
}