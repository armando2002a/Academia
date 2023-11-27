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
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Nota Nota)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _notaServicio.ListaNotaPorID(Nota.NotaID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Nota Nota)
        {
            return Ok(_notaServicio.GuardarNota(Nota));
        }

        [HttpPost]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Nota Nota)
        {
            return Ok(_notaServicio.ActualizarNota(Nota));
        }
    }
}
