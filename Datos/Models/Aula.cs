using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Aula
    {
        [Key]
        public int AulaID { get; set; }
        public DateTime Hora_ClaseInicio { get; set; }
        public DateTime Hora_ClaseFin { get; set; }
        public string? Numero_de_Aula { get; set; }
        public string? Estado { get; set; }
    }
}
