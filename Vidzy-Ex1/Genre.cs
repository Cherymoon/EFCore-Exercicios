using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; } = new List<Video>();
    }
}
