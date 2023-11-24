using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Asignatura
{
    public interface IAsignaturaRepositorio
    {
        List<Datos.Models.Asignatura> ListaAsignatura();
        List<Datos.Models.Asignatura> ListaAsignaturaPorID(int EstudianteID);
        bool GuardarAsignatura(Datos.Models.Asignatura Asignatura);
        bool ActualizarAsignatura(Datos.Models.Asignatura Asignatura);
    }
}
