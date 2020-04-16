using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Classification Classification { get; set; }
    }
}
