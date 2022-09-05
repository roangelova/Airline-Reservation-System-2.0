using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.Entities
{
    public class Announcement
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public Airline Airline { get; set; }

        [Required]
        [ForeignKey(nameof(Airline))]
        public Guid AirlineId { get; set; }
    }
}
