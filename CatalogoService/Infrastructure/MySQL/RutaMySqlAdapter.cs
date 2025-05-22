using CatalogoService.Application.Interfaces;
using CatalogoService.Domain.Entities;
using CatalogoService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CatalogoService.Infrastructure.MySQL
{
    public class RutaMySqlAdapter : IRutaRepository
    {
        private readonly MyDbContext _context;

        public RutaMySqlAdapter(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ruta>> BuscarRutasAsync(int idOrigen, int idDestino)
        {
            return await _context.Rutas
                .Where(r => r.IdOrigen == idOrigen && r.IdDestino == idDestino && r.Activo)
                .ToListAsync();
        }
    }
}
