using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AlteraResultadoPartida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusPartida",
                table: "Partidas",
                newName: "ResultadoPartida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResultadoPartida",
                table: "Partidas",
                newName: "StatusPartida");
        }
    }
}
