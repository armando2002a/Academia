using Repositorios.Estudiante;

namespace Servicio.Estudiante
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private readonly IEstudianteRepositorio _estudianteRepositorio;

        public EstudianteServicio(IEstudianteRepositorio estudianteRepositorio)
        {
            _estudianteRepositorio = estudianteRepositorio;
        }

        public List<Datos.Models.Estudiante> ListaEstudiantes() => _estudianteRepositorio.ListaEstudiantes();

        public List<Datos.Models.Estudiante> ListaEstudiantesPorID(int EstudianteID) => _estudianteRepositorio.ListaEstudiantesPorID(EstudianteID);

        public bool GuardarEstudiante(Datos.Models.Estudiante Estudiante) => _estudianteRepositorio.GuardarEstudiante(Estudiante);

        public bool ActualizarEstudiante(Datos.Models.Estudiante Estudiante) => _estudianteRepositorio.ActualizarEstudiante(Estudiante);
    }
}