using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetMovies();
        void Add(Movie movie);
        Task<int> SaveChangesAsync();
    }
}
