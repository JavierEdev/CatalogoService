using CatalogoService.Application.Interfaces;
using CatalogoService.Domain.Entities;
using CatalogoService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CatalogoService.Infrastructure.MySQL
{
    public class HorarioMySqlAdapter : IHorarioRepository
    {
        private readonly MyDbContext _context;

        public HorarioMySqlAdapter(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Horario>> ObtenerHorariosPorRutaAsync(int rutaId)
        {
            return await _context.Horarios
                .Where(h => h.IdRuta == rutaId && h.Estado)
                .ToListAsync();
        }
    }
}
