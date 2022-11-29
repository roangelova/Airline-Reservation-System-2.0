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
            await airlineService.CreateAirlineAsync(createAirlineDTO);

            return StatusCode(201);
        }


        [HttpPost(nameof(CreateAirlineAdminAsync))]
        public async Task<IActionResult> CreateAirlineAdminAsync(CreateAirlineAdminDTO createDTO)
        {
            var adminId = await userService.CreateAirlineAdminAsync(createDTO);

           // await airlineService.AssignAdminToAirline(adminId, Guid.Parse(createDTO.AirlineId));

            return Ok();
        }

        [HttpGet(nameof(GetAirlines))]
        public async Task<List<ListAirlineDTO>> GetAirlines()
        {
            return await airlineService.GetAirlines();
        }
    }
}
