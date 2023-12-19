using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedAuditoriosPesquisa.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(p => p.Nome).HasColumnType("Varchar(100)").IsRequired();

            builder.HasData(
                new Usuario(1,"Daniel Armond", Funcao.Administrador, "daniel.armond@rmedcursosmedicos.com.br", "root"),
                new Usuario(2,"Aline Inojosa", Funcao.Gestor, "aline.inojosa@rmedcursosmedicos.com.br", "medaline123"),
                new Usuario(3,"João Gomes", Funcao.Auxiliar, "joao.gomes@rmedcursosmedicos.com.br", "medjoao123"),
                new Usuario(4,"Michele Bhering", Funcao.Gestor, "michele.bhering@rmedcursosmedicos.com.br", "medmichele123"),
                new Usuario(5,"Alana Nascimento", Funcao.Gestor, "alana.nascimento@rmedcursosmedicos.com.br", "medalana123")
                ) ;
        }
    }
}
