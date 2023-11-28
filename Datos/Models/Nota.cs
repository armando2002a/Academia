using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Nota
    {
        [Key]
        public int NotaID { get; set; }
        public int MatriculaID { get; set; }
        public Decimal? Calificacion { get; set; }
    }
}
