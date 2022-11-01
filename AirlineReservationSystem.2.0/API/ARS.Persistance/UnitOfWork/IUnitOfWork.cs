using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Persistance.Repositories.Contracts;

namespace ARS.Persistance.UnitOfWork
{
    internal interface IUnitOfWork
    {
        IAirlineRepository Airlines { get; set; }
        public Task<int> CompleteAsync();

    }
}