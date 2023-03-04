using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using System.Xml.Linq;


namespace MedAuditoriosPesquisa.Models.Enums
{
    public enum TipoCadeira
    {
        [Display(Name ="Acolchoada com prancheta")]
        AcolchoadaComPrancheta,

        [Display(Name = "Acolchoada com mesa")]
        AcolchoadaComMesa,

        [Display(Name = "Acolchoada com braço")]
        AcolchoadaComBraco,

        [Display(Name = "Acolchoada sem apoio")]
        AcolchoadaSemApoio,

        [Display(Name = "Semi ou Não acolchoada com prancheta")]
        SemiOuNaoAcolchoadaComPrancheta,

        [Display(Name = "Semi ou Não acolchoada com mesa")]
        SemiOuNaoAcolchoadaComMesa,

        [Display(Name = "Semi ou Não acolchoada com braço")]
        SemiOuNaoAcolchoadaComBraco,

        [Display(Name = "Semi ou Não acolchoada sem apoio")]
        SemiOuNaoAcolchoadaSemApoio,

        [Display(Name = "Não informado")]
        NaoInformado,

        [Display(Name = "Não possui")]
        NaoPossui
    }
}
