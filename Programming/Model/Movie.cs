using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме
    /// </summary>
    internal class Movie
    {
        private string _name;
        private string _genre;
        private int _duration;
        private double _rating;
        private int _year;

        /// <summary>
        /// Возвращает и задаёт название фильма
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// Возвращает и задаёт продожительность фильма. Только положительное число
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (Validator.AssertOnPositiveValue(value));
                    _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выхода фильма
        /// </summary>
        public int Year        
        {
            get { return _year; }
            set
            {
                if (Validator.AssertValueInRange(value, 1900, 3000))
                    _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 10))
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
