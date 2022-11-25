
using ARS.Persistance.Repositories.Contracts;

namespace ARS.Persistance.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAirlineRepository Airlines { get; set; }

        ICrewMemberRepository CrewMembers { get; set; }

        IAircraftRepository Aircraft { get; set; }

        public Task<int> CompleteAsync();

    }
}