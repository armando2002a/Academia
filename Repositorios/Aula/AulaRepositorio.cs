using Datos.DataDb;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Aula
{
    public class AulaRepositorio : IAulaRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public AulaRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Aula> ListaAula()
        {
            List<Datos.Models.Aula> listAula = new List<Datos.Models.Aula>();

            var result = _appDbContext.Aula.FromSqlRaw("EXEC dbo.MostrarInformacionAula").ToList();

            foreach (var item in result)
            {
                listAula.Add(new Datos.Models.Aula
                {
                    AulaID = item.AulaID,
                    Hora_ClaseInicio = item.Hora_ClaseInicio,
                    Hora_ClaseFin = item.Hora_ClaseFin,
                    Numero_de_Aula = item.Numero_de_Aula,
                    Estado = item.Estado

                });
            }
            return listAula;
        }

        public List<Datos.Models.Aula> ListaAulaPorID(int AulaID)
        {
            return _appDbContext.Aula.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarAulaPorID] {0}", AulaID)).ToList();
        }

        public bool GuardarAula(Datos.Models.Aula Aula)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarAula] '{0}', {1}, '{2}', '{3}'",
                    Aula.Hora_ClaseInicio,
                    Aula.Hora_ClaseFin,
                    Aula.Numero_de_Aula,
                    Aula.Estado
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarAula(Datos.Models.Aula Aula)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarAula] {0}, '{1}', {2}, '{3}', '{4}'",
                    Aula.AulaID,
                    Aula.Hora_ClaseInicio,
                    Aula.Hora_ClaseFin,
                    Aula.Numero_de_Aula,
                    Aula.Estado
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
