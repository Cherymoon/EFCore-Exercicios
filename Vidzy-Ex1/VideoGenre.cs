using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class VideoGenre
    {
        public int VideoId { get; set; }
        public Video Video { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public VideoGenre(int videoId, int genreId)
        {
            VideoId = videoId;
            GenreId = genreId;
        }
    }
}
