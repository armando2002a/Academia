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
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }
        

    }
}
