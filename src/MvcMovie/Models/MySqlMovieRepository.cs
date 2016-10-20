using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MySqlMovieRepository : IMovieRepository
    {
        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetMovies()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
