using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Mappings
{
    public class FilialMap : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.Property(p => p.Nome).HasColumnType("Varchar(100)").IsRequired();

            builder.HasData(
                new Filial(1, "Belo Horizonte (MG)"),
                new Filial(2, "São Paulo (SP)"),
                new Filial(3, "Rio de Janeiro (RJ)"),
                new Filial(4, "Salvador (BA)"),
                new Filial(5, "Porto Alegre (RS)"));


    }
    }
}
