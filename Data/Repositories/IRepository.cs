using System.Linq.Expressions;

namespace TorneioApp.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        void Alterar(TEntity entity);
        void Adicionar(TEntity entity);
        void Remover(TEntity entity);
        void AdicionarVarios(TEntity[] entityList);
        void RemoverVarios(TEntity[] entityList);
        void Atualizar(TEntity entity);
    }
}
