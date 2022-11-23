using ARS.Common.DTOs.User;
using ARS.Common.Entities.NotMapped;

namespace ARS.Service.Contracts
{
    public interface IAuthenticationService
    {
        public Task<(JwtTokenModel tokenMode, Guid userId)> LoginAsync(LoginDTO loginDTO);
    }
}
