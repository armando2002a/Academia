using Repositorios.Colaborador;

namespace Servicio.Colaborador
{
    public class ColaboradorServicio : IColaboradorServicio
    {
        private readonly IColaboradorRepositorio _colaboradorRepositorio;

        public ColaboradorServicio(IColaboradorRepositorio colaboradorRepositorio)
        {
            _colaboradorRepositorio = colaboradorRepositorio;
        }

        public List<Datos.Models.Colaborador> ListaColaborador()
        {
            return _colaboradorRepositorio.ListaColaborador();
        }
    }
}
