using System.ComponentModel.DataAnnotations;

namespace TorneioApp.Models
{
    public class Torneio
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime Data { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        public byte Duracao { get; set; } = 15;

        public byte Acrescimo { get; set; } = 10;

        public List<Jogador> Jogadores { get; set; } = new List<Jogador>();

        public List<Partida> Partidas { get; set; } = new List<Partida>();

        public Status Status { get; set; } = 0;
    }

    public enum Status
    {
       NaoIniciado = 0,
       EmAndamento = 1,
       Encerrado = 2
    }
}