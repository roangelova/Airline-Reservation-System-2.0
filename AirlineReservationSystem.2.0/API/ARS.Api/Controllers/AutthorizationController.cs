
using ARS.Api.Controllers.BaseControllers;
using ARS.Common.DTOs.User;

using Microsoft.AspNetCore.Mvc;

namespace ARS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : BaseApiController
    {
        [HttpPost(nameof(LoginAsync))]
        public async Task<ActionResult> LoginAsync(LoginDTO loginDTO)
        {

            return Ok();
        }
    }
}
