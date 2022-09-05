using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ARS.Common.Constants.EntityConstants;

namespace ARS.Common.Entities
{
    public class User : IdentityUser<Guid>, ITrackable
    {
        [Required]
        [MaxLength(UserNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(UserNameMaxLength)]
        public string LastName { get; set; }

        public string? Nationality { get; set; }

        public Gender? Gender { get; set; } 

        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
