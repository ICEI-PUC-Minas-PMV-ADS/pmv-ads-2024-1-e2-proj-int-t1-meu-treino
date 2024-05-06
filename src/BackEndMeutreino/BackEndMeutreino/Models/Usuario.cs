using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndMeutreino.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "id")]
        public int id { get; set; }

        [Column("nome")]
        [Display(Name = "nome")]
        public string nome { get; set; }

        [Column("email")]
        [Display(Name = "email")]
        public string email { get; set;}

        [Column("senha")]
        [Display(Name = "senha")]
        public string senha { get; set;}

        [Column("role")]
        [Display(Name = "role")]
        public string? role { get; set; } = "user";

        [Column("altura")]
        [Display(Name = "altura")]
        public double altura { get; set; }

        [Column("peso")]
        [Display(Name = "peso")]
        public double peso { get; set; }

        public ICollection<Favoritos> Favoritos { get; } = new List<Favoritos>();
        public ICollection<Avaliacao> Avaliacao { get; } = new List<Avaliacao>();

        public ICollection<HistoricoPeso> HistoricoPeso { get; } = new List<HistoricoPeso>();

    }
}
