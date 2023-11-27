using Microsoft.AspNetCore.Mvc;
using Servicio.Estudiante;

namespace Academia.Controllers.v1.Estudiante
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteServicio _estudianteServicio;

        public EstudianteController(IEstudianteServicio estudianteServicio)
        {
            _estudianteServicio = estudianteServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _estudianteServicio.ListaEstudiantes() });
           
        }

        [HttpGet]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Estudiante Estudiante)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _estudianteServicio.ListaEstudiantesPorID(Estudiante.EstudianteID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Estudiante Estudiante)
        {
            return Ok(_estudianteServicio.GuardarEstudiante(Estudiante));
        }

        [HttpPut]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Estudiante Estudiante)
        {
            return Ok(_estudianteServicio.ActualizarEstudiante(Estudiante));
        }
    }
}