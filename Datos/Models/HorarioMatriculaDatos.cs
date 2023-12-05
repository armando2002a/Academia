using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class HorarioMatriculaDatos
    {
        [Key]
        public int? HorarioID { get; set; }
        public string? NombreDocente { get; set; }
        public string? AsignaturaNombre { get; set; }
        public int? Grado { get; set; }
        public int? Nivel { get; set; }
		public int? Numero_de_Aula { get; set; }
        public string? Hora_Clase { get; set; }
    }
}