using BrainyTrainy.Domain;
using BrainyTrainy.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BrainyTrainy.Data
{
    public class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : class
    {
        protected BrainyTrainyContext DbContext { get; }

        public BaseRepository(BrainyTrainyContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<TEntity> Get(TId id)
        {
            return await DbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetByPredicate(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbContext.Set<TEntity>().Where(predicate).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbContext.Set<TEntity>().ToListAsync();
        }

        public async Task Add(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await DbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException(nameof(entities));

            await DbContext.Set<TEntity>().AddRangeAsync(entities);
        }

        public async Task Remove(TId id)
        {
            TEntity entity = await DbContext.Set<TEntity>().FindAsync(id);

            if (entity != null)
                DbContext.Set<TEntity>().Remove(entity);
        }
    }
}