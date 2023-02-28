using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class StatusSecundario
    {
        [Key]
        [Required]
        public int Id { get; set; }
    [Required]
        [Display(Name = "Status Secundário")]
        public string Nome { get; set; }
}
}
