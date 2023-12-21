using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedAuditoriosPesquisa.Migrations
{
    /// <inheritdoc />
    public partial class SeedingInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusPrimario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPrimario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusSecundario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSecundario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Funcao = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false),
                    DataInteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    PeDireito = table.Column<int>(type: "int", nullable: false),
                    TipoCadeira = table.Column<int>(type: "int", nullable: false),
                    StatusPrimarioId = table.Column<int>(type: "int", nullable: false),
                    StatusSecundarioId = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkVisita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeContato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefoneContato = table.Column<int>(type: "int", nullable: false),
                    EmailContato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Local_Filial_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Local_StatusPrimario_StatusPrimarioId",
                        column: x => x.StatusPrimarioId,
                        principalTable: "StatusPrimario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Local_StatusSecundario_StatusSecundarioId",
                        column: x => x.StatusSecundarioId,
                        principalTable: "StatusSecundario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Filial",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Belo Horizonte (MG)" },
                    { 2, "São Paulo (SP)" },
                    { 3, "Rio de Janeiro (RJ)" },
                    { 4, "Salvador (BA)" },
                    { 5, "Porto Alegre (RS)" }
                });

            migrationBuilder.InsertData(
                table: "StatusPrimario",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Aguardando Retorno do Local" },
                    { 2, "Aguardando Visita" },
                    { 3, "Aprovado sem Restrições" },
                    { 4, "Aprovado com Restrições" },
                    { 5, "Backup" },
                    { 6, "Banco de Dados" },
                    { 7, "Lista restrita" },
                    { 8, "Contato Sem Sucesso" },
                    { 9, "Local Atual" },
                    { 10, "Local Potencial" },
                    { 11, "Não Aluga" },
                    { 12, "Não Existe na Cidade" },
                    { 13, "Não Possui Auditório" },
                    { 14, "Reprovado" },
                    { 15, "Sem Contato" }
                });

            migrationBuilder.InsertData(
                table: "StatusSecundario",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Reprovado Capacidade" },
                    { 2, "Acessibilidade" },
                    { 3, "Capacidade" },
                    { 4, "Infraestrutura" },
                    { 5, "Localização / Segurança" },
                    { 6, "Não Atende" },
                    { 7, "Ocupado" },
                    { 8, "Responsável Não Está" },
                    { 9, "Telefone Errado / FAX" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Email", "Funcao", "Nome", "Senha" },
                values: new object[,]
                {
                    { 1, "daniel.armond@rmedcursosmedicos.com.br", 2, "Daniel Armond", "root" },
                    { 2, "aline.inojosa@rmedcursosmedicos.com.br", 1, "Aline Inojosa", "medaline123" },
                    { 3, "joao.gomes@rmedcursosmedicos.com.br", 0, "João Gomes", "medjoao123" },
                    { 4, "michele.bhering@rmedcursosmedicos.com.br", 1, "Michele Bhering", "medmichele123" },
                    { 5, "alana.nascimento@rmedcursosmedicos.com.br", 1, "Alana Nascimento", "medalana123" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Local_FilialId",
                table: "Local",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Local_StatusPrimarioId",
                table: "Local",
                column: "StatusPrimarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Local_StatusSecundarioId",
                table: "Local",
                column: "StatusSecundarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Filial");

            migrationBuilder.DropTable(
                name: "StatusPrimario");

            migrationBuilder.DropTable(
                name: "StatusSecundario");
        }
    }
}
