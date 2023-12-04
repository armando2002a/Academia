using Microsoft.AspNetCore.Mvc;
using Servicio.Nota;

namespace Academia.Controllers.v1.Nota
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaServicio _notaServicio;

        public NotaController(INotaServicio notaServicio)
        {
            _notaServicio = notaServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _notaServicio.ListaNota() });

        }

        [HttpPost]
        [Route("ListaPorID/{EstudianteID}")]
        public IActionResult ListaPorIDNota(int EstudianteID)
        {
            if (EstudianteID <= 0)
            {
                return BadRequest("Se requiere un ID de estudiante válido.");
            }

            List<Datos.Models.NotaPorEstudiante> listaNotas = _notaServicio.ListaNotaClase(EstudianteID);

            if (listaNotas == null || !listaNotas.Any())
            {
                return NotFound("No se encontraron notas para el estudiante con el ID proporcionado.");
            }

            return Ok(listaNotas);
        }


        [HttpPost]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Nota Nota)
        {
            return Ok(_notaServicio.ListaNotaPorID(Nota.NotaID));
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Nota Nota)
        {
            return Ok(_notaServicio.GuardarNota(Nota));
        }

        [HttpPut]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Nota Nota)
        {
            return Ok(_notaServicio.ActualizarNota(Nota));
        }
    }
}
