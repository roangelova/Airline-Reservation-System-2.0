using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ARS.Common.Constants.models.EntityConstraintsConstants;


namespace ARS.Common.DTOs.User
{
    public class RegisterUserDTO
    {
        [Required]
        [MaxLength(UserNameMaxLength)]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [MaxLength(UserNameMaxLength)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(UserNameMaxLength)]
        [Required]
        public string LastName { get; set; }

        public string? Nationality { get; set; }

        [Required]
        public string Gender { get; set; }


        public string Password { get; set; }
    }
}
