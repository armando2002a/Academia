namespace Servicio.Asignatura
{
    public class AsignaturaServicio : IAsignaturaServicio
    {
        private readonly IAsignaturaRepositorio _asignaturaRepositorio;

        public EstudianteServicio(IAsignaturaRepositorio asignaturaRepositorio)
        {
            _asignaturaRepositorio = asignaturaRepositorio;
        }

        public List<Datos.Models.Asignatura> ListaAsignatura() => _asignaturaRepositorio.ListaAsignatura();

        public List<Datos.Models.Asignatura> ListaAsignaturaPorID(int AsignaturaID) => _asignaturaRepositorio.ListaAsignaturaPorID(AsignaturaID);

        public bool GuardarAsignatura(Datos.Models.Asignatura Asignatura) => _asignaturaRepositorio.GuardarAsignatura(Asignatura);

        public bool ActualizarAsignatura(Datos.Models.Asignatura Asignatura) => _asignaturaRepositorio.ActualizarAsignatura(Asignatura);
    }
}
