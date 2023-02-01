using MedAuditoriosPesquisa.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class Local
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Filial { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataInteracao { get; set; }
        public int Capacidade { get; set; }
        public int PeDireito { get; set; }
        public TipoCadeira TipoCadeira { get; set; }
        [Required]
        public StatusPrimario StatusPrimario { get; set; }
        [Required]
        public StatusSecundario StatusSecundario { get; set; }
        public Contato Contato { get; set; }
        public string Observacao { get; set; }
        public string LinkVisita { get; set; }

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
            LinkVisita = linkVisita;
        }
    }
}
