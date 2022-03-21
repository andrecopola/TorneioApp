using System.ComponentModel.DataAnnotations;

namespace TorneioApp.Models
{
    public class Torneio
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        public List<Jogador> Jogadores { get; set; } = new List<Jogador>();
    }
}