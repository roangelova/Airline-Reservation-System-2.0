using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ARS.Common.Constants.DbConstraints;

namespace ARS.Persistance.Entities
{
    public class Destination
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(IATACodeMaxLength)]
        public string IATA { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
