using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedAuditoriosPesquisa.Migrations
{
    public partial class IncluindoTabelasDeStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusSecundario",
                table: "Local",
                newName: "StatusSecundarioId");

            migrationBuilder.RenameColumn(
                name: "StatusPrimario",
                table: "Local",
                newName: "StatusPrimarioId");

            migrationBuilder.CreateTable(
                name: "StatusPrimario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPrimario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatusSecundario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSecundario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Local_StatusPrimarioId",
                table: "Local",
                column: "StatusPrimarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Local_StatusSecundarioId",
                table: "Local",
                column: "StatusSecundarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Local_StatusPrimario_StatusPrimarioId",
                table: "Local",
                column: "StatusPrimarioId",
                principalTable: "StatusPrimario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Local_StatusSecundario_StatusSecundarioId",
                table: "Local",
                column: "StatusSecundarioId",
                principalTable: "StatusSecundario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Local_StatusPrimario_StatusPrimarioId",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Local_StatusSecundario_StatusSecundarioId",
                table: "Local");

            migrationBuilder.DropTable(
                name: "StatusPrimario");

            migrationBuilder.DropTable(
                name: "StatusSecundario");

            migrationBuilder.DropIndex(
                name: "IX_Local_StatusPrimarioId",
                table: "Local");

            migrationBuilder.DropIndex(
                name: "IX_Local_StatusSecundarioId",
                table: "Local");

            migrationBuilder.RenameColumn(
                name: "StatusSecundarioId",
                table: "Local",
                newName: "StatusSecundario");

            migrationBuilder.RenameColumn(
                name: "StatusPrimarioId",
                table: "Local",
                newName: "StatusPrimario");
        }
    }
}
