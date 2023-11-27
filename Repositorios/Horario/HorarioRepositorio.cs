using Datos.DataDb;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Horario
{
    public class HorarioRepositorio : IHorarioRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public HorarioRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Horario> ListaHorario()
        {
            List<Datos.Models.Horario> listHorario = new List<Datos.Models.Horario>();

            var result = _appDbContext.Horario.FromSqlRaw("EXEC dbo.MostrarInformacionHorario").ToList();

            foreach (var item in result)
            {
                listHorario.Add(new Datos.Models.Horario
                {
                    HorarioID = item.HorarioID,
                    DocenteID = item.DocenteID,
                    AsignaturaID = item.AsignaturaID,
                    AulaID = item.AulaID,
                    Hora_ClaseInicio = item.Hora_ClaseInicio,
                    Hora_ClaseFin = item.Hora_ClaseFin

                });
            }
            return listHorario;
        }

        public List<Datos.Models.Horario> ListaEstuHorarioPorID(int HorarioID)
        {
            return _appDbContext.Horario.FromSqlRaw(string.Format(@"EXEC [dbo].[BuscarEstudiantePorID] {0}", HorarioID)).ToList();
        }

        public bool GuardarHorario(Datos.Models.Horario Horario)
        {
            try
            {
                var sql = string.Format(@"EXEC [dbo].[AgregarEstudiante] '{0}', {1}, '{2}', '{3}', '{4}'",
                    Horario.DocenteID,
                    Horario.AsignaturaID,
                    Horario.AulaID,
                    Horario.Hora_ClaseInicio,
                    Horario.Hora_ClaseFin
                );
                var result = _appDbContext.Database.ExecuteSqlRaw(sql);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarHorario(Datos.Models.Horario Horario)
        {
            try
            {
                _appDbContext.Database.ExecuteSqlRaw(
                    string.Format(@"EXEC [dbo].[EditarEstudiante] {0}, '{1}', {2}, '{3}', '{4}', '{5}'",
                    Horario.HorarioID,
                    Horario.DocenteID,
                    Horario.AsignaturaID,
                    Horario.AulaID,
                    Horario.Hora_ClaseInicio,
                    Horario.Hora_ClaseFin
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
