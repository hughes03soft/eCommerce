﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
