using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Name { get; set; }

        public DateTime Published { get; set; }

        public List<MovieActor> MovieActors { get; set; }
    }
}