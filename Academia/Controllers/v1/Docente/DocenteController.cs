﻿using Microsoft.AspNetCore.Mvc;
using Servicio.Docente;

namespace Academia.Controllers.v1.Docente
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private readonly IDocenteServicio _docenteServicio;

        public DocenteController(IDocenteServicio docenteServicio)
        {
            _docenteServicio = docenteServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _docenteServicio.ListaDocentes() });
           
        }

        [HttpPost]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Docente Docente)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _docenteServicio.ListaDocentesPorID(Docente.DocenteID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Docente Docente)
        {
            return Ok(_docenteServicio.GuardarDocente(Docente));
        }

        [HttpPost]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Docente Docente)
        {
            return Ok(_docenteServicio.ActualizarDocente(Docente));
        }
    }
}
