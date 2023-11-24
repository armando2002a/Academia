namespace Servicio.Docente
{
    public interface IDocenteServicio
    {
        List<Datos.Models.Docente> ListaDocente();
        List<Datos.Models.Docente> ListaDocentePorID(int DocenteID);
        bool GuardarDocente(Datos.Models.Docente Docente);
        bool ActualizarDocente(Datos.Models.Docente Docente);
    }
}
