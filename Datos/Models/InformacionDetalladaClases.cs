using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class InformacionDetalladaClases
    {
        [Key]
        public int? Aula { get; set; }
        public string? Docente { get; set; }
        public string? Estudiante { get; set; }
        public string? Asignatura { get; set; }
        public int? Nivel { get; set; }
        public string? Horario_Clase { get; set; }
    }
}
