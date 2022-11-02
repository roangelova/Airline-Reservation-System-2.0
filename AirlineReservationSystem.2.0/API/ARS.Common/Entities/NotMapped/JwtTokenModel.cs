using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.Entities.NotMapped
{
    public class JwtTokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public string AccessTokenType { get; set; }

        public DateTime AccessTokenExpriration { get; set; }

        public DateTime RefreshTokenExpriration { get; set; }

    }
}
