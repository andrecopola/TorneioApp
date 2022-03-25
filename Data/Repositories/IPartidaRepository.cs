using TorneioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TorneioApp.Repositories
{
    public interface IPartidaRepository : IRepository<Partida>
    {
        IEnumerable<Partida> ObterPartidasComJogadores();
    }
}
