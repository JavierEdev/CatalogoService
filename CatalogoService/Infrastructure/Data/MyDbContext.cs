namespace CatalogoService.Infrastructure.Data
{
    using Microsoft.EntityFrameworkCore;
    using CatalogoService.Domain.Entities;
    using System.Collections.Generic;
    using System.Reflection.Emit;

    public class MyDbContext : DbContext
    {
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Horario> Horarios { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lugar>().ToTable("lugar").HasKey(l => l.Id);
            modelBuilder.Entity<Ruta>().ToTable("ruta").HasKey(r => r.Id);
            modelBuilder.Entity<Bus>().ToTable("bus").HasKey(b => b.Id);
            modelBuilder.Entity<Horario>().ToTable("horario").HasKey(h => h.Id);
        }
    }
}
