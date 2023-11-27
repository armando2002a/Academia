using Microsoft.AspNetCore.Mvc;
using Servicio.Aula;

namespace Academia.Controllers.v1.Aula
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        private readonly IAulaServicio _aulaServicio;

        public AulaController(IAulaServicio aulaServicio)
        {
            _aulaServicio = aulaServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _aulaServicio.ListaAula() });

        }

        [HttpGet]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Aula Aula)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _aulaServicio.ListaAulaPorID(Aula.AulaID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Aula Aula)
        {
            return Ok(_aulaServicio.GuardarAula(Aula));
        }

        [HttpPut]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Aula Aula)
        {
            return Ok(_aulaServicio.ActualizarAula(Aula));
        }
    }
}
