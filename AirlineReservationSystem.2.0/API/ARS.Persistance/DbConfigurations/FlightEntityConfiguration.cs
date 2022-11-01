using ARS.Common.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ARS.Persistance.DbConfigurations
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

            builder.HasOne(x => x.Airline)
                .WithMany(x => x.Flights)
                .OnDelete(DeleteBehavior.Restrict);

            // builder.HasOne(x => x.FlightsBookings)
            //     .WithMany()
            //     .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
