using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ARS.Common.Constants.models.EntityConstraintsConstants;

namespace ARS.Common.Entities
{
    public class Aircraft : Trackable
    {
        public Guid AircraftId { get; set; } = Guid.NewGuid();

        [Required]
        public AircraftManufacturer Manufacturer { get; set; }

        [Required]
        [MaxLength(AircraftModelMaxLength)]
        public string Model { get; set; }

        [Required]
        [MaxLength(AircraftImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Required]
        public int Capacity { get; set; }

        public Airline Airline { get; set; }

        [ForeignKey(nameof(Airline))]
        public Guid AirlineId { get; set; }

        [Required]
        public double PurchasePrice { get; set; }

        [Required]
        public double MonthlyOperationalCost { get; set; }
    }
}
