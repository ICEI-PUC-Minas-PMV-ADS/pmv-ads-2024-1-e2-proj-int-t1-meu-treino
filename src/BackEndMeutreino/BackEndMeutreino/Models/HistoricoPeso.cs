using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndMeutreino.Models
{
    [Table("historico_peso")]   
    public class HistoricoPeso
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "id")]
        public int id { get; set; }

        [Column("id_usuario")]
        [Display(Name = "id_usuario")]
        public int idUsuario { get; set; }
        public Usuario usuario { get; set; }

        [Column("peso")]
        [Display(Name = "peso")]
        public double peso { get; set; }

        [Column("data")]
        [Display(Name = "data")]
        public string data { get; set; }    
    }
}
