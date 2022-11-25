using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ARS.Common.DTOs.User;
using ARS.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using ARS.Common.Constants.API;

namespace ARS.Api.Controllers
{
    [Route(RoutingConstants.UserRoute)]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost(nameof(RegisterUserAsync))]
        [AllowAnonymous]
        public async Task<ActionResult> RegisterUserAsync(RegisterUserDTO registerUserDto)
        {
            await userService.RegisterUser(registerUserDto);

            return Ok();
        }
    }
}
