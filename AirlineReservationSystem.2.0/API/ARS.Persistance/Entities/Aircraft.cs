using ARS.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Entities
{
    public class Aircraft
    {
        public Guid AircraftId { get; set; } = Guid.NewGuid();

        [Required]
        public AircraftManufacturer Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
