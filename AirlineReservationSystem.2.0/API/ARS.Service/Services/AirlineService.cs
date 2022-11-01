using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.DTOs.Airline;
using ARS.Common.Entities;
using ARS.Service.Contracts;

namespace ARS.Service.Services
{
    public class AirlineService : IAirlineService
    {
        public async Task<Airline> CreateAnAirlineAsync(CreateAnAirlineDTO createDTO)
        {
            var airline = new Airline
            {
                AirlineName = createDTO.AirlineName,
                Description = createDTO?.AirlineDescription,
                AirlineLogo = createDTO?.AirlineLogo,
                AdminId = createDTO?.AirlineAdmin ?? Guid.Empty
            };

            //savetodb

            return airline;
        }
    }
}
