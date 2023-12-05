using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class ListaMatricula
    {
        [Key]
        public int MatriculaID { get; set; }
        public int EstudianteID { get; set; }
        public int HorarioID { get; set; }
        public DateTime FechaMatricula { get; set; }
    }
}
