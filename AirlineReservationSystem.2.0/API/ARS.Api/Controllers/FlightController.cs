using ARS.Common.Constants.API;
using ARS.Common.DTOs.Flight;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ARS.Api.Controllers
{
    [Route(RoutingConstants.FlightRoute)]
    [ApiController]
    public class FlightController : ControllerBase
    {
        [HttpPost(nameof(CreateFlight))]
        public IActionResult CreateFlight (AddFlightDTO addFlightDTO)
        {

            //code

            return Ok();
        }
    }
}
