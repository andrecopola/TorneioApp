using System.Data;
using System.Linq.Expressions;
using TorneioApp.Data;

namespace TorneioApp.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly TorneioAppDbContext _context;

        public Repository(TorneioAppDbContext context)
        {
            _context = context;
        }

        public TEntity ObterPorId(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public void Alterar(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public void Adicionar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Remover(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void AdicionarVarios(TEntity[] entityList)
        {
            _context.Set<TEntity>().AddRange(entityList);
        }

        public void RemoverVarios(TEntity[] entityList)
        {
            _context.Set<TEntity>().RemoveRange(entityList);
        }

        public void Atualizar(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
