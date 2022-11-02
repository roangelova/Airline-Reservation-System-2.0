using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Entities;
using ARS.Common.Entities.NotMapped;

namespace ARS.Service.Contracts
{
    public interface ITokenService
    {
        Task<JwtTokenModel> CreateJwtToken(User user);
    }
}
