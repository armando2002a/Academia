using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class NotaPorEstudiante
    {
        [Key]
        public int NumeroMatricula { get; set; }
        public string? NombreAsignatura { get; set; }
        public int? Grado { get; set; }
        public int? Nivel { get; set; }
        public string? NombreDocente { get; set; }
        public decimal? Nota { get; set; }
    }
}
