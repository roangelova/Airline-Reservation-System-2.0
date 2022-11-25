using System.ComponentModel.DataAnnotations;

using static ARS.Common.Constants.models.EntityConstraintsConstants;

namespace ARS.Common.DTOs.CrewMember
{
    public class AddCrewMemberDTO
    {
        [Required]
        [MaxLength(CrewMemberMaxNameLength)]
        public string Name { get; set; }

        [Required]
        public string CrewType { get; set; }

        [Required]
        public string TypeRating { get; set; }


        [MaxLength(CrewMemberMaxAvatarUrl)]
        public string? AvatarUrl { get; set; }

        [Required]
        public string AirlineId { get; set; }
    }
}
