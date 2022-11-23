using ARS.Common.Constants.API;
using ARS.Common.DTOs.Airline;
using ARS.Common.DTOs.User;
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
        private readonly IUserService userService;


        public AirlineController(
            IAirlineService airlineService,
            IUserService userService)
        {
            this.airlineService = airlineService;
            this.userService = userService;
        }

        [HttpPost(nameof(CreateAirlineAsync))]
        public async Task<IActionResult> CreateAirlineAsync(CreateAirlineDTO createAirlineDTO)
        {

            //todo: create admin -> how are we gonna create admin for the airlie

            await airlineService.CreateAirlineAsync(createAirlineDTO);

            return StatusCode(201);
        }
    }
}
