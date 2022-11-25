using ARS.Common.Constants.API;
using ARS.Common.DTOs.Aircraft;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Mvc;

namespace ARS.Api.Controllers
{
    [Route(RoutingConstants.AircraftRoute)]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        public IAircraftService aircraftService;

        public AircraftController(
            IAircraftService aircraftService)
        {
            this.aircraftService = aircraftService;
        }

        [HttpPost(nameof(AddAircraft))]
        public async Task<IActionResult> AddAircraft (AddAircraftDTO addAircraftDTO)
        {
            await aircraftService.AddAircraft (addAircraftDTO);

            return StatusCode(201);
        }
    }
}
