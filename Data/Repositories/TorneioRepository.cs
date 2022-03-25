using Microsoft.EntityFrameworkCore;
using TorneioApp.Data;
using TorneioApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace TorneioApp.Repositories
{
    public class TorneioRepository : Repository<Torneio>, ITorneioRepository
    {
        public TorneioRepository(TorneioAppDbContext context) : base(context) { }

  
    }
}