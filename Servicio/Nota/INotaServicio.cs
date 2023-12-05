namespace Servicio.Nota
{
    public interface INotaServicio
    {
        List<Datos.Models.Nota> ListaNota();
        List<Datos.Models.MostrarNotasMaestro> ListaNotaMaestro(int DocenteID);
        List<Datos.Models.NotaPorEstudiante> ListaNotaClase(int EstudianteID);
        List<Datos.Models.Nota> ListaNotaPorID(int NotaID);
        bool GuardarNota(Datos.Models.Nota Nota);
        bool ActualizarNota(Datos.Models.Nota Nota
            );
    }
}
