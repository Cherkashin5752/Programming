using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Programming.Model.Class
{
    internal class Song
    {
        private string Name { get; set; }
        private string Author { get; set; }
        private string Duration { get; set; }

        public Song(string _name, string _author, string _duration)
        {
            Name = _name;
            Author = _author;
            Duration = _duration;
        }

        public Song()
        {

        }
    }
}
