using ARS.Common.DTOs.Aircraft;
using ARS.Common.Entities;
using ARS.Common.Enums;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

namespace ARS.Service.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly IUnitOfWork unitOfWork;

        public AircraftService(
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddAircraft(AddAircraftDTO addAircraftDTO)
        {
            try
            {
                var aircraft = new Aircraft
                {
                    Manufacturer = Enum.Parse<AircraftManufacturer>(addAircraftDTO.AircraftManufacturer),
                    Model = addAircraftDTO.Model,
                    ImageUrl = addAircraftDTO?.ImageUrl,
                    Capacity = addAircraftDTO.Capacity,
                    AirlineId = Guid.Parse(addAircraftDTO.AirlineId)
                };

                await unitOfWork.Aircraft.AddAsync(aircraft);
                await unitOfWork.CompleteAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
