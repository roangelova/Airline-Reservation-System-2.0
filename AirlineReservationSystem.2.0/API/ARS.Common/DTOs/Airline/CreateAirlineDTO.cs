using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ARS.Common.Constants.models.EntityConstraintsConstants;

namespace ARS.Common.DTOs.Airline
{
    public class CreateAirlineDTO
    {
        [Required]
        [MaxLength(AirlineMaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(IATA_AirlineCodeMaxLength)]
        public string IATA { get; set; }


        [MaxLength(AirlineMaxDescriptionLength)]
        public string Description { get; set; }


        [MaxLength(AirlineMaxLogoImageLength)]
        public string? LogoUrl { get; set; }

        public Guid? AdminId { get; set; }


        [Required]
        public string AirlineType { get; set; }
    }

}
