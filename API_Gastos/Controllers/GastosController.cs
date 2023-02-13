using Business.Service;
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
        //private IGenericRepository<CatConcepto> repository = null;
        private readonly IGastoService _gastoService;
        public GastosController(IGastoService gastoService)
        {
            //this.repository = new GenericRepository<CatConcepto>();
            _gastoService = gastoService;
        }


        [HttpGet]
        public IActionResult Get() 
        {
            var model = _gastoService.Get();
            return Ok(model);
        }
    }
}
