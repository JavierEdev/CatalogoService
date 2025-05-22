using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoService.Domain.Entities
{
    [Table("horario")]
    public class Horario
    {
        [Column("id_horario")]
        public int Id { get; set; }

        [Column("id_ruta")]
        public int IdRuta { get; set; }

        [Column("id_bus")]
        public int IdBus { get; set; }

        [Column("hora_salida")]
        public DateTime HoraSalida { get; set; }

        [Column("hora_llegada")]
        public DateTime HoraLlegada { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }
    }
}