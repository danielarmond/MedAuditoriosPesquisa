namespace MedAuditoriosPesquisa.Models.ViewModels
{
    public class LocalFormViewModel
    {
        public Local Local { get; set; }
        public ICollection<StatusPrimario> StatusPrimarios { get; set; }
        public ICollection<StatusSecundario> StatusSecundarios { get; set; }
        public ICollection<Contato> Contatos { get; set; }
        public ICollection<Filial> Filiais { get; set; }

    }
}
