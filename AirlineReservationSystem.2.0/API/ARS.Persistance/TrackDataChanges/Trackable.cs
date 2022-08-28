using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.TrackDataChanges
{
    public class Trackable
    {
        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
