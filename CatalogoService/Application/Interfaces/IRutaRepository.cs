using CatalogoService.Domain.Entities;

namespace CatalogoService.Application.Interfaces
{
    public interface IRutaRepository
    {
        Task<List<Ruta>> BuscarRutasAsync(int idOrigen, int idDestino);
    }
}
