using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Asignatura
    {
        [Key]
        public int AsignaturaID { get; set; }
        public string? AsignaturaNombre { get; set; }
        public int? Nivel { get; set; }
        public int? Grado { get; set; }
    }
}
