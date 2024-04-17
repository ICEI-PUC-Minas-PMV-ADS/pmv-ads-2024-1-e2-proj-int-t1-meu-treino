using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace BackEndMeutreino.Models
{
    [Table("exercicio")]
    public class Exercicio
    {

        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "id")]
        public int id { get; set; }

        [Column("nome")]
        [Display(Name = "nome")]
        public string nome { get; set; }

        [Column("descricao")]
        [Display(Name = "descricao")]
        public string descricao { get; set; }

        [Column("grupoMuscular")]
        [Display(Name = "grupoMuscular")]
        public string grupoMuscular { get; set; }

        [Column("imagem")]
        [Display(Name = "imagem")]
        public string imagem { get; set; }

        [Column("dificuldade")]
        [Display(Name = "dificuldade")]
        public int dificuldade { get; set; }

        public ICollection<Favoritos> Favoritos { get; } = new List<Favoritos>();
        public ICollection<Avaliacao> Avaliacoes { get; } = new List<Avaliacao>();
    }
}
