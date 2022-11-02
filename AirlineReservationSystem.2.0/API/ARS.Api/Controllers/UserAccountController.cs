using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ARS.Api.Controllers.BaseControllers;
using ARS.Common.DTOs.User;

namespace ARS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : BaseApiController
    {

        [HttpPost]
        public async Task<ActionResult> Register(RegisterUserDTO registerUserDto)
        {
            Console.WriteLine(registerUserDto);
            return Ok();
        }
    }
}
