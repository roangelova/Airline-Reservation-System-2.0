using ARS.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class Flight
    {
        public Guid FlightId { get; set; } = Guid.NewGuid();

        [ForeignKey(nameof(Origin))]
        public string OriginId { get; set; }

        [Required]
        public Destination Origin { get; set; }

        [ForeignKey(nameof(Destination))]
        public string DestinationId { get; set; }

        [Required]
        public Destination Destination { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TakeOffTime { get; set; }

        [Required]
        public DateTime Duration { get; set; }

        [Required]
        public Status FlightStatus { get; set; }

        [Required]
        public Aircraft Aircraft { get; set; }

        [ForeignKey(nameof(Aircraft))]
        public string AircraftID { get; set; }

        [Required]
        public decimal TicketPrice { get; set; }

        public List<Booking> Bookings = new List<Booking>();
    }
}
