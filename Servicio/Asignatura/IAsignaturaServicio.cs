namespace Servicio.Asignatura
{
    public interface IAsignaturaServicio
    {
        List<Datos.Models.Asignatura> ListaAsignatura();
        List<Datos.Models.Asignatura> ListaAsignaturaPorID(int AsignaturaID);
        bool GuardarAsignatura(Datos.Models.Asignatura Asignatura);
        bool ActualizarAsignatura(Datos.Models.Asignatura Asignatura);
    }
}
