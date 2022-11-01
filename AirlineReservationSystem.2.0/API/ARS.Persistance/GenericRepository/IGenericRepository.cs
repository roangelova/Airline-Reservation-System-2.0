namespace ARS.Persistance.GenericRepository
{
    public interface IGenericRepository<TEntity>
    {
        public Task<TEntity> GetByIdAsync(object id);

        public Task AddAsync(TEntity entity);

        public Task DeleteByIdAsync(object id);

        public void DeleteEntity(TEntity entityToDelete);

        public void Update(TEntity entityToUpdate);

        //TODO: GET ALL ASYNC with fiter sort include etc

    }
}
