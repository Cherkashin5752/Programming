using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Movie
    {
        private string _name;
        private string _genre;
        private int _duration;
        private double _rating;
        private int _year;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (_duration < 0)
                    throw new ArgumentException();
                _duration = value;
            }
        }

        public int Year        
        {
            get { return _year; }
            set
            {
                if (_year < 0)
                    throw new ArgumentException();
                _year = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (_rating > 10 || _rating < 0)
                {
                    throw new ArgumentException();
                    return;
                }
                
                _rating = value;
            }
        }

        public Movie(string name, string genre, int duration, int year, double rating)
        {
            Name = name;
            Genre = genre;
            Duration = duration;
            Year = year;
            Rating = rating;
        }

        public Movie()
        {

        }
    }
}
