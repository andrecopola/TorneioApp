using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AdicionarDuracaoPartida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Acrescimo",
                table: "Torneios",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Duracao",
                table: "Torneios",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<short>(
                name: "Rating",
                table: "Jogadores",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acrescimo",
                table: "Torneios");

            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Torneios");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Jogadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
