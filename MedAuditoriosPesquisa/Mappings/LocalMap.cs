using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Models.Enums;


namespace MedAuditoriosPesquisa.Mappings
{
    public class LocalMap : IEntityTypeConfiguration<Local>
    {


        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.Property(p => p.Nome).HasColumnType("Varchar(100)").IsRequired();

            builder.HasData(


             new Local
             {
                 Id = 1,
                 FilialId = 1,
                 Nome = "Colégio CRA",
                 DataInteracao = new DateTime(2023, 2, 20),
                 Capacidade = 400,
                 PeDireito = 5,
                 TipoCadeira = TipoCadeira.AcolchoadaComBraco,
                 StatusPrimarioId = 1,
                 StatusSecundarioId = 1,
                 Observacao = "Ótimo local",
                 LinkVisita = "https://trello.com/",
                 UrlImagem = "https://conceitos.com/wp-content/uploads/cultura/Auditorio.jpg",
                 NomeContato = "Jorge",
                 TelefoneContato = 21,
                 EmailContato = "jorge@jorge.com.br"
             },

             new Local
             {
                 Id = 2,
                 FilialId = 2,
                 Nome = "Hotel Golden Tulip",
                 DataInteracao = new DateTime(2023, 2, 10),
                 Capacidade = 200,
                 PeDireito = 4,
                 TipoCadeira = TipoCadeira.AcolchoadaSemApoio,
                 StatusPrimarioId = 2,
                 StatusSecundarioId = 2,
                 Observacao = "Péssimo local",
                 LinkVisita = "https://trello.com/",
                 UrlImagem = "https://www.proacustica.org.br/assets/images/Publicacoes/Cases/AuditorioCNC_001.jpg",
                 NomeContato = "Laura",
                 TelefoneContato = 21,
                 EmailContato = "laura@laura.com.br"
             },

             new Local
             {
                 Id = 3,
                 FilialId = 3,
                 Nome = "Colégio Batista",
                 DataInteracao = new DateTime(2023, 5, 30),
                 Capacidade = 350,
                 PeDireito = 5,
                 TipoCadeira = TipoCadeira.AcolchoadaComBraco,
                 StatusPrimarioId = 3,
                 StatusSecundarioId = 3,
                 Observacao = "Achei feio.",
                 LinkVisita = "https://trello.com/",
                 UrlImagem = "https://www.univates.br/eventos//media/alugue/auditorios/aud_7_01.jpg",
                 NomeContato = "Antônio",
                 TelefoneContato = 251,
                 EmailContato = "antônio@antônio.com.br"
             },

             new Local
             {
                 Id = 4,
                 FilialId = 4,
                 Nome = "Teatro Morumbi",
                 DataInteracao = new DateTime(2023, 11, 12),
                 Capacidade = 700,
                 PeDireito = 8,
                 TipoCadeira = TipoCadeira.AcolchoadaComPrancheta,
                 StatusPrimarioId = 4,
                 StatusSecundarioId = 4,
                 Observacao = "Perfeito. Aprovado pra tudo.",
                 LinkVisita = "https://trello.com/",
                 UrlImagem = "https://ama-al.com.br/wp-content/uploads/2021/09/MK36029-2.jpg",
                 NomeContato = "Malaquias",
                 TelefoneContato = 21,
                 EmailContato = "malaquias@malaquias.com.br"
             },

             new Local
             {
                 Id = 5,
                 FilialId = 5,
                 Nome = "Cinema Carioca",
                 DataInteracao = new DateTime(2023, 5, 25),
                 Capacidade = 200,
                 PeDireito = 3,
                 TipoCadeira = TipoCadeira.AcolchoadaComBraco,
                 StatusPrimarioId = 5,
                 StatusSecundarioId = 5,
                 Observacao = "Ótimo local",
                 LinkVisita = "https://trello.com/",
                 UrlImagem = "https://images.adsttc.com/media/images/5f7d/feb4/63c0/1772/3f00/0340/slideshow/Marcus_Wend_3.jpg?1602092715",
                 NomeContato = "Ramses",
                 TelefoneContato = 21,
                 EmailContato = "ramses@silva.com.br"
             });








        }
    }
}
