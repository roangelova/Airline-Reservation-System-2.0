
using ARS.Common.Constants.ErrorConstants;
using ARS.Common.DTOs.Airline;
using ARS.Common.Entities;
using ARS.Common.Enums;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Identity;

namespace ARS.Service.Services
{
    public class AirlineService : IAirlineService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<User> userManager;

        public AirlineService(
            IUnitOfWork unitOfWork,
            UserManager<User> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }

        public async Task AssignAdminToAirline(Guid adminId, Guid airlineId)
        {
            try
            {
                var airline = await unitOfWork.Airlines.GetByIdAsync(airlineId);

                if (airline is null)
                {
                    throw new Exception(string.Format(ErrorMessageConstants.Object_is_null, nameof(Airline), airlineId));

                }

                airline.AdminId = adminId;
                unitOfWork.Airlines.Update(airline);
                await unitOfWork.CompleteAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task CreateAirlineAsync(CreateAirlineDTO createDTO)
        {
            try
            {
                var airline = new Airline
                {
                    AirlineName = createDTO.Name,
                    IATA = createDTO.IATA,
                    Description = createDTO?.Description,
                    AirlineLogo = createDTO?.LogoUrl,
                    AdminId = createDTO?.AdminId ?? null,
                    AirlineType = Enum.Parse<AirlineType>(createDTO.AirlineType)
                };

                await unitOfWork.Airlines.AddAsync(airline);
                await unitOfWork.CompleteAsync();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<ListAirlineDTO>> GetAirlines()
        {
            var aircraft = await unitOfWork.Airlines.GetAllAsync(null, null, "");


            return aircraft.Select(x => new ListAirlineDTO
            {
                Name = x.AirlineName,
                Description = x.Description,
                Id = x.AirlineId.ToString()
            }).
            ToList();
        }
    }
}
