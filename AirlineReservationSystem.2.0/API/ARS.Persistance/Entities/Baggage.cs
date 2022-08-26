using ARS.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class Baggage
    {
        public Guid BaggageId { get; set; } = Guid.NewGuid();

        public BaggageSize Size { get; set; }

        public bool IsReportedLost { get; set; } = false;


        public Booking Booking { get; set; }

        [ForeignKey(nameof(Booking))]
        public string BookingNumber { get; set; }


        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
