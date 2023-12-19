using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedAuditoriosPesquisa.Migrations
{
    public partial class InclusaoDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuario",
                type: "Varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "StatusSecundario",
                type: "Varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "StatusPrimario",
                type: "Varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Local",
                type: "Varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Filial",
                type: "Varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Filial",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filial",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filial",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Filial",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Filial",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StatusPrimario",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StatusSecundario",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "StatusSecundario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "StatusPrimario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Local",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Filial",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
