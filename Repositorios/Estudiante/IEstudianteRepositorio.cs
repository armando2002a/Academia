namespace Repositorios.Estudiante
{
    public interface IEstudianteRepositorio
    {
        List<Datos.Models.Estudiante> ListaEstudiantes();
        List<Datos.Models.Estudiante> ListaEstudiantesPorID(int EstudianteID);
        bool GuardarEstudiante(Datos.Models.Estudiante Estudiante);
        bool ActualizarEstudiante(Datos.Models.Estudiante Estudiante);
    }
}