using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Migrations
{
    class VideoTags
    {
        public int VideoId { get; set; }
        public int TagId { get; set; }

        public Video Video { get; set; }
        public Tag Tag { get; set; }
    }
}
