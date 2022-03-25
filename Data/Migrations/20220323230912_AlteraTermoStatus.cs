using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AlteraTermoStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusTorneio",
                table: "Torneios",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Torneios",
                newName: "StatusTorneio");
        }
    }
}
