using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Docente
{
    public class DocenteRepositorio : IDocenteRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public DocenteRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
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
            return _appDbContext.Docente.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarEstudiantePorID] {0}", DocenteID)).ToList();
        }


    }
}
