using MedAuditoriosPesquisa.Models.Enums;

namespace MedAuditoriosPesquisa.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Funcao Funcao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
