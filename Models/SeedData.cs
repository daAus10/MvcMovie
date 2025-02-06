using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
    Title = "When Harry Met Sally",
    ReleaseDate = DateTime.Parse("1989-2-12"),
    Genre = "Romantic Comedy",
    Rating = "R",
    Price = 7.99M
},
new Movie
{
    Title = "Ghostbusters",
    ReleaseDate = DateTime.Parse("1984-3-13"),
    Genre = "Comedy",
    Rating = "R",
    Price = 8.99M
},
new Movie
{
    Title = "Ghostbusters 2",
    ReleaseDate = DateTime.Parse("1986-2-23"),
    Genre = "Comedy",
    Rating = "R",
    Price = 9.99M
},
new Movie
{
    Title = "Rio Bravo",
    ReleaseDate = DateTime.Parse("1959-4-15"),
    Genre = "Western",
    Rating = "PG",
    Price = 3.99M
},
new Movie
{
    Title = "Ford v Ferrari",
    ReleaseDate = DateTime.Parse("2019-11-15"),
    Genre = "Drama",
    Rating = "PG-13",
    Price = 12.99M
},
new Movie
{
    Title = "The Shawshank Redemption",
    ReleaseDate = DateTime.Parse("1994-9-23"),
    Genre = "Drama",
    Rating = "R",
    Price = 9.99M
},
new Movie
{
    Title = "The Godfather",
    ReleaseDate = DateTime.Parse("1972-3-24"),
    Genre = "Crime",
    Rating = "R",
    Price = 14.99M
},
new Movie
{
    Title = "The Dark Knight",
    ReleaseDate = DateTime.Parse("2008-7-18"),
    Genre = "Action",
    Rating = "PG-13",
    Price = 11.99M
},
new Movie
{
    Title = "Pulp Fiction",
    ReleaseDate = DateTime.Parse("1994-10-14"),
    Genre = "Crime",
    Rating = "R",
    Price = 8.99M
},
new Movie
{
    Title = "The Lord of the Rings: The Return of the King",
    ReleaseDate = DateTime.Parse("2003-12-17"),
    Genre = "Fantasy",
    Rating = "PG-13",
    Price = 10.99M
}
            );
            context.SaveChanges();
        }
    }
}