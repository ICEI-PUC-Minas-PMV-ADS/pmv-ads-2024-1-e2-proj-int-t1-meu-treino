using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndMeutreino.Models
{

    [Table("avaliacao")]
    public class Avaliacao
    {

        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "id")]
        public int id { get; set; }

        [Column("id_usuario")]
        [Display(Name = "id_usuario")]
        public int idUsuario { get; set; }
        public Usuario usuario { get; set; }

        [Column("id_exercicio")]
        [Display(Name = "id_exercicio")]
        public int idExercicio { get; set; }
        public Exercicio exercicio { get; set; }

        [Column("avaliacao")]
        [Display(Name = "avaliacao")]
        public int avaliacao { get; set; }
    }
}
