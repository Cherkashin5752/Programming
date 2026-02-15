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
        private int duration;
        private double Durating
        {
            get { return duration; }
            set
            {
                if (duration < 0)
                    throw new ArgumentException();
            }
        }

        private int year;
        private double Year        
        {
            get { return year; }
            set
            {
                if (year < 1900)
                    throw new ArgumentException();
            }
        }

        private string genre { get; set; }

        private double rating;
        private double Rating
        {
            get { return rating; }
            set
            {
                if (rating > 10 || rating < 0)
                    throw new ArgumentException();
            }
        }
    }
}
