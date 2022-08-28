﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ARS.Common.Constants.EntityConstants;

namespace ARS.Persistance.Entities
{
    public class Airline
    {
        public Guid AirlineId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(AirlineMaxNameLength)]
        public string AirlineName { get; set; }


        [MaxLength(AirlineMaxDescriptionLength)]
        public string? Description { get; set; }
        
        [MaxLength(AirlineMaxLogoImageLength)]
        public string? AirlineLogo { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }


    }
}
