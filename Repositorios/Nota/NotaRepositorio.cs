using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Nota
{
    public class NotaRepositorio : INotaRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public NotaRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Nota> ListaNota()
        {
            List<Datos.Models.Nota> listNota = new List<Datos.Models.Nota>();

            var result = _appDbContext.Nota.FromSqlRaw("EXEC dbo.MostrarInformacionNota").ToList();

            foreach (var item in result)
            {
                listNota.Add(new Datos.Models.Nota
                {
                    NotaID = item.NotaID,
                    MatriculaID = item.MatriculaID,
                    Calificacion = item.Calificacion

                });
            }
            return listNota;
        }

        public List<Datos.Models.Nota> ListaNotaPorID(int NotaID)
        {
            return _appDbContext.Nota.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarNotaPorID] {0}", NotaID)).ToList();
        }

        public bool GuardarNota(Datos.Models.Nota Nota)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarNota] '{0}', {1}",
                    Nota.MatriculaID,
                    Nota.Calificacion
                   
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarNota(Datos.Models.Nota Nota)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarNota] {0}, '{1}', {2}",
                    Nota.NotaID,
                    Nota.MatriculaID,
                    Nota.Calificacion

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
