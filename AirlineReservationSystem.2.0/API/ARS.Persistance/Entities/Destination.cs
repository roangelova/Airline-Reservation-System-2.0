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
    public class Destination :Trackable
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(IATACodeMaxLength)]
        public string IATA { get; set; }

        [Required]
        [MaxLength(DestinationNameMaxLength)]
        public string Name { get; set; }
    }
}
