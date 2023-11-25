using Repositorios.Estudiante;
using Repositorios.Matricula;

namespace Servicio.Matricula
{
    public class MatriculaServicio
    {
        private readonly IMatriculaRepositorio _matriculaRepositorio;

        public MatriculaServicio(MatriculaRepositorio MatriculaRepositorio)
        {
            _matriculaRepositorio = MatriculaRepositorio;
        }

        public List<Datos.Models.Matricula> ListaMatricula() => _matriculaRepositorio.ListaMatricula();

        public List<Datos.Models.Matricula> ListaMatriculaPorID(int MatriculaID) => _matriculaRepositorio.ListaMatriculaPorID(MatriculaID);

        public bool GuardarMatricula(Datos.Models.Matricula Matricula) => _matriculaRepositorio.GuardarMatricula(Matricula);

        public bool ActualizarMatricula(Datos.Models.Matricula Matricula) => _matriculaRepositorio.ActualizarMatricula(Matricula);
    }
}
