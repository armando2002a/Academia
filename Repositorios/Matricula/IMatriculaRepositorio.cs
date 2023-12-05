namespace Repositorios.Matricula
{
    public interface IMatriculaRepositorio
    {
        List<Datos.Models.ListaMatricula> ListaMatricula();
        List<Datos.Models.Matricula> ListaMatriculaPorID(int MatriculaID);
        bool GuardarMatricula(Datos.Models.Matricula Matricula);
        bool ActualizarMatricula(Datos.Models.Matricula Matricula);
    }
}
