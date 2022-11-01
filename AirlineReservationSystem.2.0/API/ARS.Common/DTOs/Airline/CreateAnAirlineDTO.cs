using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.DTOs.Create
{
    public class CreateAnAirlineDTO
    {
        [Required]
        public string AirlineName { get; set; }

        public string AirlineDescription { get; set; }

        public string AirlineLogo { get; set; }

        public Guid? AirlineAdmin { get; set; }
    }

}
