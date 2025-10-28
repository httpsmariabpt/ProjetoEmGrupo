namespace projeto.Models
{
    public class Veterinario
    {
        public Guid VeterinarioId { get; set; }

        public string Nome { get; set; }

        public string CRMV { get; set; }

        public string Celular { get; set; }

        public Guid EspecialidadeId { get; set; }

        public Especialidade? Especialidade { get; set; }

    }
}
