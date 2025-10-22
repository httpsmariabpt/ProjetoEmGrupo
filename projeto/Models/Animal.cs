namespace projeto.Models
{
    public class Animal
    {
        public Guid AnimalId { get; set; }

        public string Nome {  get; set; }

        public string Tutor { get; set; }

        public string Sexo { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public int Idade { get; set; }

        public int Peso { get; set; }

        public string Observacao { get; set; }

        public bool Ecastrado { get; set; }
    }
}
