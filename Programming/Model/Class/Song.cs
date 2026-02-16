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
        private string _name;
        private string _author;
        private int _duration;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set 
            {
                if (Validator.AssertOnPositiveValue(value))
                    _duration = value;
            }
        }

        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            Duration = duration;
        }

        public Song()
        {

        }
    }
}
