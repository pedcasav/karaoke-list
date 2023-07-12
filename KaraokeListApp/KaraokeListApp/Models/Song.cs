using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeListApp.Models
{
    internal class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
