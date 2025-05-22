using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoService.Domain.Entities
{
    [Table("ruta")]
    public class Ruta
    {
        [Column("id_ruta")]
        public int Id { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("id_origen")]
        public int IdOrigen { get; set; }

        [Column("id_destino")]
        public int IdDestino { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }
    }
}
