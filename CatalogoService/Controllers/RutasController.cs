using CatalogoService.Application.Factories;
using CatalogoService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoService.Controllers
{
    [ApiController]
    [Route("api/rutas")]
    public class RutasController : ControllerBase
    {
        private readonly IRutaRepository _rutaRepo;

        public RutasController(IRepositoryFactory factory)
        {
            _rutaRepo = factory.CreateRutaRepository();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarRutas([FromQuery] int idOrigen, [FromQuery] int idDestino)
        {
            var rutas = await _rutaRepo.BuscarRutasAsync(idOrigen, idDestino);
            return rutas.Any() ? Ok(rutas) : NotFound("No hay rutas disponibles.");
        }
    }
}
