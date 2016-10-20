using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieRepository : IMovieRepository
    {
        MovieContext _context;
        public MovieRepository(MovieContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
        }

        public async Task<List<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync();
        }
    }
}
