using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AlterarStatusPartida2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Jogadores_JogadorBrancasId",
                table: "Partida");

            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Jogadores_JogadorNegrasId",
                table: "Partida");

            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Torneios_TorneioId",
                table: "Partida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partida",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "Finalizada",
                table: "Partida");

            migrationBuilder.RenameTable(
                name: "Partida",
                newName: "Partidas");

            migrationBuilder.RenameIndex(
                name: "IX_Partida_TorneioId",
                table: "Partidas",
                newName: "IX_Partidas_TorneioId");

            migrationBuilder.RenameIndex(
                name: "IX_Partida_JogadorNegrasId",
                table: "Partidas",
                newName: "IX_Partidas_JogadorNegrasId");

            migrationBuilder.RenameIndex(
                name: "IX_Partida_JogadorBrancasId",
                table: "Partidas",
                newName: "IX_Partidas_JogadorBrancasId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partidas",
                table: "Partidas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Partidas_Jogadores_JogadorBrancasId",
                table: "Partidas",
                column: "JogadorBrancasId",
                principalTable: "Jogadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidas_Jogadores_JogadorNegrasId",
                table: "Partidas",
                column: "JogadorNegrasId",
                principalTable: "Jogadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidas_Torneios_TorneioId",
                table: "Partidas",
                column: "TorneioId",
                principalTable: "Torneios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partidas_Jogadores_JogadorBrancasId",
                table: "Partidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidas_Jogadores_JogadorNegrasId",
                table: "Partidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidas_Torneios_TorneioId",
                table: "Partidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partidas",
                table: "Partidas");

            migrationBuilder.RenameTable(
                name: "Partidas",
                newName: "Partida");

            migrationBuilder.RenameIndex(
                name: "IX_Partidas_TorneioId",
                table: "Partida",
                newName: "IX_Partida_TorneioId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidas_JogadorNegrasId",
                table: "Partida",
                newName: "IX_Partida_JogadorNegrasId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidas_JogadorBrancasId",
                table: "Partida",
                newName: "IX_Partida_JogadorBrancasId");

            migrationBuilder.AddColumn<bool>(
                name: "Finalizada",
                table: "Partida",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partida",
                table: "Partida",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Jogadores_JogadorBrancasId",
                table: "Partida",
                column: "JogadorBrancasId",
                principalTable: "Jogadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Jogadores_JogadorNegrasId",
                table: "Partida",
                column: "JogadorNegrasId",
                principalTable: "Jogadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Torneios_TorneioId",
                table: "Partida",
                column: "TorneioId",
                principalTable: "Torneios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
