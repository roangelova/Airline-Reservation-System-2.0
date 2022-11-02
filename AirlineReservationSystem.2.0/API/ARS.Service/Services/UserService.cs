using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Constants.ErrorConstants;
using ARS.Common.Entities;
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

        public async Task<bool> CheckUserExists(string userId)
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
