using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Colaborador
    {
        [Key]
        public int ColaboradorID { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Correo { get; set; }
        public string? Cedula { get; set; }
    }
}
