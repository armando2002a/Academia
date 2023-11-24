using Datos.DataDb;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Estudiante
{
    public class EstudianteRepositorio : IEstudianteRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public EstudianteRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Estudiante> ListaEstudiantes()
        {
            List<Datos.Models.Estudiante> listEstudiante = new List<Datos.Models.Estudiante>();

            var result = _appDbContext.Estudiante.FromSqlRaw("EXEC dbo.MostrarInformacionEstudiantes").ToList();

            foreach (var item in result)
            {
                listEstudiante.Add(new Datos.Models.Estudiante
                {
                    EstudianteID = item.EstudianteID,
                    Nombre = item.Nombre,
                    Edad = item.Edad,
                    Direccion = item.Direccion,
                    Celular = item.Celular,
                    Correo = item.Correo,
                    Cedula = item.Cedula

                });
            }
            return listEstudiante;
        }

        public List<Datos.Models.Estudiante> ListaEstudiantesPorID(int EstudianteID)
        {
            return _appDbContext.Estudiante.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarEstudiantePorID] {0}", EstudianteID)).ToList();
        }

        public bool GuardarEstudiante(Datos.Models.Estudiante Estudiante)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarEstudiante] '{0}', {1}, '{2}', '{3}', '{4}', '{5}'",
                    Estudiante.Nombre,
                    Estudiante.Edad,
                    Estudiante.Direccion,
                    Estudiante.Celular,
                    Estudiante.Correo,
                    Estudiante.Cedula
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarEstudiante(Datos.Models.Estudiante Estudiante)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarEstudiante] {0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}'",
                    Estudiante.EstudianteID,
                    Estudiante.Nombre,
                    Estudiante.Edad,
                    Estudiante.Direccion,
                    Estudiante.Celular,
                    Estudiante.Correo,
                    Estudiante.Cedula
                ));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}