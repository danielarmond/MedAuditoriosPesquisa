using MedAuditoriosPesquisa.Models.Enums;
using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Mappings
{
    public class StatusPrimarioMap : IEntityTypeConfiguration<StatusPrimario>
    {
        public void Configure(EntityTypeBuilder<StatusPrimario> builder)
        {
            builder.Property(p => p.Nome).HasColumnType("Varchar(100)").IsRequired();

            builder.HasData(
                new StatusPrimario(1,"Aguardando Retorno do Local"),
                new StatusPrimario(2,"Aguardando Visita"),
                new StatusPrimario(3,"Aprovado sem Restrições"),
                new StatusPrimario(4,"Aprovado com Restrições"),
                new StatusPrimario(5,"Backup"),
                new StatusPrimario(6,"Banco de Dados"),
                new StatusPrimario(7,"Lista restrita"),
                new StatusPrimario(8,"Contato Sem Sucesso"),
                new StatusPrimario(9,"Local Atual"),
                new StatusPrimario(10,"Local Potencial"),
                new StatusPrimario(11,"Não Aluga"),
                new StatusPrimario(12,"Não Existe na Cidade"),
                new StatusPrimario(13,"Não Possui Auditório"),
                new StatusPrimario(14,"Reprovado"),
                new StatusPrimario(15,"Sem Contato")

                );
            {
            }
        }
    }
}
