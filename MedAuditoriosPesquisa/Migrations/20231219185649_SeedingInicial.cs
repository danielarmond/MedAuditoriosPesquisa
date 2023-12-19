using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedAuditoriosPesquisa.Migrations
{
    public partial class SeedingInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Local",
                columns: new[] { "Id", "Capacidade", "DataInteracao", "EmailContato", "FilialId", "LinkVisita", "Nome", "NomeContato", "Observacao", "PeDireito", "StatusPrimarioId", "StatusSecundarioId", "TelefoneContato", "TipoCadeira", "UrlImagem" },
                values: new object[,]
                {
                    { 1, 400, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jorge@jorge.com.br", 1, "https://trello.com/", "Colégio CRA", "Jorge", "Ótimo local", 5, 1, 1, 21, 2, "https://conceitos.com/wp-content/uploads/cultura/Auditorio.jpg" },
                    { 2, 200, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura@laura.com.br", 2, "https://trello.com/", "Hotel Golden Tulip", "Laura", "Péssimo local", 4, 2, 2, 21, 3, "https://www.proacustica.org.br/assets/images/Publicacoes/Cases/AuditorioCNC_001.jpg" },
                    { 3, 350, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "antônio@antônio.com.br", 3, "https://trello.com/", "Colégio Batista", "Antônio", "Achei feio.", 5, 3, 3, 251, 2, "https://www.univates.br/eventos//media/alugue/auditorios/aud_7_01.jpg" },
                    { 4, 700, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "malaquias@malaquias.com.br", 4, "https://trello.com/", "Teatro Morumbi", "Malaquias", "Perfeito. Aprovado pra tudo.", 8, 4, 4, 21, 0, "https://ama-al.com.br/wp-content/uploads/2021/09/MK36029-2.jpg" },
                    { 5, 200, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ramses@silva.com.br", 5, "https://trello.com/", "Cinema Carioca", "Ramses", "Ótimo local", 3, 5, 5, 21, 2, "https://images.adsttc.com/media/images/5f7d/feb4/63c0/1772/3f00/0340/slideshow/Marcus_Wend_3.jpg?1602092715" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Local",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Local",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Local",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Local",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Local",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
