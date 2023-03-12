using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class Filial
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Filial")]
        public string Nome { get; set; }
    }
}
