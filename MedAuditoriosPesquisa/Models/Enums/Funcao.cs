using System.ComponentModel;

namespace MedAuditoriosPesquisa.Models.Enums
{
    public enum Funcao
    {
        [Description("Usuário")]
        Usuario,

        [Description("Gestor")]
        Gestor,

        [Description("Administrador")]
        Administrador
    }
}
