using System.ComponentModel.DataAnnotations;

namespace TorneioApp.Models
{
    public class Jogador
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; } = string.Empty;

        public List<Torneio> Torneios { get; set; } = new List<Torneio>();
    }
}
