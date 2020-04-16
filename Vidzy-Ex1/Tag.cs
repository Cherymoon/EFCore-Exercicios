using ConsoleApp5.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Tag
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<VideoTags> VideoTags { get; set; } = new List<VideoTags>();
    }
}
