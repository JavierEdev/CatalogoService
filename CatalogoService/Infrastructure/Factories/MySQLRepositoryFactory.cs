namespace CatalogoService.Infrastructure.Factories
{
    using CatalogoService.Application.Factories;
    using CatalogoService.Application.Interfaces;
    using CatalogoService.Infrastructure.Data;
    using CatalogoService.Infrastructure.MySQL;

    public class MySQLRepositoryFactory : IRepositoryFactory
    {
        private readonly MyDbContext _context;

        public MySQLRepositoryFactory(MyDbContext context)
        {
            _context = context;
        }

        public IRutaRepository CreateRutaRepository()
            => new RutaMySqlAdapter(_context);

        public IHorarioRepository CreateHorarioRepository()
            => new HorarioMySqlAdapter(_context);

        public ILugarRepository CreateLugarRepository()
            => new LugarMySqlAdapter(_context);
    }
}