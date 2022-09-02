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
        public Guid BookingId { get; set; } = Guid.NewGuid();


        public Flight Flight { get; set; }

        [ForeignKey(nameof(Flight))]
        public Guid FlightId { get; set; } = Guid.NewGuid();
    }
}
