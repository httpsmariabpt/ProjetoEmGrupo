using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class Animal
    {
        [Key]
        public Guid AnimalId { get; set; }

        public string Nome {  get; set; }

        public string Sexo { get; set; }

        [Display(Name = "Especie")]
        public string Especie { get; set; }

        public string Raca { get; set; }

        public int Idade { get; set; }

        public int Peso { get; set; }

        public string Observacao { get; set; }

        [Display(Name = "É Castrado?")]
        public bool Ecastrado { get; set; }
    }
}
