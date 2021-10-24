using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BrainyTrainy.Domain.Interfaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : class
    {
        Task<TEntity> Get(TId id);

        Task<List<TEntity>> GetByPredicate(Expression<Func<TEntity, bool>> condition);

        Task<IEnumerable<TEntity>> GetAll();

        Task Add(TEntity entity);

        Task AddRange(IEnumerable<TEntity> entities);

        Task Remove(TId id);
    }
}