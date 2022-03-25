using Microsoft.EntityFrameworkCore;
using TorneioApp.Models;

namespace TorneioApp.Data
{
    public class TorneioAppDbContext : DbContext
    {
        public TorneioAppDbContext(DbContextOptions<TorneioAppDbContext> options) : base(options) { }

        public DbSet<Torneio> Torneios { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Partida> Partidas { get; set; }
    }
}
