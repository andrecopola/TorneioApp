using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AlterarStatusTorneio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finalizado",
                table: "Torneios");

            migrationBuilder.AddColumn<int>(
                name: "StatusTorneio",
                table: "Torneios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusTorneio",
                table: "Torneios");

            migrationBuilder.AddColumn<bool>(
                name: "Finalizado",
                table: "Torneios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
