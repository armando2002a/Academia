using Microsoft.AspNetCore.Mvc;
using Servicio.Docente;

namespace Academia.Controllers.v1.Docente
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase //Base
    {
        private readonly IDocenteServicio _estudianteServicio;

        public DocenteController(IDocenteServicio estudianteServicio)
        {
            _estudianteServicio = estudianteServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Datos.Models.Docente> lista = new List<Datos.Models.Docente>();

            var result = _estudianteServicio.ListaDocente();

            return Ok(result);

        }
    }
}
