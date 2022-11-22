using ARS.Common.Entities;
using ARS.Persistance.Context;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Seed
{
    public static class DbInitializer
    {
        public static async Task SeedInitialData(ApplicationDbContext context)
        {
            if (context.Destinations.Any())
            {
                return;
            }

            var destinations = new List<Destination>();

            string path = Path.GetFullPath("EuropeAirports.json");

            //TODO : REFACTOR
            var json = File.ReadAllText(Path.GetFullPath(@"C:\Users\RoslavaAngelova\Documents\training\ARS.2.0\Airline-Reservation-System-2.0\AirlineReservationSystem.2.0\API\ARS.Persistance\SeedData\EuropeAirports.json"));

            destinations = JsonConvert.DeserializeObject<List<Destination>>(json);
            await context.Destinations.AddRangeAsync(destinations);
            await context.SaveChangesAsync();

        }
    }
}
