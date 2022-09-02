using ARS.Common.Entities.Contracts;
using ARS.Common.Enums;
using ARS.Common.MappingTables;
using ARS.Common.TrackDataChanges;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.Entities
{
    public class Booking : Trackable
    {
        [Key]
        public Guid BookingNumber { get; set; } = Guid.NewGuid();

        [Required]
        public Status BookingStatus { get; set; }

        public decimal TotalPrice { get; set; }

        [ForeignKey(nameof(User))]
        [Required]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public ICollection<FlightsBookings> FlightsBookings { get; set; } = new List<FlightsBookings>();

        public ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();

    }
}
