using ARS.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.MappingTables
{
    public class FlightsBookings
    {
        public Booking Booking { get; set; }

        [ForeignKey(nameof(Booking))]
        [Required]
        public Guid BookingId { get; set; }


        public Flight Flight { get; set; }

        [ForeignKey(nameof(Flight))]
        [Required]
        public Guid FlightId { get; set; }
    }
}
