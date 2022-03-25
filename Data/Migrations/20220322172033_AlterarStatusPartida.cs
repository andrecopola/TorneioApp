using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AlterarStatusPartida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScoreJogadorBrancas",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "ScoreJogadorNegras",
                table: "Partida");

            migrationBuilder.AddColumn<int>(
                name: "StatusPartida",
                table: "Partida",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusPartida",
                table: "Partida");

            migrationBuilder.AddColumn<decimal>(
                name: "ScoreJogadorBrancas",
                table: "Partida",
                type: "decimal(2,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ScoreJogadorNegras",
                table: "Partida",
                type: "decimal(2,1)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
