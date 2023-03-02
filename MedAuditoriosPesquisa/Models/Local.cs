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
        [Required]
        [Display(Name = "Status Primário")]
        public StatusPrimario StatusPrimario { get; set; }
        [Required]
        public int StatusPrimarioId { get; set; }
        [Required]
        [Display(Name = "Status Secundário")]
        public StatusSecundario StatusSecundario { get; set; }
        [Required]
        public int StatusSecundarioId { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        [Display(Name = "Link da Visita")]
        [DataType(DataType.Url)]
        public string LinkVisita { get; set; }
        [Display(Name = "Imagem")]
        public string UrlImagem  {get; set; }

    public Local()
        {
        }

        public Local(string filial, string nome, DateTime dataInteracao, int capacidade, int peDireito, 
            TipoCadeira tipoCadeira, StatusPrimario statusPrimario, StatusSecundario statusSecundario, 
            string observacao, string linkVisita, string urlImagem)
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
        }
    }
}
