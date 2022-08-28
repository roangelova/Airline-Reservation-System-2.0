using ARS.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ARS.Common.Constants.EntityConstants;

namespace ARS.Persistance.Entities
{
    public class CrewMember
    {
        public Guid CrewMemberId {get; set;} = Guid.NewGuid();

        [Required]
        public CrewType CrewType { get; set;}

        [Required]
        [MaxLength(CrewMemberMaxNameLength)]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
