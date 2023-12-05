    using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class AlumnosMaestros
    {
        [Key]
        public int MatriculaID { get; set; }
        public int EstudianteID { get; set; }
        public string? NombreEstudiante { get; set; }
        public int? NumerodeAula { get; set; }
        public string? AsignaturaNombre { get; set; }
        public int Grado { get; set; }
        public int Nivel { get; set; }
    }
}
