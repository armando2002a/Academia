﻿using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public  class Estudiante
    {
        [Key]
        public int EstudianteID { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Direccion { get; set; }
        public string? Celular { get; set; }
        public string? Correo { get; set; }
        public string? Cedula { get; set; }
    }
}
