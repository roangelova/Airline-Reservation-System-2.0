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
    public class Airline:Trackable
    {
        public Guid AirlineId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(AirlineMaxNameLength)]
        public string AirlineName { get; set; }


        [MaxLength(AirlineMaxDescriptionLength)]
        public string? Description { get; set; }
        
        [MaxLength(AirlineMaxLogoImageLength)]
        public string? AirlineLogo { get; set; }

        //TODO: ADMIN??

        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<CrewMember> CrewMembers { get; set; } = new List<CrewMember>();
    }
}
