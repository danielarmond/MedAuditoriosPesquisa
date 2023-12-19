using MedAuditoriosPesquisa.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MedAuditoriosPesquisa.Models
{
    public class Local
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Filial? Filial { get; set; }
        [Required]
        [Display(Name = "Filial")]
        public int FilialId { get; set; }
        [Required]
        [Display(Name = "Local")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Data da Interação")]
        [DataType(DataType.Date)]
        public DateTime DataInteracao { get; set; }
        public int Capacidade { get; set; }
        [Display(Name = "Pé Direito")]
        public int PeDireito { get; set; }
        [Display(Name = "Tipo de Cadeira")]
        public TipoCadeira TipoCadeira { get; set; }
        [Display(Name = "Status Primário")]
        public StatusPrimario? StatusPrimario { get; set; }
        [Required]
        public int StatusPrimarioId { get; set; }
        [Display(Name = "Status Secundário")]
        public StatusSecundario? StatusSecundario { get; set; }
        [Required]
        public int StatusSecundarioId { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        [Display(Name = "Link da Visita")]
        [DataType(DataType.Url)]
        public string LinkVisita { get; set; }
        [Display(Name = "Imagem")]
        public string UrlImagem  {get; set; }
        [Display(Name = "Nome Contato")]
        public string NomeContato { get; set; }
        [Display(Name = "Telefone Contato")]
        public int TelefoneContato { get; set; }
        [Display(Name = "Email Contato")]
        public string EmailContato { get; set; }

        public Local()
        {
        }

        public Local(Filial filial, string nome, DateTime dataInteracao, int capacidade, int peDireito, 
            TipoCadeira tipoCadeira, StatusPrimario statusPrimario, StatusSecundario statusSecundario, 
            string observacao, string linkVisita, string urlImagem, string nomeContato, int telefoneContato, string emailContato)
        {
            Filial = filial;
            Nome = nome;
            DataInteracao = dataInteracao;
            Capacidade = capacidade;
            PeDireito = peDireito;
            TipoCadeira = tipoCadeira;
            StatusPrimario = statusPrimario;
            StatusSecundario = statusSecundario;
            Observacao = observacao;
            LinkVisita = linkVisita;
            UrlImagem = urlImagem;
            NomeContato = nomeContato;
            TelefoneContato = telefoneContato;
            EmailContato = emailContato;
        }

        public Local(int id, Filial filial, string nome, DateTime dataInteracao, int capacidade, int peDireito,
            TipoCadeira tipoCadeira, StatusPrimario statusPrimario, StatusSecundario statusSecundario,
            string observacao, string linkVisita, string urlImagem, string nomeContato, int telefoneContato, string emailContato)
        {
            Id = id;
            Filial = filial;
            Nome = nome;
            DataInteracao = dataInteracao;
            Capacidade = capacidade;
            PeDireito = peDireito;
            TipoCadeira = tipoCadeira;
            StatusPrimario = statusPrimario;
            StatusSecundario = statusSecundario;
            Observacao = observacao;
            LinkVisita = linkVisita;
            UrlImagem = urlImagem;
            NomeContato = nomeContato;
            TelefoneContato = telefoneContato;
            EmailContato = emailContato;
        }
    }
}
