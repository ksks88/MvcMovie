using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Genre : BaseModel
    {
        public int GenreId { get; set; }

        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}