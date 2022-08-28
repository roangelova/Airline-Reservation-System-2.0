using ARS.Persistance.TrackDataChanges;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ARS.Common.Constants.EntityConstants;

namespace ARS.Persistance.Entities
{
    public abstract class Passenger:Trackable
    {
        public Guid PassengerId { get; set; } = Guid.NewGuid();

        public User User { get; set; }

        [Required]
        [MaxLength(PassengerMaxNameLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(PassengerMaxNameLength)]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [MaxLength(PassengerMaxNationalityLength)]
        public string Nationality { get; set; }

        [Required]
        [MaxLength(PassengerMaxDocumentNumberLength)]
        public string DocumentNumber { get; set; }


        public List<Booking> Bookings = new List<Booking>();

        public List<Baggage> Baggages = new List<Baggage>();
    }
}
