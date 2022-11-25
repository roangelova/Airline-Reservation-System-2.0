using ARS.Common.Constants.API;
using ARS.Common.DTOs.CrewMember;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Mvc;

namespace ARS.Api.Controllers
{

    [Route(RoutingConstants.CrewMemberRoute)]
    [ApiController]
    public class CrewMemberController : ControllerBase
    {
        private readonly ICrewMemberService crewMemberService;

        public CrewMemberController(
            ICrewMemberService crewMemberService)
        {
            this.crewMemberService = crewMemberService;
        }

        [HttpPost(nameof(AddCrewMember))]
        public async Task<IActionResult> AddCrewMember (AddCrewMemberDTO addCrewMemberDTO)
        {
            await crewMemberService.AddCrewMember (addCrewMemberDTO);

            return StatusCode(201);
        }
    }
}
