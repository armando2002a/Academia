using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.DataDb
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; } 
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
    }
}
