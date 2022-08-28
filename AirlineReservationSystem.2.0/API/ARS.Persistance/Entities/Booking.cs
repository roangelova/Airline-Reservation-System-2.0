using ARS.Common.Enums;
using ARS.Persistance.TrackDataChanges;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class Booking:Trackable
    {
        public Guid BookingNumber { get; set; } = Guid.NewGuid();

        [Required]
        public Status BookingStatus { get; set; }
    }
}
