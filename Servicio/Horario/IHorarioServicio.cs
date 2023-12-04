namespace Servicio.Horario
{
    public interface IHorarioServicio 
    {
        List<Datos.Models.Horario> ListaHorario();
        List<Datos.Models.HorarioMatricula> ListaHorarioMatricula();
        List<Datos.Models.Horario> ListaHorarioPorID(int HorarioID);
        bool GuardarHorario(Datos.Models.Horario Horario);
        bool ActualizarHorario(Datos.Models.Horario Horario);
    }
}
