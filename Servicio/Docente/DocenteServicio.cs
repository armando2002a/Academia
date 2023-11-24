using Repositorios.Docente;

namespace Servicio.Docente
{
    public class DocenteServicio : IDocenteServicio
    {
        private readonly IDocenteRepositorio _docenteRepositorio;

        public DocenteServicio(IDocenteRepositorio docenteRepositorio)
        {
            _docenteRepositorio = docenteRepositorio;
        }

        public List<Datos.Models.Docente> ListaDocente() => _docenteRepositorio.ListaDocente();

        public List<Datos.Models.Docente> ListaDocentePorID(int DocenteID) => _docenteRepositorio.ListaDocentePorID(DocenteID);

        public bool GuardarDocente(Datos.Models.Docente Docente) => _docenteRepositorio.GuardarDocente(Docente);

        public bool ActualizarDocente(Datos.Models.Docente Docente) => _docenteRepositorio.ActualizarDocente(Docente);
    }
}
