namespace Academia.Controllers.v1.Matricula
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaServicio _matriculaServicio;

        public MatriculaController(IMatriculaServicio matriculaServicio)
        {
            _matriculaServicio = matriculaServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _matriculaServicio.ListaMatricula() });
           
        }

        [HttpPost]
        [Route("ListaPorID")]
        public IActionResult ListaPorID([FromBody] Datos.Models.Matricula Matricula)
        {
            return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = _matriculaServicio.ListaMatriculaPorID(Matricula.MatriculaID) });
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Datos.Models.Matricula Matricula)
        {
            return Ok(_matriculaServicio.GuardarMatricula(Matricula));
        }

        [HttpPost]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Datos.Models.Matricula Matricula)
        {
            return Ok(_matriculaServicio.ActualizarMatricula(Matricula));
        }
    }
}
