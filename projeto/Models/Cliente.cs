namespace projeto.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public Guid AnimalId { get; set; }
        public Animal Animal { get; set; }
        public string CPF { get; set; }
        public string DataNasc { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
    }
}