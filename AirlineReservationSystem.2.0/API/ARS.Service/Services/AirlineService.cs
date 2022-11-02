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

        public async Task<Airline> CreateAnAirlineAsync(CreateAnAirlineDTO createDTO)
        {
            try
            {
                //TODO: check if name is uniqe
                
                var airline = new Airline
                {
                    AirlineName = createDTO.AirlineName,
                    Description = createDTO?.AirlineDescription,
                    AirlineLogo = createDTO?.AirlineLogo,
                    AdminId = createDTO?.AirlineAdmin ?? Guid.Empty
                };

                await UnitOfWork.Airlines.AddAsync(airline);
                await UnitOfWork.CompleteAsync();

                //savetodb

                return airline;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
