using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class Airline
    {
        public Guid AirlineId { get; set; } = Guid.NewGuid();

        [Required]
        public string AirlineName { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }


    }
}
