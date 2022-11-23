using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.DTOs.Airline
{
    public class CreateAirlineDTO
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string? LogoUrl { get; set; }

        public Guid? AdminId { get; set; }
    }

}
