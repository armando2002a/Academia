namespace Servicio.Aula
{
    public interface IAulaServicio
    {
        List<Datos.Models.Aula> ListaAula();
        List<Datos.Models.AulaInfo> ListaAulaInfo();
        List<Datos.Models.Aula> ListaAulaPorID(int AulaID);
        bool GuardarAula(Datos.Models.Aula Aula);
        bool ActualizarAula(Datos.Models.Aula Aula);
    }
}
