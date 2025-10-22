using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class Consulta
    {
        [Key]
        public Guid ConsultaId { get; set; }
        public DateTime Data { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime Hora { get; set; }
        public Guid VeterinarioId { get; set; }
        public Veterinario? Veterinario { get; set; }

    }
}
