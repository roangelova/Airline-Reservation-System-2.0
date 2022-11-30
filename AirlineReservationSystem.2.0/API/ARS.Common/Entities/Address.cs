using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Enums;
using ARS.Common.TrackDataChanges;

using static ARS.Common.Constants.models.EntityConstraintsConstants;


namespace ARS.Common.Entities
{
    
    public class Address : Trackable
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Country Country { get; set; }

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; }

        [Required]
        [MaxLength(PostalCodeMaxLength)]
        public string PostalCode { get; set; }

        [MaxLength(RegionMaxLength)]
        public string Region { get; set; }

        [Required]
        [MaxLength(StreetMaxLength)]
        public string Street { get; set; }

        [MaxLength(DetailsMaxLength)]
        public string AdditionalDetails { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        public User User { get; set; }

        public bool IsPrimary { get; set; } = true;

    }
}
