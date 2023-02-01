using System.ComponentModel;

namespace MedAuditoriosPesquisa.Models.Enums
{
    public enum StatusPrimario
    {
        [Description("Aguardando Retorno do Local")]
        AguardandoRetornodoLocal,

        [Description("Aguardando Visita")]
        AguardandoVisita,

        [Description("Aprovado sem Restrições")]
        AprovadoSemRestrições,

        [Description("Aprovado com Restrições")]
        AprovadoComRestrições,

        [Description("Backup")]
        Backup,

        [Description("Banco de Dados")]
        BancoDeDados,

        [Description("Lista restrita")]
        ListaRestrita,

        [Description("Contato Sem Sucesso")]
        ContatoSemSucesso,

        [Description("Local Atual")]
        LocalAtual,

        [Description("Local Potencial")]
        LocalPotencial,

        [Description("Não Aluga")]
        NaoAluga,

        [Description("Não Existe na Cidade")]
        NaoExisteNaCidade,

        [Description("Não Possui Auditório")]
        NaoPossuiAuditório,

        [Description("Reprovado")]
        Reprovado,

        [Description("Sem Contato")]
        SemContato

    }
}
