using Microsoft.AspNetCore.Mvc;
using Servicio.Asignatura;

namespace Academia.Controllers.v1.Asignatura
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturaController : ControllerBase
    {
        private readonly IAsignaturaServicio _asignaturaServicio;

        public AsignaturaController(IAsignaturaServicio asignaturaServicio)
        {
            _asignaturaServicio = asignaturaServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _asignaturaServicio.ListaAsignatura() });
           
        }

        [HttpPost]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Asignatura Asignatura)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _asignaturaServicio.ListaAsignaturaPorID(Asignatura.AsignaturaID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Asignatura Asignatura)
        {
            return Ok(_asignaturaServicio.GuardarAsignatura(Asignatura));
        }

        [HttpPost]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Asignatura Asignatura)
        {
            return Ok(_asignaturaServicio.ActualizarAsignatura(Asignatura));
        }
    }
}
