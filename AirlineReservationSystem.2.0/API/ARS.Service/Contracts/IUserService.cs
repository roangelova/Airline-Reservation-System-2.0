using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Service.Contracts
{
    public interface IUserService
    {
        Task<bool> CheckUserExists(string userId);
    }
}
