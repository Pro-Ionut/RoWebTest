using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RoWebTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoWebTest.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Terminator 1",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Producer="Producer 1"
                        
                        
                    },

                    new Movie
                    {
                        Title = "Terminator 2",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Producer = "Producer 2"


                    },

                    new Movie
                    {
                        Title = "Terminator 3",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Producer = "Producer 3"

                    },

                    new Movie
                    {
                        Title = "Terminator 4",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Producer = "Producer 4"

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
