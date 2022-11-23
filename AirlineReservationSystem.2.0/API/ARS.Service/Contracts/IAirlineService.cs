
using ARS.Common.DTOs.Airline;

namespace ARS.Service.Contracts
{
    public interface IAirlineService
    {
        //GET

        //POST
        public Task CreateAirlineAsync(CreateAirlineDTO createDTO);

        //PUT

        //DELETE
    }
}
