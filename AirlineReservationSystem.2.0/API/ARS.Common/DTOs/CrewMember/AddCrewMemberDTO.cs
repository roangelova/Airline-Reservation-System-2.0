using System.ComponentModel.DataAnnotations;

namespace ARS.Common.DTOs.CrewMember
{
    public class AddCrewMemberDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string CrewType { get; set; }

        [Required]
        public string TypeRating { get; set; }

        public string? AvatarUrl { get; set; }

        [Required]
        public string AirlineId { get; set; }
    }
}
