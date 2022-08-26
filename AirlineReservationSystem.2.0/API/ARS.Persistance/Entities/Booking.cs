using ARS.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class Booking
    {
        public Guid BookingNumber { get; set; } = Guid.NewGuid();

        public Status BookingStatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }


    }
}
