using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Constants.ErrorConstants;
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

        public UserService(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<User> RegisterUser(RegisterUserDTO registerDTO)
        {
            try
            {
                //TODO - check if username is taken 
               await CheckIfEmailOrUsernameIsUnique(registerDTO.UserName, registerDTO.Email);

                var user = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = registerDTO.FirstName,
                    LastName = registerDTO.LastName,
                    UserName = registerDTO.UserName,
                    Gender = Enum.Parse<Gender>(registerDTO.Gender),
                    Nationality = registerDTO.Nationality
                };

               var result = await userManager.CreateAsync(user, registerDTO.Password);

                if (!result.Succeeded)
                {
                    var errorModel = new ErrorModel();

                }


                //TODO --> add to role customer 

                return user;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> CheckIfUserExists(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Checks if there is already a registered user with the provided username or email.
        /// </summary>
        /// <param name="username">Username to check</param>
        /// <param name="email">Email to check</param>
        /// <returns>True if both values are unique. False if either value is not unique</returns>
        private async Task<bool> CheckIfEmailOrUsernameIsUnique (string username, string email)
        {
            //TODO: implement 
            //in 1 method to do 1 db query, But also provide info WHICH ONE is not unique

            var checkEmail = await userManager.FindByEmailAsync(email);

            if(checkEmail != null)
            {
                throw new Exception(string.Join(ErrorMessageConstants.EmailOrUsernameNotUnique, nameof(email)));
                return false;
            }

            var checkUserName = await userManager.FindByNameAsync(username);

            if (checkUserName != null)
            {
                throw new Exception(string.Join(ErrorMessageConstants.EmailOrUsernameNotUnique, nameof(username)));
                return false;
            }

            return true;
        }

    }

}
