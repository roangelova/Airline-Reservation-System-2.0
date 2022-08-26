using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public abstract class Passenger
    {
        public Guid PassengerId { get; set; } = Guid.NewGuid();


        public User User { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string DocumentNumber { get; set; }


        public List<Booking> Bookings = new List<Booking>();

        public List<Baggage> Baggages = new List<Baggage>();

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
