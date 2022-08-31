using ARS.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Configurations
{
    public class FlightEntityConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasOne(x => x.Origin)
                 .WithMany()
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Destination)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
