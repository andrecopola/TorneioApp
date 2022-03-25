using Microsoft.EntityFrameworkCore;
using TorneioApp.Data;
using TorneioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace TorneioApp.Repositories
{
    public class PartidaRepository : Repository<Partida>, IPartidaRepository
    {
        public PartidaRepository(TorneioAppDbContext context) : base(context) { }

        public IEnumerable<Partida> ObterPartidasComJogadores()
        {
            return _context.Partidas
                .Include(p => p.JogadorBrancas)
                .Include(p => p.JogadorNegras)
                .Include(p => p.Torneio)
                .ToList();
        }
    }
}