﻿using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Matricula
    {
        [Key]
        public int EstudianteID { get; set; }
        public int HorarioID { get; set; }
    }
}
