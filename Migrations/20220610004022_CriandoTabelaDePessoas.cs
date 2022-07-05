using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste_Londrina_SA.Migrations
{
    public partial class CriandoTabelaDePessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CadastroPessoa",
                table: "CadastroPessoa");

            migrationBuilder.RenameTable(
                name: "CadastroPessoa",
                newName: "pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pessoa",
                table: "pessoa",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_pessoa",
                table: "pessoa");

            migrationBuilder.RenameTable(
                name: "pessoa",
                newName: "CadastroPessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CadastroPessoa",
                table: "CadastroPessoa",
                column: "Id");
        }
    }
}
