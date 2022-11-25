
using ARS.Common.DTOs.User;
using ARS.Common.Entities;

namespace ARS.Service.Contracts
{
    public interface IUserService
    {
        Task<User> RegisterUser(RegisterUserDTO registerDTO);
        Task<bool> CheckIfUserExists(string userId);

        public Task<Guid> CreateAirlineAdminAsync(CreateAirlineAdminDTO createDTO);
    }
}
