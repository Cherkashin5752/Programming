using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о времени
    /// </summary>
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        
        /// <summary>
        /// Возвращает и задаёт час. В диапазоне от 0 до 23
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 23))
                    _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт минуты. В диапазоне от 0 до 59
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 59))
                    _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт секунды. В диапазоне от 0 до 59
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 59))
                    _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time()
        {

        }
    }
}
