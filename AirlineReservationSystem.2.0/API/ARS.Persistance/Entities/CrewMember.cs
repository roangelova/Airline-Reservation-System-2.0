using ARS.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class CrewMember
    {
        public Guid CrewMemberId {get; set;} = Guid.NewGuid();

        public CrewType CrewType { get; set;}

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
