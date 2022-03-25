using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TorneioApp.Models
{
    public class Partida
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public short NumeroPartida { get; set; } = 0;

        public Jogador JogadorBrancas { get; set; } = new Jogador();

        public Jogador JogadorNegras { get; set; } = new Jogador();

        public ResultadoPartida ResultadoPartida { get; set; } = 0;

        public Torneio Torneio { get; set; } = new Torneio();
    }

    public enum ResultadoPartida
    {
        NaoIniciado = 0,
        EmAndamento = 1,
        Empate = 2,
        VitoriaBrancas = 3,
        VitoriaNegras = 4,
        Cancelado = 5
    }
}