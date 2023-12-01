using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.InformacionDetalladaClases
{
    public class DetallesClaseRepositorio : IDetallesClaseRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public DetallesClaseRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.InformacionDetalladaClases> ListaClases()
        {
            List<Datos.Models.InformacionDetalladaClases> listaInformacionDetallada = new List<Datos.Models.InformacionDetalladaClases>();

            var result = _appDbContext.DetallesClases.FromSqlRaw("EXEC dbo.ObtenerInformacionDetalladaClases").ToList();

            foreach (var item in result)
            {
                listaInformacionDetallada.Add(new Datos.Models.InformacionDetalladaClases
                {
                    Aula = item.Aula,
                    Docente = item.Docente,
                    Estudiante = item.Estudiante,
                    Asignatura = item.Asignatura,
                    Nivel = item.Nivel,
                    Horario_Clase = item.Horario_Clase
                });
            }

            return listaInformacionDetallada;
        }
    }
}
