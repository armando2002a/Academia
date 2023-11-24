using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Colaborador
{
    public interface IColaboradorServicio
    {
        List<Datos.Models.Colaborador> ListaColaborador();
    }
}
