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

        public List<Datos.Models.Docente> ListaDocente()
        {
            return _docenteRepositorio.ListaDocente();
        }
    }
}
