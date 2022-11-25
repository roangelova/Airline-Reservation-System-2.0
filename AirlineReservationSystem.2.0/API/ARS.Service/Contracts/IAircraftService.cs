using ARS.Common.DTOs.Aircraft;

namespace ARS.Service.Contracts
{
    public interface IAircraftService
    {
        public Task AddAircraft(AddAircraftDTO addAircraftDTO);
    }
}
