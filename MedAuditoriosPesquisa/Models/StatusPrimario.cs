using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class StatusPrimario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Status Primário")]
        public string Nome { get; set; }
    }
}
