using Microsoft.AspNetCore.Mvc;
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
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _docenteServicio.ListaDocente() });
           
        }

        [HttpPost]
        [Route("ListaAlumnosPorDocenteID/{DocenteID}")]
        public IActionResult ListaAlumnosPorDocenteID(int DocenteID)
        {
            if (DocenteID <= 0)
            {
                return BadRequest("Se requiere un ID de estudiante válido.");
            }

            List<Datos.Models.AlumnosMaestros> listaAlumnos = _docenteServicio.ListaAlumnos(DocenteID);

            if (listaAlumnos == null || !listaAlumnos.Any())
            {
                return NotFound("No se encontraron notas para el estudiante con el ID proporcionado.");
            }

            return Ok(listaAlumnos);
        }

        [HttpGet]
        [Route("ListaDocente")]
        public IActionResult ListaDocente()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _docenteServicio.DocenteHorario() });

        }

        [HttpPost]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Docente Docente)
        {
            return Ok(_docenteServicio.ListaDocentePorID(Docente.DocenteID));
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Docente Docente)
        {
            return Ok(_docenteServicio.GuardarDocente(Docente));
        }

        [HttpPut]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Docente Docente)
        {
            return Ok(_docenteServicio.ActualizarDocente(Docente));
        }
    }
}
