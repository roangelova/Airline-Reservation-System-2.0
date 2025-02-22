﻿using ARS.Common.Entities;
using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ARS.Common.Constants.models.EntityConstraintsConstants;

namespace ARS.Common.Entities.Contracts
{
    public class Passenger : Trackable
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public User User { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        [Required]
        [MaxLength(PassengerMaxNameLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(PassengerMaxNameLength)]
        public string LastName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [MaxLength(PassengerMaxNationalityLength)]
        public string? Nationality { get; set; }

        [MaxLength(PassengerMaxDocumentNumberLength)]
        public string? DocumentNumber { get; set; }


        public List<Booking> Bookings = new List<Booking>();

        public List<Baggage> Baggages = new List<Baggage>();
    }
}
