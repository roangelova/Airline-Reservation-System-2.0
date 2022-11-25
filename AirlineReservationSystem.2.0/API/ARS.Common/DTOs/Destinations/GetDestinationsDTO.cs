using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.DTOs.Destinations
{
    public class GetDestinationsDTO
    {
        public string Name { get; set; }

        public string Continent { get; set; }

        public string Country { get; set; }

        public string IATA { get; set; }

        public string Id { get; set; }
    }
}
