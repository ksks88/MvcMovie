using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Actor : BaseModel
    {
        public int ActorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<MovieActor> MovieActors { get; set; }
    }
}
