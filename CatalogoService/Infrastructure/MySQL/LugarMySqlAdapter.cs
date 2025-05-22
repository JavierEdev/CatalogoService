using CatalogoService.Application.Interfaces;
using CatalogoService.Domain.Entities;
using CatalogoService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CatalogoService.Infrastructure.MySQL
{
    public class LugarMySqlAdapter : ILugarRepository
    {
        private readonly MyDbContext _context;

        public LugarMySqlAdapter(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Lugar>> ObtenerTodosAsync()
        {
            return await _context.Lugares.ToListAsync();
        }
    }
}
