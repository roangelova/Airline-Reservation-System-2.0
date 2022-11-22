using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ARS.Api.Controllers.BaseControllers;
using ARS.Common.DTOs.User;
using ARS.Service.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace ARS.Api.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UserAccountController : BaseApiController
    {
        private readonly IUserService userService;

        public UserAccountController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost(nameof(RegisterUserAsync))]
        [AllowAnonymous]
        public async Task<ActionResult> RegisterUserAsync(RegisterUserDTO registerUserDto)
        {
            
            return Ok();
        }
    }
}
