using Data.Persistence;
using Data.Repository;
using Data.Repository.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Gastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        private IGenericRepository<CatConcepto> repository = null;
        public GastosController()
        {
            this.repository = new GenericRepository<CatConcepto>();
        }


        [HttpGet]
        public IActionResult Get() 
        {
            var model = repository.GetAll();
            return Ok(model);
        }
    }
}
