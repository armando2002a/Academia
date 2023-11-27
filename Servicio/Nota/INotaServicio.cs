namespace Servicio.Nota
{
    public interface INotaServicio
    {
        List<Datos.Models.Nota> ListaNota();
        List<Datos.Models.Nota> ListaNotaPorID(int NotaID);
        bool GuardarNota(Datos.Models.Nota Nota);
        bool ActualizarNota(Datos.Models.Nota Nota
            );
    }
}
