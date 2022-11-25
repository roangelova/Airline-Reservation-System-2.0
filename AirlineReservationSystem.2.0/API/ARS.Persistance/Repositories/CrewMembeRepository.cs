
using ARS.Common.Entities;
using ARS.Persistance.Context;
using ARS.Persistance.GenericRepository;
using ARS.Persistance.Repositories.Contracts;

namespace ARS.Persistance.Repositories
{
    public class CrewMembeRepository : GenericRepository<CrewMember>, ICrewMemberRepository
    {
        public CrewMembeRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
