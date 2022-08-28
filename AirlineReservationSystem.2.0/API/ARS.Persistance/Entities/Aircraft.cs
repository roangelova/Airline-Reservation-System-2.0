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
    public class Aircraft
    {
        public Guid AircraftId { get; set; } = Guid.NewGuid();

        [Required]
        public AircraftManufacturer Manufacturer { get; set; }

        [Required] 
        [MaxLength(AircraftModelMaxLength)]
        public string Model { get; set; }

        [Required]
        [MaxLength(AircraftImageUrlMaxLength)]
        public string ImageUrl { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
