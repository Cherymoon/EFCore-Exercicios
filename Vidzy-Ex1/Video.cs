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
        public virtual ICollection<VideoGenre> VideoGenres { get; set; }

        public Video(int id, string name, DateTime releaseDate)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            VideoGenres = new List<VideoGenre>();
        }
    }
}
