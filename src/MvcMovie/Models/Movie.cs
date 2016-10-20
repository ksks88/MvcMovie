using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Movie : BaseModel
    {
        public int MovieId { get; set; }

        public string Name { get; set; }

        public DateTime Published { get; set; }

        public List<MovieActor> MovieActors { get; set; }

        public Genre Genre { get; set; }
    }
}