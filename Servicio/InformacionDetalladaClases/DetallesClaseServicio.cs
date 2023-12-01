using Repositorios.InformacionDetalladaClases;

namespace Servicio.InformacionDetalladaClases
{
    public class DetallesClaseServicio : IDetallesClaseServicio
    {
        private readonly IDetallesClaseRepositorio _detallesClaseRepositorio;

        public DetallesClaseServicio(IDetallesClaseRepositorio detallesClaseRepositorio)
        {
            _detallesClaseRepositorio = detallesClaseRepositorio;
        }

        public List<Datos.Models.InformacionDetalladaClases> ListaClases() => _detallesClaseRepositorio.ListaClases();
    }
}
