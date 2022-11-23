using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Constants.ErrorConstants;
using ARS.Common.Constants.Roles;
using ARS.Common.DTOs.User;
using ARS.Common.Entities;
using ARS.Common.Entities.NotMapped;
using ARS.Common.Enums;
using ARS.Persistance.UnitOfWork;
using ARS.Service.Contracts;

using Microsoft.AspNetCore.Identity;

namespace ARS.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly IAuthenticationService authenticationService;

        public UserService(
            UserManager<User> userManager, 
            IAuthenticationService authenticationService)
        {
            this.userManager = userManager;
            this.authenticationService = authenticationService;
        }

        public async Task<User> RegisterUser(RegisterUserDTO registerDTO)
        {
            try
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Email = registerDTO.Email,
                    FirstName = registerDTO.FirstName,
                    LastName = registerDTO.LastName,
                    UserName = registerDTO.UserName,
                    Gender = Enum.Parse<Gender>(registerDTO.Gender),
                    Nationality = registerDTO.Nationality
                };

                var result = await userManager.CreateAsync(user, registerDTO.Password);

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select( x => x.Description)));

                }

                await userManager.AddToRoleAsync(user, RoleConstants.Customer);

                return user;
            }
            catch (Exception)
            {
                throw;
            }

        }


        //TODO: clear if not used
        public async Task<bool> CheckIfUserExists(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            return true;
        }

    }

}
