using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoService.Domain.Entities
{
    [Table("lugar")]
    public class Lugar
    {
        [Column("id_lugar")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
