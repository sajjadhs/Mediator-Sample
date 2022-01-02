namespace Mediator_sample.Data.Services.Contract
{
    public interface IBaseService<TEntity,in TKey>  where TEntity : class,new()
    {
        Task<TEntity> AddAsync(TEntity entity,CancellationToken ct);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken ct);
        Task<TEntity> GetByIdAsync(TKey id);
        Task<TEntity> DeleteAsync(TKey id, CancellationToken ct);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken ct);
        Task<IList<TEntity>> UpdateRangeAsync(IList<TEntity> entities, CancellationToken ct);
    }
}
