using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class AlumnosMaestros
    {
        [Key]
        public int EstudianteID { get; set; }
        public string? NombreEstudiante { get; set; }
    }
}
