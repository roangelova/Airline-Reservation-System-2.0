using ARS.Common.Entities;
using ARS.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Persistance.Seed
{
    public static class  DbInitializer
    {
        public static void SeedInitialData(ApplicationDbContext context)
        {
            if (context.Destinations.Any())
            {
                return;
            }

            var destinations = new List<Destination>();
            var pathToJon = Path.Combine(Path.GetFullPath)

        }
    }
}
