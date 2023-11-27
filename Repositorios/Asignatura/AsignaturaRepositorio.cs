using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Asignatura
{
    public class AsignaturaRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public AsignaturaRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Asignatura> ListaAsignatura()
        {
            List<Datos.Models.Asignatura> listAsignatura = new List<Datos.Models.Asignatura>();

            var result = _appDbContext.Asignatura.FromSqlRaw("EXEC dbo.MostrarInformacionAsignatura").ToList();

            foreach (var item in result)
            {
                listAsignatura.Add(new Datos.Models.Asignatura
                {
                    AsignaturaID = item.AsignaturaID,
                    AsignaturaNombre = item.AsignaturaNombre,
                    Nivel = item.Nivel,
                    Grado = item.Grado
                
                });
            }
            return listAsignatura;
        }

        public List<Datos.Models.Asignatura> ListaAsignaturaPorID(int AsignaturaID)
        {
            return _appDbContext.Asignatura.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarAsignaturaPorID] {0}", AsignaturaID)).ToList();
        }

        public bool GuardarAsignatura(Datos.Models.Asignatura Asignatura)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarAsignatura] '{0}', {1}, '{2}' ",
                    Asignatura.AsignaturaNombre,
                    Asignatura.Nivel,
                    Asignatura.Grado
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarAsignatura(Datos.Models.Asignatura Asignatura)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarAsignatura] {0}, '{1}', {2}, '{3}''",
                    Asignatura.AsignaturaID,
                    Asignatura.AsignaturaNombre,
                    Asignatura.Nivel,
                    Asignatura.Grado
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
