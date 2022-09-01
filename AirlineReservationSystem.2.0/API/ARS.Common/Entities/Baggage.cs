using ARS.Common.Enums;
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
    public class Baggage : Trackable
    {
        public Guid BaggageId { get; set; } = Guid.NewGuid();

        [Required]
        public BaggageSize Size { get; set; }

        public bool IsReportedLost { get; set; } = false;


        public Booking Booking { get; set; }

        [ForeignKey(nameof(Booking))]
        [Required]
        public Guid BookingNumber { get; set; }
    }
}
