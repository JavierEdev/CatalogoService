using CatalogoService.Domain.Entities;

namespace CatalogoService.Application.Interfaces
{
    public interface ILugarRepository
    {
        Task<List<Lugar>> ObtenerTodosAsync();
    }
}
