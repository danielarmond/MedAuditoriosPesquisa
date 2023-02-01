using System.ComponentModel;

namespace MedAuditoriosPesquisa.Models.Enums
{
    public enum StatusSecundario
    {
        [Description("Acessibilidade")]
        Acessibilidade,

        [Description("Capacidade")]
        Capacidade,

        [Description("Infraestrutura")]
        Infraestrutura,

        [Description("Localização / Segurança")]
        LocalizaçãoSegurança,

        [Description("Não Atende")]
        NaoAtende,

        [Description("Ocupado")]
        Ocupado,

        [Description("Responsável Não Está")]
        ResponsavelNaoEsta,

        [Description("Telefone Errado / FAX")]
        TelefoneErradoFAX
    }
}
