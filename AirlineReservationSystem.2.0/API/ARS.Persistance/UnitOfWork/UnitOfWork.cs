using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Persistance.Context;
using ARS.Persistance.Repositories.Contracts;

namespace ARS.Persistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IAirlineRepository Airlines { get; set; }

        public UnitOfWork(
            ApplicationDbContext context,
            IAirlineRepository airlines)
        {
            this.context = context;
            Airlines = airlines;
        }

        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
