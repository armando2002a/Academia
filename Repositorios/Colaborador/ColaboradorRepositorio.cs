using Datos.DataDb;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Colaborador
{
    public class ColaboradorRepositorio : IColaboradorRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ColaboradorRepositorio(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public List<Datos.Models.Colaborador> ListaColaborador()
        {
            List<Datos.Models.Colaborador> listColaborador = new List<Datos.Models.Colaborador>();

            var result = _appDbContext.Colaborador.FromSqlRaw("EXEC dbo.MostrarInformacionColaborador").ToList();

            foreach (var item in result)
            {
                listColaborador.Add(new Datos.Models.Colaborador
                {
                    ColaboradorID = item.ColaboradorID,
                    Nombre = item.Nombre,
                    Edad = item.Edad,
                    Correo = item.Correo,
                    Cedula = item.Cedula

                });
            }
            return listColaborador;
        }
    }
}
