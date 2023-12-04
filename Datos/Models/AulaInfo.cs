using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class AulaInfo
    {
        [Key]
        public int AulaID { get; set; }
        public int? Numero_de_Aula { get; set; }
        public string? Horario_Clase { get; set; }
    }
}