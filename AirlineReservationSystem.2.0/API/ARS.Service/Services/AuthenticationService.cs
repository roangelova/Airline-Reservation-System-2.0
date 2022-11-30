
using ARS.Common.Constants.ErrorConstants;
using ARS.Common.DTOs.User;
using ARS.Common.Entities;
using ARS.Common.Entities.NotMapped;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Identity;

namespace ARS.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> userManager;
        private readonly ITokenService tokenService;
        private readonly IUnitOfWork unitOfWork;

        public AuthenticationService(
            ITokenService tokenService,
            UserManager<User> userManager,
            IUnitOfWork unitOfWork)
        {
            this.tokenService = tokenService;
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
        }

        public async Task<(JwtTokenModel tokenMode, Guid userId)> LoginAsync(LoginDTO loginDTO)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(loginDTO.Email);

                if (user is null)
                {
                    throw new Exception(ErrorMessageConstants.LoginFailed);
                }

                if (!user.IsActive)
                {
                    throw new Exception(string.Format(ErrorMessageConstants.UserNotFound, nameof(loginDTO.Email), loginDTO.Email));
                }

                if(user.LockoutEnd > DateTime.UtcNow)
                {
                    throw new Exception($"User is locked out unil {user.LockoutEnd}");
                }

                var result = await userManager.CheckPasswordAsync(user, loginDTO.Password);

                if (!result)
                {
                    await userManager.AccessFailedAsync(user);
                    throw new Exception(ErrorMessageConstants.LoginFailed);
                }

                user.AccessFailedCount = 0;
                await userManager.UpdateAsync(user);

                var tokenModel = await tokenService.CreateJwtToken(user);

                return (tokenModel, user.Id);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
