﻿using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ARS.Common.Constants.EntityConstants;

namespace ARS.Common.Entities
{
    public class Destination : Trackable
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Continent Continent { get; set; }

        [Required]
        [MaxLength(IATACodeMaxLength)]
        public string IATA { get; set; }

        [Required]
        [MaxLength(DestinationNameMaxLength)]
        public string Name { get; set; }
    }
}