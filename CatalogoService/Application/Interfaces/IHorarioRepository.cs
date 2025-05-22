using CatalogoService.Domain.Entities;

namespace CatalogoService.Application.Interfaces
{
    public interface IHorarioRepository
    {
        Task<List<Horario>> ObtenerHorariosPorRutaAsync(int rutaId);
    }
}
