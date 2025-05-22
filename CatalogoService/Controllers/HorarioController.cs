using CatalogoService.Application.Factories;
using CatalogoService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoService.Controllers
{
    [ApiController]
    [Route("api/horarios")]
    public class HorarioController : ControllerBase
    {
        private readonly IHorarioRepository _horarioRepo;

        public HorarioController(IRepositoryFactory factory)
        {
            _horarioRepo = factory.CreateHorarioRepository();
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerHorarios([FromQuery] int rutaId)
        {
            var horarios = await _horarioRepo.ObtenerHorariosPorRutaAsync(rutaId);
            return horarios.Any() ? Ok(horarios) : NotFound("No hay horarios disponibles para esta ruta.");
        }
    }
}
