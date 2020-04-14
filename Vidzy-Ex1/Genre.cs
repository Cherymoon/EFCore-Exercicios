using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<VideoGenre> VideoGenres { get; set; }

        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
            VideoGenres = new List<VideoGenre>();
        }
    }
}
