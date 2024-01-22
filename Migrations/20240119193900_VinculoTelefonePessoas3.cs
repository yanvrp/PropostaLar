using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPI.Migrations
{
    /// <inheritdoc />
    public partial class VinculoTelefonePessoas3 : Migration
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
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PessoaAniversario",
                table: "Pessoas",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 12);

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

            migrationBuilder.AlterColumn<int>(
                name: "PessoaID",
                table: "Telefones",
                type: "int",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PessoaAniversario",
                table: "Pessoas",
                type: "datetime2",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaID",
                table: "Telefones",
                column: "PessoaID",
                principalTable: "Pessoas",
                principalColumn: "PessoaID");
        }
    }
}
