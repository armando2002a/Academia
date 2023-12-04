using Repositorios.Aula;

namespace Servicio.Aula
{
    public class AulaServicio : IAulaServicio
    {
        private readonly IAulaRepositorio _aulaRepositorio;

        public AulaServicio(IAulaRepositorio aulaRepositorio)
        {
            _aulaRepositorio = aulaRepositorio;
        }

        public List<Datos.Models.Aula> ListaAula() => _aulaRepositorio.ListaAula();

        public List<Datos.Models.AulaInfo> ListaAulaInfo() => _aulaRepositorio.ListaAulaInfo();

        public List<Datos.Models.Aula> ListaAulaPorID(int AulaID) => _aulaRepositorio.ListaAulaPorID(AulaID);

        public bool GuardarAula(Datos.Models.Aula Aula) => _aulaRepositorio.GuardarAula(Aula);

        public bool ActualizarAula(Datos.Models.Aula Aula) => _aulaRepositorio.ActualizarAula(Aula);
    }
}
