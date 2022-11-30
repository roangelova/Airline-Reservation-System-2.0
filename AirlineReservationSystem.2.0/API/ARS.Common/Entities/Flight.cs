using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;
using ARS.Common.MappingTables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARS.Common.Entities
{
    public class Flight : Trackable
    {
        public Guid FlightId { get; set; } = Guid.NewGuid();

        public bool IsAnOffer { get; set; }

        [ForeignKey(nameof(Origin))]
        public Guid OriginId { get; set; }

        [Required]
        public Destination Origin { get; set; }

        [ForeignKey(nameof(Destination))]
        public Guid DestinationId { get; set; }

        [Required]
        public Destination Destination { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TakeOffTime { get; set; }

        [Required]
        public DateTime Duration { get; set; }

        [Required]
        public FlightStatus FlightStatus { get; set; }

        [Required]
        public Aircraft Aircraft { get; set; }

        [ForeignKey(nameof(Aircraft))]
        [Required]
        public Guid AircraftID { get; set; }

        [Required]
        public Airline Airline { get; set; }

        [ForeignKey(nameof(Airline))]
        [Required]
        public Guid AirlineId { get; set; }

        [Required]
        public decimal TicketPrice { get; set; }

        public ICollection<FlightsBookings> FlightsBookings { get; set; } = new List<FlightsBookings>();
    }
}
