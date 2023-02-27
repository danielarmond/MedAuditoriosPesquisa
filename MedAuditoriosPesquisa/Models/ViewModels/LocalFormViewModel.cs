namespace MedAuditoriosPesquisa.Models.ViewModels
{
    public class LocalFormViewModel
    {
        public Local Local { get; set; }
        public ICollection<StatusPrimario> StatusPrimarios { get; set; }
        public ICollection<StatusSecundario> StatusSecundarios { get; set; }
    }
}
