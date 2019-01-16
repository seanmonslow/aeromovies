using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aermovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Details { get; set; }
        public string imageurl { get; set; }
    }
}