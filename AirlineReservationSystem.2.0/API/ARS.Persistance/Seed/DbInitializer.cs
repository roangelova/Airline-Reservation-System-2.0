using ARS.Common.Constants.Roles;
using ARS.Common.Entities;
using ARS.Persistance.Context;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;

namespace ARS.Persistance.Seed
{
    public class DbInitializer
    {

        public static async Task SeedInitialData(
            ApplicationDbContext context, IServiceScope scope)
        {
            if (!context.Destinations.Any())
            {
                await SeedDestinations(context);
            }

            if (!context.Roles.Any())
            {
                await SeedRoles(context);
            }

            await SeedGlobalAdmin(scope);

        }

        private static async Task SeedDestinations(ApplicationDbContext context)
        {
            try
            {
                var destinations = new List<Destination>();

                string path = Path.GetFullPath("EuropeAirports.json");

                //TODO : REFACTOR
                var json = File.ReadAllText(Path.GetFullPath(@"C:\Users\RoslavaAngelova\Documents\training\ARS.2.0\Airline-Reservation-System-2.0\AirlineReservationSystem.2.0\API\ARS.Persistance\SeedData\EuropeAirports.json"));

                destinations = JsonConvert.DeserializeObject<List<Destination>>(json);

                await context.Destinations.AddRangeAsync(destinations);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static async Task SeedRoles(ApplicationDbContext context)
        {
            try
            {
                var GlobalAdmin = new Role
                {
                    Name = RoleConstants.GlobalAdmin,
                    NormalizedName = RoleConstants.GlobalAdmin.ToUpper()
                };

                var AirlineAdmin = new Role
                {
                    Name = RoleConstants.AirlineAdmin,
                    NormalizedName = RoleConstants.AirlineAdmin.ToUpper()
                };

                var Customer = new Role
                {
                    Name = RoleConstants.Customer,
                    NormalizedName = RoleConstants.Customer.ToUpper()
                };

                await context.Roles.AddRangeAsync(GlobalAdmin, AirlineAdmin, Customer);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static async Task SeedGlobalAdmin(IServiceScope scope)
        {
            try
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                var GlobalAdmin = new User
                {
                    Email = "roan97dev@gmail.com",
                    UserName = "roan97",
                    FirstName = "Roslava",
                    LastName = "Angelova"
                };

                await userManager.CreateAsync(GlobalAdmin, "P@ssw1rd");
                await userManager.AddToRoleAsync(GlobalAdmin, RoleConstants.GlobalAdmin);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }

}
