using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Mappings
{
    public class StatusSecundarioMap : IEntityTypeConfiguration<StatusSecundario>
    {
        public void Configure(EntityTypeBuilder<StatusSecundario> builder)
        {
            builder.Property(p => p.Nome).HasColumnType("Varchar(100)").IsRequired();

            builder.HasData(
                new StatusSecundario(1,"Reprovado Capacidade"),
                new StatusSecundario(2,"Acessibilidade"),
                new StatusSecundario(3,"Capacidade"),
                new StatusSecundario(4,"Infraestrutura"),
                new StatusSecundario(5,"Localização / Segurança"),
                new StatusSecundario(6,"Não Atende"),
                new StatusSecundario(7,"Ocupado"),
                new StatusSecundario(8,"Responsável Não Está"),
                new StatusSecundario(9,"Telefone Errado / FAX")

                );
            {
            }
        }
    }
}