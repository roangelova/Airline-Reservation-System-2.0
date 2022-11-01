using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Persistance.Context;

using Microsoft.EntityFrameworkCore;

namespace ARS.Persistance.GenericRepository
{
    public class GenericRepository<TEntity>:IGenericRepository<TEntity> where TEntity: class
    {
        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
        }

        public virtual async Task DeleteByIdAsync(object id)
        {
            //TODO: 
           
        }

        public virtual void DeleteEntity(TEntity entityToDelete)
        {
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Update(entityToUpdate);
        }

    }
}
