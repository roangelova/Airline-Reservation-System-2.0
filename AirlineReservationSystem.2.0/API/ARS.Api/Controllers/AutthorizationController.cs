
using ARS.Api.Controllers.BaseControllers;
using ARS.Common.DTOs.User;

using Microsoft.AspNetCore.Mvc;

namespace ARS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutthorizationController : BaseApiController
    {
        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDTO loginDTO)
        {
            return Ok();
        }
    }
}
