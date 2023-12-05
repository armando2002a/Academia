using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class MostrarNotasMaestro
    {
        [Key]
        public int IDNota { get; set; }
        public string? NombreEstudiante { get; set; }
        public string? NombreAsignatura { get; set; }
        public int Grado { get; set;}
        public int Nivel { get; set;}
        public decimal NotaEstudiante { get; set; }

    }
}
