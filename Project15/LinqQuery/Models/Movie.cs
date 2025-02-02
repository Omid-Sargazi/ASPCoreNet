using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQuery.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public int ReleaseYear { get; set; }
    }
}