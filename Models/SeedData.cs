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

                    },
                    new Movie
                    {
                        Title = "Terminator 5",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Producer = "Producer 5"


                    },

                    new Movie
                    {
                        Title = "Terminator 6",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Producer = "Producer 6"


                    },

                    new Movie
                    {
                        Title = "Terminator 7",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Producer = "Producer 7"

                    },

                    new Movie
                    {
                        Title = "Terminator 8",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Producer = "Producer 9"

                    },
                      new Movie
                      {
                          Title = "Terminator 9",
                          ReleaseDate = DateTime.Parse("1989-2-12"),
                          Genre = "Romantic Comedy",
                          Price = 7.99M,
                          Producer = "Producer 9"


                      },

                    new Movie
                    {
                        Title = "Terminator 10",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Producer = "Producer 10"


                    },

                    new Movie
                    {
                        Title = "Terminator 11",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Producer = "Producer 12"

                    },

                    new Movie
                    {
                        Title = "Terminator 13",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Producer = "Producer 13"

                    },
                    new Movie
                    {
                        Title = "Terminator 14",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Producer = "Producer 14"


                    },

                    new Movie
                    {
                        Title = "Terminator 15",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Producer = "Producer 15"


                    },

                    new Movie
                    {
                        Title = "Terminator 16",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Producer = "Producer 16"

                    },

                    new Movie
                    {
                        Title = "Terminator 17",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Producer = "Producer 17"

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
