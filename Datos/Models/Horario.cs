﻿using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Horario
    {
        [Key]
        public int DocenteID { get; set; }
        public int AsignaturaID { get; set; }
        public int AulaID { get; set; }
    }
}
