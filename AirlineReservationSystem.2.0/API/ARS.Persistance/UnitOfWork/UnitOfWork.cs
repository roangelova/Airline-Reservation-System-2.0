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
        public ICrewMemberRepository CrewMembers { get; set; }

        public IAircraftRepository Aircraft { get; set; }

        public UnitOfWork(
            ApplicationDbContext context,
            IAirlineRepository airlines,
            ICrewMemberRepository crewMembers,
            IAircraftRepository aircrafts)
        {
            this.context = context;
            Airlines = airlines;
            CrewMembers = crewMembers;
            Aircraft = aircrafts;
        }

        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
