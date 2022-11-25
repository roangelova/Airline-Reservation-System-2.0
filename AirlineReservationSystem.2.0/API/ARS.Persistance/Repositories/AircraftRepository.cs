
using ARS.Common.Entities;
using ARS.Persistance.Context;
using ARS.Persistance.GenericRepository;
using ARS.Persistance.Repositories.Contracts;

namespace ARS.Persistance.Repositories
{
    public class AircraftRepository : GenericRepository<Aircraft>, IAircraftRepository
    {
        public AircraftRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
