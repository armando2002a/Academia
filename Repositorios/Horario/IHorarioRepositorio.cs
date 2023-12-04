namespace Repositorios.Horario
{
    public interface IHorarioRepositorio
    {
        List<Datos.Models.Horario> ListaHorario();
        List<Datos.Models.HorarioMatricula> ListaHorarioMatricula();
        List<Datos.Models.Horario> ListaEstuHorarioPorID(int HorarioID);
        bool GuardarHorario(Datos.Models.Horario Horario);
        bool ActualizarHorario(Datos.Models.Horario Horario);
    }
}
