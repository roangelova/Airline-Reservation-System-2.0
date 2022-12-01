using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.DTOs.Flight
{
    public class AddFlightDTO
    {
        public Guid AirlineId { get; set; }

        public Guid AircraftId { get; set; }

        public Guid OriginId { get; set; }

        public Guid DestinationId { get; set; }

        public DateTime TakeOffTime { get; set; }

        public TimeOnly Duration { get; set; }

        public bool IsAnOffer { get; set; }

        public Guid CaptainId { get; set; }

        public Guid FirstOfficerId { get; set; }

        public List<Guid> FlightAttendants { get; set; }

        public decimal TicketPrice { get; set; }


    }
}
