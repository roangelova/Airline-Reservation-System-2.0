
using ARS.Common.DTOs.Airline;
using ARS.Common.DTOs.User;

namespace ARS.Service.Contracts
{
    public interface IAirlineService
    {
        //GET
        public Task<List<ListAirlineDTO>> GetAirlines ();

        //POST
        public Task CreateAirlineAsync(CreateAirlineDTO createDTO);

        public Task AssignAdminToAirline(Guid adminId, Guid airlineId);

        //PUT

        //DELETE
    }
}
