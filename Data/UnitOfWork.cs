using TorneioApp.Data;
using TorneioApp.Repositories;

namespace TorneioApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TorneioAppDbContext _context;

        public UnitOfWork(TorneioAppDbContext context)
        {
            _context = context;
            Torneios = new TorneioRepository(_context);
            Jogadores = new JogadorRepository(_context);
            Partidas = new PartidaRepository(_context);
        }

        public ITorneioRepository Torneios { get; private set; }
        public IJogadorRepository Jogadores { get; private set; }
        public IPartidaRepository Partidas { get; private set; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
