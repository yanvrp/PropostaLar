using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPI.Migrations
{
    /// <inheritdoc />
    public partial class VinculoTelefonePessoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaID",
                table: "Telefones",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaID",
                table: "Telefones",
                column: "PessoaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones",
                column: "PessoaID",
                principalTable: "Pessoas",
                principalColumn: "PessoaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_PessoaID",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "PessoaID",
                table: "Telefones");
        }
    }
}
