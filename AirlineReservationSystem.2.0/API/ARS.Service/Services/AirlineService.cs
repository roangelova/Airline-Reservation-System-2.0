using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.DTOs.Airline;
using ARS.Common.Entities;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

namespace ARS.Service.Services
{
    public class AirlineService : IAirlineService
    {
        private readonly IUnitOfWork UnitOfWork;

        public AirlineService(
            IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public async Task CreateAirlineAsync(CreateAirlineDTO createDTO)
        {
            try
            {
                var airline = new Airline
                {
                    AirlineName = createDTO.Name,
                    Description = createDTO?.Description,
                    AirlineLogo = createDTO?.LogoUrl,
                    AdminId = createDTO?.AdminId ?? Guid.Empty
                };

                await UnitOfWork.Airlines.AddAsync(airline);
                await UnitOfWork.CompleteAsync();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
