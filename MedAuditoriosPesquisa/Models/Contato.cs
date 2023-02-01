using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class Contato
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }

        public Contato() { }

        public Contato(string nome, int telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }    
}
