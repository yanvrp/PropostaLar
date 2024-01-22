using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPI.Migrations
{
    /// <inheritdoc />
    public partial class VinculoTelefonePessoas4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaID",
                table: "Telefones",
                type: "int",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones",
                column: "PessoaID",
                principalTable: "Pessoas",
                principalColumn: "PessoaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaID",
                table: "Telefones",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones",
                column: "PessoaID",
                principalTable: "Pessoas",
                principalColumn: "PessoaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
