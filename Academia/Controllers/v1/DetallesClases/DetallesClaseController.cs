using Microsoft.AspNetCore.Mvc;
using Servicio.InformacionDetalladaClases;

namespace Academia.Controllers.v1.DetallesClases
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallesClaseController : ControllerBase
    {
        private readonly IDetallesClaseServicio _detallesClaseServicio;

        public DetallesClaseController(IDetallesClaseServicio detallesClaseServicio)
        {
            _detallesClaseServicio = detallesClaseServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _detallesClaseServicio.ListaClases() });

        }
    }
}
