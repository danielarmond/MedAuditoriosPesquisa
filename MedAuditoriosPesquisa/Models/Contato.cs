namespace MedAuditoriosPesquisa.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int telefone { get; set; }
        public string Email { get; set; }

        public Contato() { }

        public Contato(string nome, int telefone, string email)
        {
            Nome = nome;
            this.telefone = telefone;
            Email = email;
        }
    }    
}
