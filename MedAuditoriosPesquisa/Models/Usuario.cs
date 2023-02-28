using MedAuditoriosPesquisa.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Função")]
        public Funcao Funcao { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
