using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Gastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get(string mensaje) 
        {
            return Ok(mensaje);
        }
    }
}
