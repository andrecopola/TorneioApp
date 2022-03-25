using Microsoft.EntityFrameworkCore;
using TorneioApp.Data;
using TorneioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace TorneioApp.Repositories
{
    public class JogadorRepository : Repository<Jogador>, IJogadorRepository
    {
        public JogadorRepository(TorneioAppDbContext context) : base(context) { }


    }
}
