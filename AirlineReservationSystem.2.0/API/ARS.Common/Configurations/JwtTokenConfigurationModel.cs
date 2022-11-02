using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.Configurations
{
    public class JwtTokenConfigurationModel
    {
        public string Key { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

    }
}
