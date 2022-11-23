using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.DTOs.Airline;
using ARS.Common.Entities;

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
