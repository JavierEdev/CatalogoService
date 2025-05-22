using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoService.Domain.Entities
{
    [Table("bus")]
    public class Bus
    {
        [Column("id_bus")]
        public int Id { get; set; }

        [Column("placa")]
        public string Placa { get; set; }

        [Column("capacidad")]
        public int Capacidad { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }
    }
}