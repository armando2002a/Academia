using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Matricula
{
    public class MatriculaRepositorio : IMatriculaRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public MatriculaRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Matricula> ListaMatricula()
        {
            List<Datos.Models.Matricula> listMatricula = new List<Datos.Models.Matricula>();

            var result = _appDbContext.Matricula.FromSqlRaw("EXEC dbo.MostrarInformacionMatricula").ToList();

            foreach (var item in result)
            {
                listMatricula.Add(new Datos.Models.Matricula
                {
                    MatriculaID = item.MatriculaID,
                    EstudianteID = item.EstudianteID,
                    HorarioID = item.HorarioID,
                    FechaMatricula = item.FechaMatricula

                });
            }
            return listMatricula;
        }

        public List<Datos.Models.Matricula> ListaMatriculaPorID(int MatriculaID)
        {
            return _appDbContext.Matricula.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarMatriculaPorID] {0}", MatriculaID)).ToList();
        }

        public bool GuardarMatricula(Datos.Models.Matricula Matricula)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarMatricula] '{0}', {1}, '{2}'",
                    Matricula.EstudianteID,
                    Matricula.HorarioID,
                    Matricula.FechaMatricula
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarMatricula(Datos.Models.Matricula Matricula)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarMatricula] {0}, '{1}', {2}, '{3}'",
                    Matricula.MatriculaID,
                    Matricula.EstudianteID,
                    Matricula.HorarioID,
                    Matricula.FechaMatricula

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
