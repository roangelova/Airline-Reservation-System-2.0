using System.ComponentModel.DataAnnotations;

namespace ARS.Common.DTOs.User

{
    using static ARS.Common.Constants.models.EntityConstraintsConstants;

    public class CreateAirlineAdminDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [MaxLength(UserNameMaxLength)]
        [Required]
        public string RepresentativesFirstName { get; set; }

        [MaxLength(UserNameMaxLength)]
        [Required]
        public string RepresentativesLastName { get; set; }

        public string Password { get; set; }
    }
}
