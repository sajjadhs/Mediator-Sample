using Mediator_sample.Data.DataBase;
using Mediator_sample.Data.Services.Contract;
using Microsoft.EntityFrameworkCore;

namespace Mediator_sample.Data.Services.Concrete
{
    public class BaseService<TEntity, TKey> : IBaseService<TEntity, TKey> where TEntity : class, new()
    {
        protected readonly MyDbContext dbContext;
        public BaseService(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken ct)
        {
            await dbContext.AddAsync<TEntity>(entity, ct);
            await dbContext.SaveChangesAsync(ct);
            return entity;


        }

        public async Task<TEntity> DeleteAsync(TKey id, CancellationToken ct)
        {
            var entity = await GetByIdAsync(id);
            dbContext.Remove(entity);
            await dbContext.SaveChangesAsync(ct);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken ct)
        {
            try
            {
                if (!ct.IsCancellationRequested)
                    return await dbContext.Set<TEntity>().ToListAsync();
                return default;
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities {ex.Message}");
            }
        }

        public async Task<TEntity> GetByIdAsync(TKey id) => await dbContext.FindAsync<TEntity>(id);

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken ct)
        {
            dbContext.Update<TEntity>(entity);
            await dbContext.SaveChangesAsync(ct);
            return entity;
        }

        public async Task<IList<TEntity>> UpdateRangeAsync(IList<TEntity> entities, CancellationToken ct)
        {
            dbContext.UpdateRange(entities);
            await dbContext.SaveChangesAsync(ct);
            return entities;
        }


    }
}
