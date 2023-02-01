using System.ComponentModel;


namespace MedAuditoriosPesquisa.Models.Enums
{
    public enum TipoCadeira
    {
        [Description("Acolchoada com prancheta")]
        AcolchoadaComPrancheta,

        [Description("Acolchoada com mesa")]
        AcolchoadaComMesa,

        [Description("Acolchoada com braço")]
        AcolchoadaComBraco,

        [Description("Acolchoada sem apoio")]
        AcolchoadaSemApoio,

        [Description("Semi ou Não acolchoada com prancheta")]
        SemiOuNaoAcolchoadaComPrancheta,

        [Description("Semi ou Não acolchoada com mesa")]
        SemiOuNaoAcolchoadaComMesa,

        [Description("Semi ou Não acolchoada com braço")]
        SemiOuNaoAcolchoadaComBraco,

        [Description("Semi ou Não acolchoada sem apoio")]
        SemiOuNaoAcolchoadaSemApoio,

        [Description("Não informado")]
        NaoInformado,

        [Description("Não possui")]
        NaoPossui
    }
}
