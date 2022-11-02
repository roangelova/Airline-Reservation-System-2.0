using System.Linq.Expressions;

namespace ARS.Persistance.GenericRepository
{
    public interface IGenericRepository<TEntity>
    {
        public Task<TEntity> GetByIdAsync(object id);

        public Task AddAsync(TEntity entity);

        public Task DeleteByIdAsync(object id);

        public void DeleteEntity(TEntity entityToDelete);

        public void Update(TEntity entityToUpdate);

        public Task<IEnumerable<TEntity>> GetAllAsync(
           Expression<Func<TEntity, bool>> filter,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = "");


        //TODO: GET ALL ASYNC with fiter sort include etc

    }
}
