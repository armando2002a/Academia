namespace Servicio.Estudiante
{
    public interface IEstudianteServicio
    {
        List<Datos.Models.Estudiante> ListaEstudiantes();
        List<Datos.Models.Estudiante> ListaEstudiantesPorID(int EstudianteID);
        bool GuardarEstudiante(Datos.Models.Estudiante Estudiante);
        bool ActualizarEstudiante(Datos.Models.Estudiante Estudiante);
    }
}
