using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    
    public  class DocenteHorario
    {
        [Key]
        public int DocenteID { get; set; }
        public string? Nombre { get; set; }
    }
}
