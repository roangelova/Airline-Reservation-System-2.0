using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

using ARS.Common.Configurations;
using ARS.Common.Entities;
using ARS.Common.Entities.NotMapped;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ARS.Service.Services
{
    public class TokenService : ITokenService
    {
        private readonly IOptions<JwtTokenConfigurationModel> jwtconfig;
        private readonly UserManager<User> userManager;

        public TokenService(
            IOptions<JwtTokenConfigurationModel> jwtconfig,
            UserManager<User> userManager)
        {
            this.jwtconfig = jwtconfig;
            this.userManager = userManager;
        }

        public Task<JwtTokenModel> CreateJwtToken(User user)
        {
            throw new NotImplementedException();
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        private async Task<string> GenerateAccessToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtconfig.Value.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

           var role = await userManager.GetRolesAsync(user);

            var claims = new[]
            {
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName),
                new Claim(ClaimTypes.Email, user.Email),
               // new Claim(ClaimTypes.Role, role.Name),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var token = new JwtSecurityToken(
                jwtconfig.Value.Issuer,
                jwtconfig.Value.Audience,
                claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
