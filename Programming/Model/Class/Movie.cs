using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Movie
    {
        private string name { get; set; }
        private string genre { get; set; }
        private int duration;
        private double rating;
        private int year;

        private int Durating
        {
            get { return duration; }
            set
            {
                if (duration < 0)
                    throw new ArgumentException();
                duration = value;
            }
        }

        private int Year        
        {
            get { return year; }
            set
            {
                if (year < 1900)
                    throw new ArgumentException();
                year = value;
            }
        }

        private double Rating
        {
            get { return rating; }
            set
            {
                if (rating > 10 || rating < 0)
                    throw new ArgumentException();
                rating = value;
            }
        }
    }
}
