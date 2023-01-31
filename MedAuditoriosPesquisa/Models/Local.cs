using MedAuditoriosPesquisa.Models.Enums;

namespace MedAuditoriosPesquisa.Models
{
    public class Local
    {
        public int Id { get; set; }
        public string Filial { get; set; }
        public string Nome { get; set; }
        public DateTime DataInteracao { get; set; }
        public int Capacidade { get; set; }
        public int PeDireito { get; set; }
        public TipoCadeira TipoCadeira { get; set; }
        public StatusPrimario StatusPrimario { get; set; }
        public StatusSecundario StatusSecundario { get; set; }
        public Contato Contato { get; set; }
        public string Observacao { get; set; }
        public string linkVisita { get; set; }

        public Local()
        {
        }

        public Local(string filial, string nome, DateTime dataInteracao, int capacidade, int peDireito, 
            TipoCadeira tipoCadeira, StatusPrimario statusPrimario, StatusSecundario statusSecundario, 
            Contato contato, string observacao, string linkVisita)
        {
            Filial = filial;
            Nome = nome;
            DataInteracao = dataInteracao;
            Capacidade = capacidade;
            PeDireito = peDireito;
            TipoCadeira = tipoCadeira;
            StatusPrimario = statusPrimario;
            StatusSecundario = statusSecundario;
            Contato = contato;
            Observacao = observacao;
            this.linkVisita = linkVisita;
        }
    }
}
