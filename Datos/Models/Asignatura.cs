using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Asignatura
    {
        [Key]
        public int AsignaturaID { get; set; }
        public string? AsignaturaNombre { get; set; }
        public string? Nivel { get; set; }
        public string? Grado { get; set; }
    }
}
