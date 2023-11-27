using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Docente
{
    public class DocenteRepositorio : IDocenteRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public DocenteRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Docente> ListaDocente()
        {
            List<Datos.Models.Docente> listDocente = new List<Datos.Models.Docente>();

            var result = _appDbContext.Docente.FromSqlRaw("EXEC dbo.MostrarInformacionDocente").ToList();

            foreach (var item in result)
            {
                listDocente.Add(new Datos.Models.Docente
                {
                    DocenteID = item.DocenteID,
                    Nombre = item.Nombre,
                    Edad = item.Edad,
                    Celular = item.Celular,
                    Correo = item.Correo,
                    Direccion = item.Direccion,
                    Cedula = item.Cedula

                });
            }
            return listDocente;
        }

        public List<Datos.Models.Docente> ListaDocentePorID(int DocenteID)
        {
            return _appDbContext.Docente.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarDocentePorID] {0}", DocenteID)).ToList();
        }

        public bool GuardarDocente(Datos.Models.Docente Docente)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarDocente] '{0}', {1}, '{2}', '{3}', '{4}', '{5}'",
                    Docente.Nombre,
                    Docente.Edad,
                    Docente.Celular,
                    Docente.Correo,
                    Docente.Direccion,
                    Docente.Cedula
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarDocente(Datos.Models.Docente Docente)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarDocente] {0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}'",
                    Docente.DocenteID,
                    Docente.Nombre,
                    Docente.Edad,
                    Docente.Celular,
                    Docente.Correo,
                    Docente.Direccion,
                    Docente.Cedula
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
