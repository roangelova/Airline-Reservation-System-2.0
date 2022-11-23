using ARS.Common.Constants.API;
using ARS.Common.DTOs.Airline;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ARS.Api.Controllers
{
    [Route(RoutingConstants.AirlineRoute)]
    [ApiController]
    public class AirlineController : ControllerBase
    {
        private readonly IAirlineService airlineService;


        public AirlineController(IAirlineService airlineService)
        {
            this.airlineService = airlineService;
        }

        [HttpPost(nameof(CreateAirlineAsync))]
        public async Task<IActionResult> CreateAirlineAsync(CreateAirlineDTO createAirlineDTO)
        {
            await airlineService.CreateAirlineAsync(createAirlineDTO);

            return StatusCode(201);
        }
    }
}
