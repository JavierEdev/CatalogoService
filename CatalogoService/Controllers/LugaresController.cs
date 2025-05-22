using CatalogoService.Application.Factories;
using CatalogoService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoService.Controllers
{
    [ApiController]
    [Route("api/lugares")]
    public class LugaresController : ControllerBase
    {
        private readonly ILugarRepository _lugarRepo;

        public LugaresController(IRepositoryFactory factory)
        {
            _lugarRepo = factory.CreateLugarRepository();
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerLugares()
        {
            var lugares = await _lugarRepo.ObtenerTodosAsync();
            return Ok(lugares);
        }
    }
}
