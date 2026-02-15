using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Movie
    {
        private string Name { get; set; }
        private string Genre { get; set; }
        private int duration;
        private double rating;
        private int year;

        public int Duration
        {
            get { return duration; }
            set
            {
                if (duration < 0)
                    throw new ArgumentException();
                duration = value;
            }
        }

        public int Year        
        {
            get { return year; }
            set
            {
                if (year < 1900)
                    throw new ArgumentException();
                year = value;
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (rating > 10 || rating < 0)
                    throw new ArgumentException();
                rating = value;
            }
        }

        public Movie(string _name, string _genre, int _duration, int _year, double _rating)
        {
            Name = _name;
            Genre = _genre;
            Duration = _duration;
            Year = _year;
            Rating = _rating;
        }

        public Movie()
        {

        }
    }
}
