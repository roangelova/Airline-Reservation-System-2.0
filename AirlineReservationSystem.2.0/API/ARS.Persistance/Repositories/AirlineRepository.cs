
using ARS.Common.Entities;
using ARS.Persistance.Context;
using ARS.Persistance.GenericRepository;
using ARS.Persistance.Repositories.Contracts;

namespace ARS.Persistance.Repositories
{
    public class AirlineRepository : GenericRepository<Airline>, IAirlineRepository
    {
        public AirlineRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
