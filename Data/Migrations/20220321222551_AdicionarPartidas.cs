using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApp.Migrations
{
    public partial class AdicionarPartidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finalizado",
                table: "Torneios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JogadorBrancasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JogadorNegrasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScoreJogadorBrancas = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    ScoreJogadorNegras = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    TorneioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Finalizada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partida_Jogadores_JogadorBrancasId",
                        column: x => x.JogadorBrancasId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Partida_Jogadores_JogadorNegrasId",
                        column: x => x.JogadorNegrasId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Partida_Torneios_TorneioId",
                        column: x => x.TorneioId,
                        principalTable: "Torneios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partida_JogadorBrancasId",
                table: "Partida",
                column: "JogadorBrancasId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_JogadorNegrasId",
                table: "Partida",
                column: "JogadorNegrasId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_TorneioId",
                table: "Partida",
                column: "TorneioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropColumn(
                name: "Finalizado",
                table: "Torneios");
        }
    }
}
