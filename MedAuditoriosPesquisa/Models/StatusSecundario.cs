using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class StatusSecundario
    {
        [Key]
        [Required]
        public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
}
}
