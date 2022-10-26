using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFinder.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public string?  Actor { get; set; }
        public string? Director { get; set; }
        public string? Lang { get; set; }

        public int ReleasedYear { get; set; }
    }
}