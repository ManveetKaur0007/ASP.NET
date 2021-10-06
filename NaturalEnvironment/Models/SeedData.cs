using Microsoft.EntityFrameworkCore;using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesNaturalEnvironment.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesNaturalEnvironmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesNaturalEnvironmentContext>>()))
            {
                // Look for any movies.
                if (context.NaturalEnvironment.Any())
                {
                    return;   // DB has been seeded
                }

                context.NaturalEnvironment.AddRange(
                    new NaturalEnvironment
                    {
                        Country = "Mongolia",
                        Pollutionrate = 91.84,
                        Currentstatus = "Worst",
                        Effectonpeople = ""
                    },

                    new NaturalEnvironment
                    {
                        Country = "Cameroon",
                        Pollutionrate = 90.12,
                        Currentstatus = "Worst",
                        Effectonpeople = "Poor air quality"
                    },

                    new NaturalEnvironment
                    {
                        Country = "Myanmar",
                        Pollutionrate = 89.77,
                        Currentstatus = "Very Bad",
                        Effectonpeople = "Poor air quality"
                    },

                    new NaturalEnvironment
                    {
                        Country = "Afghanistan",
                        Pollutionrate = 89.77,
                        Currentstatus = "Very Bad",
                        Effectonpeople = "Poor air quality"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}