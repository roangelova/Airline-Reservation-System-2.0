
using ARS.Common.Constants.API;
using ARS.Common.DTOs.User;
using ARS.Common.Entities.NotMapped;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ARS.Api.Controllers
{
    [Route(RoutingConstants.AuthenticationRoute)]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;
        private readonly IMemoryCache authenicationCache;

        public AuthenticationController(
            IAuthenticationService authenticationService,
            IMemoryCache authenicationCache)
        {
            this.authenticationService = authenticationService;
            this.authenicationCache = authenicationCache;
        }

        [AllowAnonymous]
        [HttpPost(nameof(Login))]
        public async Task<ActionResult> Login(LoginDTO loginDTO)
        {
            (JwtTokenModel tokenModel, Guid userId) = await authenticationService.LoginAsync(loginDTO);

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(TokenConstants.RefreshTokenValidityInMinutes));

            this.authenicationCache.Set(userId.ToString(), tokenModel.RefreshToken, cacheEntryOptions);


            return Ok(tokenModel);

        }
    }
}
