using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Matricula
{
    public class MatriculaRepositorio : IMatriculaRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public MatriculaRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
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
                    Nombre = item.Nombre,
                    Edad = item.Edad,
                    Celular = item.Celular,
                    Correo = item.Correo,
                    Direccion = item.Direccion,
                    Cedula = item.Cedula

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
                var sql = string.Format(@"EXEC [dbo].[AgregarEstudiante] '{0}', {1}, '{2}', '{3}', '{4}', '{5}'",
                    Matricula.Nombre,
                    Matricula.Edad,
                    Matricula.Celular,
                    Matricula.Correo,
                    Matricula.Direccion,
                    Matricula.Cedula
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
                    string.Format(@"EXEC [dbo].[EditarMatricula] {0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}'",
                    Matricula.MatriculaID,
                    Matricula.Nombre,
                    Matricula.Edad,
                    Matricula.Celular,
                    Matricula.Correo,
                    Matricula.Direccion,
                    Matricula.Cedula
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
