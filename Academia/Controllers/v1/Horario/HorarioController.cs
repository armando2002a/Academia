using Microsoft.AspNetCore.Mvc;
using Servicio.Horario;

namespace Academia.Controllers.v1.Horario
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly IHorarioServicio _horarioServicio;

        public HorarioController(IHorarioServicio horarioServicio)
        {
            _horarioServicio = horarioServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _horarioServicio.ListaHorario()});

        }

        [HttpPost]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Horario Horario)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _horarioServicio.ListaHorarioPorID(Horario.HorarioID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Horario Horario)
        {
            return Ok(_horarioServicio.GuardarHorario(Horario));
        }

        [HttpPost]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Horario Horario)
        {
            return Ok(_horarioServicio.ActualizarHorario(Horario));
        }
    }
}
