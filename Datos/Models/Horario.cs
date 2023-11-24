using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Horario
    {
        [Key]
        public int HorarioID { get; set; }
        public int DocenteID { get; set; }
        public int AsignaturaID { get; set; }
        public int AulaID { get; set; }
        public DateTime Hora_ClaseInicio { get; set; }
        public DateTime Hora_ClaseFin { get; set; }
    }
}
