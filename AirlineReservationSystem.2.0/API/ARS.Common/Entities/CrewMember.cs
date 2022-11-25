using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ARS.Common.Constants.models.EntityConstraintsConstants;

namespace ARS.Common.Entities
{
    public class CrewMember : Trackable
    {
        public Guid CrewMemberId { get; set; } = Guid.NewGuid();

        [Required]
        public CrewType CrewType { get; set; }

        [Required]
        [MaxLength(CrewMemberMaxNameLength)]
        public string Name { get; set; }

        public AircraftType TypeRating { get; set; }

        [MaxLength(CrewMemberMaxAvatarUrl)]
        //TODO: USE A DIFFERENT KIND OF DB TO STORE UPLOADED AVATARS; alt - blob storage 
        public string? AvatarUrl { get; set; }

        public Airline Airline { get; set; }

        [Required]
        [ForeignKey(nameof(Airline))]
        public Guid AirlineId { get; set; }
    }
}
