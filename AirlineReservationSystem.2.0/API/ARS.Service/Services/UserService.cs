using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Constants.ErrorConstants;
using ARS.Common.DTOs.User;
using ARS.Common.Entities;
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

                var user = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = registerDTO.FirstName,
                    LastName = registerDTO.LastName,
                    UserName = registerDTO.UserName,
                    Gender = Enum.Parse<Gender>(registerDTO.Gender),
                    Nationality = registerDTO.Nationality
                };

                await userManager.CreateAsync(user, registerDTO.Password);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> CheckUserExists(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="registerDTO"></param>
        /// <returns></returns>
        private async Task<bool> CheckIfEmailOrUsernameIsUnique (string username, string email)
        {
            //TODO: implement 

            return false;

        }

    }

}
