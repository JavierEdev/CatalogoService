namespace CatalogoService.Application.Factories
{
    using CatalogoService.Application.Interfaces;

    public interface IRepositoryFactory
    {
        IRutaRepository CreateRutaRepository();
        IHorarioRepository CreateHorarioRepository();
        ILugarRepository CreateLugarRepository();
    }
}