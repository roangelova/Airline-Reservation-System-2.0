
using ARS.Common.DTOs.Flight;

namespace ARS.Service.Contracts
{
    public interface IFlightService
    {
        public Task CreateFlights(AddFlightDTO addFlightDTO);
    }
}
