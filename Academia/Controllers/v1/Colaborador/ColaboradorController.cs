using Microsoft.AspNetCore.Mvc;
using Servicio.Colaborador;

namespace Academia.Controllers.v1.Colaborador
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase 
    {
        private readonly IColaboradorServicio _colaboradorServicio;

        public ColaboradorController(IColaboradorServicio colaboradorServicio)
        {
            _colaboradorServicio = colaboradorServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Datos.Models.Colaborador> lista = new List<Datos.Models.Colaborador>();

            var result = _colaboradorServicio.ListaColaborador();

            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = result });

        }
    }
}
