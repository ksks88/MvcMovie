using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public List<Movie> Movies { get; set; }
    }
}