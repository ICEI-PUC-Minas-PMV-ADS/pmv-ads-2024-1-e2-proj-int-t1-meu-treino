using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndMeutreino.Models
{

    [Table("favoritos")]
    public class Favoritos
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "id")]
        public int id { get; set; }

        [Column("id_usuario")]
        public int idUsuario { get; set; }
        public Usuario usuario { get; set; }

        [Column("id_exercicio")]
        public int idExercicio { get; set; }
        public Exercicio exercicio { get; set; }
    }
}
