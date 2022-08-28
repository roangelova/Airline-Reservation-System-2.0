using ARS.Persistance.Entities;
using ARS.Persistance.TrackDataChanges;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ARS.Persistance.Context
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IHttpContextAccessor httpContextAccessor) : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Role> Roles { get; set; }

        //is this optimal? how do we destinguis when making calls to the DB?
        //how to structure abstract classes 

        public DbSet<Adult> Adults { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Infant> Infants { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSave();

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSave()
        {
            var currentDate = DateTime.UtcNow;
            var currentUser = GetCurrentUser();

            var trackedEntities = ChangeTracker.Entries<ITrackable>();

            foreach (var trackedEntity in trackedEntities)
            {
                switch (trackedEntity.State)
                {
                    case EntityState.Added:
                        trackedEntity.Entity.CreatedAt = currentDate;
                        trackedEntity.Entity.CreatedBy = currentUser;
                        break;

                    case EntityState.Modified:
                        trackedEntity.Entity.ModifiedAt = currentDate;
                        trackedEntity.Entity.ModifiedBy = currentUser;
                        break;

                    case EntityState.Deleted:
                        trackedEntity.Entity.ModifiedAt = currentDate;
                        trackedEntity.Entity.ModifiedBy = currentUser;
                        break;
                }
            }
        }

        private Guid GetCurrentUser()
        {
            var identity = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            var userId = identity.Claims.FirstOrDefault(x =>
            x.Type == ClaimTypes.NameIdentifier)?.Value;
            return userId != null ? Guid.Parse(userId) : Guid.Empty;
        }
    }
}
