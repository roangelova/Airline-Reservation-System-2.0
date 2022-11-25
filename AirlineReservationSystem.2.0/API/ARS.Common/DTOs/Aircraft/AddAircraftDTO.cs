using System.ComponentModel.DataAnnotations;

using static ARS.Common.Constants.models.EntityConstraintsConstants;

namespace ARS.Common.DTOs.Aircraft
{

    public class AddAircraftDTO
    {
        [Required]
        public string AircraftManufacturer { get; set; }

        [Required]
        [MaxLength(AircraftModelMaxLength)]

        public string Model { get; set; }


        [MaxLength(AircraftImageUrlMaxLength)]
        public string? ImageUrl { get; set; }


        [Required]
        public int Capacity { get; set; }

        [Required]
        public string AirlineId { get; set; }
    }
}
